using Mtconnect;
using Mtconnect.AdapterInterface.Contracts;
using System.Collections.Generic;

namespace Service
{
    /// <summary>
    /// Wrapper for managing the <see cref="Adapter"/> that must be started and the relevant <see cref="IAdapterSource" /> to assign to it.
    /// </summary>
    public class AdapterInstance
    {
        /// <summary>
        /// Reference to the <see cref="Adapter"/> implementation that must be started.
        /// </summary>
        public Adapter Instance { get; set; }

        /// <summary>
        /// Reference to the <see cref="IAdapterSource"/> implementation that must be assigned to <see cref="Instance"/>.
        /// </summary>
        public List<IAdapterSource> Sources { get; set; } = new List<IAdapterSource>();

        /// <summary>
        /// A reference to an optional broadcaster.
        /// </summary>
        public IBroadcaster Broadcaster { get; set; }

        /// <summary>
        /// Constructs a new <see cref="AdapterInstance"/> from a constructed <see cref="Adapter"/>.
        /// </summary>
        /// <param name="instance">Reference to a previously constructed <see cref="Adapter"/>.</param>
        public AdapterInstance(Adapter instance)
        {
            Instance = instance;
        }
    }
}