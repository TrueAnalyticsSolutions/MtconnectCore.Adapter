using Mtconnect.AdapterSdk.Attributes;
using Mtconnect.AdapterSdk.DataItemTypes;
using Mtconnect.AdapterSdk.DataItemValues;

namespace Mtconnect.AdapterSourceTemplate.Models
{
    public sealed class AdvancedLinearAxis : Linear
    {
        /// <summary>
        /// The actual position of the axis.
        /// </summary>
        [Sample("act_pos")]
        public PathPosition.ACTUAL ActualPosition { get; set; }

        /// <summary>
        /// The commanded position of the axis.
        /// </summary>
        [Sample("cmd_pos")]
        public PathPosition.COMMANDED CommandedPosition { get; set; }

        /// <summary>
        /// The current load of the axis.
        /// </summary>
        [Sample("load")]
        public Load Load { get; set; }

        [DataItemPartial("drive_")]
        public AdvancedMotor Motor { get; set; } = new AdvancedMotor();
    }
}
