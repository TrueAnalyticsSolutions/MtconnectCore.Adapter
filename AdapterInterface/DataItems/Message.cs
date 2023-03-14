using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItemTypes;
using System;

namespace Mtconnect.AdapterInterface.DataItems
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
        /// <param name="subType"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='subType']"/></param>
        public Message(string name, string description = null, string type = null, string subType = null) : base(name, description, type, subType)
        {
            HasNewLine = true;
        }

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
    }
}
