using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItems;

namespace Mtconnect
{
    /// <summary>
    /// An implementation of a MTConnect Adapter that publishes data thru a TCP stream.
    /// </summary>
    public sealed class TcpAdapter : Adapter, IDisposable
    {
        private bool _disposing = false;

        /// <summary>
        /// Event that fires when a response is received from a <see cref="TcpConnection"/>.
        /// </summary>
        public event TcpConnectionDataReceived ClientDataReceived;

        public string Address { get; private set; } = IPAddress.Any.ToString();
        public EndPoint LocalEndpoint => _listener?.LocalEndpoint;

        /// <summary>
        /// The Port property to set and get the mPort. This will only take affect when the adapter is stopped.
        /// </summary>
        public int Port { get; private set; } = 7878;

        /// <summary>
        /// The maximum number of kvp connections allowed to exist at any given point.
        /// </summary>
        public int MaxConnections { get; private set; } = 2;

        private CancellationTokenSource _listerCancellationSource = new CancellationTokenSource();
        /// <summary>
        /// The listening thread for new connections
        /// </summary>
        private Task _listenerThread;

        /// <summary>
        /// A list of all the kvp connections.
        /// </summary>
        private ConcurrentDictionary<string, TcpConnection> _clients { get; set; } = new ConcurrentDictionary<string, TcpConnection>();

        /// <summary>
        /// A count of how many clients are currently connected to the TCP listener.
        /// </summary>
        public int CurrentConnections => _clients.Count;

        /// <summary>
        /// The server socket.
        /// </summary>
        private TcpListener _listener { get; set; }

        /// <summary>
        /// Constructs a new <see cref="TcpAdapter"/>.
        /// </summary>
        /// <param name="options"><inheritdoc cref="TcpAdapterOptions" path="/summary"/></param>
        public TcpAdapter(TcpAdapterOptions options, ILoggerFactory logFactory = default) : base(options, logFactory)
        {
            Port = options.Port;
            MaxConnections = options.MaxConcurrentConnections;
            _listener = new TcpListener(IPAddress.Parse(Address), Port);
        }

        /// <inheritdoc />
        protected override void Start(bool begin = true, CancellationToken token = default)
        {
            if (State <= AdapterStates.NotStarted)
            {
                _logger?.LogInformation("Starting Adapter");
                State = AdapterStates.Starting;

                // Start TcpListener
                _listener.Start();

                // Start before the _listenerThread because it relies on state being Busy
                State = AdapterStates.Started;

                // Setup task that listens for new clients
                _listerCancellationSource.Token.Register(() => Stop());
                _listenerThread = Task.Factory.StartNew(
                    ListenForClients,
                    _listerCancellationSource.Token,
                    TaskCreationOptions.LongRunning,
                    TaskScheduler.Default
                );

            }

            if (begin) Begin();
        }

        /// <inheritdoc />
        public override void Stop(Exception ex = null)
        {
            base.Stop(ex);

            if (State > AdapterStates.NotStarted)
            {
                _logger?.LogInformation("Stopping TcpAdapter");
                State = AdapterStates.Stopping;

                // Queue the _listerThread to cancel
                _listerCancellationSource?.Cancel();

                // Dispose of all tracked clients and clear connections from memory.
                foreach (var kvp in _clients)
                {
                    kvp.Value.Dispose();
                }
                _clients.Clear();

                State = AdapterStates.Stopped;
            }
        }

        /// <inheritdoc />
        public override void Send(DataItemSendTypes sendType = DataItemSendTypes.Changed, string clientId = null)
        {
            if (HasBegun)
                foreach (var item in DataItems) item.Prepare();

            base.Send(sendType, clientId);

            // Flush the output
            FlushAll();

            // Cleanup
            foreach (DataItem di in DataItems) di.Cleanup();
            HasBegun = false;
        }

        /// <inheritdoc />
        protected override void Write(string message, string clientId = null)
        {
            _logger?.LogDebug("Sending message: {Message}", message);
            lock(_clients)
            {
                if (_clients.Any())
                {
                    if (clientId == null)
                    {
                        foreach (var kvp in _clients)
                        {
                            kvp.Value.Write(message);
                        }
                    }
                    else if (_clients.TryGetValue(clientId, out var client) && client != null)
                    {
                        lock (client)
                        {
                            client.Write(message);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Flush all the communications to all the clients
        /// TODO: Exception handling.
        /// </summary>
        public void FlushAll()
        {
            foreach (var kvp in _clients)
                kvp.Value.Flush();
        }

        /// <summary>
        /// Listens for new TCP clients.
        /// </summary>
        private void ListenForClients()
        {
            State = AdapterStates.Busy;

            try
            {
                while (State == AdapterStates.Busy)
                {
                    if (!_listener.Pending()) continue;

                    //blocks until a kvp has connected to the server
                    var client = new TcpConnection(_listener.AcceptTcpClient(), (int)Heartbeat);
                    if (_clients.Count >= MaxConnections)
                    {
                        _logger?.LogWarning(
                            "Denied connection to '{ClientId}', too many concurrent connections ({ActiveConnections}/{MaxConnections})",
                            client.ClientId,
                            _clients.Count,
                            MaxConnections
                        );
                        continue;
                    }

                    if (!_clients.ContainsKey(client.ClientId))
                    {
                        _logger?.LogInformation("New client connection '{ClientId}'", client.ClientId);
                        if (_clients.TryAdd(client.ClientId, client))
                        {
                            client.OnDisconnected += Client_OnConnectionDisconnected;
                            client.OnDataReceived += Client_OnReceivedData;
                            client.Connect();

                            // Send all commands that do not result in errors
                            Func<string>[] agentCommands = new Func<string>[]
                            {
                                AgentCommands.AdapterVersion,
                                //AgentCommands.Calibration,
                                //AgentCommands.ConversionRequired,
                                //AgentCommands.Device,
                                //AgentCommands.Description,
                                //AgentCommands.Manufacturer,
                                //AgentCommands.MtconnectVersion,
                                //AgentCommands.NativeName,
                                //AgentCommands.RealTime,
                                //AgentCommands.RelativeTime,
                                //AgentCommands.SerialNumber,
                                //AgentCommands.ShdrVersion,
                                //AgentCommands.Station
                            };
                            foreach (var agentCommand in agentCommands)
                            {
                                try
                                {
                                    string command = agentCommand();
                                    Write($"{command}\n", client.ClientId);
                                }
                                catch (Exception ex)
                                {
                                    Write($"{AgentCommands.Error("Unsupported command '" + agentCommand.Method.Name + "'")}\n", client.ClientId);
                                }
                            }

                            // Issue command for underlying Adapter to send all DataItem current values to the newly added kvp
                            Send(DataItemSendTypes.All, client.ClientId);
                        } else
                        {
                            _logger?.LogError("Failed to add client '{ClientId}'", client.ClientId);
                        }
                    } else
                    {
                        _logger?.LogWarning("Client '{ClientId}' already has an established connection", client.ClientId);
                    }
                }
            }
            catch (Exception e)
            {
                _logger?.LogError(e, "Exception occurred while waiting for connection");
            }
            finally
            {
                State = AdapterStates.Started;
                _listener.Stop();
            }
        }

        /// <summary>
        /// ReceiveClient data from a kvp and implement heartbeat ping/pong protocol.
        /// </summary>
        private bool Client_OnReceivedData(TcpConnection connection, string message)
        {
            bool handled = HandleCommand(message, connection.ClientId);

            if (ClientDataReceived != null) ClientDataReceived(connection, message);

            return handled;
        }

        private void Client_OnConnectionDisconnected(TcpConnection connection, Exception ex = null)
        {
            if (!_clients.ContainsKey(connection.ClientId))
            {
                _logger?.LogWarning("Client '{ClientId}' is not tracked", connection.ClientId);
                return;
            }

            lock (_clients)
            {
                if (ex == null)
                {
                    _logger?.LogInformation("Client disconnected '{ClientId}'", connection.ClientId);
                } else
                {
                    _logger?.LogError("Client '{ClientId}' disconnected due to error: \r\n\t{Error}", connection.ClientId, ex);
                }
                if (_clients.TryRemove(connection.ClientId, out TcpConnection client))
                {
                    if (_clients.Count == 0)
                    {
                        _logger?.LogInformation("No clients connected");
                    }
                }
            }
        }

        public void Dispose()
        {
            if (_disposing) return;
            _disposing = true;

            // Stop the TcpListener
            _listener?.Stop();

            // Dispose of all tracked clients and clear connections from memory.
            foreach (var kvp in _clients)
            {
                kvp.Value.Dispose();
            }
            _clients.Clear();

            // Dispose of the _listenerThread
            _listenerThread?.Dispose();
            _listerCancellationSource?.Dispose();
        }
    }
}
