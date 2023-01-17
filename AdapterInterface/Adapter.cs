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
using System.Reflection;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using System.Diagnostics.Tracing;
using EventAttribute = Mtconnect.AdapterInterface.Contracts.Attributes.EventAttribute;

namespace Mtconnect
{

    /// <summary>
    /// An abstract implementation for a MTConnect adapter
    /// </summary>
    public abstract class Adapter
    {
        /// <summary>
        /// Reference to a logging service.
        /// </summary>
        protected readonly ILogger<Adapter> _logger;

        /// <summary>
        /// The * PONG ... text
        /// </summary>
        protected byte[] PONG { get; set; }

        /// <summary>
        /// Internal collection of <see cref="DataItem"/>s being tracked.
        /// </summary>
        private Dictionary<string, DataItem> _dataItems = new Dictionary<string, DataItem>();

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
        /// The ascii encoder for creating the messages.
        /// </summary>
        protected ASCIIEncoding Encoder { get; } = new ASCIIEncoding();

        /// <summary>
        /// The heartbeat interval.
        /// </summary>
        private double _heartbeat;
        /// <summary>
        /// This is a method to set the heartbeat interval given in milliseconds.
        /// </summary>
        public virtual double Heartbeat
        {
            get { return _heartbeat; }
            set
            {
                _heartbeat = value;
                PONG = Encoder.GetBytes($"* PONG {_heartbeat}\n");
            }
        }

        /// <summary>
        /// Indicates what state the MTConnect Adapter is currently in.
        /// </summary>
        public AdapterStates State { get; protected set; } = AdapterStates.NotStarted;

        /// <summary>
        /// An optional reference to an Adapter source. If the Adapter is started with a reference to a source, this is where the reference is maintained.
        /// </summary>
        private List<IAdapterSource> _sources { get; set; } = new List<IAdapterSource>();

        private AdapterOptions _options { get; set; }

        /// <summary>
        /// Generic constructor of a new Adapter instance with basic AdapterOptions.
        /// </summary>
        /// <param name="options"><inheritdoc cref="AdapterOptions" path="/summary"/></param>
        /// <param name="loggerFactory">Reference to the logger factory to handle logging.</param>
        public Adapter(AdapterOptions options, ILogger<Adapter> logger = null)
        {
            _options = options;
            Heartbeat = options.Heartbeat;
            CanEnqueueDataItems = options.CanEnqueueDataItems;

            _logger = logger;
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

            _dataItems[internalName].FormatValue = options?.Formatter;
            if (!string.IsNullOrEmpty(options?.DataItemName) && options?.DataItemName != internalName)
                _dataItems[internalName].Name = options?.DataItemName;
        }

        private void Adapter_OnDataItemChanged(DataItem sender, DataItemChangedEventArgs e)
        {
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
            var values = new List<ReportedValue>();
            switch (sendType)
            {
                case DataItemSendTypes.All:
                    values = DataItems.SelectMany(o => o.ItemList(sendType == DataItemSendTypes.All)).Select(o => new ReportedValue(o)).ToList();
                    // TODO: Clear ConcurrentQueue
                    break;
                case DataItemSendTypes.Changed:
                    var changedDataItems = DataItems
                        .SelectMany(o => o.ItemList(sendType == DataItemSendTypes.All))
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
            _logger?.LogTrace($"Sending {values.Count()} values");

            var orderedValues = values.OrderBy(o => o.Timestamp).ToList();
            var individualValues = values.Where(o => o.HasNewLine).ToList();
            var multiplicityValues = orderedValues.Except(individualValues).ToList();

            foreach (var item in individualValues)
            {
                Write($"{item.Timestamp}|{item}\n", clientId);
            }

            if (multiplicityValues.Any())
            {
                var timestampGroups = multiplicityValues.GroupBy(o => o.Timestamp);
                foreach (var grouping in timestampGroups)
                {
                    string contents = string.Join("|", grouping.Select(o => o.ToString()));
                    string timestamp = grouping.Key.ToString(Constants.DATE_TIME_FORMAT);
                    Write($"{timestamp}|{contents}\n", clientId);
                }
            }
        }

        /// <summary>
        /// Send a new asset to the Agent
        /// </summary>
        /// <param name="asset">The asset</param>
        public virtual void AddAsset(Asset asset)
        {
            StringBuilder sb = new StringBuilder();

            DateTime now = DateTime.UtcNow;
            sb.Append(now.ToString(Constants.DATE_TIME_FORMAT));
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
        
        ///// <summary>
        ///// The heartbeat thread for a client. This thread receives data from a client, closes the socket when it fails, and handles communication timeouts when the client does not send a heartbeat within 2x the heartbeat frequency. When the heartbeat is not received, the client is assumed to be unresponsive and the connection is closed. Waits for one ping to be received before enforcing the timeout. 
        ///// </summary>
        ///// <param name="client">The client we are communicating with.</param>
        //protected abstract void HeartbeatClient(object client);

        /// <summary>
        /// Start the listener thread.
        /// </summary>
        /// <param name="begin">Flag for whether or not to also call <see cref="Begin"/>.</param>
        public abstract void Start(bool begin = true);

        /// <summary>
        /// Starts the listener thread and the provided <see cref="IAdapterSource"/>.
        /// </summary>
        /// <param name="source">Reference to the source of the Adapter.</param>
        /// <param name="begin">Flag for whether or not to also call <see cref="Begin"/>.</param>
        public void Start<T>(T source, bool begin = true) where T : class, IAdapterSource
            => Start(new IAdapterSource[] { source }, begin);

        /// <summary>
        /// Starts the listener thread and the provided <see cref="IAdapterSource"/>s.
        /// </summary>
        /// <param name="sources">Reference to the sources of the Adapter.</param>
        /// <param name="begin"><inheritdoc cref="Start{T}(T, bool)" path="/param[@name='begin']"/></param>
        public void Start(IEnumerable<IAdapterSource> sources, bool begin = true)
        {
            Start(begin);

            foreach (var source in sources)
            {
                AddSource(source);
                source.Start();
            }
        }

        private void AddSource<T>(T source) where T : class, IAdapterSource
        {
            _sources.Add(source);
            source.OnDataReceived += _source_OnDataReceived;

            Type sourceType = source.GetType();
            AddDataItemsFromSource(sourceType);
        }

        /// <summary>
        /// Adds Data Items from properties in the <paramref name="sourceType"/> that are decorated with the <see cref="DataItemAttribute"/>.
        /// </summary>
        /// <param name="sourceType">Reference to the type to perform reflection on.</param>
        /// <param name="dataItemPrefix">A recursive prefix for the Data Item names.</param>
        private void AddDataItemsFromSource(Type sourceType, string dataItemPrefix = "")
        {
            // TODO: Cache the property map
            var properties = sourceType.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .ToArray();
            var dataItemProperties = properties
                .Where(o => o.GetCustomAttribute(typeof(DataItemAttribute)) != null)
                .ToArray();
            foreach (var property in dataItemProperties)
            {
                var dataItemAttribute = property.GetCustomAttribute<DataItemAttribute>();
                string dataItemName = dataItemPrefix + dataItemAttribute.Name;

                switch (dataItemAttribute)
                {
                    case DataItemPartialAttribute _:
                        AddDataItemsFromSource(property.PropertyType, dataItemName);
                        break;
                    case EventAttribute _:
                        AddDataItem(new Event(dataItemName));
                        break;
                    case SampleAttribute _:
                        AddDataItem(new Sample(dataItemName));
                        break;
                    case ConditionAttribute _:
                        AddDataItem(new Condition(dataItemName));
                        break;
                    case TimeSeriesAttribute _:
                        AddDataItem(new TimeSeries(dataItemName));
                        break;
                    case MessageAttribute _:
                        AddDataItem(new Message(dataItemName));
                        break;
                    default:
                        break;
                }
            }
        }

        private void _source_OnDataReceived(object sender, DataReceivedEventArgs e)
        {
            updateValuesFromSource(sender);

            Send(DataItemSendTypes.Changed);
        }

        /// <summary>
        /// A recursive method for reflecting on the properties of the <paramref name="source"/>.
        /// </summary>
        /// <param name="source">Reference to the source object. This value will change throughout the recursion.</param>
        /// <param name="dataItemPrefix">As the Data Item Prefix</param>
        private void updateValuesFromSource(object source, string dataItemPrefix = "")
        {
            // TODO: Cache the property map
            Type sourceType = source.GetType();
            var dataItemProperties = sourceType.GetProperties().Where(o => o.GetCustomAttribute(typeof(DataItemAttribute)) != null);
            foreach (var property in dataItemProperties)
            {
                var dataItemAttribute = property.GetCustomAttribute<DataItemAttribute>();
                string dataItemName = dataItemPrefix + dataItemAttribute.Name;
                switch (dataItemAttribute)
                {
                    case DataItemPartialAttribute _:
                        updateValuesFromSource(property.GetValue(source), dataItemName);
                        break;
                    case EventAttribute _:
                    case SampleAttribute _:
                    case ConditionAttribute _:
                    case TimeSeriesAttribute _:
                    case MessageAttribute _:
                        this[dataItemName].Value = property.GetValue(source);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Stop the listener thread and shutdown all client connections. Make sure to call this base method when overriding to ensure any internal properties are properly stopped.
        /// </summary>
        public virtual void Stop()
        {
            foreach (var source in _sources)
            {
                source.Stop();
            }
        }
    }
}