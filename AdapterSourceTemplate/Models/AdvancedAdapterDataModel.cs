using Mtconnect.AdapterSdk.Contracts.Attributes;
using Mtconnect.AdapterSdk.DataItemTypes;
using Mtconnect.AdapterSdk.DataItemValues;
using System.Collections.Generic;

namespace Mtconnect.AdapterSourceTemplate.Models
{
    public sealed class AdvancedAdapterDataModel : IAdapterDataModel
    {
        /// <summary>
        /// The current availability of the machine tool
        /// </summary>
        [Event("avail")]
        public Availability Availability { get; set; }

        [DataItemPartial("path_")]
        public Dictionary<string, Path> Paths { get; set; } = new Dictionary<string, Path>();
    }
    public sealed class Path : Mtconnect.AdapterSdk.DataItemTypes.Path
    {
        [Event("exec")]
        public override Execution Execution { get; set; }
    }
}
