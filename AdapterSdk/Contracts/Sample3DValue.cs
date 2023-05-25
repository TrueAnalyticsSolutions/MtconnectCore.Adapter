namespace Mtconnect.AdapterSdk.Contracts
{
    /// <summary>
    /// A generic implementation of an Sample DataItem value type with 3D data format.
    /// </summary>
    public abstract class Sample3DValue : DataItemValue<float?[]>
    {
        /// <inheritdoc />
        public override string Category => Constants.SAMPLE;

        /// <inheritdoc />
        protected Sample3DValue(float?[] value) : base(value) { }
    }
}
