using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DataItemTypes;
using System;

namespace Mtconnect.AdapterSdk.DataItems
{
    /// <summary>
    /// A sample is a data item with a floating point value
    /// </summary>
    public class Sample : DataItem
    {
        /// <inheritdoc />
        public override string Category => Constants.SAMPLE;

        /// <summary>
        /// Creates a new SAMPLE DataItem.
        /// </summary>
        /// <param name="name"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='name']"/></param>
        /// <param name="description"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='description']"/></param>
        public Sample(string name, string description = null) : base(name, description) { }

        public Sample(string name, string type, string subType = null, string description = null) : base(name, type, subType, description) { }

        /// <param name="type"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='type']"/></param>
        /// <param name="subType"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='subType']"/></param>
        public Sample(string name, SampleTypes type, Enum subType = null, string description = null) : this(name, type.ToString(), subType?.ToString(), description) { }

        private bool isNumeric(object v) => v is sbyte || v is byte || v is short || v is ushort || v is int || v is uint || v is long || v is ulong || v is float || v is double || v is decimal;
        /// <inheritdoc />
        public override bool Validate(out ValidationResult result)
        {
            var baseResponse = base.Validate(out result);
            if (!baseResponse) return baseResponse;

            // Validate the SAMPLE value
            if (!ValueValidated)
            {
                if (!isNumeric(Value) && !Value.Equals(Constants.UNAVAILABLE))
                {
                    result = new ValidationResult
                    {
                        Level = ValidationLevel.ERROR,
                        Message = $"{Category} DataItem MUST be numeric"
                    };
                    ValueValidated = true;
                    return false;
                }
                ValueValidated = true;
            }

            result = new ValidationResult
            {
                Level = ValidationLevel.VALID,
                Message = string.Empty
            };
            return true;
        }
    }
}
