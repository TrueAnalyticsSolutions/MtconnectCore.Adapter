using System;

namespace Mtconnect.AdapterSdk
{
    /// <summary>
    /// Triggered when an Adapter instance starts
    /// </summary>
    /// <param name="sender">Reference to the Adapter that started</param>
    /// <param name="e">Reference to the event arguments</param>
    public delegate void AdapterDataModelReceivedHandler(IAdapter sender, AdapterDataModelReceivedEventArgs e);

    /// <summary>
    /// Custom event that triggers when the <see cref="IAdapter"/> receives a new <see cref="IAdapterDataModel"/>
    /// </summary>
    public class AdapterDataModelReceivedEventArgs : EventArgs
    {
        /// <summary>
        /// Reference to the source of the adapter.
        /// </summary>
        public IAdapterSource Sender { get; }

        /// <summary>
        /// References to the data model that was passed.
        /// </summary>
        public IAdapterDataModel Data { get; }

        /// <summary>
        /// Constructs a new instance of the event trigger.
        /// </summary>
        /// <param name="sender">Reference to the source of the adapter.</param>
        /// <param name="data">Reference to the data model that was passed.</param>
        public AdapterDataModelReceivedEventArgs(IAdapterSource sender, IAdapterDataModel data)
        {
            Sender = sender;
            Data = data;
        }
    }
}