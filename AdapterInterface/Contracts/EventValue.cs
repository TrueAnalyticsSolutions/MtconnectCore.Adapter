namespace Mtconnect.AdapterInterface.Contracts
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
