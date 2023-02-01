using System;
using System.Xml.Linq;

namespace Mtconnect.AdapterInterface.DataItems
{
    /// <summary>
    /// Represents the instance of a <see cref="DataItem"/> changing.
    /// </summary>
    public class ReportedValue
    {
        /// <inheritdoc cref="DataItem.DevicePrefix"/>
        public string DevicePrefix = null;

        /// <inheritdoc cref="DataItem.Name"/>
        public string DataItemName { get; }

        /// <inheritdoc cref="DataItem.Value"/>
        public object Value { get; }

        /// <inheritdoc cref="DataItem.LastChanged"/>
        public DateTime Timestamp { get; }

        /// <inheritdoc cref="DataItem.HasNewLine"/>
        public bool HasNewLine { get; }

        private string _output { get; }

        /// <summary>
        /// Constructs a new instance of a reported <see cref="DataItem"/> value.
        /// </summary>
        /// <param name="dataItem">Reference to the source DataItem</param>
        public ReportedValue(DataItem dataItem)
        {
            DevicePrefix = dataItem.DevicePrefix;
            DataItemName = dataItem.Name;
            Value = dataItem.Value;
            Timestamp = dataItem.LastChanged.GetValueOrDefault();
            HasNewLine = dataItem.HasNewLine;

            _output = dataItem.ToString();
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return _output;
            string result = string.Empty;

            if (DevicePrefix != null) result += $"{DevicePrefix}:";
            result += $"{DataItemName}|{Value}";

            return result;
        }
    }
}
