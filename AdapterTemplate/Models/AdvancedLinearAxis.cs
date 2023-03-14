using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.DataItemTypes;

namespace Mtconnect.AdapterTemplate.Models
{
    public sealed class AdvancedLinearAxis
    {
        /// <summary>
        /// The actual position of the axis.
        /// </summary>
        [Sample("act_pos", type: nameof(SampleTypes.PATH_POSITION), subtype: nameof(PathPositionSubTypes.ACTUAL))]
        public float ActualPosition { get; set; }

        /// <summary>
        /// The commanded position of the axis.
        /// </summary>
        [Sample("cmd_pos", type: nameof(SampleTypes.PATH_POSITION), subtype: nameof(PathPositionSubTypes.COMMANDED))]
        public float CommandedPosition { get; set; }

        /// <summary>
        /// The current load of the axis.
        /// </summary>
        [Sample("load", type: nameof(SampleTypes.LOAD))]
        public float Load { get; set; }
    }
}
