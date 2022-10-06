using System;
using System.Collections.Generic;

namespace MtconnectCore.Adapter.DataItems
{
    // Simple base data item class. Has an abstract value and a name. It
    // keeps track if it has changed since the last time it was reset.
    public class DataItem
    {
        /// <summary>
        /// The name of the data item.
        /// </summary>
        protected string _name;

        /// <summary>
        /// Optional device prefix.
        /// </summary>
        public string DevicePrefix = null;

        /// <summary>
        /// The value of the data item, can be any type.
        /// </summary>
        protected object _value = Constants.UNAVAILABLE;
        /// <summary>
        /// Get and set the Value property. This will check if the value has changed
        /// and set the changed flag appropriately. Automatically boxes types so will
        /// work for any data.
        /// </summary>
        public object Value
        {
            set
            {
                if (!_value.Equals(value))
                {
                    _value = value;
                    Changed = true;
                }
            }
            get { return _value; }
        }

        /// <summary>
        /// A flag to indicate if the data item's value has changed since it 
        /// has last been set.
        /// </summary>
        public bool Changed { get; protected set; }

        /// <summary>
        /// An indicator that this data item must be sent on a separate line.
        /// This is done for all data items that are more complex than simple 
        /// Key|Value pairs.
        /// </summary>
        public bool NewLine { get; protected set; }

        /// <summary>
        /// Create a new data item
        /// </summary>
        /// <param name="name">The name of the data item</param>
        public DataItem(String name)
        {
            this._name = name;
        }

        /// <summary>
        /// Make this data item unavailable.
        /// </summary>
        public virtual void Unavailable() { Value = Constants.UNAVAILABLE; }

        /// <summary>
        /// Checks if the data item is unavailable.
        /// </summary>
        /// <returns>true if Unavailable</returns>
        public bool IsUnavailable() => _value.Equals(Constants.UNAVAILABLE);

        public void ForceChanged()
        {
            Changed = true;
        }

        /// <summary>
        /// Simple string representation with pipe delim.
        /// </summary>
        /// <returns>A text representation</returns>
        public override string ToString()
        {
            if (DevicePrefix == null)
                return $"{_name}|{_value}";
            else
                return $"{DevicePrefix}:{_name}|{_value}";
        }

        /// <summary>
        /// These methods are mainly for conditions. They allow for
        /// mark and sweep of the condition activations.
        /// </summary>
        public virtual void Begin() { }
        public virtual void Prepare() { }

        /// <summary>
        /// Reset the Changed flag.
        /// </summary>
        public virtual void Cleanup() { Changed = false; }

        /// <summary>
        /// Get a list of all the changed data items. Since this is a 
        /// single value, just return a list with one item if it has 
        /// changed
        /// </summary>
        /// <param name="onlyChanged">true means to return this data item regardless of the 
        /// changed flag. This is used to send initial data back to a new client.</param>
        /// <returns>The changed data item</returns>
        public virtual List<DataItem> ItemList(bool all = false)
        {
            List<DataItem> list = new List<DataItem>();
            if (all || Changed)
                list.Add(this);
            return list;
        }
    }
}
