using Mtconnect.AdapterSdk.DataItemTypes;
using System;

namespace Mtconnect.AdapterSdk.Contracts.Attributes
{
    /// <summary>
    /// A decorative attribute for indicating a property intended to go thru an Adapter stream as an Time Series.
    /// </summary>
    public class TimeSeriesAttribute : DataItemAttribute
    {
        /// <inheritdoc />
        public TimeSeriesAttribute(string name, string description = null) : base(name, description) { }
    }
}
