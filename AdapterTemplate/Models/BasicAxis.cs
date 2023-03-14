using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.DataItems;

namespace Mtconnect.AdapterTemplate.Models
{
    /// <summary>
    /// Basic data model representation of a machine tool axis.
    /// </summary>
    public sealed class BasicAxis
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
