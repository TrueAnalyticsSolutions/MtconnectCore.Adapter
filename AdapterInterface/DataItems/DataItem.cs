using System;
using System.Collections.Generic;

namespace MtconnectCore.AdapterInterface.DataItems
{
    /// <summary>
    /// Triggered when the value of a DataItem has changed.
    /// </summary>
    /// <param name="sender">Reference to the <see cref="DataItem"/>.</param>
    /// <param name="e">Reference to the event arguments for the data changed event.</param>
    public delegate void DataItemChangedHandler(DataItem sender, DataItemChangedEventArgs e);
    /// <summary>
    /// Simple base data item class. Has an abstract value and a name. It keeps track if it has changed since the last time it was reset.
    /// </summary>
    public class DataItem
    {
        /// <summary>
        /// Occurrs when the value of a DataItem has changed.
        /// </summary>
        public event DataItemChangedHandler OnDataItemChanged;

        /// <summary>
        /// The name of the data item.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Optional device prefix.
        /// </summary>
        public string DevicePrefix = null;

        /// <summary>
        /// The value of the data item, can be any type.
        /// </summary>
        protected object _value = Constants.UNAVAILABLE;
        /// <summary>
        /// Get and set the Value property. This will check if the value has changed and set the changed flag appropriately. Automatically boxes types so will work for any data.
        /// </summary>
        public object Value
        {
            set
            {
                if (!_value.Equals(value))
                {
                    var now = DateTime.UtcNow;
                    var e = new DataItemChangedEventArgs(_value, value, LastChanged, now);

                    _value = value;
                    LastChanged = now;

                    HasChanged = true;

                    if (OnDataItemChanged != null)
                    {
                        OnDataItemChanged(this, e);
                    }
                }
            }
            get { return _value; }
        }

        /// <summary>
        /// Timestamp of when the <see cref="Value"/> was last Changed.
        /// </summary>
        public DateTime? LastChanged { get; private set; }

        /// <summary>
        /// A flag to indicate if the data item's value has changed since it 
        /// has last been set.
        /// </summary>
        public bool HasChanged { get; protected set; }

        /// <summary>
        /// An indicator that this data item must be sent on a separate line.
        /// This is done for all data items that are more complex than simple 
        /// Key|Value pairs.
        /// </summary>
        public bool HasNewLine { get; protected set; }

        /// <summary>
        /// Create a new data item
        /// </summary>
        /// <param name="name">The name of the data item</param>
        public DataItem(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Make this data item <c>UNAVAILABLE</c>.
        /// </summary>
        public virtual void Unavailable() { Value = Constants.UNAVAILABLE; }

        /// <summary>
        /// Checks if the data item is unavailable.
        /// </summary>
        /// <returns>true if Unavailable</returns>
        public bool IsUnavailable() => _value.Equals(Constants.UNAVAILABLE);

        /// <summary>
        /// Forces this <see cref="DataItem"/> to indicate that the <see cref="Value"/> has changed.
        /// </summary>
        public void ForceChanged()
        {
            HasChanged = true;
        }

        /// <summary>
        /// Simple string representation with pipe delim.
        /// </summary>
        /// <returns>A text representation</returns>
        public override string ToString()
        {
            if (DevicePrefix == null)
                return $"{Name}|{_value}";
            else
                return $"{DevicePrefix}:{Name}|{_value}";
        }

        /// <summary>
        /// These methods are mainly for conditions. They allow for
        /// mark and sweep of the condition activations.
        /// </summary>
        public virtual void Begin() { }

        /// <summary>
        /// This is called before we send the actual changed data. It does the diff from the previous state and finds all the activations that need to be removed. This also check to see if all the activations have been removed because we only need to do a single normal with no native code to clear all. This is not required for simple conditions.
        /// </summary>
        public virtual void Prepare() { }

        /// <summary>
        /// Reset the Changed flag.
        /// </summary>
        public virtual void Cleanup() { HasChanged = false; }

        /// <summary>
        /// Get a list of all the changed data items. Since this is a 
        /// single value, just return a list with one item if it has 
        /// changed
        /// </summary>
        /// <param name="all">true means to return this data item regardless of the 
        /// changed flag. This is used to send initial data back to a new client.</param>
        /// <returns>The changed data item</returns>
        public virtual List<DataItem> ItemList(bool all = false)
        {
            List<DataItem> list = new List<DataItem>();
            if (all || HasChanged)
                list.Add(this);
            return list;
        }
    }
}
