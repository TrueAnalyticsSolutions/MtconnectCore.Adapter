using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Mtconnect.AdapterSdk.Contracts
{
    /// <summary>
    /// A DTO for serialized MTConnect Adapter configuration options.
    /// </summary>
    public interface IAdapterOptions
    {
        /// <inheritdoc cref="IAdapter.DeviceUUID"/>
        string DeviceUUID { get; }

        /// <inheritdoc cref="IAdapter.DeviceName"/>
        string DeviceName { get; }

        /// <inheritdoc cref="IAdapter.StationId"/>
        string StationId { get; }

        /// <inheritdoc cref="IAdapter.SerialNumber"/>
        string SerialNumber { get; }

        /// <inheritdoc cref="IAdapter.Manufacturer"/>
        string Manufacturer { get; }

        /// <inheritdoc cref="IAdapter.Heartbeat"/>
        double Heartbeat { get; }

        /// <inheritdoc cref="IAdapter.CanEnqueueDataItems"/>
        bool CanEnqueueDataItems { get; }

        /// <inheritdoc cref="IAdapter.CanValidateDataItems"/>
        bool CanValidateDataItems { get; }

        /// <summary>
        /// Gets a <see cref="IDataItemOptions"/> by the name of the data item as defined internally within the Adapter implementation.
        /// </summary>
        /// <param name="internalName">Reference to the internal name of the DataItem within the context of the Adapter implementation.</param>
        /// <returns>Reference to the <see cref="IDataItemOptions"/>.</returns>
        IDataItemOptions this[string internalName] { get; }

        /// <summary>
        /// Updates the properties of the <see cref="IAdapterOptions"/> from the <see cref="ConfigurationManager"/> section 'adapter'.
        /// </summary>
        Dictionary<string, object> UpdateFromConfig(ILogger logger = default);
    }
}
