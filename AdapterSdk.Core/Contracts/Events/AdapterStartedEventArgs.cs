using System;

namespace Mtconnect.AdapterSdk
{
    /// <summary>
    /// Triggered when an Adapter instance starts
    /// </summary>
    /// <param name="sender">Reference to the Adapter that started</param>
    /// <param name="e">Reference to the event arguments</param>
    public delegate void AdapterStartedHandler(IAdapter sender, object e);

    /// <summary>
    /// Custom event arguments when an <see cref="IAdapter"/> has successfully started.
    /// </summary>
    public class AdapterStartedEventArgs : EventArgs
    {
        /// <summary>
        /// Reference to how many DataItems are currently registered.
        /// </summary>
        public int DataItemCount { get; set; }

        /// <summary>
        /// Constructs a new instance of the event arguments for the <see cref="AdapterStartedHandler"/>
        /// </summary>
        public AdapterStartedEventArgs() { }
    }
}