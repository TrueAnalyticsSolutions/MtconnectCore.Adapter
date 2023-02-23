using Microsoft.Extensions.Logging;
using System.Net;
using System;
using Mtconnect.AdapterInterface.UPnP;

namespace Mtconnect.UPnP
{
    /// <inheritdoc />
    public sealed class TcpUPnPService : UPnPService<TcpAdapter>
    {
        /// <inheritdoc cref="UPnPService{T}.UPnPService(T, double, string, int, ILoggerFactory)"/>
        /// <param name="adapter">Reference to a <see cref="TcpAdapter"/> instance.</param>
        /// <param name="broadcastRate"><inheritdoc cref="UPnPService{T}.UPnPService(T, double, string, int, ILoggerFactory)" path="[@name='broadcastRate']"/></param>
        /// <param name="address"><inheritdoc cref="UPnPService{T}.UPnPService(T, double, string, int, ILoggerFactory)" path="[@name='address']"/></param>
        /// <param name="port"><inheritdoc cref="UPnPService{T}.UPnPService(T, double, string, int, ILoggerFactory)" path="[@name='port']"/></param>
        /// <param name="logFactory"><inheritdoc cref="UPnPService{T}.UPnPService(T, double, string, int, ILoggerFactory)" path="[@name='logFactory']"/></param>
        public TcpUPnPService(TcpAdapter adapter, double broadcastRate = DEFAULT_BROADCAST_RATE, string address = DEFAULT_UPnP_ADDRESS, int port = DEFAULT_UPnP_PORT, ILoggerFactory logFactory = default) : base(adapter, broadcastRate, address, port, logFactory) { }

        protected override UPnPDeviceServiceModel ConstructDescription()
        {
            var model = base.ConstructDescription();
            model.AdapterEndpoint = ConvertLocalhost(Adapter.Address).ToString();
            model.ServiceType = nameof(TcpAdapter);
            return model;
        }
    }
}
