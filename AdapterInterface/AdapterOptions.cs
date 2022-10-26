using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
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

        public void UpdateFromConfig()
        {
            var adapterSettings = (ConfigurationManager.GetSection("adapter") as Hashtable)
                .Cast<System.Collections.DictionaryEntry>()
                .ToDictionary(o => o.Key.ToString(), o => o.Value); ;
            if (adapterSettings == null) return;

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
                    } else if (kvp.Key.Contains(":format"))
                    {
                        var func = Scripting.DecryptScript(Convert.ToString(kvp.Value)).Result;

                        if (func != null)
                        {
                            dataItems[internalName].Formatter = func;
                        } else
                        {
                            // TODO: Log error
                        }
                    } else
                    {
                        // TODO: Log unrecognized setting
                    }

                } else if (kvp.Key.StartsWith("heartbeat", StringComparison.OrdinalIgnoreCase))
                {
                    Heartbeat = Convert.ToDouble(kvp.Value);
                } else if (kvp.Key.StartsWith("enqueue", StringComparison.OrdinalIgnoreCase))
                {
                    CanEnqueueDataItems = Convert.ToBoolean(kvp.Value);
                }
                // TODO: Reflect on the properties and automatically assign values.
            }
            
        }
    }
}