using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
    public sealed class TcpAdapter : Adapter
    {
        /// <summary>
        /// The Port property to set and get the mPort. This will only take affect when the adapter is stopped.
        /// </summary>
        public int Port { get; private set; } = 7878;

        /// <summary>
        /// The listening thread for new connections
        /// </summary>
        private Thread _listenerThread;

        /// <summary>
        /// A list of all the client connections.
        /// </summary>
        private Dictionary<string, Stream> _clients = new Dictionary<string, Stream>();

        /// <summary>
        /// A count of client threads.
        /// </summary>
        private CountdownEvent _activeClients = new CountdownEvent(1);

        /// <summary>
        /// The server socket.
        /// </summary>
        private TcpListener _listener;

        /// <summary>
        /// Constructs a new TCP Adapter
        /// </summary>
        /// <param name="port"></param>
        public TcpAdapter(int port = 7878) : base(port)
        {
            Port = port;
        }

        /// <summary>
        /// Constructs a new <see cref="TcpAdapter"/>.
        /// </summary>
        /// <param name="options"><inheritdoc cref="TcpAdapterOptions" path="/summary"/></param>
        public TcpAdapter(TcpAdapterOptions options) : base(options)
        {
            Port = options.Port;
        }

        /// <inheritdoc />
        public override void Start(bool begin = true)
        {
            if (State <= AdapterStates.NotStarted)
            {
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
                State = AdapterStates.Stopping;

                // Wait 2 seconds for the thread to exit.
                _listenerThread.Join((int)(2 * Heartbeat));

                foreach (Object obj in _clients)
                {
                    Stream client = (Stream)obj;
                    client.Close();
                }
                _clients.Clear();

                // Wait for all client threads to exit.
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

#if DEBUG
        /// <summary>
        /// For testing, add a io stream to the adapter.
        /// </summary>
        /// <param name="clientId">The client who sent the text</param>
        /// <param name="aStream">A IO Stream</param>
        public void addClientStream(string clientId, Stream aStream)
        {
            _clients.Add(clientId, aStream);
            Send(DataItemSendTypes.All, clientId);
        }
#endif

        /// <inheritdoc />
        protected override void Write(string message, string clientId = null)
        {
            _logger?.LogDebug("Sending message: {Message}", message);

            if (clientId == null)
            {
                foreach (var kvp in _clients)
                {
                    lock (kvp.Value)
                    {
                        WriteToClient(kvp.Key, message);
                    }
                }
            } else if (_clients.ContainsKey(clientId))
            {
                lock (_clients[clientId])
                {
                    WriteToClient(clientId, message);
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
        /// Receive data from a client and implement heartbeat ping/pong protocol.
        /// </summary>
        /// <param name="clientId">The client who sent the text</param>
        /// <param name="line">The line of text</param>
        private bool Receive(string clientId, string line)
        {
            Stream clientStream = null;
            if (!_clients.TryGetValue(clientId, out clientStream))
                return false;

            bool heartbeat = false;
            // TODO: Implement const for * PING
            if (line.StartsWith("* PING") && Heartbeat > 0)
            {
                heartbeat = true;
                lock (clientStream)
                {
                    _logger?.LogDebug("Received PING, sending PONG");
                    WriteToClient(clientId, PONG);
                    clientStream.Flush();
                }
            }

            return heartbeat;
        }
        
        /// <summary>
        /// Send text to a client as a byte array. Handles execptions and remove the client from the list of clients if the write fails. Also makes sure the client connection is closed when it fails.
        /// </summary>
        /// <param name="clientId">Reference to the registered client id for the TCP stream.</param>
        /// <param name="message">The message to send to the client.</param>
        private void WriteToClient(string clientId, string message) => WriteToClient(clientId, Encoder.GetBytes(message.ToCharArray()));

        /// <summary>
        /// Send text to a client as a byte array. Handles execptions and remove the client from the list of clients if the write fails. Also makes sure the client connection is closed when it fails.
        /// </summary>
        /// <param name="clientId">The client to send the message to</param>
        /// <param name="message">The message</param>
        private void WriteToClient(string clientId, byte[] message)
        {
            Stream clientStream = null;
            try
            {
                if (_clients.TryGetValue(clientId, out clientStream))
                {
                    clientStream.Write(message, 0, message.Length);
                } else
                {
                    _logger?.LogWarning("Could not find client from id '{clientId}'", clientId);
                }
            }
            catch (Exception e)
            {
                // TODO: Convert to constant
                _logger?.LogError(e, "Failed to write to client stream");
                try
                {
                    clientStream?.Close();
                }
                catch (Exception f)
                {
                    _logger?.LogError(f, "Failed to close client stream");
                } finally
                {
                    if (_clients.ContainsKey(clientId))
                        _clients.Remove(clientId);
                }
            }
        }

        /// <inheritdoc />
        protected override void HeartbeatClient(object client)
        {
            _activeClients.AddCount();
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();
            string clientId = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();

            if (!_clients.ContainsKey(clientId))
                _clients.Add(clientId, null);
            _clients[clientId] = clientStream;

            ArrayList readList = new ArrayList();
            bool heartbeatActive = false;

            byte[] message = new byte[4096];
            int length = 0;

            try
            {
                while (State == AdapterStates.Busy && tcpClient.Connected)
                {
                    int bytesRead = 0;

                    try
                    {
                        readList.Clear();
                        readList.Add(tcpClient.Client);
                        if (Heartbeat > 0 && heartbeatActive)
                            Socket.Select(readList, null, null, (int)(Heartbeat * 2000));
                        if (readList.Count == 0 && heartbeatActive)
                        {
                            _logger?.LogWarning("Heartbeat timed out, closing connection");
                            break;
                        }

                        //blocks until a client sends a message
                        bytesRead = clientStream.Read(message, length, 4096 - length);
                    }
                    catch (Exception e)
                    {
                        //a socket error has occured
                        _logger?.LogError(e, "Failed to read heartbeat client message");
                        break;
                    }

                    if (bytesRead == 0)
                    {
                        //the client has disconnected from the server
                        _logger?.LogWarning("No bytes were read from heartbeat client");
                        break;
                    }

                    // See if we have a line
                    int pos = length;
                    length += bytesRead;
                    int eol = 0;
                    for (int i = pos; i < length; i++)
                    {
                        if (message[i] == '\n')
                        {

                            String line = Encoder.GetString(message, eol, i);
                            if (Receive(clientId, line)) heartbeatActive = true;
                            eol = i + 1;
                        }
                    }

                    // Remove the lines that have been processed.
                    if (eol > 0)
                    {
                        length = length - eol;
                        // Shift the message array to remove the lines.
                        if (length > 0)
                            Array.Copy(message, eol, message, 0, length);
                    }
                }
            }
            catch (Exception e)
            {
                _logger?.LogError(e, "Failed to process heartbeat client");
            }

            finally
            {
                try
                {
                    if (_clients.ContainsKey(clientId))
                    {
                        _clients.Remove(clientId);
                    }
                    tcpClient.Close();
                }
                catch (Exception e)
                {
                    _logger?.LogError(e, "Failed to cleanup heartbeat client connection");
                }
                _activeClients.Signal();
            }
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
                    //blocks until a client has connected to the server
                    TcpClient tcpClient = _listener.AcceptTcpClient();
                    string clientId = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();

                    //create a thread to handle communication 
                    //with connected client
                    Thread clientThread = new Thread(new ParameterizedThreadStart(HeartbeatClient));
                    clientThread.Start(tcpClient);

                    // Issue command for underlying Adapter to send all DataItem current values to the newly added client
                    Send(DataItemSendTypes.All, clientId);
                    clientThread.Join();
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
    }
}
