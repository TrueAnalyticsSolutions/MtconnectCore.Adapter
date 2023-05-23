namespace Mtconnect.UPnP
{
    /// <summary>
    /// A model used to update the UPnP Device Description template document. See <see href="/UPnP-Description.xml"/>.
    /// </summary>
    public class UPnPDeviceServiceModel
    {
        /// <summary>
        /// Unique identifier for the device.
        /// </summary>
        public string DeviceUUID { get; set; }

        /// <summary>
        /// Reference to the type of MTConnect Adapter implemented.
        /// </summary>
        public string ServiceType { get; set; }

        /// <summary>
        /// Reference to the version of the MTConnect Adapter implemented.
        /// </summary>
        public string ServiceVersion { get; set; }

        /// <summary>
        /// Reference to the endpoint for the MTConnect Adapter.
        /// </summary>
        public string AdapterEndpoint { get; set; }

        /// <summary>
        /// Reference to the endpoint for the UPnP service.
        /// </summary>
        public string UPnPEndpoint { get; set; }
    }
}