using System.Linq;

namespace Mtconnect.AdapterSdk
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

        public override string ToString()
        {
            if (_value == null || _value.Length == 0)
            {
                return Constants.UNAVAILABLE;
            }
            return string.Join(", ", _value.Select(o => o.ToString()));
        }
    }
}
