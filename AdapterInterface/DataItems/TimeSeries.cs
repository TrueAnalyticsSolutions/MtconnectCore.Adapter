using System;
using System.Linq;

namespace Mtconnect.AdapterInterface.DataItems
{
    /// <summary>
    /// Represents data that is collected at a high rate.
    /// </summary>
    public class TimeSeries : DataItem
    {
        /// <summary>
        /// Collection rate for a time series data source.
        /// </summary>
        public double Rate { set; get; }

        private double[] _values;
        /// <summary>
        /// Collection of recorded values.
        /// </summary>
        public double[] Values {
            set
            {
                _values = value;
                HasChanged = true;
            }
            get { return _values; } 
        }

        /// <summary>
        /// Constructs a new Time Series dataset.
        /// </summary>
        /// <param name="name"><inheritdoc cref="DataItem.Name" path="/summary"/></param>
        /// <param name="rate"><inheritdoc cref="Rate" path="/summary"/></param>
        public TimeSeries(string name, double rate = 0.0) : base(name)
        {
            HasNewLine = true;
            Rate = rate;
        }

        /// <summary>
        /// Simple string representation with pipe delim.
        /// </summary>
        /// <returns>A text representation</returns>
        public override string ToString()
        {
            string rate = Rate == 0.0 ? "" : Rate.ToString();
            string v = string.Empty;
            int count = 0;

            if (_values != null)
            {
                v = String.Join(" ", Values.Select(p => p.ToString()).ToArray());
                count = Values.Length;
            }

            return $"{Name}|{count}|{rate}|{v}";
        }
    }
}
