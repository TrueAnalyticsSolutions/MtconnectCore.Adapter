using System;

namespace MtconnectCore.Adapter
{
    using System.IO;
    using System.Text;
    using System.Threading;
    using System.Net;
    using System.Net.Sockets;
    using System.Collections;
    using System.Collections.Generic;
    using System.Xml;
    using MtconnectCore.Adapter.DataItems;
    using MtconnectCore.Adapter.Assets;
    using MtconnectCore.Adapter.Contracts;

    /// <summary>
    /// An MTConnect adapter
    /// </summary>
    public partial class Adapter
    {
        /// <summary>
        /// The listening thread for new connections
        /// </summary>
        private Thread _listenerThread;

        /// <summary>
        /// A list of all the client connections.
        /// </summary>
        private ArrayList _clients = new ArrayList();

        /// <summary>
        /// A count of client threads.
        /// </summary>
        private CountdownEvent _activeClients = new CountdownEvent(1);

        /// <summary>
        /// The server socket.
        /// </summary>
        private TcpListener _listener;

        /// <summary>
        /// The * PONG ... text
        /// </summary>
        byte[] PONG;

        /// <summary>
        /// All the data items we're tracking.
        /// </summary>
        private ArrayList _dataItems = new ArrayList();


        /// <summary>
        /// The send changed has begun and we are tracking conditions.
        /// </summary>
        bool _hasBegun = false;

        /// <summary>
        /// The ascii encoder for creating the messages.
        /// </summary>
        ASCIIEncoding _encoder = new ASCIIEncoding();

        /// <summary>
        /// The heartbeat interval.
        /// </summary>
        double _heartbeat;
        /// <summary>
        /// This is a method to set the heartbeat interval given in milliseconds.
        /// </summary>
        public double Heartbeat { 
            get { return _heartbeat; } 
            set { 
                _heartbeat = value;
                PONG = _encoder.GetBytes($"* PONG {_heartbeat}\n");
            } 
        }

        /// <summary>
        /// The Port property to set and get the mPort. This will only take affect when the adapter is stopped.
        /// </summary>
        public int Port { get; private set; } = 7878;

        /// <summary>
        /// Indicates what state the MTConnect Adapter is currently in.
        /// </summary>
        public AdapterStates State { get; private set; } = AdapterStates.NotStarted;

        /// <summary>
        /// Create an adapter. Defaults the heartbeat to 10 seconds and the 
        /// port to 7878
        /// </summary>
        /// <param name="port">The optional port number (default: 7878)</param>
        /// <param name="heartbeat">The optional heartbeat (default: 10,000)</param>
        public Adapter(int port = 7878, int heartbeat = 10_000)
        {
            Port = port;
            Heartbeat = heartbeat;
        }

        public Adapter(Options options)
        {
            Port = options.Port;
            Heartbeat = options.Heartbeat;
        }

#if DEBUG
        /// <summary>
        /// For testing, add a io stream to the adapter.
        /// </summary>
        /// <param name="aStream">A IO Stream</param>
        public void addClientStream(Stream aStream)
        {
            _clients.Add(aStream);
            SendAllTo(aStream);
        }
#endif

        /// <summary>
        /// Add a data item to the adapter.
        /// </summary>
        /// <param name="aDI">The data item.</param>
        public void AddDataItem(DataItem aDI)
        {
            _dataItems.Add(aDI);
        }

        /// <summary>
        /// Remove all data items.
        /// </summary>
        public void RemoveAllDataItems()
        {
            _dataItems.Clear();
        }

        /// <summary>
        /// Remove a data item from the adapter.
        /// </summary>
        /// <param name="aItem"></param>
        public void RemoveDataItem(DataItem aItem)
        {
            int ind = _dataItems.IndexOf(aItem);
            if (ind >= 0)
                _dataItems.RemoveAt(ind);
        }

        /// <summary>
        /// Make all data items unavailable
        /// </summary>
        public void Unavailable()
        {
            foreach (DataItem di in _dataItems)
                di.Unavailable();
        }

        /// <summary>
        /// The asks all data items to begin themselves for collection. Only 
        /// required for conditions and should not be called if you are not 
        /// planning on adding all the conditions before you send. If you skip this
        /// the adapter will not perform the mark and sweep.
        /// </summary>
        public void Begin()
        {
            _hasBegun = true;
            foreach (DataItem di in _dataItems) di.Begin();
        }

        /// <summary>
        /// Send only the objects that need have changed to the clients.
        /// </summary>
        /// <param name="timestamp"></param>
        public void SendChanged(String timestamp = null)
        {
            if (_hasBegun)
                foreach (DataItem di in _dataItems) di.Prepare();

            // Separate out the data items into those that are on one line and those
            // need separate lines.
            List<DataItem> together = new List<DataItem>();
            List<DataItem> separate = new List<DataItem>();
            foreach (DataItem di in _dataItems)
            {
                List<DataItem> list = di.ItemList();
                if (di.NewLine)
                    separate.AddRange(list);
                else
                    together.AddRange(list);
            }

            // Compone all the same line data items onto one line.
            string line;
            if (timestamp == null)
            {
                DateTime now = DateTime.UtcNow;
                timestamp = now.ToString(Constants.DATE_TIME_FORMAT);
            }
            if (together.Count > 0)
            {
                line = timestamp;
                foreach (DataItem di in together)
                    line += $"|{di}";
                line += "\n";

                SendToAll(line);
            }

            // Now write out all the separate lines
            if (separate.Count > 0)
            {
                foreach (DataItem di in separate)
                {
                    line = timestamp;
                    line += $"|{di}\n";
                    SendToAll(line);
                }
            }

            // Flush the output
            FlushAll();

            // Cleanup
            foreach (DataItem di in _dataItems) di.Cleanup();
            _hasBegun = false;
        }

        /// <summary>
        /// Send a new asset to the Agent
        /// </summary>
        /// <param name="asset">The asset</param>
        public void AddAsset(Asset asset)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            StringBuilder result = new StringBuilder();
            
            DateTime now = DateTime.UtcNow;
            result.Append(now.ToString(Constants.DATE_TIME_FORMAT));
            result.Append("|@ASSET@|");
            result.Append(asset.AssetId);
            result.Append('|');
            result.Append(asset.GetMTCType());
            result.Append("|--multiline--ABCD\n");

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;

            XmlWriter writer = XmlWriter.Create(result, settings);
            asset.ToXml(writer);
            writer.Close();
            result.Append("\n--multiline--ABCD\n");

            SendToAll(result.ToString());
        }

        /// <summary>
        /// Flush all the communications to all the clients
        /// TODO: Exception handling.
        /// </summary>
        public void FlushAll()
        {
            foreach (Stream client in _clients)
                client.Flush();

        }

        /// <summary>
        /// Send all the data items, regardless if they have changed to one
        /// client. Used for the initial data dump.
        /// TODO: DRY out with SendChanged.
        /// </summary>
        /// <param name="clientStream">The network stream of the client</param>
        public void SendAllTo(Stream clientStream)
        {
            lock (clientStream)
            {
                List<DataItem> together = new List<DataItem>();
                List<DataItem> separate = new List<DataItem>();
                foreach (DataItem di in _dataItems)
                {
                    List<DataItem> list = di.ItemList(true);
                    if (di.NewLine)
                        separate.AddRange(list);
                    else
                        together.AddRange(list);
                }


                DateTime now = DateTime.UtcNow;
                String timestamp = now.ToString(Constants.DATE_TIME_FORMAT);

                String line = timestamp;
                foreach (DataItem di in together)
                    line += $"|{di}";
                line += "\n";

                byte[] message = _encoder.GetBytes(line.ToCharArray());
                clientStream.Write(message, 0, message.Length);

                foreach (DataItem di in separate)
                {
                    line = timestamp;
                    line += $"|{di}\n";
                    message = _encoder.GetBytes(line.ToCharArray());
                    WriteToClient(clientStream, message);
                }

                clientStream.Flush();
            }
        }

        /// <summary>
        /// Send a string of text to all clients.
        /// </summary>
        /// <param name="line">A line of text</param>
        public void SendToAll(string line)
        {
            byte[] message = _encoder.GetBytes(line.ToCharArray());
            // TODO: Convert to ILogger
            if (Verbose)
                Console.WriteLine("Sending: " + line);
            foreach (Stream client in _clients.ToArray())
            {
                lock (client)
                {
                    WriteToClient(client, message);
                }
            }
        }

        /// <summary>
        /// Receive data from a client and implement heartbeat ping/pong protocol.
        /// </summary>
        /// <param name="aClient">The client who sent the text</param>
        /// <param name="aLine">The line of text</param>
        private bool Receive(Stream aClient, String aLine)
        {
            bool heartbeat = false;
            // TODO: Implement const for * PING
            if (aLine.StartsWith("* PING") && _heartbeat > 0)
            {
                heartbeat = true;
                lock (aClient)
                {
                    // Console.WriteLine("Received PING, sending PONG");
                    WriteToClient(aClient, PONG);
                    aClient.Flush();
                }
            }

            return heartbeat;
        }

        /// <summary>
        /// Send text to a client as a byte array. Handles execptions and 
        /// remove the client from the list of clients if the write fails. 
        /// Also makes sure the client connection is closed when it fails.
        /// </summary>
        /// <param name="aClient">The client to send the message to</param>
        /// <param name="aMessage">The message</param>
        private void WriteToClient(Stream aClient, byte[] aMessage)
        {
            try
            {
                aClient.Write(aMessage, 0, aMessage.Length);
            }
            catch (Exception e)
            {
                // TODO: Convert to constant
                Console.WriteLine("Error during write: " + e.Message);
                try { aClient.Close(); }
                catch (Exception f) {
                    Console.WriteLine("Error during close: " + f.Message);
                }
                _clients.Remove(aClient);
            }
        }

        /// <summary>
        /// The heartbeat thread for a client. This thread receives data from a client, 
        /// closes the socket when it fails, and handles communication timeouts when 
        /// the client does not send a heartbeat within 2x the heartbeat frequency. 
        /// 
        /// When the heartbeat is not received, the client is assumed to be unresponsive
        /// and the connection is closed. Waits for one ping to be received before
        /// enforcing the timeout. 
        /// </summary>
        /// <param name="client">The client we are communicating with.</param>
        private void HeartbeatClient(object client)
        {
            _activeClients.AddCount();
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();
            _clients.Add(clientStream);
            ArrayList readList = new ArrayList();
            bool heartbeatActive = false;

            byte[] message = new byte[4096];
            ASCIIEncoding encoder = new ASCIIEncoding();
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
                        if (_heartbeat > 0 && heartbeatActive)
                            Socket.Select(readList, null, null, (int)(_heartbeat * 2000));
                        if (readList.Count == 0 && heartbeatActive)
                        {
                            Console.WriteLine("Heartbeat timed out, closing connection\n");
                            break;
                        }

                        //blocks until a client sends a message
                        bytesRead = clientStream.Read(message, length, 4096 - length);
                    }
                    catch (Exception e)
                    {
                        //a socket error has occured
                        Console.WriteLine("Heartbeat read exception: " + e.Message + "\n");
                        break;
                    }

                    if (bytesRead == 0)
                    {
                        //the client has disconnected from the server
                        Console.WriteLine("No bytes were read from heartbeat thread");
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

                            String line = encoder.GetString(message, eol, i);
                            if (Receive(clientStream, line)) heartbeatActive = true;
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
                Console.WriteLine("Error during heartbeat: " + e.Message);
            }

            finally
            {
                try
                {
                    _clients.Remove(clientStream);
                    tcpClient.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error during heartbeat cleanup: " + e.Message);
                }
                _activeClients.Signal();
            }
        }

        /// <summary>
        /// The is the socket server listening thread. Creates a new client and starts a heartbeat client thread to implement the ping/pong protocol.
        /// </summary>
        private void ListenForClients()
        {
            State = AdapterStates.Busy;

            try
            {
                while (State == AdapterStates.Busy)
                {
                    //blocks until a client has connected to the server
                    TcpClient client = _listener.AcceptTcpClient();

                    //create a thread to handle communication 
                    //with connected client
                    Thread clientThread = new Thread(new ParameterizedThreadStart(HeartbeatClient));
                    clientThread.Start(client);

                    SendAllTo(client.GetStream());
                    clientThread.Join();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Execption occurred waiting for connection: " + e.Message);
            }

            finally
            {
                State = AdapterStates.Started;
                _listener.Stop();
            }
        }

        /// <summary>
        /// Start the listener thread.
        /// </summary>
        public void Start()
        {
            if (State <= AdapterStates.NotStarted) {
                State = AdapterStates.Starting;

                _listener = new TcpListener(IPAddress.Any, Port);
                _listener.Start();
                _listenerThread = new Thread(new ThreadStart(ListenForClients));
                _listenerThread.Start();

                State = AdapterStates.Started;
            }
        }

        /// <summary>
        /// Stop the listener thread and shutdown all client connections.
        /// </summary>
        public void Stop()
        {
            if (State > AdapterStates.NotStarted) {
                State = AdapterStates.Stopping;

                // Wait 2 seconds for the thread to exit.
                _listenerThread.Join(2*Heartbeat);

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
    }
}