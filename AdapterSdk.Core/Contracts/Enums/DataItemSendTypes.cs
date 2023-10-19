namespace Mtconnect.AdapterSdk.Contracts
{
    /// <summary>
    /// Represents methods for sending <see cref="IDataItem"/>s.
    /// </summary>
    public enum DataItemSendTypes
    {
        /// <summary>
        /// Instructs the Adapter to send all <see cref="IDataItem"/>s.
        /// </summary>
        All,
        /// <summary>
        /// Instructs the Adapter to send only the <see cref="IDataItem"/>s which values have changed.
        /// </summary>
        Changed,
        /// <summary>
        /// Instructs the Adapter to send all of the changed <see cref="IDataItem"/> values that have been queued up.
        /// </summary>
        Queued
    }
}
