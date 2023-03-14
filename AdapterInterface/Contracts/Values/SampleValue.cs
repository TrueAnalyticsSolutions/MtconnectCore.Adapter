namespace Mtconnect.AdapterInterface.Contracts.Values
{
    /// <summary>
    /// A generic implementation of an Sample DataItem value type.
    /// </summary>
    public abstract class SampleValue : DataItemValue<float>
    {
        /// <inheritdoc />
        protected SampleValue(float value) : base(value) { }
    }
}
