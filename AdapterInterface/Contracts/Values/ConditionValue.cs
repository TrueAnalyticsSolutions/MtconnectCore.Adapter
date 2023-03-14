using Mtconnect.AdapterInterface.DataItems;

namespace Mtconnect.AdapterInterface.Contracts.Values
{
    /// <summary>
    /// A generic implementation of an Condition DataItem value type.
    /// </summary>
    public abstract class ConditionValue : DataItemValue<Condition>
    {
        /// <inheritdoc />
        protected ConditionValue(Condition value) : base(value) { }
    }
}
