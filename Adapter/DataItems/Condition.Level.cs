namespace MtconnectCore.Adapter.DataItems
{
    public partial class Condition
    {
        /// <summary>
        /// The four values for the condition.
        /// </summary> 
        public enum Level
        {
            UNAVAILABLE,
            NORMAL,
            WARNING,
            FAULT
        }
    }
}
