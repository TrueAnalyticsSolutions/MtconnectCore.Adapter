namespace Mtconnect.AdapterInterface.DataItems
{
    /// <summary>
    /// A message is an event with an additional native code. The 
    /// text of the message is the value.
    /// </summary>
    public class Message : DataItem
    {
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
        /// Create a new message, set NewLine to true so this comes out on a separate line.
        /// </summary>
        /// <param name="name"><inheritdoc cref="DataItem.DataItem(string, string)" path="/param[@name='name']"/></param>
        /// <param name="description"><inheritdoc cref="DataItem.DataItem(string, string)" path="/param[@name='description']"/></param>
        public Message(string name, string description = null) : base(name, description)
        {
            HasNewLine = true;
        }


        /// <summary>
        /// The text representation of the code.
        /// </summary>
        /// <returns>A text representation</returns>
        public override string ToString()
        {
            return $"{Name}|{_code}|{_value}";
        }
    }
}
