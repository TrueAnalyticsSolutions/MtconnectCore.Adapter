
namespace Service.Configuration
{
    public class ServiceConfiguration
    {
        /// <summary>
        /// Collection of simultaneous adapter configurations.
        /// </summary>
        public AdapterConfiguration[] Adapters { get; set; }

        public SourceConfiguration[] Sources { get; set; }

        /// <summary>
        /// Collection of additional DLLs to load
        /// </summary>
        public string[] Imports { get; set; }
    }
}
