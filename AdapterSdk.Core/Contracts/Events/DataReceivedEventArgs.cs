using System;

namespace Mtconnect.AdapterSdk
{
    /// <summary>
    /// Handler for ingesting data from a MTConnect Adapter source.
    /// </summary>
    /// <param name="sender">Reference to the data model.</param>
    /// <param name="e">Event arguments containing data received from the MTConnect Adapter source.</param>
    public delegate void DataReceivedHandler(IAdapterSource sender, DataReceivedEventArgs e);

    /// <summary>
    /// Generic construct for storing received and processed data from an Adapter source.
    /// </summary>
    public class DataReceivedEventArgs : EventArgs
    {
        /// <summary>
        /// Reference to the the data was received.
        /// </summary>
        public DateTime Timestamp { get; set; } = TimeHelper.GetNow();

        /// <summary>
        /// Reference to the <see cref="IAdapterDataModel"/> that received the data update.
        /// </summary>
        public IAdapterDataModel Data { get; }

        /// <summary>
        /// Constructs a new instance of the event arguments for <see cref="DataReceivedHandler"/>
        /// </summary>
        /// <param name="data"><inheritdoc cref="Data" path="/summary"/></param>
        public DataReceivedEventArgs(IAdapterDataModel data)
        {
            Data = data;
        }
    }
}
