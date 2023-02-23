using System;
using System.Threading;

namespace Mtconnect.AdapterInterface.Contracts
{
    /// <summary>
    /// A generic implementation to represent a UDP broadcaster service.
    /// </summary>
    public interface IBroadcaster
    {
        /// <summary>
        /// A flag indicating whether or not the service is busy constructing and sending a message.
        /// </summary>
        bool IsBusy { get; }

        /// <summary>
        /// A timestamp (UTC) referencing the last time a broadcast message was sent.
        /// </summary>
        DateTime? LastSent { get; }

        /// <summary>
        /// Begins periodically broadcasting connection information for the Adapter. This method immediately sends a message too.
        /// </summary>
        /// <param name="cancellationToken">An optional cancellation token to automatically stop broadcasting</param>
        void Start(CancellationToken cancellationToken = default);

        /// <summary>
        /// Stops the periodic broadcasting of connection information for the Adapter.
        /// </summary>
        void Stop();
    }
}
