using System;

namespace Mtconnect
{
    /// <summary>
    /// Handler for ingesting data from a MTConnect Adapter source.
    /// </summary>
    /// <param name="data">Reference to the data model.</param>
    /// <param name="e">Event arguments containing data received from the MTConnect Adapter source.</param>
    public delegate void DataReceivedHandler(IAdapterDataModel data, DataReceivedEventArgs e);

    /// <summary>
    /// Generic construct for storing received and processed data from an Adapter source.
    /// </summary>
    public class DataReceivedEventArgs : EventArgs
    {
        /// <summary>
        /// Reference to the the data was received.
        /// </summary>
        public DateTime Timestamp { get; set; } = TimeHelper.GetNow();
    }
}
