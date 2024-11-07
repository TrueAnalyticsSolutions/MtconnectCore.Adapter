using Mtconnect.AdapterSdk.DataItemTypes;
using System;
using System.Linq;

namespace Mtconnect.AdapterSdk.DataItems
{
    /// <summary>
    /// Represents data that is collected at a high rate.
    /// </summary>
    public class TimeSeries : DataItem
    {
        /// <inheritdoc />
        public override string Category => "SAMPLE";

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
                        throw new InvalidCastException($"Cannot cast {formattedValue.GetType().FullName} to double[]");
                    }
                    updatedValue = formattedValue as double[];
                }

                _values = value;

                if (Values == null || !Values.Any())
                {
                    base.Unavailable();
                } else
                {
                    base.Value = String.Join(" ", Values.Select(p => p.ToString()).ToArray());
                }
            }
            get { return _values; } 
        }

        /// <summary>
        /// Constructs a new TimeSeries entity, relying on the attributes to define the name, description, type, and subtype fields.
        /// </summary>
        /// <param name="rate"><inheritdoc cref="Rate" path="/summary"/></param>
        public TimeSeries(double rate) : base()
        {
            HasNewLine = true;
            Rate = rate;
        }

        /// <summary>
        /// Constructs a new SAMPLE DataItem with TimeSeries formatting.
        /// </summary>
        /// <param name="name"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='name']"/></param>
        /// <param name="description"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='description']"/></param>
        /// <param name="rate"><inheritdoc cref="Rate" path="/summary"/></param>
        /// <param name="type"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='type']"/></param>
        /// <param name="subType"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='subtype']"/></param>
        public TimeSeries(string name, string description = null, double rate = 0.0, string type = null, string subType = null) : base(name, type, subType, description)
        {
            HasNewLine = true;
            Rate = rate;
        }

        /// <summary>
        /// <inheritdoc cref="TimeSeries(string,string,double,string,string)" path="/summary"/>
        /// </summary>
        /// <param name="name"><inheritdoc cref="TimeSeries(string,string,double,string,string)" path="/param[@name='name']"/></param>
        /// <param name="description"><inheritdoc cref="TimeSeries(string,string,double,string,string)" path="/param[@name='description']"/></param>
        /// <param name="rate"><inheritdoc cref="TimeSeries(string,string,double,string,string)" path="/param[@name='rate']"/></param>
        /// <param name="type"><inheritdoc cref="TimeSeries(string,string,double,string,string)" path="/param[@name='type']"/></param>
        /// <param name="subType"><inheritdoc cref="TimeSeries(string,string,double,string,string)" path="/param[@name='subType']"/></param>
        public TimeSeries(string name, string description = null, double rate = 0.0, SampleTypes? type = null, string subType = null) : this(name, description, rate, type.ToString(), subType) { }

        /// <inheritdoc />
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

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return base.GetHashCode();
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

        /// <inheritdoc />
        public override bool Validate(out ValidationResult result)
        {
            // NOTE: No need to call the base.Validate method because this is not a real DataItem

            result = new ValidationResult
            {
                Level = ValidationLevel.VALID
            };

            // TODO: Determine what needs to be validated from the Adapter
            return true;
        }

        /// <inheritdoc />
        public override IDataItem Copy()
        {
            var copy = new TimeSeries(this.Name, this.Description, this.Rate, this.ObservationalType, this.ObservationalSubType);
            copy.FormatValue = this.FormatValue;
            copy.ModelPath = this.ModelPath;
            copy.Units = this.Units;
            copy.HasTimestampOverride = this.HasTimestampOverride;

            return copy;
        }
    }
}
