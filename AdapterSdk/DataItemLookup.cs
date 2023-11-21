using System;
using System.Collections.Generic;
using System.Linq;
using Mtconnect.AdapterSdk.DataItems;
using System.Data;
using System.Collections;

namespace Mtconnect.AdapterSdk
{
    /// <summary>
    /// A performant collection that manages <see cref="IDataItem"/>s by both <see cref="IDataItem.Name"/> and <see cref="IDataItem.DevicePrefix"/>.
    /// </summary>
    /// <remarks>
    /// <br/><br/><b>NOTE</b>: Comparisons of <see cref="IDataItem.Name"/> are based on a cache of the value when the <see cref="IDataItem"/> was added to this collection. This cache is known as the <c>internalName</c> within the <see cref="IAdapter"/>.
    /// </remarks>
    public class DataItemLookup : IList<IDataItem>
    {
        private readonly List<IDataItem> _dataItems = new List<IDataItem>();
        private readonly Dictionary<string, List<int>> _byName = new Dictionary<string, List<int>>();
        private readonly Dictionary<string, List<int>> _byDevicePrefix = new Dictionary<string, List<int>>();
        private readonly Dictionary<(string, string), int> _byNameAndDevicePrefix = new Dictionary<(string, string), int>();

        /// <inheritdoc />
        public int Count => _dataItems.Count;

        /// <inheritdoc />
        public bool IsReadOnly => false;

        /// <inheritdoc />
        public IDataItem this[int index] { get => _dataItems[index]; set => _dataItems[index] = value; }

        /// <summary>
        /// Gets a collection of <see cref="IDataItem"/> that share the same <see cref="IDataItem.Name"/>.
        /// </summary>
        /// <param name="internalName">Lookup key for the <see cref="IDataItem.Name"/>.</param>
        /// <returns>Collection of <see cref="IDataItem"/> or <c>null</c>. <b>NOTE</b> that duplicate <see cref="IDataItem.Name"/> cannot exist with the same <see cref="IDataItem.DevicePrefix"/>.</returns>
        public IEnumerable<IDataItem> this[string internalName]
        {
            get => TryGetByName(internalName, out IEnumerable<IDataItem> dataItems) ? dataItems : null;
        }

        /// <summary>
        /// Gets a <see cref="IDataItem"/> with the specific <paramref name="devicePrefix"/> and <paramref name="internalName"/>.
        /// </summary>
        /// <param name="devicePrefix">Lookup key for the <see cref="IDataItem.DevicePrefix"/>.</param>
        /// <param name="internalName">Lookup key for the <see cref="IDataItem.Name"/>.</param>
        /// <returns><see cref="IDataItem"/> or <c>null</c>.</returns>
        public IDataItem this[string internalName, string devicePrefix]
        {
            get => TryGetByNameAndDevicePrefix(internalName, devicePrefix, out IDataItem dataItem) ? dataItem : null;
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
        /// Adds a <see cref="IDataItem"/> if one with the same <see cref="IDataItem.Name"/> and <see cref="IDataItem.DevicePrefix"/> has not already been added.
        /// </summary>
        /// <param name="dataItem">A <see cref="IDataItem"/> to be added to the collection.</param>
        /// <exception cref="DuplicateNameException"></exception>
        public void Add(IDataItem dataItem)
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
            _byNameAndDevicePrefix[(dataItem.Name, dataItem.DevicePrefix ?? string.Empty)] = index;
        }

        /// <summary>
        /// Attempts to get any <see cref="IDataItem"/>s where the <see cref="IDataItem.Name"/> matches the provided <paramref name="internalName"/>.
        /// <inheritdoc cref="DataItemLookup" path="/remarks"/>
        /// </summary>
        /// <param name="internalName">Lookup key for the <see cref="IDataItem.Name"/>.</param>
        /// <param name="dataItems">Output collection of <see cref="IDataItem"/>s where the <see cref="IDataItem.Name"/> matches the provided <paramref name="internalName"/>.</param>
        /// <returns>Flag of whether or not any <see cref="IDataItem"/>s were found with the provided <paramref name="internalName"/>.</returns>
        public bool TryGetByName(string internalName, out IEnumerable<IDataItem> dataItems)
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
        /// Attempts to get any <see cref="IDataItem"/>s where the <see cref="IDataItem.DevicePrefix"/> matches the provided <paramref name="devicePrefix"/>.
        /// </summary>
        /// <param name="devicePrefix">Lookup key for the <see cref="IDataItem.DevicePrefix"/>.</param>
        /// <param name="dataItems">Output collection of <see cref="IDataItem"/>s where the <see cref="DataItem.DevicePrefix"/> matches the provided <paramref name="devicePrefix"/>.</param>
        /// <returns>Flag of whether or not any <see cref="IDataItem"/>s were found with the provided <paramref name="devicePrefix"/>.</returns>
        public bool TryGetByDevicePrefix(string devicePrefix, out IEnumerable<IDataItem> dataItems)
        {
            dataItems = null;

            if (_byDevicePrefix.TryGetValue(devicePrefix, out List<int> indices))
            {
                dataItems = GetByIndices(indices);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Attempts to get any <see cref="IDataItem"/>s where both the cached <see cref="IDataItem.Name"/> and <see cref="IDataItem.DevicePrefix"/> matches the provided <paramref name="internalName"/> and <paramref name="devicePrefix"/>.
        /// <inheritdoc cref="DataItemLookup" path="/remarks"/>
        /// </summary>
        /// <param name="internalName">Lookup key for the <see cref="IDataItem.Name"/>.</param>
        /// <param name="devicePrefix">Lookup key for the <see cref="IDataItem.DevicePrefix"/>.</param>
        /// <param name="dataItem">Output result of the <see cref="IDataItem"/> sharing the <see cref="IDataItem.Name"/> and <see cref="IDataItem.DevicePrefix"/>.</param>
        /// <returns>Flag of whether or not the <see cref="IDataItem"/> was found.</returns>
        public bool TryGetByNameAndDevicePrefix(string internalName, string devicePrefix, out IDataItem dataItem)
        {
            dataItem = null;

            if (_byNameAndDevicePrefix.TryGetValue((internalName, devicePrefix ?? string.Empty), out int index))
            {
                dataItem = _dataItems[index];
                return true;
            }

            return false;
        }

        /// <summary>
        /// Sets all DataItems to UNAVAILABLE.
        /// </summary>
        /// <param name="devicePrefix">Reference to an optional device prefix.</param>
        /// <exception cref="Exception"></exception>
        public void Unavailable(string devicePrefix = null)
        {
            IEnumerable<IDataItem> items = devicePrefix == null
                ? _dataItems
                : TryGetByDevicePrefix(devicePrefix, out IEnumerable<IDataItem> deviceItems)
                    ? deviceItems
                    : throw new Exception("Could not get DataItems from device prefix");
            foreach (var dataItem in items)
                dataItem.Unavailable();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="indices"></param>
        /// <returns></returns>
        private IEnumerable<IDataItem> GetByIndices(IEnumerable<int> indices) => indices.Select(i => _dataItems[i]);

        /// <inheritdoc />
        public int IndexOf(IDataItem item) => _dataItems.IndexOf(item);

        /// <inheritdoc />
        public void Insert(int index, IDataItem item) => _dataItems.Insert(index, item);

        /// <inheritdoc />
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
                    _byNameAndDevicePrefix[(dataItem.Name, dataItem.DevicePrefix ?? string.Empty)] = i;

                    // Update indices in _byName dictionary
                    if (_byName.TryGetValue(dataItem.Name, out var list))
                    {
                        list.Remove(i - 1);
                        list.Add(i);
                    }
                }
            }
        }

        /// <inheritdoc />
        public void Clear()
        {
            _dataItems.Clear();
            _byName.Clear();
            _byDevicePrefix.Clear();
            _byNameAndDevicePrefix.Clear();
        }

        /// <inheritdoc />
        public bool Contains(IDataItem item)
            => _byNameAndDevicePrefix.ContainsKey((item.Name, item.DevicePrefix ?? string.Empty));

        /// <inheritdoc />
        public bool ContainsName(string internalName) => _byName.ContainsKey(internalName);

        /// <inheritdoc />
        public bool ContainsDevicePrefix(string devicePrefix) => _byDevicePrefix.ContainsKey(devicePrefix);

        /// <inheritdoc />
        public bool Contains(string internalName, string devicePrefix) => _byNameAndDevicePrefix.ContainsKey((internalName, devicePrefix ?? string.Empty));

        /// <inheritdoc />
        public void CopyTo(IDataItem[] array, int arrayIndex) => _dataItems.CopyTo(array, arrayIndex);

        /// <inheritdoc />
        public bool Remove(IDataItem item)
        {
            try
            {
                RemoveAt(IndexOf(item));
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <inheritdoc />
        public IEnumerator<IDataItem> GetEnumerator() => _dataItems.GetEnumerator();

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => _dataItems.GetEnumerator();
    }
}