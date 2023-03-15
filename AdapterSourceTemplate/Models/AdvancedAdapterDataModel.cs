using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.DataItemTypes;
using Mtconnect.AdapterInterface.DataItemValues;

namespace Mtconnect.AdapterSourceTemplate.Models
{
    public sealed class AdvancedAdapterDataModel : IAdapterDataModel
    {
        /// <summary>
        /// The current availability of the machine tool
        /// </summary>
        [Event("avail")]
        public Availability Availability { get; set; }

        [Event("exec")]
        public Execution Execution { get; set; }
    }
}
