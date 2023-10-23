using Mtconnect.AdapterSdk;
using Mtconnect.AdapterSdk.UPnP;
using Mtconnect.UPnP;

namespace Mtconnect.AdapterTemplate
{
    /// <inheritdoc />
    public sealed class UPnPServiceTemplate : UPnPService<AdapterTemplate>
    {
        /// <inheritdoc cref="UPnPService{T}.UPnPService(T, double, string, int, IAdapterLogger)"/>
        /// <param name="adapter">Reference to a <see cref="AdapterTemplate"/> instance.</param>
        /// <param name="broadcastRate"><inheritdoc cref="UPnPService{T}.UPnPService(T, double, string, int, IAdapterLogger)" path="[@name='broadcastRate']"/></param>
        /// <param name="address"><inheritdoc cref="UPnPService{T}.UPnPService(T, double, string, int, IAdapterLogger)" path="[@name='address']"/></param>
        /// <param name="port"><inheritdoc cref="UPnPService{T}.UPnPService(T, double, string, int, IAdapterLogger)" path="[@name='port']"/></param>
        /// <param name="logger"><inheritdoc cref="UPnPService{T}.UPnPService(T, double, string, int, IAdapterLogger)" path="[@name='logger']"/></param>
        public UPnPServiceTemplate(AdapterTemplate adapter, double broadcastRate = DEFAULT_BROADCAST_RATE, string address = DEFAULT_UPnP_ADDRESS, int port = DEFAULT_UPnP_PORT, IAdapterLogger logger = default) : base(adapter, broadcastRate, address, port, logger) { }

        /// <inheritdoc/>
        protected override UPnPDeviceServiceModel ConstructDescription()
        {
            var model = base.ConstructDescription();
            // TODO: Specify the endpoint for which your Adapter implementation is accessible.
            model.AdapterEndpoint = "Unknown";
            model.ServiceType = nameof(Mtconnect.AdapterTemplate);
            return model;
        }
    }
}
