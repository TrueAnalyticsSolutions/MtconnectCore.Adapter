using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;

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
    }
}
