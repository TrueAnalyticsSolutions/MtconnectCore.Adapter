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

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType() || !(obj is string)) return false;

            return ToString().Equals(obj.ToString());
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return _value?.ToString();
        }

        /// <inheritdoc />
        public static implicit operator T(DataItemValue<T> eventObj)
        {
            return eventObj._value;
        }

        public static bool operator ==(DataItemValue<T> left, DataItemValue<T> right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (left is null || right is null)
            {
                return false;
            }

            return left.Equals(right);
        }

        public static bool operator !=(DataItemValue<T> left, DataItemValue<T> right)
        {
            return !(left == right);
        }

        public virtual void Unavailable()
        {
            _value = default(T);
        }
    }
}
