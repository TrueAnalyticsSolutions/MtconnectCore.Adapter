using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Mtconnect
{
    public delegate void TcpConnectionConnected(TcpConnection connection);
    public delegate void TcpConnectionDisconnected(TcpConnection connection, Exception ex = null);
    public delegate bool TcpConnectionDataReceived(TcpConnection connection, string message);
    public class TcpConnection : IDisposable
    {
        private bool _disposing { get; set; } = false;

        /// <summary>
        /// An event that fires when the underlying client stream is opened and connected.
        /// </summary>
        public event TcpConnectionConnected OnConnected;

        /// <summary>
        /// An event that fires when the underlying client stream is closed and disconnected.
        /// </summary>
        public event TcpConnectionDisconnected OnDisconnected;

        /// <summary>
        /// An event that fires when data is fully parsed from the underlying client stream. Note that a new line is used to determine the end of a full message.
        /// </summary>
        public event TcpConnectionDataReceived OnDataReceived;

        /// <summary>
        /// Maximum amount of binary data to receive at a time.
        /// </summary>
        private const int BUFFER_SIZE = 4096;

        public ASCIIEncoding Encoder { get; set; } = new ASCIIEncoding();

        /// <summary>
        /// Reference to the <see cref="TcpClient"/> address.
        /// </summary>
        public string ClientId { get; private set; }

        /// <summary>
        /// The period of time (in milliseconds) to timeout stream reading.
        /// </summary>
        public int Heartbeat { get; set; }

        /// <summary>
        /// Reference to the connection to the <see cref="TcpClient"/>.
        /// </summary>
        private TcpClient _client { get; set; }

        /// <summary>
        /// Reference to the underlying client stream. Note, only available between <see cref="Connect"/> and <see cref="Disconnect"/> calls.
        /// </summary>
        private NetworkStream _stream { get; set; }

        public TcpConnection(TcpClient client, int heartbeat = 1000)
        {
            _client = client;
            Heartbeat = heartbeat;
            IPEndPoint clientIp = (IPEndPoint)_client.Client.RemoteEndPoint;
            ClientId = $"{clientIp.Address}:{clientIp.Port}";
        }

        /// <summary>
        /// Connects the underlying client stream and begins receiving data.
        /// </summary>
        public void Connect()
        {
            // Disconnect before attempting to connect again to ensure resources are disposed of
            if (_stream != null) Disconnect();

            _stream = _client.GetStream();
            Task.Run(() => receive());

            if (OnConnected != null) OnConnected(this);
        }

        /// <summary>
        /// Disconnects the underlying client stream and disposes of it. Note that this leaves the connection to the TCP client alone.
        /// </summary>
        public void Disconnect(Exception ex = null)
        {
            if (_stream == null) return;

            _stream?.Close();
            _stream?.Dispose();
            _stream = null;

            if (!_disposing && OnDisconnected != null) OnDisconnected(this, ex);
        }

        /// <summary>
        /// Writes a message to the underlying client stream.
        /// </summary>
        /// <param name="message">Message to send.</param>
        public void Write(string message) => Write(Encoder.GetBytes(message));
        /// <summary>
        /// Writes a binary message to the underlying client stream.
        /// </summary>
        /// <param name="message">Message to send.</param>
        public void Write(byte[] message)
        {
            try
            {
                _stream?.Write(message, 0, message.Length);
            }
            catch (Exception ex)
            {
                Disconnect();
            }
        }

        /// <summary>
        /// Flushes the underlying client stream.
        /// </summary>
        public void Flush()
        {
            _stream?.Flush();
        }

        /// <summary>
        /// Continuously reads messages from the underlying client stream.
        /// </summary>
        private void receive()
        {
            Exception ex = null;
            bool heartbeatActive = false;

            byte[] message = new byte[BUFFER_SIZE];
            int length = 0;

            ArrayList readList = new ArrayList();

            while (_client.Connected)
            {
                if (!_stream.DataAvailable) continue;

                int bytesRead = 0;

                readList.Clear();
                readList.Add(_client.Client);
                if (Heartbeat > 0 && heartbeatActive)
                    Socket.Select(readList, null, null, (int)(Heartbeat * 2000));
                if (readList.Count == 0 && heartbeatActive)
                {
                    ex = new TimeoutException("Heartbeat timed out, closing connection");
                    break;
                }
                bytesRead = _stream.Read(message, length, BUFFER_SIZE - length);

                // See if we have a line
                int pos = length;
                length += bytesRead;
                int eol = 0;
                for (int i = pos; i < length; i++)
                {
                    if (message[i] == '\n')
                    {

                        String line = Encoder.GetString(message, eol, i);

                        if (OnDataReceived != null)
                            heartbeatActive = OnDataReceived(this, line);

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

            Disconnect(ex);
        }

        public void Dispose()
        {
            _disposing = true;
            _client?.Dispose();
            Disconnect();
            _disposing = false;
        }
    }
}
