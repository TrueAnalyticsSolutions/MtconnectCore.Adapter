using Mtconnect.AdapterSdk.DataItemTypes;
using System;

namespace Mtconnect.AdapterSdk.DataItems
{
    /// <summary>
    /// A message is an event with an additional native code. The 
    /// text of the message is the value.
    /// </summary>
    public class Message : DataItem
    {
        /// <inheritdoc />
        public override string Category => Constants.EVENT;

        private string _code;
        /// <summary>
        /// Native Code property.
        /// </summary>
        public string Code
        {
            set 
            {
                if (_code != value)
                {
                    HasChanged = true;
                    _code = value;
                }
            }
            get { return _code; }
        }

        /// <summary>
        /// Create a new EVENT DataItem with Message formatting.
        /// </summary>
        /// <param name="name"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='name']"/></param>
        /// <param name="description"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='description']"/></param>
        /// <param name="type"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='type']"/></param>
        /// <param name="subType"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='subtype']"/></param>
        public Message(string name, string description = null, string type = null, string subType = null) : base(name, type, subType, description)
        {
            HasNewLine = true;
        }

        /// <summary>
        /// <inheritdoc cref="Message(string,string,string,string)" path="/summary"/>
        /// </summary>
        /// <param name="name"><inheritdoc cref="Message(string,string,string,string)" path="/param[@name='name']"/></param>
        /// <param name="description"><inheritdoc cref="Message(string,string,string,string)" path="/param[@name='description']"/></param>
        /// <param name="type"><inheritdoc cref="Message(string,string,string,string)" path="/param[@name='type']"/></param>
        /// <param name="subType"><inheritdoc cref="Message(string,string,string,string)" path="/param[@name='subType']"/></param>
        public Message(string name, string description = null, EventTypes? type = null, Enum subType = null) : this(name, description, type?.ToString(), subType?.ToString()) { }

        /// <summary>
        /// The text representation of the code.
        /// </summary>
        /// <returns>A text representation</returns>
        public override string ToString()
        {
            return $"{Name}|{_code}|{_value}";
        }

        /// <inheritdoc />
        public override bool Validate(out ValidationResult result)
        {
            // NOTE: No need to call the base.Validate method because this is not a real DataItem

            result = new ValidationResult
            {
                Level = ValidationLevel.VALID
            };

            // TODO: Determine what needs to be validated from the Adapter
            return true;
        }

        /// <inheritdoc />
        public override IDataItem Copy()
        {
            var copy = new Message(this.Name, this.Description, this.ObservationalType, this.ObservationalSubType);
            copy.FormatValue = this.FormatValue;
            copy.ModelPath = this.ModelPath;
            copy.Units = this.Units;
            copy.HasTimestampOverride = this.HasTimestampOverride;
            copy.Code = this.Code;

            return copy;
        }
    }
}
