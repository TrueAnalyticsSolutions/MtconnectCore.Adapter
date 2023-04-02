namespace Mtconnect.AdapterInterface.Contracts
{
    /// <summary>
    /// A generic implementation of an Sample DataItem value type.
    /// </summary>
    public abstract class SampleValue : DataItemValue<float>
    {
        /// <inheritdoc />
        public override string Category => Constants.SAMPLE;

        /// <inheritdoc />
        protected SampleValue(float value) : base(value) { }
    }
}
