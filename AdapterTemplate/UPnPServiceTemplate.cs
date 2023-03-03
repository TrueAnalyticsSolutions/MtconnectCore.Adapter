using Microsoft.Extensions.Logging;
using Mtconnect.AdapterInterface.UPnP;
using Mtconnect.UPnP;

namespace Mtconnect.AdapterTemplate
{
    /// <inheritdoc />
    public sealed class UPnPServiceTemplate : UPnPService<AdapterTemplate>
    {
        /// <inheritdoc cref="UPnPService{T}.UPnPService(T, double, string, int, ILoggerFactory)"/>
        /// <param name="adapter">Reference to a <see cref="AdapterTemplate"/> instance.</param>
        /// <param name="broadcastRate"><inheritdoc cref="UPnPService{T}.UPnPService(T, double, string, int, ILoggerFactory)" path="[@name='broadcastRate']"/></param>
        /// <param name="address"><inheritdoc cref="UPnPService{T}.UPnPService(T, double, string, int, ILoggerFactory)" path="[@name='address']"/></param>
        /// <param name="port"><inheritdoc cref="UPnPService{T}.UPnPService(T, double, string, int, ILoggerFactory)" path="[@name='port']"/></param>
        /// <param name="logFactory"><inheritdoc cref="UPnPService{T}.UPnPService(T, double, string, int, ILoggerFactory)" path="[@name='logFactory']"/></param>
        public UPnPServiceTemplate(AdapterTemplate adapter, double broadcastRate = DEFAULT_BROADCAST_RATE, string address = DEFAULT_UPnP_ADDRESS, int port = DEFAULT_UPnP_PORT, ILoggerFactory logFactory = default) : base(adapter, broadcastRate, address, port, logFactory) { }

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
