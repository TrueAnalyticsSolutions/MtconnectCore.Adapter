#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItems;
using Mtconnect.AdapterInterface.DataItemValues;
using Mtconnect.AdapterInterface.Units;

namespace Mtconnect.AdapterInterface.DataItemValues
{
	/// <summary>
	/// A value type for BatteryCharge to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
	/// <item><b>Units</b>: <see cref="MtconnectUnit.PERCENT" /></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.7.0")]
	public partial class BatteryCharge : SampleValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.SampleTypes.BATTERY_CHARGE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the BatteryCharge EVENT Data Item.
		/// </summary>
        public BatteryCharge(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="BatteryCharge"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="BatteryCharge"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="BatteryCharge"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator BatteryCharge(float value)
            => new BatteryCharge(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="BatteryCharge" />.
		/// </summary>
		public partial class ACTUAL : BatteryCharge
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.BatteryChargeSubTypes.ACTUAL);

			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="ACTUAL"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="ACTUAL"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="ACTUAL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ACTUAL(float value)
				=> new ACTUAL(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="BatteryCharge" />.
		/// </summary>
		public partial class TARGET : BatteryCharge
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.BatteryChargeSubTypes.TARGET);

			/// <summary>
			/// Constructs a new value type for TARGET.
			/// </summary>
            public TARGET(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="TARGET"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="TARGET"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="TARGET"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator TARGET(float value)
				=> new TARGET(value);
		}
    }
}