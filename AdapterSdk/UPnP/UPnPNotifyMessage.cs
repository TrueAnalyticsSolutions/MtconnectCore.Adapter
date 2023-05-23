using Mtconnect.UPnP;
using System;
using System.Reflection;
using System.Text;

namespace Mtconnect.AdapterSdk.UPnP
{
    /// <summary>
    /// A payload to be published to the SSDP multicast group for UPnP. This message produces the <c>NOTIFY *</c> message for NTS options: <c>ssdp:alive</c>, <c>ssdp:update</c>, and <c>ssdp:byebye</c>.
    /// </summary>
    public class UPnPNotifyMessage : IUPnPMessage
    {
        /// <inheritdoc />
        /// <remarks>Required. See <see href="https://openconnectivity.org/upnp-specs/UPnP-arch-DeviceArchitecture-v2.0-20200417.pdf">UPnP Architecture Documents</see>, Page 33</remarks>
        public virtual string Host { get; }

        /// <inheritdoc />
        /// <remarks>Required. See <see href="https://openconnectivity.org/upnp-specs/UPnP-arch-DeviceArchitecture-v2.0-20200417.pdf">UPnP Architecture Documents</see>, Page 33</remarks>
        public virtual SSDP_NTS NotificationSubType { get; set; } = SSDP_NTS.Alive;

        /// <inheritdoc />
        /// <remarks>Required. See <see href="https://openconnectivity.org/upnp-specs/UPnP-arch-DeviceArchitecture-v2.0-20200417.pdf">UPnP Architecture Documents</see>, Page 28</remarks>
        public virtual string ServiceLocation { get; set; }

        /// <inheritdoc />
        /// <remarks>Required. See <see href="https://openconnectivity.org/upnp-specs/UPnP-arch-DeviceArchitecture-v2.0-20200417.pdf">UPnP Architecture Documents</see>, Page 33</remarks>
        /// <remarks>This must be incremented with each new broadcast</remarks>
        public uint BootId { get; set; } = (uint)DateTime.UtcNow.Ticks;

        /// <summary>
        /// Reference to the SSDP <c>CONFIGID.UPNP.ORG</c>
        /// </summary>
        /// <remarks>Required. See <see href="https://openconnectivity.org/upnp-specs/UPnP-arch-DeviceArchitecture-v2.0-20200417.pdf">UPnP Architecture Documents</see>, Page 34</remarks>
        public virtual string ConfigId { get; set; }

        /// <inheritdoc />
        /// <remarks>Required. See <see href="https://openconnectivity.org/upnp-specs/UPnP-arch-DeviceArchitecture-v2.0-20200417.pdf">UPnP Architecture Documents</see>, Page 34</remarks>
        public uint NextBootId => BootId + 1;

        /// <summary>
        /// Reference to the SSDP <c>SECURELOCATION.UPNP.ORG</c>
        /// </summary>
        /// <remarks>Allowed. See <see href="https://openconnectivity.org/upnp-specs/UPnP-arch-DeviceArchitecture-v2.0-20200417.pdf">UPnP Architecture Documents</see>, Page 34</remarks>
        public string SecureLocation { get; set; }

        /// <summary>
        /// Reference to the SSDP <c>SEARCHPORT.UPNP.ORG</c>
        /// </summary>
        /// <remarks>Allowed. See <see href="https://openconnectivity.org/upnp-specs/UPnP-arch-DeviceArchitecture-v2.0-20200417.pdf">UPnP Architecture Documents</see>, Page 34</remarks>
        public int? SearchPort { get; set; }

        /// <summary>
        /// Reference to the SSDP <c>CACHE-CONTROL</c> <c>max-age</c> token
        /// </summary>
        public virtual TimeSpan MaxAge { get; set; } = TimeSpan.FromSeconds(1800);

        /// <inheritdoc />
        public UPnPDeviceServiceModel Model { get; set; }

        public UPnPNotifyMessage(IUPnPService broadcaster, UPnPDeviceServiceModel model)
        {
            Model = model;
            Host = broadcaster.BroadcastEndpoint.ToString();
            MaxAge = broadcaster.UpdateRate;
            ServiceLocation = $"http://{model.UPnPEndpoint}/upnp/description.xml";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOTIFY * HTTP/1.1");
            sb.AppendLine($"HOST: {Host}");
            if (NotificationSubType == SSDP_NTS.Alive)
                sb.AppendLine($"CACHE-CONTROL: max-age={(int)MaxAge.TotalSeconds}");
            if (NotificationSubType == SSDP_NTS.Alive || NotificationSubType == SSDP_NTS.Update)
                sb.AppendLine($"LOCATION: {ServiceLocation}");
            sb.AppendLine($"NT: urn:mtconnect-org:service:{Model.ServiceType}:{Model.ServiceVersion}");
            sb.AppendLine($"NTS: ssdp:{NotificationSubType.ToString().ToLower()}");
            if (NotificationSubType == SSDP_NTS.Alive)
                sb.AppendLine($"SERVER: {Environment.OSVersion.Platform}/{Environment.OSVersion.VersionString} UPnP/1.0 MTConnect{Model.ServiceType}/{Model.ServiceVersion}");
            sb.AppendLine($"USN: uuid:{Model.DeviceUUID}::urn:mtconnect-org:service:{Model.ServiceType}:{Model.ServiceVersion}");
            sb.AppendLine($"BOOTID.UPNP.ORG: {BootId}");
            // TODO: Undrestand <c>CONFIGID.UPNP.ORG</c>
            sb.AppendLine($"NEXTBOOTID.UPNP.ORG: {NextBootId}");
            if (NotificationSubType == SSDP_NTS.Alive || NotificationSubType == SSDP_NTS.Update)
            {
                if (SearchPort != null) sb.AppendLine($"SEARCHPORT.UPNP.ORG: {SearchPort}");
                if (!string.IsNullOrEmpty(SecureLocation)) sb.AppendLine($"SECURELOCATION.UPNP.ORG: {SecureLocation}");
            }

            sb.AppendLine();

            return sb.ToString();
        }
    }
}