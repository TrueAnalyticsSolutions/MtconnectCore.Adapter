#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItems;
using Mtconnect.AdapterInterface.DataItemValues;

namespace Mtconnect.AdapterInterface.DataItemValues
{
	/// <summary>
	/// A value type for Voltage to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_6_0")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class Voltage : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the Voltage EVENT Data Item.
		/// </summary>
        public Voltage(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="Voltage"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="Voltage"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="Voltage"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Voltage(float value)
        {
            return new Voltage(value);
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Voltage" />.
		/// </summary>
		public partial class ALTERNATING : Voltage
		{
			/// <summary>
			/// Constructs a new value type for ALTERNATING.
			/// </summary>
            public ALTERNATING(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Voltage" />.
		/// </summary>
		public partial class DIRECT : Voltage
		{
			/// <summary>
			/// Constructs a new value type for DIRECT.
			/// </summary>
            public DIRECT(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Voltage" />.
		/// </summary>
		public partial class ACTUAL : Voltage
		{
			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Voltage" />.
		/// </summary>
		public partial class TARGET : Voltage
		{
			/// <summary>
			/// Constructs a new value type for TARGET.
			/// </summary>
            public TARGET(float value) : base(value) { }
		}
    }
}