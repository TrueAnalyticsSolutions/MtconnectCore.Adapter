using System.Collections.Generic;

namespace Service.Configuration
{
    /// <summary>
    /// Options for configuring a single <see cref="Mtconnect.UPnP.IUPnPService"/>.
    /// </summary>
    public class UPnPConfiguration
    {
        /// <summary>
        /// Reference to the <see cref="System.Type"/> of the <see cref="Mtconnect.UPnP.IUPnPService"/> implementation.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Key value pairs of the parameters that can be injected into the constructor for the referenced <see cref="Type"/>.
        /// </summary>
        public Dictionary<string, object> Options { get; set; } = new Dictionary<string, object>();
    }
}
