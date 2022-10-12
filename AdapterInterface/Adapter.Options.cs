using System;

namespace MtconnectCore.AdapterInterface
{
    /// <summary>
    /// A DTO for serialized MTConnect Adapter configuration options.
    /// </summary>
    [Serializable]
    public partial class Options
    {
        /// <summary>
        /// The Port property to set and get the mPort. This will only take affect when the adapter is stopped.
        /// </summary>
        public int Port { get; }

        /// <summary>
        /// This is a method to set the heartbeat interval given in milliseconds.
        /// </summary>
        public double Heartbeat { get; }

        /// <summary>
        /// Constructs the most basic options for configuring a MTConnect Adapter.
        /// </summary>
        /// <param name="port"></param>
        public Options(int port)
        {
            Port = port;
        }

        /// <summary>
        /// Constructs options for configuring a MTConnect Adapter.
        /// </summary>
        /// <param name="port">Reference to the port number to publish the data thru.</param>
        /// <param name="heartbeat">This is a method to set the heartbeat interval given in milliseconds.</param>
        public Options(int port, double heartbeat)
        {
            Port = port;
            Heartbeat = heartbeat;
        }
    }

}