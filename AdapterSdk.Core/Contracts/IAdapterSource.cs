using System;
using System.Threading;

namespace Mtconnect.AdapterSdk
{
    /// <summary>
    /// A generic interface for classes used to derive DataItemAttributes from use.
    /// </summary>
    public interface IAdapterSource
    {
        /// <inheritdoc cref="IAdapter.DeviceUUID"/>
        string DeviceUuid { get; }

        /// <inheritdoc cref="IAdapter.DeviceName"/>
        string DeviceName { get; }

        /// <inheritdoc cref="IAdapter.StationId"/>
        string StationId { get; }

        /// <inheritdoc cref="IAdapter.SerialNumber"/>
        string SerialNumber { get; }

        /// <inheritdoc cref="IAdapter.Manufacturer"/>
        string Manufacturer { get; }

        /// <summary>
        /// Handles the event when an Adapter source has finished receiving and processing data.
        /// </summary>
        event DataReceivedHandler OnDataReceived;

        /// <summary>
        /// Handles the event when an Adapter source has started processing data.
        /// </summary>
        event AdapterSourceStartedHandler OnAdapterSourceStarted;

        /// <summary>
        /// Handles the event when an Adapter source has stopped processing data.
        /// </summary>
        event AdapterSourceStoppedHandler OnAdapterSourceStopped;

        /// <summary>
        /// Instructs the Adapter source to begin collecting data.
        /// </summary>
        /// <param name="token">Token for cancelling the startup method.</param>
        void Start(CancellationToken token = default);

        /// <summary>
        /// Instructs the Adapter source to stop collecting and/or processing data.
        /// </summary>
        /// <param name="ex">Reference to a possible exception that led to the stop of the Adapter Source.</param>
        void Stop(Exception ex = null);
    }
}
