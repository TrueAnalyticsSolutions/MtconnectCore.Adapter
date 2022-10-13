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

        public DataItemChangedEventArgs(object previousValue, object newValue, DateTime? previousChangeTime, DateTime changeTime)
        {
            PreviousValue = previousValue;
            NewValue = newValue;
            PreviousChangeTime = previousChangeTime;
            ChangeTime = changeTime;
        }
    }
}
