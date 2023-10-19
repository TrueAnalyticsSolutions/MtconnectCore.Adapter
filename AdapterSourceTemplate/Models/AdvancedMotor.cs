using Mtconnect.AdapterSdk.Contracts.Attributes;
using Mtconnect.AdapterSdk.DataItemTypes;
using Mtconnect.AdapterSdk.DataItemValues;

namespace Mtconnect.AdapterSourceTemplate.Models
{
    public sealed class AdvancedMotor : Motor
    {
        [Sample("current")]
        public Amperage Amperage { get; set; }

        [Sample("load")]
        public Load Load { get; set; }

        [Sample("torque")]
        public Torque Torque { get; set; }
    }
}
