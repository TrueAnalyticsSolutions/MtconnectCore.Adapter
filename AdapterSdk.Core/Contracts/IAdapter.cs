using Microsoft.Extensions.Logging;
using Mtconnect.AdapterSdk.Assets;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;

namespace Mtconnect.AdapterSdk.Contracts
{
    /// <summary>
    /// An abstract implementation for a MTConnect adapter
    /// </summary>
    public interface IAdapter
    {
        /// <summary>
        /// Occurs when the Adapter receives a new <see cref="IAdapterDataModel"/>.
        /// </summary>
        event AdapterDataModelReceivedHandler OnDataModelRecieved;

        /// <summary>
        /// Occurs when the Adapter starts.
        /// </summary>
        event AdapterStartedHandler OnStarted;

        /// <summary>
        /// Occurs when the Adapter stops.
        /// </summary>
        event AdapterStoppedHandler OnStopped;

        /// <summary>
        /// Reference to a logging service.
        /// </summary>
        ILogger<IAdapter> _logger { get; }

        /// <summary>
        /// A unique identifier for the device this Adapter is monitoring. <b>NOTE</b>: The same uuid can be referenced in multiple Adapter instances.
        /// </summary>
        string DeviceUUID { get; set; }

        /// <summary>
        /// The name of the deivce.
        /// </summary>
        string DeviceName { get; set; }

        /// <summary>
        /// An identifier for known location of the device. For example, this could be a reference to the workstation. The default options set this to the computer name where the adapter is deployed.
        /// </summary>
        string StationId { get; set; }

        /// <summary>
        /// A reference to the device's serial number, if applicable.
        /// </summary>
        string SerialNumber { get; set; }

        /// <summary>
        /// A reference to the manufacturer of the device.
        /// </summary>
        string Manufacturer { get; set; }

        /// <summary>
        /// Reference to the collection of <see cref="IDataItem"/>s being tracked.
        /// </summary>
        IEnumerable<IDataItem> DataItems { get; }

        /// <summary>
        /// The send changed has begun and we are tracking conditions.
        /// </summary>
        bool HasBegun { get; }

        /// <summary>
        /// Flags whether or not the Adapter can store reported DataItem value from its source. The internal queue can ensure that all values reported from the data source are pushed thru the implemented stream.
        /// <br/><br/>
        /// Setting this to false will automatically send the entire queue thru the stream.
        /// </summary>
        bool CanEnqueueDataItems { get; set; }
        
        /// <summary>
        /// Flags whether or not the Adapter should validate all DataItems before publishing them.
        /// </summary>
        bool CanValidateDataItems { get; set; }

        /// <summary>
        /// The heartbeat interval (in milliseconds).
        /// </summary>
        double Heartbeat { get; }

        /// <summary>
        /// Indicates what state the MTConnect Adapter is currently in.
        /// </summary>
        AdapterStates State { get; }

        /// <summary>
        /// An optional reference to an Adapter source. If the Adapter is started with a reference to a source, this is where the reference is maintained.
        /// </summary>
        List<IAdapterSource> Sources { get; }

        /// <summary>
        /// Reference to the options provided in the constructor.
        /// </summary>
        IAdapterOptions Options { get; }

        /// <summary>
        /// Provides a reference to a <see cref="IDataItem"/> from the internal collection based on the provided <paramref name="name"/>.
        /// </summary>
        /// <param name="name"><inheritdoc cref="IDataItem.Name" path="/summary"/></param>
        /// <param name="devicePrefix"><inheritdoc cref="IDataItem.DevicePrefix" path="/summary"/></param>
        /// <returns>Reference to the <see cref="IDataItem"/> with the matching <paramref name="name"/>.</returns>
        IDataItem this[string name, string devicePrefix = null] { get; set; }

        /// <summary>
        /// Determines whether or not a DataItem with the same <see cref="IDataItem.Name"/> (and possibly <see cref="IDataItem.DevicePrefix"/> exists in this adapter.
        /// </summary>
        /// <param name="name"><inheritdoc cref="IDataItem.Name" path="/summary"/></param>
        /// <param name="devicePrefix"><inheritdoc cref="IDataItem.DevicePrefix" path="/summary"/></param>
        /// <returns>Flag for whether or not a <see cref="IDataItem"/> was found.</returns>
        bool Contains(string name, string devicePrefix = null);

        /// <summary>
        /// <inheritdoc cref="Contains(string, string)" path="/summary"/>
        /// </summary>
        /// <param name="dataItem"></param>
        /// <returns><inheritdoc cref="Contains(string, string)" path="/returns"/></returns>
        bool Contains(IDataItem dataItem);

        /// <summary>
        /// Add a data item to the adapter.
        /// </summary>
        /// <param name="dataItem">The data item.</param>
        /// <exception cref="DuplicateNameException"></exception>
        void AddDataItem(IDataItem dataItem);

        /// <summary>
        /// Remove all data items.
        /// </summary>
        void RemoveAllDataItems();

        /// <summary>
        /// Remove a data item from the adapter.
        /// </summary>
        /// <param name="dataItem"></param>
        void RemoveDataItem(IDataItem dataItem);

        /// <summary>
        /// Make all data items unavailable
        /// </summary>
        void Unavailable(string devicePrefix = null);

        void Cleanup();
        void Prepare();


        /// <summary>
        /// The asks all data items to begin themselves for collection. Only 
        /// required for conditions and should not be called if you are not 
        /// planning on adding all the conditions before you send. If you skip this
        /// the adapter will not perform the mark and sweep.
        /// </summary>
        void Begin();

        /// <summary>
        /// Issues a <see cref="Write"/> command to the implementing Adapter for each appropriate <see cref="ReportedValue"/> depending on the provided <paramref name="sendType"/>.
        /// </summary>
        /// <param name="clientId">Reference to the id of the client to send the <see cref="ReportedValue"/>s to.</param>
        /// <param name="sendType">Flag for identifying which <see cref="ReportedValue"/>s to send.</param>
        void Send(DataItemSendTypes sendType = DataItemSendTypes.Changed, string clientId = null);

        /// <summary>
        /// Send a new asset to the Agent
        /// </summary>
        /// <param name="asset">The asset</param>
        void AddAsset(IAsset asset);

        /// <summary>
        /// Starts the listener thread and the provided <see cref="IAdapterSource"/>s.
        /// </summary>
        /// <param name="sources">Reference to the sources of the Adapter.</param>
        /// <param name="begin"><inheritdoc cref="Start{T}(T, bool)" path="/param[@name='begin']"/></param>
        /// <param name="token">Reference to a cancellation token that is capable of cancelling the Adapter operation</param>
        void Start(IEnumerable<IAdapterSource> sources, bool begin = true, CancellationToken token = default);

        /// <summary>
        /// Stop the listener thread and shutdown all client connections. Make sure to call this base method when overriding to ensure any internal properties are properly stopped.
        /// </summary>
        void Stop(Exception ex = null);

        /// <summary>
        /// Gets a list of the <see cref="IDataItem.Name"/>s.
        /// </summary>
        /// <returns>Array of <see cref="IDataItem.Name"/>s that are registered in this <see cref="IAdapter"/>.</returns>
        string[] GetDataItemNames();

        Type[] GetDataModelTypes();

        /// <summary>
        /// Handle an incoming command from a client.
        /// </summary>
        /// <param name="command">Reference to the incoming message command.</param>
        /// <param name="clientId">Reference to the client that sent the command</param>
        /// <returns>Flag for whether or not the command was handled with a response</returns>
        bool HandleCommand(string command, string clientId = null);
    }
}
