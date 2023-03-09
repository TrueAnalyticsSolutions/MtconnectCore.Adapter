using System;
using System.Collections.Generic;
using System.Linq;
using Mtconnect.AdapterInterface.DataItems;
using System.Data;
using System.Collections;

namespace Mtconnect
{
    /// <summary>
    /// A performant collection that manages <see cref="DataItem"/>s by both <see cref="DataItem.Name"/> and <see cref="DataItem.DevicePrefix"/>.
    /// </summary>
    /// <remarks>
    /// <br/><br/><b>NOTE</b>: Comparisons of <see cref="DataItem.Name"/> are based on a cache of the value when the <see cref="DataItem"/> was added to this collection. This cache is known as the <c>internalName</c> within the <see cref="Adapter"/>.
    /// </remarks>
    public class DataItemLookup : IList<DataItem>
    {
        private readonly List<DataItem> _dataItems = new List<DataItem>();
        private readonly Dictionary<string, List<int>> _byName = new Dictionary<string, List<int>>();
        private readonly Dictionary<string, List<int>> _byDevicePrefix = new Dictionary<string, List<int>>();
        private readonly Dictionary<(string, string), int> _byNameAndDevicePrefix = new Dictionary<(string, string), int>();

        public int Count => _dataItems.Count;

        public bool IsReadOnly => false;

        public DataItem this[int index] { get => _dataItems[index]; set => _dataItems[index] = value; }

        /// <summary>
        /// Gets a collection of <see cref="DataItem"/> that share the same <see cref="DataItem.Name"/>.
        /// </summary>
        /// <param name="internalName">Lookup key for the <see cref="DataItem.Name"/>.</param>
        /// <returns>Collection of <see cref="DataItem"/> or <c>null</c>. <b>NOTE</b> that duplicate <see cref="DataItem.Name"/> cannot exist with the same <see cref="DataItem.DevicePrefix"/>.</returns>
        public IEnumerable<DataItem> this[string internalName]
        {
            get => TryGetByName(internalName, out IEnumerable<DataItem> dataItems) ? dataItems : null;
        }

        /// <summary>
        /// Gets a <see cref="DataItem"/> with the specific <paramref name="devicePrefix"/> and <paramref name="internalName"/>.
        /// </summary>
        /// <param name="devicePrefix">Lookup key for the <see cref="DataItem.DevicePrefix"/>.</param>
        /// <param name="internalName">Lookup key for the <see cref="DataItem.Name"/>.</param>
        /// <returns><see cref="DataItem"/> or <c>null</c>.</returns>
        public DataItem this[string internalName, string devicePrefix]
        {
            get => TryGetByNameAndDevicePrefix(internalName, devicePrefix, out DataItem dataItem) ? dataItem : null;
            set {
                if (_byNameAndDevicePrefix.ContainsKey((internalName, devicePrefix)))
                {
                    _dataItems[_byNameAndDevicePrefix[(internalName, devicePrefix)]] = value;
                }
                else
                {
                    throw new KeyNotFoundException();
                }
            }
        }

        /// <summary>
        /// Adds a <see cref="DataItem"/> if one with the same <see cref="DataItem.Name"/> and <see cref="DataItem.DevicePrefix"/> has not already been added.
        /// </summary>
        /// <param name="dataItem">A <see cref="DataItem"/> to be added to the collection.</param>
        /// <exception cref="DuplicateNameException"></exception>
        public void Add(DataItem dataItem)
        {
            if (_byNameAndDevicePrefix.ContainsKey((dataItem.Name, dataItem.DevicePrefix)))
                throw new DuplicateNameException();

            _dataItems.Add(dataItem);

            int index = _dataItems.Count - 1;

            // Add to byName dictionary
            if (!_byName.TryGetValue(dataItem.Name, out List<int> nameItems))
            {
                nameItems = new List<int>();
                _byName.Add(dataItem.Name, nameItems);
            }
            nameItems.Add(index);

            // Add to byDevicePrefix dictionary
            if (!_byDevicePrefix.TryGetValue(dataItem.DevicePrefix, out List<int> deviceItems))
            {
                deviceItems = new List<int>();
                _byDevicePrefix.Add(dataItem.DevicePrefix, deviceItems);
            }
            deviceItems.Add(index);

            // Add to byNameAndDevicePrefix dictionary
            _byNameAndDevicePrefix[(dataItem.Name, dataItem.DevicePrefix)] = index;
        }

        /// <summary>
        /// Attempts to get any <see cref="DataItem"/>s where the <see cref="DataItem.Name"/> matches the provided <paramref name="internalName"/>.
        /// <inheritdoc cref="DataItemLookup" path="/remarks"/>
        /// </summary>
        /// <param name="internalName">Lookup key for the <see cref="DataItem.Name"/>.</param>
        /// <param name="dataItems">Output collection of <see cref="DataItem"/>s where the <see cref="DataItem.Name"/> matches the provided <paramref name="internalName"/>.</param>
        /// <returns>Flag of whether or not any <see cref="DataItem"/>s were found with the provided <paramref name="internalName"/>.</returns>
        public bool TryGetByName(string internalName, out IEnumerable<DataItem> dataItems)
        {
            dataItems = null;

            if (_byName.TryGetValue(internalName, out List<int> indices))
            {
                dataItems = indices.Select(i => _dataItems[i]);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Attempts to get any <see cref="DataItem"/>s where the <see cref="DataItem.DevicePrefix"/> matches the provided <paramref name="devicePrefix"/>.
        /// </summary>
        /// <param name="devicePrefix">Lookup key for the <see cref="DataItem.DevicePrefix"/>.</param>
        /// <param name="dataItems">Output collection of <see cref="DataItem"/>s where the <see cref="DataItem.DevicePrefix"/> matches the provided <paramref name="devicePrefix"/>.</param>
        /// <returns>Flag of whether or not any <see cref="DataItem"/>s were found with the provided <paramref name="devicePrefix"/>.</returns>
        public bool TryGetByDevicePrefix(string devicePrefix, out IEnumerable<DataItem> dataItems)
        {
            dataItems = null;

            if (_byDevicePrefix.TryGetValue(devicePrefix, out List<int> indices))
            {
                dataItems = getByIndices(indices);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Attempts to get any <see cref="DataItem"/>s where both the cached <see cref="DataItem.Name"/> and <see cref="DataItem.DevicePrefix"/> matches the provided <paramref name="internalName"/> and <paramref name="devicePrefix"/>.
        /// <inheritdoc cref="DataItemLookup" path="/remarks"/>
        /// </summary>
        /// <param name="internalName">Lookup key for the <see cref="DataItem.Name"/>.</param>
        /// <param name="devicePrefix">Lookup key for the <see cref="DataItem.DevicePrefix"/>.</param>
        /// <param name="dataItem">Output result of the <see cref="DataItem"/> sharing the <see cref="DataItem.Name"/> and <see cref="DataItem.DevicePrefix"/>.</param>
        /// <returns>Flag of whether or not the <see cref="DataItem"/> was found.</returns>
        public bool TryGetByNameAndDevicePrefix(string internalName, string devicePrefix, out DataItem dataItem)
        {
            dataItem = null;

            if (_byNameAndDevicePrefix.TryGetValue((internalName, devicePrefix), out int index))
            {
                dataItem = _dataItems[index];
                return true;
            }

            return false;
        }

        public void Unavailable(string devicePrefix = null)
        {
            IEnumerable<DataItem> items = devicePrefix == null
                ? _dataItems
                : TryGetByDevicePrefix(devicePrefix, out IEnumerable<DataItem> deviceItems)
                    ? deviceItems
                    : throw new Exception("Could not get DataItems from device prefix");
            foreach (var dataItem in items)
                dataItem.Unavailable();
        }

        private IEnumerable<DataItem> getByIndices(IEnumerable<int> indices) => indices.Select(i => _dataItems[i]);

        public int IndexOf(DataItem item) => _dataItems.IndexOf(item);

        public void Insert(int index, DataItem item) => _dataItems.Insert(index, item);

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _dataItems.Count)
                throw new IndexOutOfRangeException();

            var item = _dataItems[index];

            if (!_byName.TryGetValue(item.Name, out var indices) || !indices.Contains(index))
                throw new KeyNotFoundException("DataItem not found in cache");

            // Remove index from _byName dictionary
            indices.Remove(index);

            // Remove DataItem from the list
            _dataItems[index] = null;

            // Update indices in the dictionaries for all DataItems after the removed one
            for (int i = index + 1; i < _dataItems.Count; i++)
            {
                var dataItem = _dataItems[i];
                if (dataItem != null)
                {
                    // Update index in _byDeviceAndName dictionary
                    _byNameAndDevicePrefix[(dataItem.Name, dataItem.DevicePrefix)] = i;

                    // Update indices in _byName dictionary
                    if (_byName.TryGetValue(dataItem.Name, out var list))
                    {
                        list.Remove(i - 1);
                        list.Add(i);
                    }
                }
            }
        }

        public void Clear()
        {
            _dataItems.Clear();
            _byName.Clear();
            _byDevicePrefix.Clear();
            _byNameAndDevicePrefix.Clear();
        }

        public bool Contains(DataItem item)
            => _byNameAndDevicePrefix.ContainsKey((item.Name, item.DevicePrefix));

        public bool ContainsName(string internalName) => _byName.ContainsKey(internalName);

        public bool ContainsDevicePrefix(string devicePrefix) => _byDevicePrefix.ContainsKey(devicePrefix);

        public bool Contains(string internalName, string devicePrefix) => _byNameAndDevicePrefix.ContainsKey((internalName, devicePrefix));

        public void CopyTo(DataItem[] array, int arrayIndex) => _dataItems.CopyTo(array, arrayIndex);

        public bool Remove(DataItem item)
        {
            try
            {
                RemoveAt(IndexOf(item));
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public IEnumerator<DataItem> GetEnumerator() => _dataItems.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _dataItems.GetEnumerator();
    }
}