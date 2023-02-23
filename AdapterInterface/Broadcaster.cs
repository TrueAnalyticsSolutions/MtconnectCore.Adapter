using Microsoft.Extensions.Logging;
using Mtconnect.AdapterInterface.Contracts;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;

namespace Mtconnect
{
    /// <summary>
    /// A UDP broadcaster service intended to make Adapter(s) discoverable within a network.
    /// </summary>
    /// <typeparam name="T">Reference to the type of Adapter to make discoverable.</typeparam>
    public abstract class Broadcaster<T> : IDisposable, IBroadcaster where T : Adapter
    {
        /// <summary>
        /// The default broadcast transmission rate.
        /// </summary>
        public const double DEFAULT_BROADCAST_RATE = 24 * 60 * 60 * 1000;
        public const string DEFAULT_BROADCAST_ADDRESS = "239.255.255.255";
        public const int DEFAULT_BROADCAST_PORT = 1900;

        private ILogger<Broadcaster<T>> _logger;

        private UdpClient _client { get; set; } = new UdpClient();

        protected IPAddress Address { get; set; }

        protected IPEndPoint Endpoint { get; set; }

        /// <summary>
        /// A timer to periodically re-send the broadcast message
        /// </summary>
        private System.Timers.Timer _timer { get; set; } = new System.Timers.Timer();

        /// <summary>
        /// Reference to the Adapter to broadcast connection information for.
        /// </summary>
        protected T Adapter { get; private set; }

        /// <summary>
        /// A timestamp (UTC) referencing the Adapter was started. Returns null if the Adapter is not currently running.
        /// </summary>
        private DateTime? _adapterStartTime { get; set; }

        private DateTime? _lastSent { get; set; }
        /// <inheritdoc />
        public DateTime? LastSent => _lastSent;

        private bool _busy { get; set; } = false;
        /// <inheritdoc />
        public bool IsBusy => _busy;

        public Broadcaster(T adapter, double broadcastRate = DEFAULT_BROADCAST_RATE, string address = DEFAULT_BROADCAST_ADDRESS, int port = DEFAULT_BROADCAST_PORT, ILoggerFactory logFactory = default)
        {
            Adapter = adapter;
            Adapter.OnStarted += (Adapter sender, object e) => _adapterStartTime = DateTime.UtcNow;
            Adapter.OnStopped += (Adapter sender, AdapterStoppedEventArgs e) => Stop();

            Address = IPAddress.Parse(address);
            Endpoint = new IPEndPoint(Address, port);

            //_client.Client.Bind(new IPEndPoint(IPAddress.Broadcast, port));
            _client.JoinMulticastGroup(Address);
            _client.EnableBroadcast = true;
            _client.ExclusiveAddressUse = false;

            _timer.Interval = broadcastRate;
            _timer.Elapsed += (object sender, System.Timers.ElapsedEventArgs e) => _broadcast();

            _logger = logFactory?.CreateLogger<Broadcaster<T>>();
        }

        /// <summary>
        /// Broadcasts connection information about an Adapter if it isn't already.
        /// </summary>
        private void _broadcast()
        {
            if (IsBusy) return;

            _busy = true;
            try
            {
                object broadcastObject = ConstructMessage(Adapter);
                if (broadcastObject == null) throw new InvalidOperationException();

                string message ="MTConnectAdapter: " + JsonSerializer.Serialize(broadcastObject);
                byte[] bytes = Encoding.ASCII.GetBytes(message);
                if (_client.Send(bytes, bytes.Length, Endpoint) > 0) _lastSent = DateTime.UtcNow;
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Failed to broadcast message");
            }
            _busy = false;
        }

        /// <summary>
        /// An overridable method for constructing the broadcast message. This can be overridden to provide additional context for the Adapter service.
        /// </summary>
        /// <param name="adapter">Reference to the adapter in-case additional context is required.</param>
        /// <returns>A formatted broadcast message, ready to be transmitted to a multicast group.</returns>
        protected virtual BroadcastMessage ConstructMessage(T adapter)
        {
            return new BroadcastMessage()
            {
                Started = _adapterStartTime,
                Type = typeof(T).Name
            };
        }

        /// <inheritdoc />
        public void Start(CancellationToken cancellationToken = default)
        {
            _busy = false;
            cancellationToken.Register(() => Stop());
            _timer.Start();
            _broadcast(); // Go ahead and broadcast before the timer elapses.
            _logger?.LogInformation("Started UDP broadcaster");
        }

        /// <inheritdoc />
        public void Stop()
        {
            _timer.Stop();
            _busy = false;
            _adapterStartTime = null;
            _logger?.LogInformation("Stopped UDP broadcaster");
        }

        public void Dispose()
        {
            Stop();
            _client.Client.Close();
            _client.Dispose();

            _timer.Dispose();
        }
    }
}