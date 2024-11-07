using Mtconnect.AdapterSdk.DataItemTypes;
using System;
using System.Collections.Generic;

namespace Mtconnect.AdapterSdk.DataItems
{
    /// <inheritdoc />
    public abstract class DataItem : IDataItem
    {
        /// <inheritdoc />
        public event DataItemChangedHandler OnDataItemChanged;

        /// <inheritdoc />
        public string ModelPath { get; set; } = null;

        /// <inheritdoc />
        public virtual string Category { get; }

        /// <inheritdoc />
        public Enum TypeEnum { get; protected set; }

        /// <inheritdoc />
        public Enum SubTypeEnum { get; protected set; }

        /// <inheritdoc />
        public bool TypeValidated { get; protected set; } = false;
        /// <summary>
        /// The protected value for <see cref="ObservationalType"/>.
        /// </summary>
        protected string Type { get; set; }
        /// <inheritdoc />
        public virtual string ObservationalType
        {
            get => Type;
            set
            {
                TypeEnum = null;
                SubTypeEnum = null;
                switch (Category)
                {
                    case Constants.EVENT:
                        if (Enum.TryParse<EventTypes>(value, true, out EventTypes eventType))
                            TypeEnum = eventType;
                        break;
                    case Constants.SAMPLE:
                        if (Enum.TryParse<SampleTypes>(value, true, out SampleTypes sampleType))
                            TypeEnum = sampleType;
                        break;
                    case Constants.CONDITION:
                        if (Enum.TryParse<ConditionTypes>(value, true, out ConditionTypes conditionTypes))
                            TypeEnum = conditionTypes;
                        else if (Enum.TryParse<EventTypes>(value, true, out EventTypes cEventType))
                            TypeEnum = cEventType;
                        else if(Enum.TryParse<SampleTypes>(value, true, out SampleTypes cSampleType))
                            TypeEnum = cSampleType;
                        break;
                    default:
                        break;
                }
                Type = value;
                TypeValidated = false;
            }
        }

        /// <summary>
        /// A flag for whether or not the <see cref="ObservationalSubType"/> has been validated against the MTConnect Standard and the provided <see cref="Type"/>.
        /// </summary>
        protected bool SubTypeValidated { get; set; } = false;
        /// <summary>
        /// The protected value for <see cref="ObservationalSubType"/>.
        /// </summary>
        private string SubType { get; set; }
        /// <inheritdoc />
        public virtual string ObservationalSubType
        {
            get => SubType;
            set
            {
                SubTypeEnum = null;
                // TODO: Find Enum type from the EventType
                if (TypeEnum != null)
                {
                    var subType = DataItemHelper.GetSubType(TypeEnum, value);
                    if (subType != null)
                    {
                        SubTypeEnum = subType;
                    }
                }
                SubType = value;
                SubTypeValidated = false;
            }
        }

        /// <inheritdoc />
        public virtual string Units { get; set; }

        /// <inheritdoc />
        public string Name { get; set; }

        /// <inheritdoc />
        public string Description { get; set; }

        /// <inheritdoc />
        public string DevicePrefix { get; set; } = string.Empty;

        /// <summary>
        /// The value of the data item, can be any type.
        /// </summary>
        protected object _value = Constants.UNAVAILABLE;
        /// <summary>
        /// A falg for whether or not the <see cref="Value"/> has been validated against the MTConnect Standard.
        /// </summary>
        protected bool ValueValidated { get; set; } = false;
        /// <inheritdoc />
        public object Value
        {
            set
            {
                var updatedValue = value;
                if (updatedValue is IDataItemValue)
                    updatedValue = updatedValue?.ToString();
                if (FormatValue != null) updatedValue = FormatValue(updatedValue);

                if (IsReadyToUpdate(updatedValue)
                    && ((_value == null && updatedValue != null)
                    || (_value != null && updatedValue == null)
                    || _value?.Equals(updatedValue) == false))
                {
                    // Default the value to UNAVAILABLE to avoid crashing the Agent
                    if (updatedValue == null
                        || (updatedValue is string && string.IsNullOrEmpty(updatedValue as string)))
                        updatedValue = Constants.UNAVAILABLE;

                    var now = TimeHelper.GetNow();
                    // TODO: Figure out a way to ensure that both now and LastChanged respect TimestampAttribute implementations
                    var e = new DataItemChangedEventArgs(_value, updatedValue, LastChanged, now);

                    _value = updatedValue;
                    if (!HasTimestampOverride) LastChanged = now;

                    HasChanged = true;
                    ValueValidated = false;

                    TriggerDataChangedEvent(e);
                }
            }
            get { return _value; }
        }

        /// <summary>
        /// A method for determining whether or not the provided value is worth overriding the existing <see cref="Value"/>.
        /// </summary>
        /// <param name="value">Potentially new value</param>
        /// <returns>Flag for whether or not the new value is different enough compared to the current value.</returns>
        protected virtual bool IsReadyToUpdate(object value)
            => _value?.Equals(Constants.UNAVAILABLE) == true
            ? (value is string ? !string.IsNullOrEmpty(value as string) : value != null)
            : value != null;

        /// <inheritdoc />
        public DateTime? LastChanged { get; set; }

        /// <inheritdoc />
        public bool HasChanged { get; protected set; }

        /// <inheritdoc />
        public virtual bool HasNewLine { get; protected set; }

        /// <inheritdoc />
        public bool HasTimestampOverride { get; set; }

        /// <inheritdoc />
        public Func<object, object> FormatValue { get; set; }

        protected DataItem()
        {
            Unavailable();
        }

        /// <summary>
        /// Create a new data item
        /// </summary>
        /// <param name="name"><inheritdoc cref="DataItem.Name" path="/summary"/></param>
        /// <param name="description"><inheritdoc cref="DataItem.Description" path="/summary"/></param>
        public DataItem(string name, string description = null) : this()
        {
            Name = name;
            Description = description;
        }

        /// <summary>
        /// <inheritdoc cref="DataItem(string,string)" path="/summary"/>
        /// </summary>
        /// <param name="name"><inheritdoc cref="DataItem(string,string)" path="/param[@name='name']"/></param>
        /// <param name="type"><inheritdoc cref="DataItem.ObservationalType" path="/summary"/></param>
        /// <param name="subtype"><inheritdoc cref="DataItem.ObservationalSubType" path="/summary"/></param>
        /// <param name="description"><inheritdoc cref="DataItem(string,string)" path="/param[@name='description']"/></param>
        public DataItem(string name, string type, string subtype = null, string description = null) : this(name, description)
        {
            ObservationalType = type;
            ObservationalSubType = subtype;
        }

        /// <inheritdoc />
        public virtual void Unavailable() { Value = Constants.UNAVAILABLE; }

        /// <inheritdoc />
        public bool IsUnavailable() => Value?.Equals(Constants.UNAVAILABLE) == true;

        /// <inheritdoc />
        public void ForceChanged()
        {
            HasChanged = true;
            if (!HasTimestampOverride) LastChanged = TimeHelper.GetNow();
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is IDataItem)
            {
                return (obj as IDataItem).Value?.Equals(Value) == true;
            } else if (obj is string)
            {
                if (!(Value is string)) return false;
                return obj?.Equals(Value) == true;
            }

            return base.Equals(obj);
        }

        /// <summary>
        /// Simple string representation with pipe delim.
        /// </summary>
        /// <returns>A text representation</returns>
        public override string ToString()
        {
            if (string.IsNullOrEmpty(DevicePrefix))
                return $"{Name}|{Value}";
            else
                return $"{DevicePrefix}:{Name}|{Value}";
        }

        /// <inheritdoc />
        public virtual void Begin() { }

        /// <inheritdoc />
        public virtual void Prepare() { }

        /// <inheritdoc />
        public virtual void Cleanup() { HasChanged = false; }

        /// <inheritdoc />
        /// <returns>The changed data item</returns>
        public virtual List<IDataItem> ItemList(bool all = false)
        {
            List<IDataItem> list = new List<IDataItem>();
            if (all || HasChanged)
                list.Add(this);
            return list;
        }
    
        /// <summary>
        /// Triggers the <see cref="OnDataItemChanged"/> event.
        /// </summary>
        /// <param name="e">Reference to the event arguments.</param>
        protected void TriggerDataChangedEvent(DataItemChangedEventArgs e)
        {
            OnDataItemChanged?.Invoke(this, e);
        }

        /// <inheritdoc />
        public virtual bool Validate(out ValidationResult result)
        {

            // Validate the DataItem type
            if (!TypeValidated)
            {
                if (!string.IsNullOrEmpty(ObservationalType))
                {
                    if (TypeEnum == null && !ObservationalType.StartsWith("x:", StringComparison.OrdinalIgnoreCase))
                    {
                        result = new ValidationResult
                        {
                            Level = ValidationLevel.ERROR,
                            Message = $"{Category} DataItem MUST refer to a defined type or extend the type with the 'x:' prefix"
                        };
                        TypeValidated = true;
                        return false;
                    }
                    else if (ObservationalType.StartsWith("x:", StringComparison.OrdinalIgnoreCase))
                    {
                        string unextendedType = ObservationalType.Substring(2);
                        if (Enum.TryParse(unextendedType, out EventTypes unextendedEventType))
                        {
                            result = new ValidationResult
                            {
                                Level = ValidationLevel.WARNING,
                                Message = $"{Category} DataItem already contains a defined type of '{unextendedEventType}'"
                            };
                            TypeValidated = true;
                            return false;
                        }
                    }
                }
                TypeValidated = true;
            }

            // Validate the DataItem subType
            if (!SubTypeValidated)
            {
                if (!string.IsNullOrEmpty(ObservationalSubType))
                {
                    if (ObservationalType.StartsWith("x:") && !ObservationalSubType.StartsWith("x:"))
                    {
                        result = new ValidationResult
                        {
                            Level = ValidationLevel.WARNING,
                            Message = $"{Category} DataItem subType should be extended if the type is extended"
                        };
                        SubTypeValidated = true;
                        return false;
                    }
                    else if (!ObservationalType.StartsWith("x:") && TypeEnum != null)
                    {
                        var subTypes = DataItemHelper.GetSubTypes(TypeEnum);
                        if (subTypes != null)
                        {
                            var subType = DataItemHelper.GetSubType(TypeEnum, ObservationalSubType);
                            if (subType == null)
                            {
                                result = new ValidationResult
                                {
                                    Level = ValidationLevel.ERROR,
                                    Message = $"{Category} DataItem of type '{ObservationalType}' MUST include one of the defined subTypes or be extended"
                                };
                                SubTypeValidated = true;
                                return false;
                            }
                        }
                    }
                }
                SubTypeValidated = true;
            }

            result = new ValidationResult
            {
                Level = ValidationLevel.VALID
            };

            return true;
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            int hashCode = 934948419;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Category);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SubType);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(Value);
            return hashCode;
        }

        /// <inheritdoc />
        public abstract IDataItem Copy();
    }
}
