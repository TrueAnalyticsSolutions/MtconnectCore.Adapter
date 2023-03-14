﻿using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.DataItems;

namespace Mtconnect.AdapterTemplate.Models
{
    /// <summary>
    /// A basic implementation of a machine tool data model.
    /// </summary>
    public sealed class BasicAdapterDataModel : IAdapterDataModel
    {
        /// <summary>
        /// The current availability of the machine tool
        /// </summary>
        public string Availability { get; set; }

        public string Execution { get; set; }

        /// <summary>
        /// The linear -X- Axis
        /// </summary>
        [DataItemPartial("x_")]
        public BasicAxis X { get; set; } = new BasicAxis();

        /// <summary>
        /// The linear -Y- Axis
        /// </summary>
        [DataItemPartial("y_")]
        public BasicAxis Y { get; set; } = new BasicAxis();

        /// <summary>
        /// The linear -Z- Axis
        /// </summary>
        [DataItemPartial("z_")]
        public BasicAxis Z { get; set; } = new BasicAxis();
    }
}
