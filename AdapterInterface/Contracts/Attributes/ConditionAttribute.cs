using System;

namespace Mtconnect.AdapterInterface.Contracts.Attributes
{
    /// <summary>
    /// A decorative attribute for indicating a property intended to go thru an Adapter stream as an Condition.
    /// </summary>
    public class ConditionAttribute : DataItemAttribute
    {
        /// <inheritdoc />
        public ConditionAttribute(string name, string description = null) : base(name, description) { }
    }
}
