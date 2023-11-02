namespace Mtconnect.AdapterSdk.UPnP
{
    /// <summary>
    /// A model used to update the UPnP Device Description template document. See <see href="/UPnP-Description.xml"/>.
    /// </summary>
    public interface IUPnPDeviceServiceModel
    {
        /// <summary>
        /// Unique identifier for the device.
        /// </summary>
        string DeviceUUID { get; set; }

        /// <summary>
        /// Reference to the type of MTConnect Adapter implemented.
        /// </summary>
        string ServiceType { get; set; }

        /// <summary>
        /// Reference to the version of the MTConnect Adapter implemented.
        /// </summary>
        string ServiceVersion { get; set; }

        /// <summary>
        /// Reference to the endpoint for the MTConnect Adapter.
        /// </summary>
        string AdapterEndpoint { get; set; }

        /// <summary>
        /// Reference to the endpoint for the UPnP service.
        /// </summary>
        string UPnPEndpoint { get; set; }
    }
}