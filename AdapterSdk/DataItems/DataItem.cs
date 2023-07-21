using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.Contracts.Attributes;
using Mtconnect.AdapterSdk.DataItemTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace Mtconnect.AdapterSdk.DataItems
{
    /// <summary>
    /// Triggered when the value of a DataItem has changed.
    /// </summary>
    /// <param name="sender">Reference to the <see cref="DataItem"/>.</param>
    /// <param name="e">Reference to the event arguments for the data changed event.</param>
    public delegate void DataItemChangedHandler(DataItem sender, DataItemChangedEventArgs e);

    /// <summary>
    /// Simple base data item class. Has an abstract value and a name. It keeps track if it has changed since the last time it was reset.
    /// </summary>
    public abstract class DataItem
    {
        /// <summary>
        /// Occurrs when the value of a DataItem has changed.
        /// </summary>
        public event DataItemChangedHandler OnDataItemChanged;

        /// <summary>
        /// Reference to the type of source model (see <see cref="IAdapterDataModel"/>) this DataItem was constructed from.
        /// </summary>
        public string ModelPath { get; internal set; } = null;

        /// <summary>
        /// Refers to the category for the MTConnect observational type.
        /// </summary>
        public virtual string Category { get; }

        /// <summary>
        /// A <see cref="System.Type"/> reference to the <see cref="Enum"/> according the MTConnect Standard. See <see cref="EventTypes"/>, <see cref="SampleTypes"/>, and <see cref="ConditionTypes"/> for examples.
        /// </summary>
        public Enum TypeEnum { get; protected set; }
        /// <summary>
        /// A <see cref="System.Type"/> reference to the <see cref="Enum"/> according to the MTConnect Standard and the provided <see cref="TypeEnum"/> if it is decorated with <see cref="ObservationalSubTypeAttribute"/>.
        /// </summary>
        public Enum SubTypeEnum { get; protected set; }

        /// <summary>
        /// A flag for whether or not the <see cref="ObservationalType"/> has been validated against the MTConnect Standard.
        /// </summary>
        public bool TypeValidated { get; protected set; } = false;
        /// <summary>
        /// The protected value for <see cref="ObservationalType"/>.
        /// </summary>
        protected string Type { get; set; }
        /// <summary>
        /// The intended <c>type</c> for the Data Item. See <see cref="EventTypes">Events</see>, <see cref="SampleTypes">Samples</see>, and <see cref="ConditionTypes">Conditions</see>. The <c>type</c> can also be extended according to the standard be adding the prefix <c>x:</c> to indicate an extended type.
        /// </summary>
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
        /// <summary>
        /// The intended <c>subType</c> for the Data Item. Refer to the appropriate <see cref="EventTypes">Events</see>, <see cref="SampleTypes">Samples</see>, and <see cref="ConditionTypes">Conditions</see>. The <c>subType</c> can also be extended according to the standard be adding the prefix <c>x:</c> to indicate an extended type.
        /// </summary>
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

        /// <summary>
        /// Reference to the <c>nativeUnits</c> of the DataItem
        /// </summary>
        public virtual string Units { get; set; }

        /// <summary>
        /// The name of the data item.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// A description of the DataItem such as a trace of its source or the methodology for a composite data type.
        /// </summary>
        public string Description { get; internal set; }

        /// <summary>
        /// Optional device prefix.
        /// </summary>
        public string DevicePrefix = string.Empty;

        /// <summary>
        /// The value of the data item, can be any type.
        /// </summary>
        protected object _value = Constants.UNAVAILABLE;
        /// <summary>
        /// A falg for whether or not the <see cref="Value"/> has been validated against the MTConnect Standard.
        /// </summary>
        protected bool ValueValidated { get; set; } = false;
        /// <summary>
        /// Get and set the Value property. This will check if the value has changed and set the changed flag appropriately. Automatically boxes types so will work for any data.
        /// </summary>
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

        /// <summary>
        /// Timestamp of when the <see cref="Value"/> was last Changed.
        /// </summary>
        public DateTime? LastChanged { get; set; }

        /// <summary>
        /// A flag to indicate if the data item's value has changed since it 
        /// has last been set.
        /// </summary>
        public bool HasChanged { get; protected set; }

        /// <summary>
        /// An indicator that this data item must be sent on a separate line.
        /// This is done for all data items that are more complex than simple 
        /// Key|Value pairs.
        /// </summary>
        public virtual bool HasNewLine { get; protected set; }

        /// <summary>
        /// Flag for whether or not this DataItem has a different source for the expected output Timestamp.
        /// </summary>
        public bool HasTimestampOverride { get; internal set; }

        /// <summary>
        /// An expression that can be used to apply additional formatting or transformations to the DataItem value.
        /// </summary>
        public Func<object, object> FormatValue { get; set; }

        /// <summary>
        /// Create a new data item
        /// </summary>
        /// <param name="name"><inheritdoc cref="DataItem.Name" path="/summary"/></param>
        /// <param name="description"><inheritdoc cref="DataItem.Description" path="/summary"/></param>
        public DataItem(string name, string description = null)
        {
            Name = name;
            Description = description;

            Unavailable();
        }

        public DataItem(string name, string type, string subtype = null, string description = null) : this(name, description)
        {
            ObservationalType = type;
            ObservationalSubType = subtype;
        }

        /// <summary>
        /// Make this data item <c>UNAVAILABLE</c>.
        /// </summary>
        public virtual void Unavailable() { Value = Constants.UNAVAILABLE; }

        /// <summary>
        /// Checks if the data item is unavailable.
        /// </summary>
        /// <returns>true if Unavailable</returns>
        public bool IsUnavailable() => Value?.Equals(Constants.UNAVAILABLE) == true;

        /// <summary>
        /// Forces this <see cref="DataItem"/> to indicate that the <see cref="Value"/> has changed.
        /// </summary>
        public void ForceChanged()
        {
            HasChanged = true;
            if (!HasTimestampOverride) LastChanged = TimeHelper.GetNow();
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is DataItem)
            {
                return (obj as DataItem).Value?.Equals(Value) == true;
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

        /// <summary>
        /// These methods are mainly for conditions. They allow for
        /// mark and sweep of the condition activations.
        /// </summary>
        public virtual void Begin() { }

        /// <summary>
        /// This is called before we send the actual changed data. It does the diff from the previous state and finds all the activations that need to be removed. This also check to see if all the activations have been removed because we only need to do a single normal with no native code to clear all. This is not required for simple conditions.
        /// </summary>
        public virtual void Prepare() { }

        /// <summary>
        /// Reset the Changed flag.
        /// </summary>
        public virtual void Cleanup() { HasChanged = false; }

        /// <summary>
        /// Get a list of all the changed data items. Since this is a 
        /// single value, just return a list with one item if it has 
        /// changed
        /// </summary>
        /// <param name="all">true means to return this data item regardless of the 
        /// changed flag. This is used to send initial data back to a new client.</param>
        /// <returns>The changed data item</returns>
        public virtual List<DataItem> ItemList(bool all = false)
        {
            List<DataItem> list = new List<DataItem>();
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

        /// <summary>
        /// Performs validation against the DataItem value based on the <see cref="ObservationalType"/> and <see cref="ObservationalSubType"/>.
        /// </summary>
        /// <returns>Flag of whether or not the result yields anything other than <see cref="ValidationLevel.VALID"/>.</returns>
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

        /// <summary>
        /// Copies the current DataItem into a new object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public abstract DataItem Copy();
    }
}
