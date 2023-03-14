using Mtconnect.AdapterInterface.DataItemTypes;
using System;

namespace Mtconnect.AdapterInterface.Contracts.Attributes
{
    /// <summary>
    /// A decorative attribute for indicating a property intended to go thru an Adapter stream as an Time Series.
    /// </summary>
    public class TimeSeriesAttribute : DataItemAttribute
    {
        /// <inheritdoc />
        public TimeSeriesAttribute(string name, string description = null, string type = null, string subtype = null) : base(name, description, type, subtype) { }

        public TimeSeriesAttribute(string name, string description = null, SampleTypes? type = null, Enum subtype = null) : this(name, description, type.ToString(), subtype.ToString()) { }
    }
}
