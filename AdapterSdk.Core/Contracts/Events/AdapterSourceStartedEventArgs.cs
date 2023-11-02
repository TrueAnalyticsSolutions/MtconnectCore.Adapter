using System;

namespace Mtconnect.AdapterSdk
{
    /// <summary>
    /// Triggered when the <see cref="IAdapterSource"/> has started.
    /// </summary>
    /// <param name="sender">Reference to the <see cref="IAdapterSource"/> that has started.</param>
    /// <param name="e">Reference to event arguments</param>
    public delegate void AdapterSourceStartedHandler(IAdapterSource sender, AdapterSourceStartedEventArgs e);

    /// <summary>
    /// Custom event arguments when an <see cref="IAdapterSource"/> has successfully started.
    /// </summary>
    public class AdapterSourceStartedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of the event arguments for the <see cref="AdapterSourceStartedHandler"/>
        /// </summary>
        public AdapterSourceStartedEventArgs() { }
    }
}
