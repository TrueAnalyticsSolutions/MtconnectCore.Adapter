using System;
using System.Net;
using System.Threading;

namespace Mtconnect.AdapterSdk.UPnP
{
    /// <summary>
    /// A generic implementation to represent a UDP broadcaster service.
    /// </summary>
    public interface IUPnPService

    {
        /// <summary>
        /// UPnP Device Description Address. Example: <example>http://10.0.0.2:7878/upnp/description.xml</example>
        /// </summary>
        IPEndPoint UPnP_DescriptionEndpoint { get; set; }

        /// <summary>
        /// UPnP Notification Address. Example: <example><c>239.255.255.250</c></example>
        /// </summary>
        IPAddress BroadcastAddress { get; set; }

        /// <summary>
        /// UPnP Notification Endpoint. Example: <example><c>239.255.255.250:1900</c></example>
        /// </summary>
        IPEndPoint BroadcastEndpoint { get; set; }

        /// <summary>
        /// A flag indicating whether or not the service is busy constructing and sending a message.
        /// </summary>
        bool IsBusy { get; }

        /// <summary>
        /// A timestamp (UTC) referencing the last time a broadcast message was sent.
        /// </summary>
        DateTime? LastSent { get; }

        /// <summary>
        /// A reference to how frequently the broadcaster transmits the discovery advertisement.
        /// </summary>
        TimeSpan UpdateRate { get; }

        /// <summary>
        /// Reference to the static model that describes the device and service for UPnP.
        /// </summary>
        IUPnPDeviceServiceModel Model { get; }

        /// <summary>
        /// Begins periodically broadcasting connection information for the Adapter. This method immediately sends a message too.
        /// </summary>
        /// <param name="cancellationToken">An optional cancellation token to automatically stop broadcasting</param>
        void Start(CancellationToken cancellationToken = default);

        /// <summary>
        /// Stops the periodic broadcasting of connection information for the Adapter.
        /// </summary>
        void Stop();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="localhostAddress"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        IPAddress ConvertLocalhost(string localhostAddress);
    }
}
