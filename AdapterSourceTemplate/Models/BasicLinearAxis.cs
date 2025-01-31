﻿using Mtconnect.AdapterSdk.Attributes;
using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.DataItemTypes;
using Mtconnect.AdapterSdk.DataItemValues;

namespace Mtconnect.AdapterSourceTemplate.Models
{
    /// <summary>
    /// Basic data model representation of a machine tool axis.
    /// </summary>
    public sealed class BasicLinearAxis : Linear
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
