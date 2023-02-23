using Microsoft.Extensions.Logging;
using Mtconnect.AdapterInterface;
using System;
using System.Collections.Generic;
using System.Net;

namespace Mtconnect
{
    /// <summary>
    /// Configuration options for a <see cref="TcpAdapter"/>.
    /// </summary>
    public sealed class TcpAdapterOptions : AdapterOptions
    {
        public string Address { get; private set; } = IPAddress.Any.ToString();

        /// <summary>
        /// The port for which the Adapter should stream data thru.
        /// </summary>
        public int Port { get; private set; }

        /// <summary>
        /// The maximum number of connections allowed at any given point.
        /// </summary>
        public int MaxConcurrentConnections { get; private set; }

        /// <summary>
        /// Constructs the most basic options for configuring a MTConnect Adapter.
        /// </summary>
        /// <param name="heartbeat"><inheritdoc cref="AdapterOptions.AdapterOptions" path="/param[@name='heartbeat']"/></param>
        /// <param name="port"><inheritdoc cref="TcpAdapterOptions.Port" path="/summary"/></param>
        public TcpAdapterOptions(double heartbeat = 10_000, string address = null, int port = 7878, int maxConnections = 3) : base(heartbeat)
        {
            if (!string.IsNullOrWhiteSpace(address))
            {
                Address = address;
            }
            Port = port;
            MaxConcurrentConnections = maxConnections;
        }

        public override Dictionary<string, object> UpdateFromConfig(ILogger logger = default)
        {
            var adapterSettings = base.UpdateFromConfig(logger);

            if (adapterSettings.ContainsKey("address"))
            {
                Address = adapterSettings["address"].ToString();
                logger?.LogDebug("Recognizing adapter option for overwriting the TCP Address");
            }

            if (adapterSettings.ContainsKey("port") && Int32.TryParse(adapterSettings["port"].ToString(), out int port))
            {
                Port = port;
                logger?.LogDebug("Recognizing adapter option for overwriting the TCP port");
            }

            if (adapterSettings.ContainsKey("maxConnections") && Int32.TryParse(adapterSettings["maxConnections"].ToString(), out int maxConnections))
            {
                MaxConcurrentConnections = maxConnections;
                logger?.LogDebug("Recognizing adapter option for overwriting the maximum client connections");
            }

            return adapterSettings;
        }
    }
}
