using Mtconnect.AdapterInterface;
using System;
using System.Collections.Generic;

namespace Mtconnect
{
    /// <summary>
    /// Configuration options for a <see cref="TcpAdapter"/>.
    /// </summary>
    public sealed class TcpAdapterOptions : AdapterOptions
    {
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
        public TcpAdapterOptions(double heartbeat = 10_000, int port = 7878, int maxConnections = 1) : base(heartbeat)
        {
            Port = port;
            MaxConcurrentConnections = maxConnections;
        }

        public override Dictionary<string, object> UpdateFromConfig()
        {
            var adapterSettings = base.UpdateFromConfig();

            if (adapterSettings.ContainsKey("port") && Int32.TryParse(adapterSettings["port"].ToString(), out int port))
            {
                Port = port;
            }

            if (adapterSettings.ContainsKey("maxConnections") && Int32.TryParse(adapterSettings["maxConnections"].ToString(), out int maxConnections))
            {
                MaxConcurrentConnections = maxConnections;
            }

            return adapterSettings;
        }
    }
}
