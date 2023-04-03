using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.DataItems;
using Mtconnect.AdapterInterface.DataItemTypes;
using Mtconnect.AdapterInterface.DataItemValues;

namespace Mtconnect.AdapterSourceTemplate.Models
{
    /// <summary>
    /// Basic data model representation of a machine tool axis.
    /// </summary>
    public sealed class BasicAxis : ILinear
    {
        /// <summary>
        /// The actual position of the axis.
        /// </summary>
        [Sample("pos_act")]
        public Position.ACTUAL ActualPosition { get; set; }

        /// <summary>
        /// The commanded position of the axis.
        /// </summary>
        [Sample("pos_cmd")]
        public Position.COMMANDED CommandedPosition { get; set; }

        /// <summary>
        /// The current load of the axis.
        /// </summary>
        [Sample("load")]
        public Load Load { get; set; }
    }
}
