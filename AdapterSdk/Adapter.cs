using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.Assets;
using System.Data;
using System.Collections.Concurrent;
using System.Threading;

namespace Mtconnect.AdapterSdk
{
    /// <inheritdoc/>
    public abstract class Adapter : IAdapter
    {
        /// <inheritdoc/>
        public event AdapterDataModelReceivedHandler OnDataModelRecieved;

        /// <inheritdoc/>
        public event AdapterStartedHandler OnStarted;

        /// <inheritdoc/>
        public event AdapterStoppedHandler OnStopped;

        /// <summary>
        /// Reference to the expected format for DateTime strings
        /// </summary>
        protected internal string DATE_TIME_FORMAT => Constants.DATE_TIME_FORMAT;

        /// <inheritdoc/>
        public IAdapterLogger _logger { get; internal set; }

        /// <inheritdoc/>
        public string DeviceUUID { get; set; }

        /// <inheritdoc/>
        public string DeviceName { get; set; }

        /// <inheritdoc/>
        public string StationId { get; set; }

        /// <inheritdoc/>
        public string SerialNumber { get; set; } = null;

        /// <inheritdoc/>
        public string Manufacturer { get; set; } = null;

        /// <summary>
        /// Internal collection of <see cref="DataItem"/>s being tracked.
        /// </summary>
        protected DataItemLookup _dataItems = new DataItemLookup();

        /// <inheritdoc/>
        public IEnumerable<IDataItem> DataItems => _dataItems;

        /// <summary>
        /// A queue of <see cref="DataItem"/> changed values that have not been sent to clients.
        /// </summary>
        private readonly ConcurrentQueue<ReportedValue> _values = new ConcurrentQueue<ReportedValue>();

        /// <inheritdoc/>
        public IDataItem this[string name, string devicePrefix = null]
        {
            get { return _dataItems[name, devicePrefix ?? string.Empty]; }
            set
            {
                _dataItems[name, devicePrefix] = value;
            }
        }

        /// <inheritdoc/>
        public bool HasBegun { get; protected set; } = false;

        private bool _canEnqueueDataItems = false;
        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public bool CanValidateDataItems { get; set; } = false;

        /// <inheritdoc/>
        public virtual double Heartbeat { get; protected set; }

        /// <inheritdoc/>
        public AdapterStates State { get; protected set; } = AdapterStates.NotStarted;

        /// <inheritdoc/>
        public List<IAdapterSource> Sources { get; protected set; } = new List<IAdapterSource>();

        private HashSet<Type> DataModelTypes { get; set; } = new HashSet<Type>();

        /// <inheritdoc/>
        public IAdapterOptions Options { get; protected set; }

        /// <summary>
        /// Generic constructor of a new Adapter instance with basic AdapterOptions.
        /// </summary>
        /// <param name="options"><inheritdoc cref="AdapterOptions" path="/summary"/></param>
        /// <param name="logger">Reference to the logger factory to handle logging.</param>
        public Adapter(AdapterOptions options, IAdapterLogger logger = default)
        {
            Options = options;
            DeviceUUID = options.DeviceUUID;
            StationId = options.StationId;
            SerialNumber = options.SerialNumber;
            Manufacturer = options.Manufacturer;
            Heartbeat = options.Heartbeat;
            CanEnqueueDataItems = options.CanEnqueueDataItems;
            CanValidateDataItems = options.CanValidateDataItems;

            _logger = logger;
        }

        /// <inheritdoc/>
        public bool Contains(string name, string devicePrefix = null) => _dataItems.Contains(name, devicePrefix);
        /// <inheritdoc/>
        public bool Contains(IDataItem dataItem) => _dataItems.Contains(dataItem);

        /// <inheritdoc/>
        public void AddDataItem(IDataItem dataItem)
        {
            string internalName = dataItem.Name;
            string devicePrefix = dataItem.DevicePrefix;
            IDataItemOptions options = Options[internalName];

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

        private void Adapter_OnDataItemChanged(IDataItem sender, DataItemChangedEventArgs e)
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

        /// <inheritdoc/>
        public void RemoveDataItem(IDataItem dataItem)
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

        /// <inheritdoc/>
        public void Unavailable(string devicePrefix = null)
        {
            _logger?.LogTrace("Setting all DataItem values to UNAVAILABLE" + (devicePrefix != null ? " for {DevicePrefix}" : ""), devicePrefix);
            _dataItems.Unavailable(devicePrefix);
        }

        /// <inheritdoc/>
        public void Cleanup()
        {
            // Cleanup
            foreach (DataItem di in _dataItems) di.Cleanup();
        }

        /// <inheritdoc/>
        public void Prepare()
        {
            foreach (var item in _dataItems) item.Prepare();
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public virtual void AddAsset(IAsset asset)
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

        /// <inheritdoc/>
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

                UpdateDeviceInformation(source);
            }
            TriggerOnStartedEvent();
        }

        #region IAdapterSource/IAdapterDataModel Processing
        private void UpdateDeviceInformation(IAdapterSource sender)
        {
            const string failedAccess = "Failed to get device information";
            Exception innerException = null;

            if (string.IsNullOrEmpty(DeviceUUID = TryGetDeviceInformation(sender, (e) => e?.DeviceUuid, out innerException)) || innerException != null)
                _logger?.LogError(new Exception(failedAccess, innerException), innerException.ToString());

            if (string.IsNullOrEmpty(StationId = TryGetDeviceInformation(sender, (e) => e?.StationId, out innerException)) || innerException != null)
                _logger?.LogError(new Exception(failedAccess, innerException), innerException.ToString());

            if (string.IsNullOrEmpty(SerialNumber = TryGetDeviceInformation(sender, (e) => e?.SerialNumber, out innerException)) || innerException != null)
                _logger?.LogError(new Exception(failedAccess, innerException), innerException.ToString());

            if (string.IsNullOrEmpty(Manufacturer = TryGetDeviceInformation(sender, (e) => e?.Manufacturer, out innerException)) || innerException != null)
                _logger?.LogError(new Exception(failedAccess, innerException), innerException.ToString());
        }
        private T TryGetDeviceInformation<T>(IAdapterSource sender, Func<IAdapterSource, T> getter, out Exception exception)
        {
            exception = null;

            if (sender == null)
                return default(T);

            if (getter == null)
                return default(T);

            try
            {
                return getter(sender);
            }
            catch(Exception ex)
            {
                exception = ex;
            }
            return default(T);
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

        private void Source_OnDataReceived(IAdapterSource sender, DataReceivedEventArgs e)
        {
            Type modelType = e?.Data?.GetType();
            if (modelType == null)
                throw new ArgumentNullException(nameof(e));

            _logger?.LogTrace("Adapter received data model update from {DataModelType}", modelType.FullName);

            if (!DataModelTypes.Contains(modelType))
            {
                DataModelTypes.Add(modelType);

                // Update device information like DeviceUuid, SerialNumber, Manufacturer
                UpdateDeviceInformation(sender);

                OnDataModelRecieved?.Invoke(this, new AdapterDataModelReceivedEventArgs(sender, e.Data));
            }

            bool dataItemsAdded = this.TryAddDataItems(e.Data);
            if (dataItemsAdded && (_ = this.TryUpdateValues(e.Data)))
            {
                Send(DataItemSendTypes.Changed);
            }
            else if (dataItemsAdded)
            {
                _logger?.LogWarning("Failed to add DataItems from data model {DataModelType}", modelType.FullName);
            }
            else
            {
                _logger?.LogWarning("Failed to update DataItem values from data model {DataModelType}", modelType.FullName);
            }
        }
        #endregion

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public string[] GetDataItemNames() => DataItems?.Select(o => o.Name)?.DefaultIfEmpty().ToArray();

        /// <inheritdoc/>
        public Type[] GetDataModelTypes() => DataModelTypes.ToArray();

        /// <inheritdoc/>
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