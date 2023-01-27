using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
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
        /// <inheritdoc cref="Adapter.Heartbeat"/>
        public double Heartbeat { get; protected set; }

        /// <inheritdoc cref="Adapter.CanEnqueueDataItems"/>
        public bool CanEnqueueDataItems { get; protected set; }

        private Dictionary<string, DataItemOptions> dataItems = new Dictionary<string, DataItemOptions>();

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
        public AdapterOptions(double heartbeat = 10_000, bool canQueue = false)
        {
            Heartbeat = heartbeat;
            CanEnqueueDataItems = canQueue;
        }

        /// <summary>
        /// Updates the properties of the <see cref="AdapterOptions"/> from the <see cref="ConfigurationManager"/> section 'adapter'.
        /// </summary>
        public virtual Dictionary<string, object> UpdateFromConfig(ILogger<Adapter> logger = null)
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
                        logger?.LogDebug("Recognizing DataItem option for overwriting the name");
                    } else if (kvp.Key.Contains(":format"))
                    {
                        try
                        {
                            var func = Scripting.DecryptScript(Convert.ToString(kvp.Value)).Result;

                            if (func != null)
                            {
                                dataItems[internalName].Formatter = func;
                                logger?.LogDebug("Recognizing DataItem option for overwriting the value format");
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
                }
                // TODO: Reflect on the properties and automatically assign values.
            }

            return adapterSettings;
        }
    }
}