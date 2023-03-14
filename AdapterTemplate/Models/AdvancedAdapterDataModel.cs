using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterTemplate.Models
{
    public sealed class AdvancedAdapterDataModel : IAdapterDataModel
    {
        /// <summary>
        /// The current availability of the machine tool
        /// </summary>
        [Event("avail")]
        public string Availability { get; set; }

        [Event("exec")]
        public string Execution { get; set; }
    }
}
