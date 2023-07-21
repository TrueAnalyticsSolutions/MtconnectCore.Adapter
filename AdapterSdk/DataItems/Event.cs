using System;
using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DataItemTypes;

namespace Mtconnect.AdapterSdk.DataItems
{
    /// <summary>
    /// Event is just an alias for DataItem
    /// </summary>
    public class Event : DataItem
    {
        /// <inheritdoc />
        public override string Category => Constants.EVENT;

        /// <summary>
        /// Creates a new EVENT DataItem.
        /// </summary>
        /// <param name="name"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='name']"/></param>
        /// <param name="description"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='description']"/></param>
        /// <param name="type"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='type']"/></param>
        /// <param name="subType"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='subType']"/></param>
        public Event(string name, string description = null) : base(name, description) { }

        public Event(string name, string type, string subtype = null, string description = null) : base(name, type, subtype, description) { }

        public Event(string name, EventTypes type, Enum subtype = null, string description = null) : this(name, type.ToString(), subtype?.ToString(), description) { }

        // TODO: Verify other constraints required against Event values.
        /// <inheritdoc />
        public override bool Validate(out ValidationResult result)
        {
            var baseResponse = base.Validate(out result);
            if (!baseResponse) return baseResponse;

            // Validate the EVENT value
            if (!ValueValidated)
            {
                if (TypeEnum != null)
                {
                    var valueTypes = DataItemHelper.GetValues(TypeEnum);
                    if (valueTypes != null)
                    {
                        if (!(Value is string))
                        {
                            result = new ValidationResult
                            {
                                Level = ValidationLevel.WARNING,
                                Message = $"{Category} DataItem of type '{ObservationalType}' MUST have a value type of type 'string'"
                            };
                            ValueValidated = true;
                            return false;
                        }

                        var value = DataItemHelper.GetValue(TypeEnum, Value as string);
                        if (value == null)
                        {
                            result = new ValidationResult
                            {
                                Level = ValidationLevel.ERROR,
                                Message = $"{Category} DataItem of type '{ObservationalType}' MUST include one of the defined values or be extended"
                            };
                            ValueValidated = true;
                            return false;
                        }
                    }
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

        /// <inheritdoc />
        public override DataItem Copy()
        {
            var copy = new Event(this.Name, this.ObservationalType, this.ObservationalSubType, this.Description);
            copy.FormatValue = this.FormatValue;
            copy.ModelPath = this.ModelPath;
            copy.Units = this.Units;
            copy.HasTimestampOverride = this.HasTimestampOverride;

            return copy;
        }
    }
}
