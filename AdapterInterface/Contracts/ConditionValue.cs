using Mtconnect.AdapterInterface.DataItems;

namespace Mtconnect.AdapterInterface.Contracts
{
    /// <summary>
    /// A generic implementation of an Condition DataItem value type.
    /// </summary>
    public abstract class ConditionValue : DataItemValue<Condition>
    {
        /// <inheritdoc />
        public override string Category => Constants.CONDITION;

        /// <inheritdoc />
        protected ConditionValue(Condition value) : base(value) { }
    }
}
