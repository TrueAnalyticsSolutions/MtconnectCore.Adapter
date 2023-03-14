namespace Mtconnect.AdapterInterface.Contracts.Values
{
    /// <summary>
    /// A generic implementation of an Event DataItem value type.
    /// </summary>
    public abstract class EventValue : DataItemValue<string>
    {
        /// <inheritdoc />
        protected EventValue(string value) : base(value) { }
    }
}
