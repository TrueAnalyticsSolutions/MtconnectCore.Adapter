using Mtconnect.AdapterSdk.Attributes;
using Mtconnect.AdapterSdk.DataItemTypes;
using System.Collections.Generic;

namespace Mtconnect.AdapterSourceTemplate.Models
{
    public sealed class AdvancedAxes : Axes
    {
        [DataItemPartial("linear_")]
        public Dictionary<string, AdvancedLinearAxis> LinearAxes { get; set; } = new Dictionary<string, AdvancedLinearAxis>();
    }
}
