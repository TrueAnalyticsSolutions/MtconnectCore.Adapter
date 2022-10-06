﻿using System;
using System.Linq;

namespace MtconnectCore.Adapter.DataItems
{
    public class TimeSeries : DataItem
    {
        public double Rate { set; get; }

        private double[] _values;
        public double[] Values {
            set
            {
                _values = value;
                Changed = true;
            }
            get { return _values; } 
        }

        public TimeSeries(string name, double rate = 0.0)
            : base(name)
        {
            NewLine = true;
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

            return $"{_name}|{count}|{rate}|{v}";
        }
    }
}
