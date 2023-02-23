
using System.Collections.Generic;

namespace Service.Configuration
{
    /// <summary>
    /// Options for configuring a single <see cref="Mtconnect.AdapterInterface.Contracts.IBroadcaster"/>.
    /// </summary>
    public class BroadcasterConfiguration
    {
        public string Type { get; set; }

        public Dictionary<string, object> Options { get; set; } = new Dictionary<string, object>();
    }
}
