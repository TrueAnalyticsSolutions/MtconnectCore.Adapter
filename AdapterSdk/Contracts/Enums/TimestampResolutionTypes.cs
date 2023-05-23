namespace Mtconnect.AdapterSdk.Contracts
{
    /// <summary>
    /// Indicators for how accurate the timestamp may be to the true occurance of an event.
    /// </summary>
    public enum TimestampResolutionTypes
    {
        /// <summary>
        /// Indicates that the accuracy of a timestamp is not known or quantifiable.
        /// </summary>
        Unknown = -1,
        /// <summary>
        /// Indicates that there is perfect resolution (or real-time)
        /// </summary>
        None = 0,
        /// <summary>
        /// Indicates that the accuracy of a timestamp is high.
        /// </summary>
        Fine = 1,
        /// <summary>
        /// Indicates that the accuracy of a timestamp is low.
        /// </summary>
        Coarse = 2,
    }
}
