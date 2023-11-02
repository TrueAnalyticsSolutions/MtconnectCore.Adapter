using Mtconnect.AdapterSdk;
using System.Collections.Generic;

namespace Mtconnect.AdapterTemplate
{
    /// <summary>
    /// Configuration options for a <see cref="AdapterTemplate"/>.
    /// </summary>
    public sealed class AdapterOptionsTemplate : AdapterOptions
    {
        /// <summary>
        /// Constructs the most basic options for configuring a MTConnect Adapter.
        /// </summary>
        /// <param name="heartbeat"><inheritdoc cref="AdapterOptions.AdapterOptions" path="/param[@name='heartbeat']"/></param>
        public AdapterOptionsTemplate(double heartbeat = 10_000) : base(heartbeat) { }

        /// <inheritdoc />
        public override Dictionary<string, object> UpdateFromConfig(IAdapterLogger logger = default)
        {
            var adapterSettings = base.UpdateFromConfig(logger);



            return adapterSettings;
        }
    }
}
