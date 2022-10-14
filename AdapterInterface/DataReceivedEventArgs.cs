using System;

namespace Mtconnect
{
    /// <summary>
    /// Generic construct for storing received and processed data from an Adapter source.
    /// </summary>
    public class DataReceivedEventArgs : EventArgs
    {
        /// <summary>
        /// Reference to the the data was received.
        /// </summary>
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
