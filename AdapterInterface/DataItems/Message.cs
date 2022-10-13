namespace Mtconnect.AdapterInterface.DataItems
{
    /// <summary>
    /// A message is an event with an additional native code. The 
    /// text of the message is the value.
    /// </summary>
    public class Message : DataItem
    {
        string mCode;
        
        /// <summary>
        /// Create a new message, set NewLine to true so this comes out 
        /// on a separate line.
        /// </summary>
        /// <param name="name">The name of the data item</param>
        public Message(string name) : base(name)
        {
            HasNewLine = true;
        }

        /// <summary>
        /// Code property.
        /// </summary>
        public string Code
        {
            set 
            {
                if (mCode != value)
                {
                    HasChanged = true;
                    mCode = value;
                }
            }
            get { return mCode; }
        }

        /// <summary>
        /// The text representation of the code.
        /// </summary>
        /// <returns>A text representation</returns>
        public override string ToString()
        {
            return $"{Name}|{mCode}|{_value}";
        }
    }
}
