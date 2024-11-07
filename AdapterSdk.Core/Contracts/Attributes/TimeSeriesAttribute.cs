using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.DataItemTypes;
using System;

namespace Mtconnect.AdapterSdk.Attributes
{
    /// <summary>
    /// A decorative attribute for indicating a property intended to go thru an Adapter stream as an Time Series.
    /// </summary>
    public class TimeSeriesAttribute : DataItemAttribute
    {
        /// <summary>
        /// <inheritdoc cref="TimeSeries.Rate" path="/summary"/>
        /// </summary>
        public double Rate { get; set; }

        /// <inheritdoc />
        public TimeSeriesAttribute(string name, string description = null) : base(name, description) { }
    }
}
