using System;
using System.Threading;

namespace Mtconnect.AdapterSdk
{
    /// <summary>
    /// Triggered when an Adapter instance stops
    /// </summary>
    /// <param name="sender">Reference to the Adapter that stopped</param>
    /// <param name="e">Reference to the event arguments</param>
    public delegate void AdapterStoppedHandler(IAdapter sender, AdapterStoppedEventArgs e);

    /// <summary>
    /// Custom event arguments when an <see cref="IAdapter"/> has successfully stopped.
    /// </summary>
    public class AdapterStoppedEventArgs : EventArgs
    {
        /// <summary>
        /// Optional reference to an exception that may have been thrown, resulting in the stopping of the <see cref="IAdapter"/>.
        /// </summary>
        public Exception Exception { get; } = null;

        /// <summary>
        /// Flag for whether or not the Adapter was stopped due to a <see cref="CancellationToken"/>.
        /// </summary>
        public bool WasCancelled { get; }

        /// <summary>
        /// Constructs a new instance of the event arguments for the <see cref="AdapterStoppedHandler"/>
        /// </summary>
        /// <param name="exception"><inheritdoc cref="Exception" path="/summary"/></param>
        /// <param name="wasCancelled"><inheritdoc cref="WasCancelled" path="/summary"/></param>
        public AdapterStoppedEventArgs(Exception exception = null, bool wasCancelled = false)
        {
            Exception = exception;
            WasCancelled = wasCancelled;
        }
    }
}