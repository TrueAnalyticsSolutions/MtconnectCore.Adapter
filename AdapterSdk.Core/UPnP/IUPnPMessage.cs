namespace Mtconnect.AdapterSdk.UPnP
{
    /// <summary>
    /// A generic, base definition for a UPnP Message. 
    /// </summary>
    public interface IUPnPMessage
    {
        /// <summary>
        /// Reference to the SSDP <c>HOST</c>
        /// <br/>
        /// Example: <example><c>239.255.255.250:1900</c></example>
        /// </summary>
        string Host { get; }

        /// <summary>
        /// Reference to tthe SSDP <c>NTS</c>
        /// </summary>
        SSDP_NTS NotificationSubType { get; set; }

        /// <summary>
        /// Reference to the SSDP <c>LOCATION</c>
        /// </summary>
        string ServiceLocation { get; }

        /// <summary>
        /// Reference to the SSDP <c>BOOTID.UPNP.ORG</c>
        /// </summary>
        uint BootId { get; set; }

        /// <summary>
        /// Reference to the SSDP <c>NEXTBOOTID.UPNP.ORG</c>
        /// </summary>
        uint NextBootId { get; }

        /// <summary>
        /// Reference to the static model that describes the device and service for UPnP.
        /// </summary>
        IUPnPDeviceServiceModel Model { get; }
    }
}