using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterTemplate.Models
{
    public sealed class AdvancedLinearAxis
    {
        /// <summary>
        /// The actual position of the axis.
        /// </summary>
        [Sample("act_pos")]
        public float ActualPosition { get; set; }

        /// <summary>
        /// The commanded position of the axis.
        /// </summary>
        [Sample("cmd_pos")]
        public float CommandedPosition { get; set; }

        /// <summary>
        /// The current load of the axis.
        /// </summary>
        [Sample("load")]
        public float Load { get; set; }
    }
}
