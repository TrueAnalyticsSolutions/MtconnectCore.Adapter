namespace Mtconnect.AdapterSdk.Contracts
{
    /// <summary>
    /// A generic implementation of an Event DataItem value type.
    /// </summary>
    public abstract class EventValue : DataItemValue<object>
    {
        /// <inheritdoc />
        public override string Category => Constants.EVENT;

        /// <inheritdoc />
        protected EventValue(object value) : base(value) { }
    }
}
