using System;

namespace Mtconnect.AdapterSdk.DataItems
{
    /// <summary>
    /// Triggered when the value of a DataItem has changed.
    /// </summary>
    /// <param name="sender">Reference to the <see cref="IDataItem"/>.</param>
    /// <param name="e">Reference to the event arguments for the data changed event.</param>
    public delegate void DataItemChangedHandler(IDataItem sender, DataItemChangedEventArgs e);
    /// <summary>
    /// Contains information on when a <see cref="IDataItem"/> was changed.
    /// </summary>
    public class DataItemChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Reference to the previous value for the sending <see cref="IDataItem"/>.
        /// </summary>
        public object PreviousValue { get; }

        /// <summary>
        /// Reference to the new value for the sending <see cref="IDataItem"/>.
        /// </summary>
        public object NewValue { get; }

        /// <summary>
        /// Reference to the timestamp that the previous value was registered.
        /// </summary>
        public DateTime? PreviousChangeTime { get; }

        /// <summary>
        /// Reference to the timestamp that the current value was initialized.
        /// </summary>
        public DateTime ChangeTime { get; }

        /// <summary>
        /// Constructs a new reference EventArgs for the DataItemChanged event.
        /// </summary>
        /// <param name="previousValue">The <see cref="IDataItem"/>s value before the change.</param>
        /// <param name="newValue">The <see cref="IDataItem"/>s value after the change.</param>
        /// <param name="previousChangeTime">Reference to the <see cref="DateTime"/> the <see cref="IDataItem"/>s value previously changed.</param>
        /// <param name="changeTime">Reference tot he <see cref="DateTime"/> the <see cref="IDataItem"/>s value currently changed.</param>
        public DataItemChangedEventArgs(object previousValue, object newValue, DateTime? previousChangeTime, DateTime changeTime)
        {
            PreviousValue = previousValue;
            NewValue = newValue;
            PreviousChangeTime = previousChangeTime;
            ChangeTime = changeTime;
        }
    }
}
