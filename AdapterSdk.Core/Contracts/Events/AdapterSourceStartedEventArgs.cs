using System;

namespace Mtconnect.AdapterSdk
{
    /// <summary>
    /// Triggered when the <see cref="IAdapterSource"/> has started.
    /// </summary>
    /// <param name="sender">Reference to the <see cref="IAdapterSource"/> that has started.</param>
    /// <param name="e">Reference to event arguments</param>
    public delegate void AdapterSourceStartedHandler(IAdapterSource sender, AdapterSourceStartedEventArgs e);

    public class AdapterSourceStartedEventArgs : EventArgs
    {
        public AdapterSourceStartedEventArgs()
        {

        }
    }
}
