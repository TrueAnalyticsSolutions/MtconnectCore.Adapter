using System;
using System.Xml.Linq;

namespace Mtconnect.AdapterSdk.DataItems
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

        private string Output { get; }

        /// <summary>
        /// Constructs a new instance of a reported <see cref="DataItem"/> value.
        /// </summary>
        /// <param name="dataItem">Reference to the source DataItem</param>
        public ReportedValue(DataItem dataItem)
        {
            DevicePrefix = dataItem.DevicePrefix;
            DataItemName = dataItem.Name;
            Value = dataItem.Value;
            Timestamp = dataItem.LastChanged.GetValueOrDefault(); // TODO: Replace with null-check TimeHelper.GetNow()
            HasNewLine = dataItem.HasNewLine;

            Output = dataItem.ToString().RemoveControlCharacters();
        }

        /// <inheritdoc />
        public override string ToString() => Output;
    }
}
