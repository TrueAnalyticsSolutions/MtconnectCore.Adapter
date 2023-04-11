using Microsoft.Extensions.Logging;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.DataItems;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Mtconnect
{
    public static class AdapterExtensions
    {
        /// <summary>
        /// Attempts to add a <paramref name="dataItem"/> to the <paramref name="adapter"/> if the adapter does not already contain such a <see cref="DataItem"/>.
        /// </summary>
        /// <param name="adapter">Reference to the adapter to add the data item onto.</param>
        /// <param name="dataItem">Reference to the data item to be added.</param>
        /// <returns>Flag for whether or not the data item has been added. Returns true if the data item has already been added.</returns>
        public static bool TryAddDataItem(this Adapter adapter, DataItem dataItem, bool logDuplicationMessage = true)
        {
            if (adapter.Contains(dataItem))
            {
                if (logDuplicationMessage) adapter._logger?.LogDebug("DataItem {DataItemType} already exists in the context of the Adapter {AdapterType}", dataItem.Name, adapter.GetType().FullName);
                return true;
            }

            adapter.AddDataItem(dataItem);

            return true;
        }

        /// <summary>
        /// Adds Data Items from properties in the <paramref name="model"/> that are decorated with the <see cref="DataItemAttribute"/>.
        /// </summary>
        /// <param name="adapter">Reference to the MTConnect <see cref="Adapter"/> to add the data items onto.</param>
        /// <param name="model">Reference to a data model containing <see cref="DataItemAttribute"/>s.</param>
        /// <returns>Flag for whether or not all decorated <see cref="DataItemAttribute"/>s were added to the adapter.</returns>
        public static bool TryAddDataItems(this Adapter adapter, IAdapterDataModel model)
        {
            return adapter.TryAddDataItems(model, string.Empty, string.Empty);
        }
        /// <summary>
        /// Gets a list of <see cref="PropertyInfo"/> that is either decorated with the <see cref="DataItemAttribute"/> or an implementation of the type <see cref="DataItem"/>.
        /// </summary>
        /// <param name="type">Reference to the model type to reflect upon.</param>
        /// <returns>Collection of properties that represent <see cref="DataItem"/>s</returns>
        private static PropertyInfo[] GetDataItemProperties(Type type)
        {
            return type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(o =>
                    _dataItemTypes.Contains(o.PropertyType)
                    || o.GetCustomAttribute(typeof(DataItemAttribute)) != null
                )
                .ToArray();
        }
        /// <summary>
        /// Gets a list of <see cref="PropertyInfo"/> that is decorated with the <see cref="TimestampAttribute"/>.
        /// </summary>
        /// <param name="type">Reference to the model type to reflect upon.</param>
        /// <returns>Collection of properties that represent the value for <see cref="DataItem.LastChanged"/></returns>
        private static PropertyInfo[] GetDataItemTimestampProperties(Type type)
        {
            return type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(o => o.GetCustomAttribute(typeof(TimestampAttribute)) != null)
                .ToArray();
        }
        private static ConcurrentDictionary<Type, Dictionary<string, PropertyInfo>> _dataItemTimestampProperties = new ConcurrentDictionary<Type, Dictionary<string, PropertyInfo>>();
        private static ConcurrentDictionary<Type, PropertyInfo[]> _dataItemProperties = new ConcurrentDictionary<Type, PropertyInfo[]>();
        private static HashSet<Type> _dataItemTypes = new HashSet<Type>
        {
                typeof(Sample),
                typeof(Event),
                typeof(Condition),
                typeof(Message),
                typeof(TimeSeries)
        };
        private static bool TryAddDataItems(this Adapter adapter, object model, string modelPath = "", string dataItemNamePrefix = "", string dataItemDescriptionPrefix = "")
        {
            bool isCached = true;
            bool allDataItemsAdded = true;
            lock (_dataItemProperties)
            {
                Type dataModelType = model.GetType();
                if (string.IsNullOrEmpty(modelPath))
                    modelPath = dataModelType.FullName;

                Dictionary<string, PropertyInfo> timestampPropertyLookup;
                // Try to get the PropertyInfo for the DataItem Timestamp override, if it exists
                _dataItemTimestampProperties.TryGetValue(dataModelType, out timestampPropertyLookup);

                // Try to get the PropertyInfo[] from the static cache
                if (!_dataItemProperties.TryGetValue(dataModelType, out PropertyInfo[] dataItemProperties))
                {
                    // Reflect and fill the static cache
                    dataItemProperties = GetDataItemProperties(dataModelType);
                    adapter._logger?.LogDebug("Found {DataItemPropertyCount} DataItems from data model {DataModelType}: {@DataItemTypes}", dataItemProperties.Length, dataModelType.FullName, dataItemProperties);
                    _dataItemProperties.TryAdd(dataModelType, dataItemProperties);

                    // Reflect and fill static cache of Timestamp properties
                    _dataItemTimestampProperties.TryAdd(dataModelType, new Dictionary<string, PropertyInfo>());

                    var timestampProperties = GetDataItemTimestampProperties(dataModelType);
                    foreach (var timestampProperty in timestampProperties)
                    {
                        TimestampAttribute attr = timestampProperty.GetCustomAttribute<TimestampAttribute>();
                        if (attr != null && !_dataItemTimestampProperties[dataModelType].ContainsKey(attr.DataItemName))
                        {
                            adapter._logger?.LogInformation("Registering Timestamp override for DataItem {DataItemName} from property {PropertyName}", attr.DataItemName, timestampProperty.Name);
                            _dataItemTimestampProperties[dataModelType].Add(attr.DataItemName, timestampProperty);
                        }
                    }
                    timestampPropertyLookup = _dataItemTimestampProperties[dataModelType];

                    isCached = false;
                }

                foreach (var property in dataItemProperties)
                {
                    bool dataItemAdded = false;
                    try
                    {
                        string dataItemName = string.Empty;
                        string dataItemDescription = string.Empty;
                        string dataItemType = string.Empty;
                        string dataItemSubType = string.Empty;

                        var dataItemAttribute = property.GetCustomAttribute<DataItemAttribute>();

                        if (dataItemAttribute != null)
                        {
                            dataItemName = dataItemNamePrefix + dataItemAttribute.Name;
                            dataItemDescription = dataItemDescriptionPrefix + dataItemAttribute.Description;
                            dataItemType = dataItemAttribute.Type;
                            dataItemSubType = dataItemAttribute.SubType;
                        }

                        PropertyInfo timestampProperty = null;
                        timestampPropertyLookup.TryGetValue(dataItemName, out timestampProperty);

                        DataItem dataItem = null;

                        // Check if the property is already of type DataItem
                        if (dataItemAttribute != null)
                        {
                            switch (dataItemAttribute)
                            {
                                case DataItemPartialAttribute _:
                                    dataItemAdded = adapter.TryAddDataItems(property.GetValue(model), $"{modelPath}[{property.Name}]", dataItemName, dataItemDescription);
                                    break;
                                case EventAttribute _:
                                    dataItem = new Event(dataItemName, dataItemType, dataItemSubType, dataItemDescription);
                                    break;
                                case SampleAttribute _:
                                    dataItem = new Sample(dataItemName, dataItemType, dataItemSubType, dataItemDescription);
                                    break;
                                case ConditionAttribute _:
                                    dataItem = new Condition(dataItemName, dataItemType, dataItemSubType, dataItemDescription);
                                    break;
                                case TimeSeriesAttribute _:
                                    dataItem = new TimeSeries(dataItemName, dataItemDescription, type: dataItemType, subType: dataItemSubType);
                                    break;
                                case MessageAttribute _:
                                    dataItem = new Message(dataItemName, dataItemDescription, dataItemType, dataItemSubType);
                                    break;
                                default:
                                    dataItemAdded = false;
                                    break;
                            }
                        } else if (_dataItemTypes.Contains(property.PropertyType))
                        {
                            // Since the property is "DataItem" type already, just add it directly as a reference without creating a new DataItem instance
                            var dataItemProperty = property.GetValue(model);
                            if (dataItemProperty == null)
                            {
                                adapter._logger?.LogError("Data model property {PropertyName} is null and cannot be added until instantiated", property.Name, property.PropertyType);
                                continue;
                            } else if ((dataItemProperty as DataItem) == null)
                            {
                                var castException = new InvalidCastException("Could not cast data model property to DataItem");
                                adapter._logger?.LogError(castException, "Could not cast data model property {PropertyName} to DataItem", property.Name);
                                continue;
                            }

                            dataItem = dataItemProperty as DataItem;

                            if (dataItemAttribute != null)
                            {
                                // Update the name/description of the DataItem based on the decorating attribute.
                                dataItem.Name = dataItemName;
                                dataItem.Description = dataItemDescription;

                                // TODO: Check for Type mismatch
                            }
                        }
                        else
                        {
                            adapter._logger?.LogDebug("DataItem {DataItemName} not handled", dataItemName);
                        }

                        // Now add the DataItem if it was constructed
                        if (dataItem != null)
                        {
                            dataItem.ModelPath = $"{modelPath}[{property.Name}]";
                            if (timestampProperty != null)
                            {
                                dataItem.HasTimestampOverride = true;
                            }
                            dataItemAdded = adapter.TryAddDataItem(dataItem, !isCached);
                        }
                    }
                    catch (Exception ex)
                    {
                        adapter._logger?.LogError(ex, "Error while attempting to add DataItem from property {PropertyName}: {Exception}", property.Name, ex);
                    }

                    if (!dataItemAdded)
                    {
                        allDataItemsAdded = false;
                        adapter._logger?.LogWarning("Failed to add DataItem from data model property {PropertyName}", property.Name);
                    }
                }

            }
            return allDataItemsAdded;
        }

        /// <summary>
        /// Attempts to update the <see cref="DataItem"/>s of the <paramref name="adapter"/>.
        /// </summary>
        /// <param name="adapter">Reference to the MTConnect <see cref="Adapter"/> to update the data items from.</param>
        /// <param name="model">Reference to the data model to update the <paramref name="adapter"/>s <see cref="DataItem"/>s from.</param>
        /// <returns>Flag for whether or not all <see cref="DataItem"/> values were updated from the <paramref name="model"/>.</returns>
        public static bool TryUpdateValues(this Adapter adapter, IAdapterDataModel model)
        {
            return TryUpdateValues(adapter, model, string.Empty);
        }
        private static bool TryUpdateValues(this Adapter adapter, object model, string dataItemPrefix)
        {
            bool allDataItemsUpdated = true;

            Type sourceType = model.GetType();

            if (!_dataItemProperties.TryGetValue(sourceType, out PropertyInfo[] dataItemProperties))
            {
                dataItemProperties = GetDataItemProperties(sourceType);
            }
            foreach (var property in dataItemProperties)
            {
                if (_dataItemTypes.Contains(property.PropertyType)) continue; // No need to update DataItem properties since the reference is already there
                bool dataItemUpdated = true;

                var dataItemAttribute = property.GetCustomAttribute<DataItemAttribute>();
                string dataItemName = dataItemPrefix + dataItemAttribute.Name;
                switch (dataItemAttribute)
                {
                    case DataItemPartialAttribute _:
                        dataItemUpdated = adapter.TryUpdateValues(property.GetValue(model), dataItemName);
                        break;
                    case EventAttribute _:
                    case SampleAttribute _:
                    case ConditionAttribute _:
                    case TimeSeriesAttribute _:
                    case MessageAttribute _:
                        adapter[dataItemName].Value = property.GetValue(model);
                        break;
                    default:
                        dataItemUpdated = false;
                        break;
                }

                if (!dataItemUpdated) allDataItemsUpdated = false;
            }

            if (_dataItemTimestampProperties.TryGetValue(sourceType, out Dictionary<string, PropertyInfo> timestampProperties))
            {
                foreach (var kvp in timestampProperties)
                {
                    var property = kvp.Value;
                    var rawTimestamp = property.GetValue(model);
                    if (rawTimestamp != null)
                    {
                        var formattedTimestamp = rawTimestamp as DateTime?;
                        if (formattedTimestamp != null)
                        {
                            adapter[kvp.Key].LastChanged = formattedTimestamp;
                        }
                        else
                        {
                            var castException = new InvalidCastException("Could not cast to DateTime");
                            adapter._logger?.LogError(castException, "Failed to cast Timestamp property {PropertyName} to proper DateTime", property.Name);
                        }
                    }
                }
            }

            return allDataItemsUpdated;
        }
    }
}