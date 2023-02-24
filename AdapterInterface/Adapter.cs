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
        protected string DATE_TIME_FORMAT => Constants.DATE_TIME_FORMAT;

        /// <summary>
        /// Reference to a logging service.
        /// </summary>
        public readonly ILogger<Adapter> _logger;

        /// <summary>
        /// A unique identifier for the device this Adapter is monitoring. **NOTE**: The same uuid can be referenced in multiple Adapter instances.
        /// </summary>
        public string DeviceUUID { get; set; }

        /// <summary>
        /// Internal collection of <see cref="DataItem"/>s being tracked.
        /// </summary>
        protected Dictionary<string, DataItem> _dataItems = new Dictionary<string, DataItem>();

        /// <summary>
        /// Reference to the collection of <see cref="DataItem"/>s being tracked.
        /// </summary>
        protected IEnumerable<DataItem> DataItems => _dataItems.Values;

        /// <summary>
        /// A queue of <see cref="DataItem"/> changed values that have not been sent to clients.
        /// </summary>
        private ConcurrentQueue<ReportedValue> _values = new ConcurrentQueue<ReportedValue>();

        /// <summary>
        /// Provides a reference to a <see cref="DataItem"/> from the internal collection based on the provided <paramref name="name"/>.
        /// </summary>
        /// <param name="name">Reference to the <see cref="DataItem.Name"/> to lookup.</param>
        /// <returns>Reference to the <see cref="DataItem"/> with the matching <paramref name="name"/>.</returns>
        public DataItem this[string name]
        {
            get { return _dataItems[name]; }
            set
            {
                _dataItems[name] = value;
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
        protected List<IAdapterSource> _sources { get; set; } = new List<IAdapterSource>();

        protected AdapterOptions _options { get; set; }

        /// <summary>
        /// Generic constructor of a new Adapter instance with basic AdapterOptions.
        /// </summary>
        /// <param name="options"><inheritdoc cref="AdapterOptions" path="/summary"/></param>
        /// <param name="loggerFactory">Reference to the logger factory to handle logging.</param>
        public Adapter(AdapterOptions options, ILoggerFactory logFactory = default)
        {
            _options = options;
            DeviceUUID = options.DeviceUUID;
            Heartbeat = options.Heartbeat;
            CanEnqueueDataItems = options.CanEnqueueDataItems;

            _logger = logFactory?.CreateLogger<Adapter>();
        }

        public bool Contains(string dataItemName)
        {
            return _dataItems.ContainsKey(dataItemName);
        }
        public bool Contains(DataItem dataItem)
        {
            return Contains(dataItem.Name);
        }

        /// <summary>
        /// Add a data item to the adapter.
        /// </summary>
        /// <param name="dataItem">The data item.</param>
        /// <exception cref="DuplicateNameException"></exception>
        public void AddDataItem(DataItem dataItem)
        {
            string internalName = dataItem.Name;
            DataItemOptions options = _options[internalName];
            if (options != null)
            {
                internalName = options?.InternalName;
            }

            if (_dataItems.ContainsKey(internalName))
            {
                throw new DuplicateNameException("Adapter cannot handle DataItems with the same name");
            }

            _dataItems.Add(internalName, dataItem);
            _dataItems[internalName].OnDataItemChanged += Adapter_OnDataItemChanged;

            if (options?.Formatter != null)
            {
                _dataItems[internalName].FormatValue = options?.Formatter;
                _logger?.LogDebug("Applying custom formatter to {DataItemName}", options?.DataItemName);
            }

            if (!string.IsNullOrEmpty(options?.DataItemName) && options?.DataItemName != internalName)
                _dataItems[internalName].Name = options?.DataItemName;

            _logger?.LogTrace("Added DataItem {DataItemName}", _dataItems[internalName].Name);
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
            {
                RemoveDataItem(item.Value);
            }
        }

        /// <summary>
        /// Remove a data item from the adapter.
        /// </summary>
        /// <param name="dataItem"></param>
        public void RemoveDataItem(DataItem dataItem)
        {
            if (!_dataItems.ContainsKey(dataItem.Name))
            {
                throw new KeyNotFoundException("No DataItems found with the given name");
            }

            _dataItems.Remove(dataItem.Name);

            var queue = new List<ReportedValue>();
            ReportedValue value = null;
            while (_values.TryDequeue(out value))
            {
                if (!string.Equals(value.DataItemName, dataItem.Name, StringComparison.OrdinalIgnoreCase))
                    queue.Add(value);
            }

            foreach (var item in queue)
            {
                _values.Enqueue(item);
            }
        }

        /// <summary>
        /// Make all data items unavailable
        /// </summary>
        public void Unavailable()
        {
            _logger?.LogTrace("Setting all DataItem values to UNAVAILABLE");
            foreach (var kvp in _dataItems)
                kvp.Value.Unavailable();
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
            foreach (var kvp in _dataItems) kvp.Value.Begin();
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
            _logger?.LogTrace("Sending {DataItemSendType} values", sendType.ToString());

            var values = new List<ReportedValue>();
            switch (sendType)
            {
                case DataItemSendTypes.All:
                    values = DataItems.SelectMany(o => o.ItemList(sendType == DataItemSendTypes.All)).Select(o => new ReportedValue(o)).ToList();
                    // TODO: Clear ConcurrentQueue
                    break;
                case DataItemSendTypes.Changed:
                    var changedDataItems = DataItems
                        .SelectMany(o => o.ItemList(sendType == DataItemSendTypes.Changed))
                        .Where(o => o.HasChanged);
                    values = changedDataItems.Select(o => new ReportedValue(o)).ToList();
                    // TODO: Clear ConcurrentQueue of matching DataItems.
                    break;
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

            _logger?.LogDebug("Sending {AllValueCount}; Individual Values: {IndividualValueCount}; Multiplicity Values: {MultiplicityValueCount};", orderedValues.Count, individualValues.Count, multiplicityValues.Count);

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

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;

            XmlWriter writer = XmlWriter.Create(sb, settings);
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
                _sources.Add(source);
                source.OnAdapterSourceStarted += Source_OnAdapterSourceStarted;
                source.OnAdapterSourceStopped += Source_OnAdapterSourceStopped;
                source.OnDataReceived += _source_OnDataReceived;
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
                var source = _sources.FirstOrDefault(o => o == sender);
                if (source != null)
                {
                    removedSource = _sources.Remove(source);
                }
            }

            // Stop the adapter if the last source was removed.
            if (removedSource && _sources.Count == 0)
            {
                Stop(e.Exception);
            }
        }

        private void _source_OnDataReceived(IAdapterDataModel data, DataReceivedEventArgs e)
        {
            _logger?.LogTrace("Adapter received data model update from {DataModelType}", data.GetType().FullName);
            bool dataItemsAdded = this.TryAddDataItems(data);
            bool dataItemsUpdated = false;
            if (dataItemsAdded && (dataItemsUpdated = this.TryUpdateValues(data)))
            {
                Send(DataItemSendTypes.Changed);
            } else if (dataItemsAdded)
            {
                _logger?.LogWarning("Failed to add DataItems from data model {DataModelType}", data.GetType().FullName);
            } else
            {
                _logger?.LogWarning("Failed to update DataItem values from data model {DataModelType}", data.GetType().FullName);
            }
        }

        /// <summary>
        /// Stop the listener thread and shutdown all client connections. Make sure to call this base method when overriding to ensure any internal properties are properly stopped.
        /// </summary>
        public virtual void Stop(Exception ex = null)
        {
            foreach (var source in _sources)
            {
                source.Stop();
                source.OnAdapterSourceStarted -= Source_OnAdapterSourceStarted;
                source.OnAdapterSourceStopped -= Source_OnAdapterSourceStopped;
                source.OnDataReceived -= _source_OnDataReceived;
            }
            TriggerOnStoppedEvent(ex);
        }

        /// <summary>
        /// Gets a list of the <see cref="DataItem.Name"/>s.
        /// </summary>
        /// <returns>Array of <see cref="DataItem.Name"/>s that are registered in this <see cref="Adapter"/>.</returns>
        public string[] GetDataItemNames() => DataItems?.Select(o => o.Name)?.DefaultIfEmpty().ToArray();

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