using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Mtconnect.AdapterInterface
{
    /// <summary>
    /// A DTO for serialized MTConnect Adapter configuration options.
    /// </summary>
    [Serializable]
    public partial class AdapterOptions
    {
        /// <inheritdoc cref="Adapter.DeviceUUID"/>
        public string DeviceUUID { get; protected set; } = Guid.NewGuid().ToString();

        /// <inheritdoc cref="Adapter.StationId"/>
        public string StationId { get; protected set; } = Environment.MachineName;

        /// <inheritdoc cref="Adapter.SerialNumber"/>
        public string SerialNumber { get; protected set; }

        /// <inheritdoc cref="Adapter.Manufacturer"/>
        public string Manufacturer { get; protected set; }

        /// <inheritdoc cref="Adapter.Heartbeat"/>
        public double Heartbeat { get; protected set; }

        /// <inheritdoc cref="Adapter.CanEnqueueDataItems"/>
        public bool CanEnqueueDataItems { get; protected set; }

        /// <inheritdoc cref="Adapter.CanValidateDataItems"/>
        public bool CanValidateDataItems { get; protected set; }

        private readonly Dictionary<string, DataItemOptions> dataItems = new Dictionary<string, DataItemOptions>();

        /// <summary>
        /// Gets a <see cref="DataItemOptions"/> by the name of the data item as defined internally within the Adapter implementation.
        /// </summary>
        /// <param name="internalName">Reference to the internal name of the DataItem within the context of the Adapter implementation.</param>
        /// <returns>Reference to the <see cref="DataItemOptions"/>.</returns>
        public DataItemOptions this[string internalName]
        {
            get {
                if (dataItems.ContainsKey(internalName))
                {
                    return dataItems[internalName];
                }
                return null;
            }
            protected set {
                dataItems[internalName] = value;
            }
        }

        /// <summary>
        /// Constructs options for configuring a MTConnect Adapter.
        /// </summary>
        /// <param name="heartbeat"><inheritdoc cref="Adapter.Heartbeat" path="/summary" /></param>
        /// <param name="canQueue"><inheritdoc cref="Adapter.CanEnqueueDataItems" path="/summary"/></param>
        /// <param name="canValidate"><inheritdoc cref="Adapter.CanValidateDataItems" path="/summary"/></param>
        public AdapterOptions(double heartbeat = 10_000, bool canQueue = false, bool canValidate = false)
        {
            Heartbeat = heartbeat;
            CanEnqueueDataItems = canQueue;
            CanValidateDataItems = canValidate;
        }

        /// <summary>
        /// Updates the properties of the <see cref="AdapterOptions"/> from the <see cref="ConfigurationManager"/> section 'adapter'.
        /// </summary>
        public virtual Dictionary<string, object> UpdateFromConfig(ILogger logger = default)
        {
            var adapterSettings = (ConfigurationManager.GetSection("adapter") as Hashtable)
                .Cast<System.Collections.DictionaryEntry>()
                .ToDictionary(o => o.Key.ToString(), o => o.Value); ;
            if (adapterSettings == null)
            {
                var ex = new Exception("Failed to load configuration");
                logger?.LogError(ex, ex.Message);
                return null;
            }

            foreach (var kvp in adapterSettings)
            {
                if (kvp.Key.StartsWith("dataItem:", StringComparison.OrdinalIgnoreCase))
                {
                    string internalName = kvp.Key.Substring(kvp.Key.IndexOf(":") + 1);
                    if (internalName.Contains(":")) internalName = internalName.Substring(0, internalName.IndexOf(":"));

                    if (!dataItems.ContainsKey(internalName))
                    {
                        dataItems.Add(internalName, new DataItemOptions(internalName));
                    }

                    if (kvp.Key.Contains(":name"))
                    {
                        dataItems[internalName].DataItemName = Convert.ToString(kvp.Value);
                        logger?.LogDebug("Recognizing DataItem option for overwriting the name on {DataItemName}", internalName);
                    }
                    else if (kvp.Key.Contains(":format"))
                    {
                        try
                        {
                            var func = Scripting.DecryptScript(Convert.ToString(kvp.Value)).Result;

                            if (func != null)
                            {
                                dataItems[internalName].Formatter = func;
                                logger?.LogDebug("Recognizing DataItem option for overwriting the value format on {DataItemName}", internalName);
                            }
                            else
                            {
                                // TODO: Log error
                                var ex = new Exception("Failed to decrypt the DataItem value format function");
                                logger?.LogError(ex, ex.Message + " for DataItem {DataItemName}", internalName);
                            }
                        }
                        catch (Exception ex)
                        {
                            logger?.LogError(ex, ex.Message);
                        }
                    } else if (kvp.Key.Contains(":publish"))
                    {
                        if (Boolean.TryParse(kvp.Value.ToString(), out bool canPublishDataItem))
                        {
                            dataItems[internalName].Ignore = canPublishDataItem;
                            logger?.LogDebug("Recognizing DataItem option for overwriting the publish flag on {DataItemName}", internalName);
                        } else
                        {
                            var ex = new Exception("Failed to parse the DataItem 'publish' flag, must be either 'true' or 'false'");
                            logger?.LogError(ex, ex.Message + " for DataItem {DataItemName}", internalName);
                        }
                    } else
                    {
                        logger?.LogWarning("Unrecognized DataItem configuration option '{DataItemOptionKey}'", kvp.Key);
                    }

                } else if (kvp.Key.StartsWith("heartbeat", StringComparison.OrdinalIgnoreCase))
                {
                    Heartbeat = Convert.ToDouble(kvp.Value);
                    logger?.LogDebug("Recognizing adapter option for overwriting the heartbeat");
                } else if (kvp.Key.StartsWith("enqueue", StringComparison.OrdinalIgnoreCase))
                {
                    CanEnqueueDataItems = Convert.ToBoolean(kvp.Value);
                    logger?.LogDebug("Recognizing adapter option for queuing all values into the buffer");
                } else if (kvp.Key.StartsWith("deviceUuid", StringComparison.OrdinalIgnoreCase))
                {
                    DeviceUUID= Convert.ToString(kvp.Value);
                    logger?.LogDebug("Recognizing adapter option for the device UUID");
                } else if (kvp.Key.StartsWith("stationId", StringComparison.OrdinalIgnoreCase))
                {
                    StationId= Convert.ToString(kvp.Value);
                    logger?.LogDebug("Recognizing adapter option for the station Id");
                }
                else if (kvp.Key.StartsWith("serialNumber", StringComparison.OrdinalIgnoreCase))
                {
                    SerialNumber = Convert.ToString(kvp.Value);
                    logger?.LogDebug("Recognizing adapter option for the serial number");
                }
                else if (kvp.Key.StartsWith("manufacturer", StringComparison.OrdinalIgnoreCase))
                {
                    Manufacturer = Convert.ToString(kvp.Value);
                    logger?.LogDebug("Recognizing adapter option for the device manufacturer");
                }
                // TODO: Reflect on the properties and automatically assign values.
            }

            return adapterSettings;
        }
    }
}