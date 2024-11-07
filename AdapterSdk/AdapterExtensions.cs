using Mtconnect.AdapterSdk.Attributes;
using Mtconnect.AdapterSdk.DataItems;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Mtconnect.AdapterSdk
{
    /// <summary>
    /// Helper methods for Adapter management
    /// </summary>
    public static class AdapterExtensions
    {
        /// <summary>
        /// Attempts to add a <paramref name="dataItem"/> to the <paramref name="adapter"/> if the adapter does not already contain such a <see cref="DataItem"/>.
        /// </summary>
        /// <param name="adapter">Reference to the adapter to add the data item onto.</param>
        /// <param name="dataItem">Reference to the data item to be added.</param>
        /// <param name="logDuplicationMessage">Flag for whether or not to log when duplicate data items are added.</param>
        /// <returns>Flag for whether or not the data item has been added. Returns true if the data item has already been added.</returns>
        public static bool TryAddDataItem(this IAdapter adapter, IDataItem dataItem, bool logDuplicationMessage = true)
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
        public static bool TryAddDataItems(this IAdapter adapter, IAdapterDataModel model)
        {
            return adapter.TryAddDataItems(model, string.Empty, string.Empty);
        }
        /// <summary>
        /// Gets a list of <see cref="PropertyInfo"/> that is either decorated with the <see cref="DataItemAttribute"/> or an implementation of the type <see cref="DataItem"/>.
        /// </summary>
        /// <param name="type">Reference to the model type to reflect upon.</param>
        /// <returns>Collection of properties that represent <see cref="IDataItem"/>s</returns>
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
        /// <returns>Collection of properties that represent the value for <see cref="IDataItem.LastChanged"/></returns>
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
        private static bool TryAddDataItems(this IAdapter adapter, object model, string modelPath = "", string dataItemNamePrefix = "", string dataItemDescriptionPrefix = "")
        {
            if (model == null)
                return false;
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

                // Iterate through PropertyInfo[] of current layer of the model
                foreach (var property in dataItemProperties)
                {
                    bool dataItemAdded = false;
                    try
                    {
                        var propertyValue = property.GetValue(model);

                        string dataItemName = string.Empty;
                        string dataItemDescription = string.Empty;
                        string dataItemType = string.Empty;
                        string dataItemSubType = string.Empty;

                        // Process DataItemAttribute
                        var dataItemAttribute = property.GetCustomAttribute<DataItemAttribute>();
                        if (dataItemAttribute != null)
                        {
                            dataItemName = dataItemNamePrefix + dataItemAttribute.Name;
                            dataItemDescription = dataItemDescriptionPrefix + dataItemAttribute.Description;
                            dataItemType = dataItemAttribute.Type;
                            dataItemSubType = dataItemAttribute.SubType;
                        }

                        // Process IDataItemValue
                        if (typeof(IDataItemValue).IsAssignableFrom(property.PropertyType))
                        {
                            if (propertyValue == null)
                            {
                                adapter._logger?.LogTrace("Data model property {PropertyName} is null and cannot be added until instantiated", property.Name);
                                continue;
                            }

                            if (string.IsNullOrEmpty(dataItemType))
                            {
                                dataItemType = (propertyValue as IDataItemValue).ObservationalType;
                            }

                            if (string.IsNullOrEmpty(dataItemSubType))
                            {
                                dataItemSubType = (propertyValue as IDataItemValue).ObservationalSubType;
                            }
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
                                    if (propertyValue == null)
                                    {
                                        adapter._logger?.LogTrace("Data model property {PropertyName} is null and cannot be added until instantiated", property.Name);
                                        continue;
                                    }
                                    dataItemAdded = adapter.TryAddDataItems(propertyValue, $"{modelPath}[{property.Name}]", dataItemName, dataItemDescription);

                                    // Process property for collections
                                    if (property.PropertyType.IsGenericType)
                                    {
                                        var genericType = property.PropertyType.GetGenericTypeDefinition();
                                        if (genericType == typeof(Dictionary<,>) && property.PropertyType.GetGenericArguments()[0] == typeof(string))
                                        {
                                            // Dictionary<string, T>
                                            var dictionary = propertyValue as IDictionary;
                                            foreach (DictionaryEntry entry in dictionary)
                                            {
                                                string dataItemSuffix = (string)entry.Key;
                                                var dataItemValue = entry.Value;
                                                dataItemAdded = adapter.TryAddDataItems(dataItemValue, $"{modelPath}[{property.Name}][{dataItemSuffix}]", $"{dataItemName}{dataItemSuffix}");
                                            }
                                        }
                                        else if (genericType == typeof(List<>))
                                        {
                                            // List<T>
                                            var list = propertyValue as IList;
                                            for (int i = 0; i < list.Count; i++)
                                            {
                                                dataItemAdded = adapter.TryAddDataItems(list[i], $"{modelPath}[{property.Name}][{i}]", $"{dataItemName}{i}");
                                            }
                                        }
                                        else
                                        {
                                            // Unknown generic type
                                            dataItemAdded = adapter.TryAddDataItems(propertyValue, $"{modelPath}[{property.Name}]", dataItemName);
                                        }
                                    }
                                    else
                                    {
                                        // Non-generic type
                                        dataItemAdded = adapter.TryAddDataItems(propertyValue, $"{modelPath}[{property.Name}]", dataItemName);
                                    }
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
                                case TimeSeriesAttribute timeSeriesAttribute:
                                    dataItem = new TimeSeries(dataItemName, dataItemDescription, rate: timeSeriesAttribute?.Rate ?? (propertyValue as TimeSeries)?.Rate ?? 0.0, type: dataItemType, subType: dataItemSubType);
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
                            if (propertyValue == null)
                            {
                                adapter._logger?.LogTrace("Data model property {PropertyName} is null and cannot be added until instantiated", property.Name);
                                continue;
                            } else if ((propertyValue as DataItem) == null)
                            {
                                var castException = new InvalidCastException("Could not cast data model property to DataItem");
                                adapter._logger?.LogError(castException, "Could not cast data model property {PropertyName} to DataItem", property.Name);
                                continue;
                            }

                            dataItem = propertyValue as DataItem;

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
                            Func<IDataItem, string, bool> addDataItem = (IDataItem di, string mp) =>
                            {
                                di.ModelPath += mp;// $"{modelPath}[{property.Name}]";
                                if (timestampProperty != null)
                                {
                                    di.HasTimestampOverride = true;
                                }
                                else
                                {
                                    di.LastChanged = TimeHelper.GetNow();
                                }
                                return adapter.TryAddDataItem(di, !isCached);
                            };

                            // Process property for collections
                            if (property.PropertyType.IsGenericType)
                            {
                                var genericType = property.PropertyType.GetGenericTypeDefinition();
                                if (genericType == typeof(Dictionary<,>) && property.PropertyType.GetGenericArguments()[0] == typeof(string))
                                {
                                    if (propertyValue == null)
                                    {
                                        adapter._logger?.LogTrace("Data model property {PropertyName} is null and cannot be added until instantiated", property.Name);
                                        continue;
                                    }
                                    // Dictionary<string, T>
                                    var dictionary = propertyValue as IDictionary;
                                    foreach (DictionaryEntry entry in dictionary)
                                    {
                                        string dataItemSuffix = (string)entry.Key;
                                        var dataItemValue = entry.Value;
                                        // Copy DataItem instance
                                        var copy = dataItem.Copy();
                                        copy.Name += dataItemSuffix;
                                        dataItemAdded = addDataItem(copy, $"{modelPath}[{property.Name}][{dataItemSuffix}]");
                                    }
                                }
                                else if (genericType == typeof(List<>))
                                {
                                    if (propertyValue == null)
                                    {
                                        adapter._logger?.LogTrace("Data model property {PropertyName} is null and cannot be added until instantiated", property.Name);
                                        continue;
                                    }
                                    // List<T>
                                    var list = propertyValue as IList;
                                    for (int i = 0; i < list.Count; i++)
                                    {
                                        // Copy DataItem instance // var entryDataItem = dataItem.
                                        var copy = dataItem.Copy();
                                        copy.Name += i.ToString();
                                        dataItemAdded = addDataItem(copy, $"{modelPath}[{property.Name}][{i}]");
                                    }
                                }
                                else
                                {
                                    // Unknown generic type
                                    dataItemAdded = addDataItem(dataItem, $"{modelPath}[{property.Name}]");
                                }
                            }
                            else
                            {
                                // Non-generic type
                                dataItemAdded = addDataItem(dataItem, $"{modelPath}[{property.Name}]");
                            }
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
        /// Attempts to update the <see cref="IDataItem"/>s of the <paramref name="adapter"/>.
        /// </summary>
        /// <param name="adapter">Reference to the MTConnect <see cref="IAdapter"/> to update the data items from.</param>
        /// <param name="model">Reference to the data model to update the <paramref name="adapter"/>s <see cref="IDataItem"/>s from.</param>
        /// <returns>Flag for whether or not all <see cref="IDataItem"/> values were updated from the <paramref name="model"/>.</returns>
        public static bool TryUpdateValues(this IAdapter adapter, IAdapterDataModel model)
        {
            return TryUpdateValues(adapter, model, string.Empty);
        }
        private static bool TryUpdateValues(this IAdapter adapter, object model, string dataItemPrefix)
        {
            if (model == null)
                return false;

            bool allDataItemsUpdated = true;

            Type sourceType = model.GetType();

            if (!_dataItemProperties.TryGetValue(sourceType, out PropertyInfo[] dataItemProperties))
                dataItemProperties = GetDataItemProperties(sourceType);

            foreach (var property in dataItemProperties)
            {
                if (_dataItemTypes.Contains(property.PropertyType))
                    continue; // No need to update DataItem properties since the reference is already there
                bool dataItemUpdated = true;

                var dataItemAttribute = property.GetCustomAttribute<DataItemAttribute>();
                string dataItemName = dataItemPrefix + dataItemAttribute.Name;
                switch (dataItemAttribute)
                {
                    case DataItemPartialAttribute _:
                        // Process property for collections
                        if (property.PropertyType.IsGenericType)
                        {
                            var genericType = property.PropertyType.GetGenericTypeDefinition();
                            if (genericType == typeof(Dictionary<,>) && property.PropertyType.GetGenericArguments().FirstOrDefault() == typeof(string))
                            {
                                // Dictionary<string, T>
                                var dictionary = property.GetValue(model) as IDictionary;
                                if (dictionary != null)
                                {
                                    foreach (DictionaryEntry entry in dictionary)
                                    {
                                        string dataItemSuffix = (string)entry.Key;
                                        var dataItemValue = entry.Value;
                                        dataItemUpdated = adapter.TryUpdateValues(dataItemValue, dataItemName + dataItemSuffix) || dataItemUpdated;
                                    }
                                } else
                                {
                                    dataItemUpdated = false;
                                }
                            }
                            else if (genericType == typeof(List<>))
                            {
                                // List<T>
                                var list = property.GetValue(model) as IList;
                                if (list != null)
                                    for (int i = 0; i < list.Count; i++)
                                        dataItemUpdated = adapter.TryUpdateValues(list[i], dataItemName + i.ToString()) || dataItemUpdated;
                                else
                                    dataItemUpdated = false;
                            }
                            else
                            {
                                // Unknown generic type
                                dataItemUpdated = adapter.TryUpdateValues(property.GetValue(model), dataItemName) || dataItemUpdated;
                            }
                        }
                        else
                        {
                            // Non-generic type
                            dataItemUpdated = adapter.TryUpdateValues(property.GetValue(model), dataItemName) || dataItemUpdated;
                        }
                        break;
                    case EventAttribute _:
                    case SampleAttribute _:
                    case ConditionAttribute _:
                    case TimeSeriesAttribute _:
                    case MessageAttribute _:
                        // Process property for collections
                        if (property.PropertyType.IsGenericType)
                        {
                            var genericType = property.PropertyType.GetGenericTypeDefinition();
                            if (genericType == typeof(Dictionary<,>) && property.PropertyType.GetGenericArguments().FirstOrDefault() == typeof(string))
                            {
                                // Dictionary<string, T>
                                var dictionary = property.GetValue(model) as IDictionary;
                                if (dictionary != null)
                                {
                                    bool anyEntriesUpdated = false;
                                    foreach (DictionaryEntry entry in dictionary)
                                    {
                                        string dataItemSuffix = (string)entry.Key;
                                        var dataItemValue = entry.Value;

                                        var observation = adapter[dataItemName + dataItemSuffix];
                                        anyEntriesUpdated = UpdateObservationValue(adapter, dataItemUpdated | anyEntriesUpdated, dataItemValue, observation);
                                    }
                                    if (!anyEntriesUpdated)
                                        dataItemUpdated = false;
                                } else
                                {
                                    dataItemUpdated = false;
                                }
                            } else if (genericType == typeof(List<>))
                            {
                                // List<T>
                                var list = property.GetValue(model) as IList;
                                if (list != null)
                                {
                                    bool anyEntriesUpdated = false;
                                    for (int i = 0; i < list.Count; i++)
                                    {
                                        string dataItemSuffix = i.ToString();
                                        var dataItemValue = list[i];

                                        var observation = adapter[dataItemName + dataItemSuffix];
                                        anyEntriesUpdated = UpdateObservationValue(adapter, dataItemUpdated | anyEntriesUpdated, dataItemValue, observation);
                                    }
                                    if (!anyEntriesUpdated)
                                        dataItemUpdated = false;
                                }
                                else
                                {
                                    dataItemUpdated = false;
                                }
                            } else
                            {
                                // Unknown generic type
                                var dataItemValue = property.GetValue(model);

                                var observation = adapter[dataItemName];
                                dataItemUpdated = UpdateObservationValue(adapter, dataItemUpdated, dataItemValue, observation);
                            }
                        } else
                        {
                            // Non-generic type
                            var dataItemValue = property.GetValue(model);

                            var observation = adapter[dataItemName];
                            dataItemUpdated = UpdateObservationValue(adapter, dataItemUpdated, dataItemValue, observation);
                        }
                        break;
                    default:
                        dataItemUpdated = false;
                        break;
                }

                if (!dataItemUpdated)
                {
                    allDataItemsUpdated = false;
                    adapter._logger?.LogWarning("Property {TypeName}.{PropertyName} was not updated", sourceType.FullName, property.Name);
                }
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

        private static bool UpdateObservationValue(IAdapter adapter, bool dataItemUpdated, object dataItemValue, IDataItem observation)
        {
            if (observation != null)
            {
                if (observation is TimeSeries timeSeriesObservation)
                {
                    if (dataItemValue is double[] dataItemValues)
                    {
                        if (timeSeriesObservation.Values != dataItemValues)
                        {
                            timeSeriesObservation.Values = dataItemValues;
                        }
                        else
                        {
                            dataItemUpdated = false;
                        }
                    } else if (dataItemValue is TimeSeries timeSeriesValue)
                    {
                        if (timeSeriesObservation.Values != timeSeriesValue.Values)
                        {
                            timeSeriesObservation.Values = timeSeriesValue.Values;
                        } else
                        {
                            dataItemUpdated = false;
                        }
                    }
                    else
                    {
                        adapter._logger.LogWarning("Cannot set Values for TimeSeries from type {Type}", dataItemValue.GetType());
                        dataItemUpdated = false;
                    }
                }
                else
                {
                    if (dataItemValue is double[] dataItemValues)
                    {
                        string dataItemResult = string.Join(" ", (dataItemValue as double[]));
                        if (observation?.Value != dataItemResult)
                        {
                            observation.Value = dataItemResult;
                        }
                    } else if (observation?.Value != dataItemValue)
                    {
                        observation.Value = dataItemValue;
                    }
                }
            }
            else
            {
                dataItemUpdated = false;
            }

            return dataItemUpdated;
        }
    }
}