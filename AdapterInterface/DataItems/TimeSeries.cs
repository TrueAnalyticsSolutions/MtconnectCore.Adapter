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
        public double Rate { get; }

        private double[] _values;
        /// <summary>
        /// Collection of recorded values.
        /// </summary>
        public double[] Values {
            set
            {
                var updatedValue = value;
                if (FormatValue != null)
                {
                    var formattedValue = FormatValue(updatedValue);
                    if (formattedValue != null && (formattedValue as double[]) == null)
                    {
                        throw new InvalidCastException("Cannot cast object to double[]");
                    }
                    updatedValue = formattedValue as double[];
                }

                _values = value;

                Value = String.Join(" ", Values.Select(p => p.ToString()).ToArray());
            }
            get { return _values; } 
        }

        /// <summary>
        /// Constructs a new Time Series dataset.
        /// </summary>
        /// <param name="name"><inheritdoc cref="DataItem.DataItem(string, string)" path="/param[@name='name']"/></param>
        /// <param name="description"><inheritdoc cref="DataItem.DataItem(string, string)" path="/param[@name='description']"/></param>
        /// <param name="rate"><inheritdoc cref="Rate" path="/summary"/></param>
        public TimeSeries(string name, string description = null, double rate = 0.0) : base(name, description)
        {
            HasNewLine = true;
            Rate = rate;
        }

        public override bool Equals(object obj)
        {
            double[] doubles = null;
            if (obj is double[])
            {
                doubles = obj as double[];
            } else if (obj is TimeSeries)
            {
                doubles = (obj as TimeSeries).Values;
            } else if (obj is string)
            {
                return obj.Equals(_value);
            } else {
                return false;
            }

            if (doubles.Length != Values.Length) return false;

            for (int i = 0; i < doubles.Length; i++)
            {
                if (doubles[i] != Values[i]) return false;
            }

            return true;
        }

        /// <summary>
        /// Simple string representation with pipe delim.
        /// </summary>
        /// <returns>A text representation</returns>
        public override string ToString()
        {
            string rate = Rate == 0.0 ? "" : Rate.ToString();

            // _value is a string join set in the setter of Values, thru the setter of base.Value
            return $"{Name}|{Values?.Length ?? 0}|{rate}|{_value}";
        }
    }
}
