using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.DataItems;

namespace Mtconnect.AdapterSourceTemplate
{
    public class AdapterSourceModel : IAdapterDataModel
    {
        [Event("avail")]
        public string Availability { get; set; }

        // NOTE: Make sure to describe how your DataItem values are sourced. This can be helpful when case the philosophy behind some of the states does not align with the implementors are expecting.
    }
}