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
	/// A value type for DischargeRate to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class DischargeRate : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the DischargeRate EVENT Data Item.
		/// </summary>
        public DischargeRate(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="DischargeRate"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="DischargeRate"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="DischargeRate"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator DischargeRate(float value)
        {
            return new DischargeRate(value);
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="DischargeRate" />.
		/// </summary>
		public partial class ACTUAL : DischargeRate
		{
			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="DischargeRate" />.
		/// </summary>
		public partial class TARGET : DischargeRate
		{
			/// <summary>
			/// Constructs a new value type for TARGET.
			/// </summary>
            public TARGET(float value) : base(value) { }
		}
    }
}