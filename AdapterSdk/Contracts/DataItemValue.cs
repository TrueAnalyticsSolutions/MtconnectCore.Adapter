using System;

namespace Mtconnect.AdapterSdk.Contracts
{
    /// <summary>
    /// A generic implementation of a DataItem value type.
    /// </summary>
    /// <typeparam name="T">Generic reference type to the underlying value type.</typeparam>
    public abstract class DataItemValue<T> : IDataItemValue
    {
        protected T _value;

        /// <inheritdoc />
        public abstract string Category { get; }

        /// <inheritdoc />
        public abstract string ObservationalType { get; }

        /// <inheritdoc />
        public abstract string ObservationalSubType { get; }

        /// <summary>
        /// Constructs a new DataItem Value type.
        /// </summary>
        /// <param name="value">Underlying value</param>
        public DataItemValue(T value)
        {
            _value = value;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(_value, null))
                return ReferenceEquals(obj, null);

            return _value.Equals(obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
            => _value.GetHashCode();

        /// <inheritdoc />
        public override string ToString()
            => _value?.ToString();

        /// <inheritdoc />
        public static implicit operator T(DataItemValue<T> eventObj)
            => eventObj._value;

        /// <inheritdoc />
        public static bool operator ==(DataItemValue<T> left, DataItemValue<T> right)
            => left.Equals(right._value);
        /// <inheritdoc />
        public static bool operator !=(DataItemValue<T> left, DataItemValue<T> right)
            => !(left == right);

        /// <inheritdoc />
        public static bool operator ==(DataItemValue<T> left, object right)
            => left.Equals(right);
        /// <inheritdoc />
        public static bool operator !=(DataItemValue<T> left, object right)
            => !(left == right);

        /// <inheritdoc />
        public static bool operator ==(object left, DataItemValue<T> right)
            => right.Equals(left);
        /// <inheritdoc />
        public static bool operator !=(object left, DataItemValue<T> right)
            => !(left == right);

        /// <inheritdoc />
        public virtual void Unavailable()
        {
            _value = default(T);
        }
    }
}
