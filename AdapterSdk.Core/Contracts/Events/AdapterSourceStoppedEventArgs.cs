using System;

namespace Mtconnect.AdapterSdk
{
    /// <summary>
    /// Triggered when the <see cref="IAdapterSource"/> has stopped.
    /// </summary>
    /// <param name="sender">Reference to the <see cref="IAdapterSource"/> that has stopped.</param>
    /// <param name="e">Reference to event arguments</param>
    public delegate void AdapterSourceStoppedHandler(IAdapterSource sender, AdapterSourceStoppedEventArgs e);

    /// <summary>
    /// Custom event arguments when an <see cref="IAdapterSource"/> has successfully stopped.
    /// </summary>
    public class AdapterSourceStoppedEventArgs : EventArgs
    {
        /// <summary>
        /// Optional reference to an exception that may have been thrown, resulting in the stopping of the <see cref="IAdapterSource"/>.
        /// </summary>
        public Exception Exception { get; } = null;

        /// <summary>
        /// Constructs a new instance of the event arguments for the <see cref="AdapterSourceStoppedHandler"/>
        /// </summary>
        public AdapterSourceStoppedEventArgs(Exception exception = null)
        {
            Exception = exception;
        }
    }
}
