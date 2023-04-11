using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using Microsoft.Extensions.Logging;
using Mtconnect.AdapterInterface.DataItems;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface;
using Mtconnect.AdapterInterface.Assets;
using System.Data;
using System.Collections.Concurrent;
using System.Threading;
using System.Collections;

namespace Mtconnect
{


    /// <summary>
    /// An abstract implementation for a MTConnect adapter
    /// </summary>
    public abstract class Adapter
    {
        /// <summary>
        /// Occurs when the Adapter starts.
        /// </summary>
        public event AdapterStartedHandler OnStarted;

        /// <summary>
        /// Occurs when the Adapter stops.
        /// </summary>
        public event AdapterStoppedHandler OnStopped;

        /// <summary>
        /// Reference to the expected format for DateTime strings
        /// </summary>
        protected internal string DATE_TIME_FORMAT => Constants.DATE_TIME_FORMAT;

        /// <summary>
        /// Reference to a logging service.
        /// </summary>
        public readonly ILogger<Adapter> _logger;

        /// <summary>
        /// A unique identifier for the device this Adapter is monitoring. <b>NOTE</b>: The same uuid can be referenced in multiple Adapter instances.
        /// </summary>
        public string DeviceUUID { get; set; }

        /// <summary>
        /// Internal collection of <see cref="DataItem"/>s being tracked.
        /// </summary>
        protected DataItemLookup _dataItems = new DataItemLookup();

        /// <summary>
        /// Reference to the collection of <see cref="DataItem"/>s being tracked.
        /// </summary>
        public IEnumerable<DataItem> DataItems => _dataItems;

        /// <summary>
        /// A queue of <see cref="DataItem"/> changed values that have not been sent to clients.
        /// </summary>
        private readonly ConcurrentQueue<ReportedValue> _values = new ConcurrentQueue<ReportedValue>();

        /// <summary>
        /// Provides a reference to a <see cref="DataItem"/> from the internal collection based on the provided <paramref name="name"/>.
        /// </summary>
        /// <param name="name"><inheritdoc cref="DataItem.Name" path="/summary"/></param>
        /// <param name="devicePrefix"><inheritdoc cref="DataItem.DevicePrefix" path="/summary"/></param>
        /// <returns>Reference to the <see cref="DataItem"/> with the matching <paramref name="name"/>.</returns>
        public DataItem this[string name, string devicePrefix = null]
        {
            get { return _dataItems[name, devicePrefix ?? string.Empty]; }
            set
            {
                _dataItems[name, devicePrefix] = value;
            }
        }

        /// <summary>
        /// The send changed has begun and we are tracking conditions.
        /// </summary>
        public bool HasBegun { get; protected set; } = false;

        private bool _canEnqueueDataItems = false;
        /// <summary>
        /// Flags whether or not the Adapter can store reported DataItem value from its source. The internal queue can ensure that all values reported from the data source are pushed thru the implemented stream.
        /// <br/><br/>
        /// Setting this to false will automatically send the entire queue thru the stream.
        /// </summary>
        public bool CanEnqueueDataItems
        {
            get { return _canEnqueueDataItems; }
            set
            {
                _canEnqueueDataItems = value;
                if (!_canEnqueueDataItems && _values.Count > 0)
                {
                    Send(DataItemSendTypes.Queued);
                }
            }
        }

        /// <summary>
        /// Flags whether or not the Adapter should validate all DataItems before publishing them.
        /// </summary>
        public bool CanValidateDataItems { get; set; } = false;

        /// <summary>
        /// The heartbeat interval (in milliseconds).
        /// </summary>
        public virtual double Heartbeat { get; protected set; }

        /// <summary>
        /// Indicates what state the MTConnect Adapter is currently in.
        /// </summary>
        public AdapterStates State { get; protected set; } = AdapterStates.NotStarted;

        /// <summary>
        /// An optional reference to an Adapter source. If the Adapter is started with a reference to a source, this is where the reference is maintained.
        /// </summary>
        protected List<IAdapterSource> Sources { get; set; } = new List<IAdapterSource>();

        private HashSet<Type> DataModelTypes { get; set; } = new HashSet<Type>();

        /// <summary>
        /// Reference to the options provided in the constructor.
        /// </summary>
        protected AdapterOptions Options { get; set; }

        /// <summary>
        /// Generic constructor of a new Adapter instance with basic AdapterOptions.
        /// </summary>
        /// <param name="options"><inheritdoc cref="AdapterOptions" path="/summary"/></param>
        /// <param name="logFactory">Reference to the logger factory to handle logging.</param>
        public Adapter(AdapterOptions options, ILoggerFactory logFactory = default)
        {
            Options = options;
            DeviceUUID = options.DeviceUUID;
            Heartbeat = options.Heartbeat;
            CanEnqueueDataItems = options.CanEnqueueDataItems;
            CanValidateDataItems = options.CanValidateDataItems;

            _logger = logFactory?.CreateLogger<Adapter>();
        }

        /// <summary>
        /// Determines whether or not a DataItem with the same <see cref="DataItem.Name"/> (and possibly <see cref="DataItem.DevicePrefix"/> exists in this adapter.
        /// </summary>
        /// <param name="name"><inheritdoc cref="DataItem.Name" path="/summary"/></param>
        /// <param name="devicePrefix"><inheritdoc cref="DataItem.DevicePrefix" path="/summary"/></param>
        /// <returns>Flag for whether or not a <see cref="DataItem"/> was found.</returns>
        public bool Contains(string name, string devicePrefix = null) => _dataItems.Contains(name, devicePrefix);
        /// <summary>
        /// <inheritdoc cref="Contains(string, string)" path="/summary"/>
        /// </summary>
        /// <param name="dataItem"></param>
        /// <returns><inheritdoc cref="Contains(string, string)" path="/returns"/></returns>
        public bool Contains(DataItem dataItem) => _dataItems.Contains(dataItem);

        /// <summary>
        /// Add a data item to the adapter.
        /// </summary>
        /// <param name="dataItem">The data item.</param>
        /// <exception cref="DuplicateNameException"></exception>
        public void AddDataItem(DataItem dataItem)
        {
            string internalName = dataItem.Name;
            string devicePrefix = dataItem.DevicePrefix;
            DataItemOptions options = Options[internalName];

            if (options?.Ignore == true)
            {
                _logger?.LogDebug("Ignoring DataItem '{DataItemName}'", internalName);
                return;
            }

            if (!string.IsNullOrEmpty(options?.InternalName))
                internalName = options?.InternalName;

            if (_dataItems.Contains(internalName, devicePrefix))
                throw new DuplicateNameException("Adapter cannot handle DataItems with the same name");

            _dataItems.Add(dataItem);

            int index = _dataItems.IndexOf(dataItem);
            _dataItems[index].OnDataItemChanged += Adapter_OnDataItemChanged;

            if (options?.Formatter != null)
            {
                _dataItems[index].FormatValue = options?.Formatter;
                _logger?.LogDebug("Applying custom formatter to {DataItemName}", options?.DataItemName);
            }

            if (!string.IsNullOrEmpty(options?.DataItemName) && options?.DataItemName != internalName)
                _dataItems[index].Name = options?.DataItemName;

            _logger?.LogTrace("Added DataItem {DataItemName}", _dataItems[index].Name);
        }

        private void Adapter_OnDataItemChanged(DataItem sender, DataItemChangedEventArgs e)
        {
            _logger?.LogTrace("DataItem '{DataItemName}' changed from '{PreviousValue}' to '{CurrentValue}' at {LastChangedTime}", sender.Name, e.PreviousValue, e.NewValue, e.ChangeTime);
            if (CanEnqueueDataItems) _values.Enqueue(new ReportedValue(sender));
        }

        /// <summary>
        /// Remove all data items.
        /// </summary>
        public void RemoveAllDataItems()
        {
            foreach (var item in _dataItems)
                RemoveDataItem(item);
        }

        /// <summary>
        /// Remove a data item from the adapter.
        /// </summary>
        /// <param name="dataItem"></param>
        public void RemoveDataItem(DataItem dataItem)
        {
            if (!_dataItems.Contains(dataItem))
            {
                throw new KeyNotFoundException("No DataItems found with the given name");
            }

            _dataItems.Remove(dataItem);

            var queue = new List<ReportedValue>();
            while (_values.TryDequeue(out ReportedValue value))
            {
                if (!string.Equals(value.DataItemName, dataItem.Name, StringComparison.OrdinalIgnoreCase))
                    queue.Add(value);
            }

            foreach (var item in queue)
                _values.Enqueue(item);
        }

        /// <summary>
        /// Make all data items unavailable
        /// </summary>
        public void Unavailable(string devicePrefix = null)
        {
            _logger?.LogTrace("Setting all DataItem values to UNAVAILABLE" + (devicePrefix != null ? " for {DevicePrefix}" : ""), devicePrefix);
            _dataItems.Unavailable(devicePrefix);
        }

        public void Cleanup()
        {
            // Cleanup
            foreach (DataItem di in _dataItems) di.Cleanup();
        }
        public void Prepare()
        {
            foreach (var item in _dataItems) item.Prepare();
        }

        /// <summary>
        /// The asks all data items to begin themselves for collection. Only 
        /// required for conditions and should not be called if you are not 
        /// planning on adding all the conditions before you send. If you skip this
        /// the adapter will not perform the mark and sweep.
        /// </summary>
        public void Begin()
        {
            HasBegun = true;
            foreach (var kvp in _dataItems)
                kvp.Begin();
        }

        /// <summary>
        /// Instructs the Adapter to send <see cref="DataItem"/>s based on a type of method.
        /// </summary>
        /// <param name="clientId">Reference to the id of the client to send the <see cref="ReportedValue"/>s to.</param>
        /// <param name="message">The message to send to any listeners to the adapter.</param>
        protected abstract void Write(string message, string clientId = null);

        /// <summary>
        /// Issues a <see cref="Write"/> command to the implementing Adapter for each appropriate <see cref="ReportedValue"/> depending on the provided <paramref name="sendType"/>.
        /// </summary>
        /// <param name="clientId">Reference to the id of the client to send the <see cref="ReportedValue"/>s to.</param>
        /// <param name="sendType">Flag for identifying which <see cref="ReportedValue"/>s to send.</param>
        public virtual void Send(DataItemSendTypes sendType = DataItemSendTypes.Changed, string clientId = null)
        {
            if (HasBegun) Prepare();

            bool onlyChanged = sendType == DataItemSendTypes.Changed;
            _logger?.LogTrace("Sending {DataItemSendType} values", sendType.ToString());

            var values = new List<ReportedValue>();
            switch (sendType)
            {
                case DataItemSendTypes.All:
                case DataItemSendTypes.Changed:
                    var validationExceptions = new List<ValidationResult>();

                    var dataItems = DataItems.SelectMany(o => o.ItemList(!onlyChanged));
                    foreach (var dataItem in dataItems)
                    {
                        bool isValid = dataItem.Validate(out ValidationResult validationResult);

                        validationExceptions.Add(validationResult);

                        if ((!CanValidateDataItems || isValid) && (!onlyChanged || dataItem.HasChanged))
                            values.Add(new ReportedValue(dataItem));
                    }
                    break;
                case DataItemSendTypes.Queued:
                default:
                    while (_values.TryDequeue(out ReportedValue value))
                    {
                        values.Add(value);
                    }
                    break;
            }

            if (values.Any())
            {
                Send(values, clientId);
            }

            Cleanup();
            HasBegun = false;
        }

        /// <summary>
        /// Iterates thru the provided <paramref name="values"/> and issues a <see cref="Write"/> command to the implementing Adapter.
        /// </summary>
        /// <param name="clientId">Reference to the id of the client to send the <see cref="ReportedValue"/>s to.</param>
        /// <param name="values">Collection of <see cref="ReportedValue"/>s to send values.</param>
        protected void Send(IEnumerable<ReportedValue> values, string clientId = null)
        {

            var orderedValues = values.OrderBy(o => o.Timestamp).ToList();
            var individualValues = values.Where(o => o.HasNewLine).ToList();
            var multiplicityValues = orderedValues.Except(individualValues).ToList();

            _logger?.LogTrace("Sending {AllValueCount}; Individual Values: {IndividualValueCount}; Multiplicity Values: {MultiplicityValueCount};", orderedValues.Count, individualValues.Count, multiplicityValues.Count);

            List<string> messages = new List<string>();

            foreach (var item in individualValues) messages.Add($"{item.Timestamp.ToString(DATE_TIME_FORMAT)}|{item}\n");

            if (multiplicityValues.Any())
            {
                var timestampGroups = multiplicityValues.GroupBy(o => o.Timestamp);
                foreach (var grouping in timestampGroups)
                {
                    string contents = string.Join("|", grouping.Select(o => o.ToString()));
                    string timestamp = grouping.Key.ToString(DATE_TIME_FORMAT);
                    messages.Add($"{timestamp}|{contents}\n");
                }
            }

            _logger?.LogTrace("Writing the following messages:\r\n\t{Messages}", string.Join("\r\n\t", messages.ToArray()));
            foreach (string message in messages) Write(message, clientId);
        }

        /// <summary>
        /// Send a new asset to the Agent
        /// </summary>
        /// <param name="asset">The asset</param>
        public virtual void AddAsset(Asset asset)
        {
            StringBuilder sb = new StringBuilder();

            DateTime now = TimeHelper.GetNow();
            sb.Append(now.ToString(DATE_TIME_FORMAT));
            sb.Append("|@ASSET@|");
            sb.Append(asset.AssetId);
            sb.Append('|');
            sb.Append(asset.GetMTCType());
            sb.Append("|--multiline--ABCD\n");

            var settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = true
            };

            var writer = XmlWriter.Create(sb, settings);
            asset.ToXml(writer);
            writer.Close();
            sb.Append("\n--multiline--ABCD\n");

            Write(sb.ToString());
        }

        /// <summary>
        /// Start the listener thread.
        /// </summary>
        /// <param name="begin">Flag for whether or not to also call <see cref="Begin"/>.</param>
        /// <param name="token">Reference to a cancellation token that is capable of cancelling the Adapter operation</param>
        protected abstract void Start(bool begin = true, CancellationToken token = default);

        /// <summary>
        /// Starts the listener thread and the provided <see cref="IAdapterSource"/>.
        /// </summary>
        /// <param name="source">Reference to the source of the Adapter.</param>
        /// <param name="begin">Flag for whether or not to also call <see cref="Begin"/>.</param>
        /// <param name="token">Reference to a cancellation token that is capable of cancelling the Adapter operation</param>
        public void Start<T>(T source, bool begin = true, CancellationToken token = default) where T : class, IAdapterSource
            => Start(new IAdapterSource[] { source }, begin, token);

        /// <summary>
        /// Starts the listener thread and the provided <see cref="IAdapterSource"/>s.
        /// </summary>
        /// <param name="sources">Reference to the sources of the Adapter.</param>
        /// <param name="begin"><inheritdoc cref="Start{T}(T, bool)" path="/param[@name='begin']"/></param>
        /// <param name="token">Reference to a cancellation token that is capable of cancelling the Adapter operation</param>
        public void Start(IEnumerable<IAdapterSource> sources, bool begin = true, CancellationToken token = default)
        {
            Start(begin, token);

            foreach (var source in sources)
            {
                Sources.Add(source);
                source.OnAdapterSourceStarted += Source_OnAdapterSourceStarted;
                source.OnAdapterSourceStopped += Source_OnAdapterSourceStopped;
                source.OnDataReceived += Source_OnDataReceived;
                source.Start(token);
            }
            TriggerOnStartedEvent();
        }

        private void Source_OnAdapterSourceStarted(IAdapterSource sender, AdapterSourceStartedEventArgs e)
        {
            _logger?.LogInformation("Adapter's Source {AdapterSourceType} has started", sender.GetType().FullName);
        }

        private void Source_OnAdapterSourceStopped(IAdapterSource sender, AdapterSourceStoppedEventArgs e)
        {
            bool removedSource = false;
            if (e.Exception != null)
            {
                var source = Sources.FirstOrDefault(o => o == sender);
                if (source != null)
                {
                    removedSource = Sources.Remove(source);
                }
            }

            // Stop the adapter if the last source was removed.
            if (removedSource && Sources.Count == 0)
            {
                Stop(e.Exception);
            }
        }

        private void Source_OnDataReceived(IAdapterDataModel data, DataReceivedEventArgs e)
        {
            _logger?.LogTrace("Adapter received data model update from {DataModelType}", data.GetType().FullName);

            if (!DataModelTypes.Contains(data.GetType()))
                DataModelTypes.Add(data.GetType());

            bool dataItemsAdded = this.TryAddDataItems(data);
            if (dataItemsAdded && (_ = this.TryUpdateValues(data)))
            {
                Send(DataItemSendTypes.Changed);
            }
            else if (dataItemsAdded)
            {
                _logger?.LogWarning("Failed to add DataItems from data model {DataModelType}", data.GetType().FullName);
            }
            else
            {
                _logger?.LogWarning("Failed to update DataItem values from data model {DataModelType}", data.GetType().FullName);
            }
        }

        /// <summary>
        /// Stop the listener thread and shutdown all client connections. Make sure to call this base method when overriding to ensure any internal properties are properly stopped.
        /// </summary>
        public virtual void Stop(Exception ex = null)
        {
            foreach (var source in Sources)
            {
                source.Stop();
                source.OnAdapterSourceStarted -= Source_OnAdapterSourceStarted;
                source.OnAdapterSourceStopped -= Source_OnAdapterSourceStopped;
                source.OnDataReceived -= Source_OnDataReceived;
            }
            TriggerOnStoppedEvent(ex);
        }

        /// <summary>
        /// Gets a list of the <see cref="DataItem.Name"/>s.
        /// </summary>
        /// <returns>Array of <see cref="DataItem.Name"/>s that are registered in this <see cref="Adapter"/>.</returns>
        public string[] GetDataItemNames() => DataItems?.Select(o => o.Name)?.DefaultIfEmpty().ToArray();

        public Type[] GetDataModelTypes() => DataModelTypes.ToArray();

        /// <summary>
        /// Handle an incoming command from a client.
        /// </summary>
        /// <param name="command">Reference to the incoming message command.</param>
        /// <param name="clientId">Reference to the client that sent the command</param>
        /// <returns>Flag for whether or not the command was handled with a response</returns>
        public virtual bool HandleCommand(string command, string clientId = null)
        {
            var response = AdapterCommands.GetResponse(this, command);
            if (!string.IsNullOrEmpty(response))
            {
                Write($"{response}\n", clientId);
                return true;
            }

            return false;
        }
    
        /// <summary>
        /// Triggers the <see cref="OnStarted"/> event.
        /// </summary>
        protected void TriggerOnStartedEvent()
        {
            OnStarted?.Invoke(this, new AdapterStartedEventArgs() { DataItemCount = _dataItems.Count });
        }
        /// <summary>
        /// Triggers the <see cref="OnStopped"/> event.
        /// </summary>
        /// <param name="ex">Reference to an exception that may have caused the Adapter to be stopped.</param>
        /// <param name="wasCancelled">Reference to whether or not a <see cref="CancellationToken"/> was the source of the Adapter stopping.</param>
        protected void TriggerOnStoppedEvent(Exception ex = null, bool wasCancelled = false)
        {
            OnStopped?.Invoke(this, new AdapterStoppedEventArgs(ex, wasCancelled));
        }
    }
}