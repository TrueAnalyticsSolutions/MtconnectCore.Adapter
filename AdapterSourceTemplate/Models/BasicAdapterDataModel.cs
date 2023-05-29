using Mtconnect.AdapterSdk.Contracts.Attributes;
using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.DataItemValues;

namespace Mtconnect.AdapterSourceTemplate.Models
{
    /// <summary>
    /// A basic implementation of a machine tool data model.
    /// </summary>
    public sealed class BasicAdapterDataModel : IAdapterDataModel
    {
        /// <summary>
        /// The current availability of the machine tool
        /// </summary>
        [Event("avail")]
        public Availability Availability { get; set; }

        [Event("exec")]
        public Execution Execution { get; set; }

        [DataItemPartial("a_")]
        public BasicAxes Axes { get; set; } = new BasicAxes();

        // NOTE: Make sure to describe how your DataItem values are sourced. This can be helpful when case the philosophy behind some of the states does not align with the implementors are expecting.
    }
}
