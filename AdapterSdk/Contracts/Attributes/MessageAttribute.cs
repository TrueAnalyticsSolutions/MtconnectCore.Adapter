using Mtconnect.AdapterSdk.DataItemTypes;
using System;

namespace Mtconnect.AdapterSdk.Contracts.Attributes
{
    /// <summary>
    /// A decorative attribute for indicating a property intended to go thru an Adapter stream as an Message.
    /// </summary>
    public class MessageAttribute : DataItemAttribute
    {
        /// <inheritdoc />
        public MessageAttribute(string name, string description = null) : base(name, description) { }
    }
}
