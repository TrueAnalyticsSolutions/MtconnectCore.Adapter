namespace Mtconnect.AdapterSdk.UPnP
{
    /// <summary>
    /// Represents available values for SSDP Notification Sub Type header field
    /// </summary>
    public enum SSDP_NTS
    {
        /// <summary>
        /// Represents SSDP Notification Sub Type <c>ssdp:alive</c>
        /// </summary>
        Alive,
        /// <summary>
        /// Represents SSDP Notification Sub Type <c>ssdp:byebye</c>
        /// </summary>
        ByeBye,
        /// <summary>
        /// Represents SSDP Notification Sub Type <c>ssdp:update</c>
        /// </summary>
        Update,
        /// <summary>
        /// Represents SSDP Notification Sub Type <c>ssdp:propchange</c>
        /// </summary>
        Propchange,
        /// <summary>
        /// Represents SSDP Notification Sub Type <c>ssdp:uknown</c>
        /// </summary>
        Unknown
    }
}
