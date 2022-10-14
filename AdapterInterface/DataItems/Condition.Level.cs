namespace Mtconnect.AdapterInterface.DataItems
{
    public partial class Condition
    {
        /// <summary>
        /// The four values for the condition.
        /// </summary> 
        public enum Level
        {
            /// <summary>
            /// The condition level is <c>UNAVAILABLE</c>.
            /// </summary>
            UNAVAILABLE,
            /// <summary>
            /// The condition level is <c>NORMAL</c>.
            /// </summary>
            NORMAL,
            /// <summary>
            /// The condition level is <c>WARNING</c>.
            /// </summary>
            WARNING,
            /// <summary>
            /// The condition level is <c>FAULT</c>.
            /// </summary>
            FAULT
        }
    }
}
