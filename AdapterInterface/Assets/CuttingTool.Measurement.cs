using System;


namespace Mtconnect.AdapterInterface.Assets
{

    public partial class CuttingTool
    {
        /// <summary>
        /// A cutting tool or cutting item measurement
        /// </summary>
        public class Measurement : Property
        {
            /// <summary>
            /// Constructs a new Cutting Item Measurement property.
            /// </summary>
            /// <param name="name"></param>
            /// <param name="code"></param>
            /// <param name="value"></param>
            /// <param name="nominal"></param>
            /// <param name="min"></param>
            /// <param name="max"></param>
            /// <param name="native"></param>
            /// <param name="units"></param>
            public Measurement(string name, string code, double value = CT_NULL, double nominal = CT_NULL,
                double min = CT_NULL, double max = CT_NULL, string native = null, string units = null)
                : base(name)
            {
                AddAttribute(new Attribute("code", code));
                if (!Double.IsNaN(value))
                    Value = value.ToString();

                if (!Double.IsNaN(nominal))
                    AddAttribute(new Attribute("nominal", nominal.ToString()));
                if (!Double.IsNaN(min))
                    AddAttribute(new Attribute("minimum", min.ToString()));
                if (!Double.IsNaN(max))
                    AddAttribute(new Attribute("maximum", max.ToString()));
                if (native != null)
                    AddAttribute(new Attribute("nativeUnits", native));
                if (units != null)
                    AddAttribute(new Attribute("units", units));
            }
        }
    }
}
