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
        public static bool TryAddDataItem(this Adapter adapter, DataItem dataItem)
        {
            if (adapter.Contains(dataItem)) return true;

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
        private static PropertyInfo[] GetDataItemProperties(Type type)
        {
            return type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(o =>
                    _dataItemTypes.Contains(o.PropertyType)
                    || o.GetCustomAttribute(typeof(DataItemAttribute)) != null
                )
                .ToArray();
        }
        private static ConcurrentDictionary<Type, PropertyInfo[]> _dataItemProperties = new ConcurrentDictionary<Type, PropertyInfo[]>();
        private static HashSet<Type> _dataItemTypes = new HashSet<Type>
        {
                typeof(Sample),
                typeof(Event),
                typeof(Condition),
                typeof(Message),
                typeof(TimeSeries)
        };
        private static bool TryAddDataItems(this Adapter adapter, object model, string dataItemNamePrefix = "", string dataItemDescriptionPrefix = "")
        {
            Type dataModelType = model.GetType();
            if (!_dataItemProperties.TryGetValue(dataModelType, out PropertyInfo[] dataItemProperties))
            {
                dataItemProperties = GetDataItemProperties(dataModelType);
                _dataItemProperties.TryAdd(dataModelType, dataItemProperties);
            }

            bool allDataItemsAdded = true;

            foreach (var property in dataItemProperties)
            {
                bool dataItemAdded = false;
                string dataItemName = string.Empty;
                string dataItemDescription = string.Empty;


                var dataItemAttribute = property.GetCustomAttribute<DataItemAttribute>();

                if (dataItemAttribute != null)
                {
                    dataItemName = dataItemNamePrefix + dataItemAttribute.Name;
                    dataItemDescription = dataItemDescriptionPrefix + dataItemAttribute.Description;
                }

                // Check if the property is already of type DataItem
                if (_dataItemTypes.Contains(property.PropertyType))
                {
                    // Since the property is "DataItem" type already, just add it directly as a reference without creating a new DataItem instance
                    var dataItemProperty = Convert.ChangeType(property.GetValue(model), property.PropertyType);
                    if (dataItemAttribute != null)
                    {
                        // Update the name/description of the DataItem based on the decorating attribute.
                        (dataItemProperty as DataItem).Name = dataItemName;
                        (dataItemProperty as DataItem).Description = dataItemDescription;

                        // TODO: Check for Type mismatch
                    }
                    if (adapter.Contains((dataItemProperty as DataItem).Name)) continue;
                    dataItemAdded = adapter.TryAddDataItem(dataItemProperty as DataItem);
                } else if (dataItemAttribute != null)
                {
                    if (adapter.Contains(dataItemName)) continue;
                    switch (dataItemAttribute)
                    {
                        case DataItemPartialAttribute _:
                            dataItemAdded = adapter.TryAddDataItems(property.PropertyType, dataItemName, dataItemDescription);
                            break;
                        case EventAttribute _:
                            dataItemAdded = adapter.TryAddDataItem(new Event(dataItemName, dataItemDescription));
                            break;
                        case SampleAttribute _:
                            dataItemAdded = adapter.TryAddDataItem(new Sample(dataItemName, dataItemDescription));
                            break;
                        case ConditionAttribute _:
                            dataItemAdded = adapter.TryAddDataItem(new Condition(dataItemName, dataItemDescription));
                            break;
                        case TimeSeriesAttribute _:
                            dataItemAdded = adapter.TryAddDataItem(new TimeSeries(dataItemName, dataItemDescription));
                            break;
                        case MessageAttribute _:
                            dataItemAdded = adapter.TryAddDataItem(new Message(dataItemName, dataItemDescription));
                            break;
                        default:
                            dataItemAdded = false;
                            break;
                    }
                }

                if (!dataItemAdded) allDataItemsAdded = false;
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

            return allDataItemsUpdated;
        }
    }
}