using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.DataItemTypes;
using Mtconnect.AdapterInterface.DataItemValues;

namespace Mtconnect.AdapterTemplate.Models
{
    public sealed class AdvancedAdapterDataModel : IAdapterDataModel
    {
        /// <summary>
        /// The current availability of the machine tool
        /// </summary>
        [Event("avail", type: nameof(EventTypes.AVAILABILITY))]
        public AvailabilityValues Availability { get; set; }

        [Event("exec", type: nameof(EventTypes.EXECUTION))]
        public ExecutionValues Execution { get; set; }
    }
}
