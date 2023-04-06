using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.DataItemTypes;

namespace Mtconnect.AdapterSourceTemplate.Models
{
    public sealed class AdvancedAxes : Axes
    {
        [DataItemPartial("x_")]
        public AdvancedLinearAxis X => GetOrAddAxis<AdvancedLinearAxis>(nameof(X));

        [DataItemPartial("y_")]
        public AdvancedLinearAxis Y => GetOrAddAxis<AdvancedLinearAxis>(nameof(Y));

        [DataItemPartial("z_")]
        public AdvancedLinearAxis Z => GetOrAddAxis<AdvancedLinearAxis>(nameof(Z));
    }
}
