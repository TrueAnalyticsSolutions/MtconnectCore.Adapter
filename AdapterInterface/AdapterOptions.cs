using System;

namespace Mtconnect.AdapterInterface
{
    /// <summary>
    /// A DTO for serialized MTConnect Adapter configuration options.
    /// </summary>
    [Serializable]
    public partial class AdapterOptions
    {
        /// <inheritdoc cref="Adapter.Heartbeat"/>
        public double Heartbeat { get; }

        /// <inheritdoc cref="Adapter.CanEnqueueDataItems"/>
        public bool CanEnqueueDataItems { get; }

        /// <summary>
        /// Constructs options for configuring a MTConnect Adapter.
        /// </summary>
        /// <param name="heartbeat"><inheritdoc cref="Adapter.Heartbeat" path="/summary" /></param>
        /// <param name="canQueue"><inheritdoc cref="Adapter.CanEnqueueDataItems" path="/summary"/></param>
        public AdapterOptions(double heartbeat, bool canQueue = false)
        {
            Heartbeat = heartbeat;
            CanEnqueueDataItems = canQueue;
        }
    }

}