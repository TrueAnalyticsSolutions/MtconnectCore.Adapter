namespace Mtconnect.AdapterInterface.Contracts
{
    /// <summary>
    /// A generic implementation of an Event DataItem value type.
    /// </summary>
    public abstract class EventValue : DataItemValue<object>
    {
        /// <inheritdoc />
        protected EventValue(object value) : base(value) { }
    }
}
