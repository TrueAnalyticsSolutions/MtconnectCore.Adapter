using System;
using System.Threading;

namespace Mtconnect
{
    /// <summary>
    /// Handler for ingesting data from a MTConnect Adapter source.
    /// </summary>
    /// <param name="data">Reference to the data model.</param>
    /// <param name="e">Event arguments containing data received from the MTConnect Adapter source.</param>
    public delegate void DataReceivedHandler(IAdapterDataModel data, DataReceivedEventArgs e);

    /// <summary>
    /// A generic interface for classes used to derive <see cref="Mtconnect.AdapterInterface.Contracts.Attributes.DataItemAttribute"/>s from use.
    /// </summary>
    public interface IAdapterSource
    {
        /// <summary>
        /// Handles the event when an Adapter source has finished receiving and processing data.
        /// </summary>
        event DataReceivedHandler OnDataReceived;

        /// <summary>
        /// Instructs the Adapter source to begin collecting data.
        /// </summary>
        /// <param name="token">Token for cancelling the startup method.</param>
        void Start(CancellationToken token = default);

        /// <summary>
        /// Instructs the Adapter source to stop collecting and/or processing data.
        /// </summary>
        void Stop();
    }
}
