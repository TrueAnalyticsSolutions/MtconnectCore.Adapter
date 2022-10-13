
namespace Mtconnect.AdapterInterface.Contracts
{
    /// <summary>
    /// Represents methods for sending <see cref="DataItem"/>s.
    /// </summary>
    public enum DataItemSendTypes
    {
        /// <summary>
        /// Instructs the Adapter to send all <see cref="DataItem"/>s.
        /// </summary>
        All,
        /// <summary>
        /// Instructs the Adapter to send only the <see cref="DataItem"/>s which values have changed.
        /// </summary>
        Changed,
        /// <summary>
        /// Instructs the Adapter to send all of the changed <see cref="DataItem"/> values that have been queued up.
        /// </summary>
        Queued
    }
}
