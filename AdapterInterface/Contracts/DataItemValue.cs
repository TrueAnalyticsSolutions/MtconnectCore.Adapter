namespace Mtconnect.AdapterInterface.Contracts
{
    /// <summary>
    /// A generic implementation of a DataItem value type.
    /// </summary>
    /// <typeparam name="T">Generic reference type to the underlying value type.</typeparam>
    public abstract class DataItemValue<T>
    {
        private T _value;

        /// <summary>
        /// Constructs a new DataItem Value type.
        /// </summary>
        /// <param name="value">Underlying value</param>
        public DataItemValue(T value)
        {
            _value = value;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return _value.ToString();
        }

        /// <inheritdoc />
        public static implicit operator T(DataItemValue<T> eventObj)
        {
            return eventObj._value;
        }
    }
}
