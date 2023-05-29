using Microsoft.Extensions.Logging;
using Mtconnect.UPnP;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Mtconnect.AdapterSdk.UPnP
{
    /// <summary>
    /// A UDP broadcaster service intended to make Adapter(s) discoverable within a network.
    /// </summary>
    /// <typeparam name="T">Reference to the type of Adapter to make discoverable.</typeparam>
    public abstract class UPnPService<T> : IDisposable, IUPnPService where T : Adapter
    {
        /// <summary>
        /// The default broadcast transmission rate.
        /// </summary>
        public const double DEFAULT_BROADCAST_RATE = 24 * 60 * 60 * 1000;
        /// <summary>
        /// The default SSDP broadcast address.
        /// </summary>
        public const string DEFAULT_BROADCAST_ADDRESS = "239.255.255.250";
        /// <summary>
        /// The default SSDP broadcast port.
        /// </summary>
        public const int DEFAULT_BROADCAST_PORT = 1900;
        /// <summary>
        /// The default UPnP server address.
        /// </summary>
        public const string DEFAULT_UPnP_ADDRESS = "0.0.0.0";
        /// <summary>
        /// The default UPnP server port.
        /// </summary>
        public const int DEFAULT_UPnP_PORT = 7879;

        private ILogger<UPnPService<T>> _logger;

        /// <summary>
        /// Internal UDP client that publishes SSDP messages to the network multicast group.
        /// </summary>
        private UdpClient _client { get; set; } = new UdpClient();
        /// <summary>
        /// Internal HTTP listener that serves the UPnP Device Description file when requested.
        /// </summary>
        private HttpListener _httpListener { get; set; } = new HttpListener();

        /// <inheritdoc />
        public IPEndPoint UPnP_DescriptionEndpoint { get; set; }

        /// <summary>
        /// Internal copy of the <c>UPnP-Description.xml</c> file that should be copied with the document.
        /// </summary>
        private XmlDocument _upnpDescription { get; set; }

        /// <summary>
        /// Internal copy of the <c>MTConnect_8-bit.png</c> file that should be copied with the document.
        /// </summary>
        private byte[] MTConnectFavicon { get; set; }

        /// <inheritdoc />
        public IPAddress BroadcastAddress { get; set; }

        /// <inheritdoc />
        public IPEndPoint BroadcastEndpoint { get; set; }

        /// <summary>
        /// A timer to periodically re-send the broadcast message.
        /// </summary>
        private System.Timers.Timer _timer { get; set; } = new System.Timers.Timer();

        /// <inheritdoc />
        public TimeSpan UpdateRate => TimeSpan.FromMilliseconds(_timer?.Interval ?? 0);

        /// <summary>
        /// Reference to the Adapter to broadcast connection information for.
        /// </summary>
        protected T Adapter { get; private set; }

        private UPnPDeviceServiceModel _model = null;
        /// <inheritdoc />
        public UPnPDeviceServiceModel Model => _model ?? (_model = ConstructDescription());

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

        private Task _listenerThread;

        /// <summary>
        /// Constructs a new instance of a UPnP broadcast service.
        /// </summary>
        /// <param name="adapter">Reference to a MTConnect Adapter instance.</param>
        /// <param name="broadcastRate">Rate (in milliseconds) for which the Adapter is advertised as a UPnP service.</param>
        /// <param name="address">Address for hosting the UPnP Device Description file.</param>
        /// <param name="port">Port for hosting the UPnP Device Description file.</param>
        /// <param name="logFactory">Reference to the log factory so an internal logger can be created.</param>
        public UPnPService(T adapter, double broadcastRate = DEFAULT_BROADCAST_RATE, string address = DEFAULT_UPnP_ADDRESS, int port = DEFAULT_UPnP_PORT, ILoggerFactory logFactory = default)
        {
            Adapter = adapter;
            Adapter.OnStarted += (sender, e) =>
            {
                _adapterStartTime = DateTime.UtcNow;
                _broadcast(SSDP_NTS.Alive);
            };
            Adapter.OnStopped += (sender, e) =>
            {
                _broadcast(SSDP_NTS.ByeBye);
                Stop();
            };

            InitializeSSDP();
            InitializeUPnPServer(address, port);

            _timer.Interval = broadcastRate;
            _timer.Elapsed += (sender, e) => _broadcast(SSDP_NTS.Update);

            _logger = logFactory?.CreateLogger<UPnPService<T>>();
        }

        /// <summary>
        /// Initializes the HTTP client in charge of listening to UPnP-related requests.
        /// </summary>
        /// <param name="address">Address of the UPnP endpoint.</param>
        /// <param name="port">Port of the UPnP endpoint.</param>
        /// <exception cref="InvalidOperationException"></exception>
        private void InitializeUPnPServer(string address, int port)
        {
            IPAddress epAddress = ConvertLocalhost(address);

            if (epAddress == null)
            {
                var invalidAddress = new ArgumentNullException(nameof(address), "Could not discover IPV4 address to host the UPnP Device Description");
                _logger?.LogError(invalidAddress, invalidAddress.Message);
                throw invalidAddress;
            }
            UPnP_DescriptionEndpoint = new IPEndPoint(epAddress, port);
            var model = LoadUPnPDescription();
            if (model.AdapterEndpoint == UPnP_DescriptionEndpoint.ToString())
                throw new InvalidOperationException("Cannot start the UPnP host server at the same address as the MTConnect Adapter");

            string serverPrefix = UPnP_DescriptionEndpoint.ToString();
            _httpListener.Prefixes.Add($"http://{serverPrefix}/");
        }

        /// <summary>
        /// Initializes the UDP client in charge of publishing the <c>NOTIFY *</c> messages on the network.
        /// </summary>
        private void InitializeSSDP()
        {
            BroadcastAddress = IPAddress.Parse(DEFAULT_BROADCAST_ADDRESS);
            BroadcastEndpoint = new IPEndPoint(BroadcastAddress, DEFAULT_BROADCAST_PORT);
            _client.JoinMulticastGroup(BroadcastAddress);
            _client.EnableBroadcast = true;
            _client.ExclusiveAddressUse = false;
        }

        /// <summary>
        /// Loads the <c>UPnP-Description.xml</c> and <c>MTConnect_8-bit.png</c> files into memory and begins formatting the Device Description document according to the current <see cref="UPnPDeviceServiceModel"/>.
        /// </summary>
        /// <returns>Reference to the <see cref="Model"/></returns>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        private UPnPDeviceServiceModel LoadUPnPDescription()
        {
            string faviconPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MTConnect_8-bit.png");
            if (!File.Exists(faviconPath))
                throw new FileNotFoundException("Cannot find UPnP icon file at the expected path", faviconPath);
            MTConnectFavicon = File.ReadAllBytes(faviconPath);

            _upnpDescription = new XmlDocument();
            string descriptionFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UPnP-Description.xml");
            if (!File.Exists(descriptionFilePath))
                throw new FileNotFoundException("Cannot find UPnP Device Description file at the expected path", descriptionFilePath);

            _upnpDescription.Load(descriptionFilePath);

            var sb = new StringBuilder(_upnpDescription.OuterXml);

            if (Model == null)
                throw new InvalidOperationException("Cannot construct a valid UPnP description without context from the implemented Adapter");
            var properties = Model.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (var property in properties) sb = sb.Replace($"{{{property.Name}}}", property.GetValue(Model).ToString());

            _upnpDescription.LoadXml(sb.ToString());

            return Model;
        }

        /// <summary>
        /// Broadcasts connection information about an Adapter if it isn't already.
        /// </summary>
        private void _broadcast(SSDP_NTS notificationSubType = SSDP_NTS.Alive)
        {
            if (IsBusy) return;

            _busy = true;
            string message = string.Empty;
            try
            {
                var broadcastObject = ConstructMessage();
                if (broadcastObject == null) throw new InvalidOperationException();

                broadcastObject.NotificationSubType = notificationSubType;

                message = broadcastObject.ToString();
                if (!string.IsNullOrEmpty(message))
                {
                    byte[] bytes = Encoding.ASCII.GetBytes(message);
                    if (_client.Send(bytes, bytes.Length, BroadcastEndpoint) > 0) _lastSent = DateTime.UtcNow;
                }
                else
                {
                    _logger?.LogWarning("UPnP Message is empty!");
                }
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Failed to broadcast message: {Message}", message);
            }
            _busy = false;
        }
        /// <summary>
        /// Listens for HTTP requests and responds to dedicated UPnP endpoints
        /// </summary>
        private async Task _runUPnPServer()
        {
            while (_httpListener.IsListening)
            {
                var context = await _httpListener.GetContextAsync();
                var response = context.Response;
                byte[] buffer = null;
                switch (context.Request.Url.LocalPath)
                {
                    case "/upnp/description.xml":
                        response.StatusCode = 200;
                        response.ContentType = "text/xml";
                        // TODO: Update XML document with latest info
                        string deviceDescription = _upnpDescription.OuterXml;
                        buffer = Encoding.UTF8.GetBytes(deviceDescription);
                        response.ContentLength64 = buffer.Length;
                        response.OutputStream.Write(buffer, 0, buffer.Length);
                        response.OutputStream.Close();
                        break;
                    case "/upnp/favicon.png":
                        buffer = MTConnectFavicon;
                        response.ContentLength64 = buffer.Length;
                        response.OutputStream.Write(buffer, 0, buffer.Length);
                        response.OutputStream.Close();
                        break;
                    default:
                        response.StatusCode = 404;
                        response.OutputStream.Close();
                        break;
                }
                // TODO: Allow the devices.xml to be generated based on the DataItems in the Adapter. An Agent should only retrieve the devices.xml if the Adapter has not already been configured in the Agent configuration.
            }
        }

        /// <summary>
        /// An overridable method for constructing the broadcast message. This can be overridden to provide additional context for the Adapter service.
        /// </summary>
        /// <returns>A formatted broadcast message, ready to be transmitted to a multicast group.</returns>
        protected virtual UPnPNotifyMessage ConstructMessage()
        {
            var advertisement = new UPnPNotifyMessage(this, Model);

            return advertisement;
        }

        protected virtual UPnPDeviceServiceModel ConstructDescription()
        {
            var version = Assembly.GetEntryAssembly()?.GetName()?.Version;

            return new UPnPDeviceServiceModel()
            {
                DeviceUUID = Adapter.DeviceUUID,
                ServiceType = nameof(Adapter),
                ServiceVersion = $"{version.Major}.{version.Minor}",
                AdapterEndpoint = null,
                UPnPEndpoint = UPnP_DescriptionEndpoint.ToString()
            };
        }

        /// <inheritdoc />
        public void Start(CancellationToken cancellationToken = default)
        {
            _busy = false;
            cancellationToken.Register(Stop);

            _timer.Start();

            try
            {
                _httpListener.Start();
                _listenerThread = Task.Factory.StartNew(
                    _runUPnPServer,
                    cancellationToken,
                    TaskCreationOptions.LongRunning,
                    TaskScheduler.Default
                );
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Failed to start UPnP Device Description server");
                throw ex;
            }

            _logger?.LogInformation("Started UDP broadcaster");
        }

        /// <inheritdoc />
        public void Stop()
        {
            _timer.Stop();
            _httpListener?.Stop();
            _listenerThread?.Dispose();

            _busy = false;
            _adapterStartTime = null;

            _logger?.LogInformation("Stopped UDP broadcaster");
        }

        public void Dispose()
        {
            Stop();
            _client?.Client?.Close();
            _client?.Dispose();
            _httpListener?.Close();
            _timer.Dispose();
        }

        /// <inheritdoc />
        public IPAddress ConvertLocalhost(string localhostAddress)
        {
            IPAddress result = null;
            if (localhostAddress == IPAddress.Any.ToString())
            {
                // Discover actual address
                string host = Dns.GetHostName();

                // Get IP Address using hostname
                IPHostEntry ip = Dns.GetHostEntry(host);
                return ip.AddressList.FirstOrDefault(o => o.AddressFamily == AddressFamily.InterNetwork);
            }
            else if (IPAddress.TryParse(localhostAddress, out result))
            {
                return result;
            }
            throw new InvalidOperationException("Could not parse localhost address");
        }
    }
}