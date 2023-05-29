using System;

namespace Mtconnect
{
    /// <summary>
    /// Triggered when an Adapter instance starts
    /// </summary>
    /// <param name="sender">Reference to the Adapter that started</param>
    /// <param name="e">Reference to the event arguments</param>
    public delegate void AdapterDataModelReceivedHandler(Adapter sender, AdapterDataModelReceivedEventArgs e);

    public class AdapterDataModelReceivedEventArgs
        : EventArgs
    {
        public IAdapterSource Sender { get; }

        public IAdapterDataModel Data { get; }


        public AdapterDataModelReceivedEventArgs(IAdapterSource sender, IAdapterDataModel data)
        {
            Sender = sender;
            Data = data;
        }
    }
}