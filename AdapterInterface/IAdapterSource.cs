
namespace Mtconnect
{
    /// <summary>
    /// Handler for ingesting data from a MTConnect Adapter source.
    /// </summary>
    /// <param name="sender">Reference to the Adapter source.</param>
    /// <param name="e">Event arguments containing data received from the MTConnect Adapter source.</param>
    public delegate void DataReceivedHandler(object sender, DataReceivedEventArgs e);

    /// <summary>
    /// A generic interface for instantiating a source for a MTConnect Adapter.
    /// </summary>
    public interface IAdapterSource
    {
        /// <summary>
        /// Handles the event when an Adapter source has finished receiving and processing data.
        /// </summary>
        event DataReceivedHandler OnDataReceived;

        /// <summary>
        /// Instructs the Adapter source to begin collecting data.
        /// </summary>
        void Start();

        /// <summary>
        /// Instructs the Adapter source to stop collecting data.
        /// </summary>
        void Stop();
    }
}
