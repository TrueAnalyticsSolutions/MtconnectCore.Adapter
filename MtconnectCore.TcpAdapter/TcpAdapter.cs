using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.Extensions.Logging;
using Mtconnect.AdapterInterface;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItems;

namespace Mtconnect
{
    /// <summary>
    /// An implementation of a MTConnect Adapter that publishes data thru a TCP stream.
    /// </summary>
    public sealed class TcpAdapter : Adapter, IDisposable
    {
        /// <summary>
        /// The Port property to set and get the mPort. This will only take affect when the adapter is stopped.
        /// </summary>
        public int Port { get; private set; } = 7878;

        /// <summary>
        /// The maximum number of kvp connections allowed to exist at any given point.
        /// </summary>
        public int MaxConnections { get; private set; } = 1;

        /// <summary>
        /// The listening thread for new connections
        /// </summary>
        private Thread _listenerThread;

        /// <summary>
        /// A list of all the kvp connections.
        /// </summary>
        private ConcurrentDictionary<string, TcpConnection> _clients { get; set; } = new ConcurrentDictionary<string, TcpConnection>();

        /// <summary>
        /// A count of kvp threads.
        /// </summary>
        private CountdownEvent _activeClients { get; set; } = new CountdownEvent(1);

        /// <summary>
        /// The server socket.
        /// </summary>
        private TcpListener _listener { get; set; }

        /// <summary>
        /// Constructs a new <see cref="TcpAdapter"/>.
        /// </summary>
        /// <param name="options"><inheritdoc cref="TcpAdapterOptions" path="/summary"/></param>
        public TcpAdapter(TcpAdapterOptions options, ILogger<Adapter> logger = null) : base(options, logger)
        {
            Port = options.Port;
            MaxConnections = options.MaxConcurrentConnections;
        }

        /// <inheritdoc />
        public override void Start(bool begin = true)
        {
            if (State <= AdapterStates.NotStarted)
            {
                _logger?.LogInformation("Starting Adapter");
                State = AdapterStates.Starting;

                _listener = new TcpListener(IPAddress.Any, Port);
                _listener.Start();
                _listenerThread = new Thread(new ThreadStart(ListenForClients));
                _listenerThread.Start();

                State = AdapterStates.Started;
            }

            if (begin) Begin();
        }

        /// <inheritdoc />
        public override void Stop()
        {
            base.Stop();

            if (State > AdapterStates.NotStarted)
            {
                _logger?.LogInformation("Stopping Adapter");
                State = AdapterStates.Stopping;

                // Wait 2 seconds for the thread to exit.
                _listenerThread.Join((int)(2 * Heartbeat));

                foreach (var kvp in _clients)
                {
                    kvp.Value.Dispose();
                }
                _clients.Clear();

                // Wait for all kvp threads to exit.
                _activeClients.Wait(2000);

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
                    if (_activeClients.CurrentCount >= MaxConnections)
                    {
                        _logger?.LogWarning(
                            "Denied connection to '{ClientId}', too many concurrent connections ({ActiveConnections}/{MaxConnections})",
                            client.ClientId,
                            _activeClients.CurrentCount,
                            MaxConnections
                        );
                        continue;
                    }

                    if (!_clients.ContainsKey(client.ClientId) && _activeClients.TryAddCount())
                    {
                        _logger?.LogInformation("New client connection '{ClientId}'", client.ClientId);
                        if (_clients.TryAdd(client.ClientId, client))
                        {
                            client.OnDisconnected += Client_OnConnectionDisconnected;
                            client.OnDataReceived += Client_OnReceivedData;
                            client.Connect();
                            // Issue command for underlying Adapter to send all DataItem current values to the newly added kvp
                            Send(DataItemSendTypes.All, client.ClientId);
                        } else
                        {
                            _activeClients.Signal(); // Undo try add
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

        private const string PING = "* PING";
        /// <summary>
        /// ReceiveClient data from a kvp and implement heartbeat ping/pong protocol.
        /// </summary>
        private bool Client_OnReceivedData(TcpConnection connection, string message)
        {
            bool heartbeat = false;
            if (message.StartsWith(PING) && Heartbeat > 0)
            {
                heartbeat = true;
                lock (connection)
                {
                    _logger?.LogInformation("Received PING from client {ClientId}, sending PONG", connection.ClientId);
                    connection.Write(PONG);
                    connection.Flush();
                }
            }

            return heartbeat;
        }

        private void Client_OnConnectionDisconnected(TcpConnection connection)
        {
            if (_clients.ContainsKey(connection.ClientId))
            {
                lock(_clients)
                {
                    _logger?.LogInformation("Client disconnected '{ClientId}'", connection.ClientId);
                    if (_clients.TryRemove(connection.ClientId, out TcpConnection client))
                    {
                        if (_activeClients.Signal())
                        {
                            _logger?.LogInformation("No clients connected");
                        }
                    }
                }
            }
        }

        public void Dispose()
        {
            foreach (var kvp in _clients)
            {
                kvp.Value.Dispose();
            }
            _clients.Clear();

            _listener.Stop();

        }
    }
}
