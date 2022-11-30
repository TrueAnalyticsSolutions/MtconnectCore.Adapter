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
        /// Constructs the most basic options for configuring a MTConnect Adapter.
        /// </summary>
        /// <param name="heartbeat"><inheritdoc cref="AdapterOptions.AdapterOptions" path="/param[@name='heartbeat']"/></param>
        /// <param name="port"><inheritdoc cref="TcpAdapterOptions.Port" path="/summary"/></param>
        public TcpAdapterOptions(double heartbeat = 10_000, int port = 7878) : base(heartbeat)
        {
            Port = port;
        }

        public override Dictionary<string, object> UpdateFromConfig()
        {
            var adapterSettings = base.UpdateFromConfig();

            if (adapterSettings.ContainsKey("port") && Int32.TryParse(adapterSettings["port"].ToString(), out int port))
            {
                Port = port;
            }

            return adapterSettings;
        }
    }
}
