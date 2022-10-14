using Mtconnect.AdapterInterface;

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
        public int Port { get; }

        /// <summary>
        /// Constructs the most basic options for configuring a MTConnect Adapter.
        /// </summary>
        /// <param name="heartbeat"><inheritdoc cref="AdapterOptions.AdapterOptions(double)" path="/param[@name='heartbeat']"/></param>
        /// <param name="port"><inheritdoc cref="TcpAdapterOptions.Port" path="/summary"/></param>
        public TcpAdapterOptions(double heartbeat, int port = 7878) : base(heartbeat)
        {
            Port = port;
        }
    }
}
