////using System;

////namespace Mtconnect
////{
////    /// <summary>
////    /// Triggered when an Adapter instance stops
////    /// </summary>
////    /// <param name="sender">Reference to the Adapter that stopped</param>
////    /// <param name="e">Reference to the event arguments</param>
////    public delegate void AdapterStoppedHandler(Adapter sender, AdapterStoppedEventArgs e);

////    public class AdapterStoppedEventArgs : EventArgs
////    {
////        public Exception Exception { get; } = null;

////        /// <summary>
////        /// Flag for whether or not the Adapter was stopped due to a <see cref="CancellationToken"/>.
////        /// </summary>
////        public bool WasCancelled { get; }

////        public AdapterStoppedEventArgs(Exception exception = null, bool wasCancelled = false)
////        {
////            Exception = exception;
////            WasCancelled = wasCancelled;
////        }
////    }
////}