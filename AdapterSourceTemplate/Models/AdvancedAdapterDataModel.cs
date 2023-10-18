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

        [DataItemPartial("ctrl_")]
        public MyController Controller { get; set; } = new MyController();
    }
    public class MyController : Mtconnect.AdapterSdk.DataItemTypes.Controller
    {
        [DataItemPartial("path_")]
        public Dictionary<string, MyPath> Paths { get; set; } = new Dictionary<string, MyPath>();

        public override void Unavailable()
        {
            base.Unavailable();
            foreach (var path in Paths)
            {
                path.Value.Unavailable();
            }
        }
    }
    public sealed class MyPath : Mtconnect.AdapterSdk.DataItemTypes.Path
    {
        [Event("exec")]
        public override Execution Execution { get; set; }

        [Event("prgm")]
        public Program.ACTIVE ActiveProgram { get; set; }

        public override void Unavailable()
        {
            base.Unavailable();

            Execution?.Unavailable();
            ActiveProgram?.Unavailable();
        }
    }
}
