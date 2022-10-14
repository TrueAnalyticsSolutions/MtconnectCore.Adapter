using System;

namespace Mtconnect.AdapterInterface.DataItems
{
    /// <summary>
    /// Contains information on when a <see cref="DataItem"/> was changed.
    /// </summary>
    public class DataItemChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Reference to the previous value for the sending <see cref="DataItem"/>.
        /// </summary>
        public object PreviousValue { get; }

        /// <summary>
        /// Reference to the new value for the sending <see cref="DataItem"/>.
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
        /// <param name="previousValue">The <see cref="DataItem"/>s value before the change.</param>
        /// <param name="newValue">The <see cref="DataItem"/>s value after the change.</param>
        /// <param name="previousChangeTime">Reference to the <see cref="DateTime"/> the <see cref="DataItem"/>s value previously changed.</param>
        /// <param name="changeTime">Reference tot he <see cref="DateTime"/> the <see cref="DataItem"/>s value currently changed.</param>
        public DataItemChangedEventArgs(object previousValue, object newValue, DateTime? previousChangeTime, DateTime changeTime)
        {
            PreviousValue = previousValue;
            NewValue = newValue;
            PreviousChangeTime = previousChangeTime;
            ChangeTime = changeTime;
        }
    }
}
