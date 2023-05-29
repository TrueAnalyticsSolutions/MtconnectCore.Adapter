using Mtconnect.AdapterSdk.Contracts.Attributes;
using Mtconnect.AdapterSdk.DataItemTypes;

namespace Mtconnect.AdapterSourceTemplate.Models
{
    /// <summary>
    /// Basic collection of axes for a machine.
    /// </summary>
    public sealed class BasicAxes : Axes
    {
        /// <summary>
        /// The linear -X- Axis
        /// </summary>
        [DataItemPartial("x_")]
        public BasicLinearAxis X => GetOrAddAxis<BasicLinearAxis>(nameof(X));

        /// <summary>
        /// The linear -Y- Axis
        /// </summary>
        [DataItemPartial("y_")]
        public BasicLinearAxis Y => GetOrAddAxis<BasicLinearAxis>(nameof(Y));

        /// <summary>
        /// The linear -Z- Axis
        /// </summary>
        [DataItemPartial("z_")]
        public BasicLinearAxis Z => GetOrAddAxis<BasicLinearAxis>(nameof(Z));
    }
}
