namespace Mtconnect.AdapterSdk.Contracts
{
    /// <summary>
    /// Represents the various states of the MTConnect Adapter.
    /// </summary>
    public enum AdapterStates
    {
        /// <summary>
        /// Indicates that the MTConnect Adapter has stopped.
        /// </summary>
        Stopped = -2,
        /// <summary>
        /// Indicates a transitionary state for the MTConnect Adapter that it is attempting to stop.
        /// </summary>
        Stopping = -1,
        /// <summary>
        /// Indicates that the MTConnect Adapter has not initially started.
        /// </summary>
        NotStarted = 0,
        /// <summary>
        /// Indicates a transitionary state for the MTConnect Adapter that it is attempting to start.
        /// </summary>
        Starting = 1,
        /// <summary>
        /// Indicates that the MTConnect Adapter has started.
        /// </summary>
        Started = 2,
        /// <summary>
        /// Indicates that the MTConnect Adapter is busy with a client.
        /// </summary>
        Busy,
    }
}
