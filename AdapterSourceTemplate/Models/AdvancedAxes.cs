using Mtconnect.AdapterSdk.Contracts.Attributes;
using Mtconnect.AdapterSdk.DataItemTypes;
using Mtconnect.AdapterSdk.DataItemValues;
using System.Collections.Generic;

namespace Mtconnect.AdapterSourceTemplate.Models
{
    public sealed class AdvancedAxes : Axes
    {
        [DataItemPartial("linear_")]
        public Dictionary<string, AdvancedLinearAxis> LinearAxes { get; set; } = new Dictionary<string, AdvancedLinearAxis>();
    }
}
