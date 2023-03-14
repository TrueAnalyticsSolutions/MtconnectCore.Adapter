using Mtconnect.AdapterInterface.DataItemTypes;
using System;

namespace Mtconnect.AdapterInterface.Contracts.Attributes
{
    /// <summary>
    /// A decorative attribute for indicating a property intended to go thru an Adapter stream as an Message.
    /// </summary>
    public class MessageAttribute : DataItemAttribute
    {
        /// <inheritdoc />
        public MessageAttribute(string name, string description = null, string type = null, string subtype = null) : base(name, description, type, subtype) { }

        public MessageAttribute(string name, string description = null, EventTypes? type = null, Enum subtype = null) : this(name, description, type.ToString(), subtype.ToString()) { }
    }
}
