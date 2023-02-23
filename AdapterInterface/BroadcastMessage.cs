using System;

namespace Mtconnect
{
    /// <summary>
    /// A payload to be transmitted to a multicast group.
    /// </summary>
    public class BroadcastMessage
    {
        /// <summary>
        /// Timestamp of when the Adapter started last.
        /// </summary>
        public DateTime? Started { get; set; }

        /// <summary>
        /// Reference to the type of Adapter implemented. For example, TcpAdapter.
        /// </summary>
        public string Type { get; set; }
    }
}