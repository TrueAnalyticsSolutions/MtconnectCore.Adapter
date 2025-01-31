#pragma warning disable 0618
#pragma warning disable 1574
#pragma warning disable CS1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk;
using Mtconnect.AdapterSdk.Attributes;
using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.DataItemValues;
using Mtconnect.AdapterSdk.Units;

namespace Mtconnect.AdapterSdk.DataItemValues
{
	/// <summary>
	/// A value type for SettlingErrorLinear to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
	/// <item><b>Units</b>: <see cref="MtconnectUnit.MILLIMETER" /></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class SettlingErrorLinear : SampleValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.SampleTypes.SETTLING_ERROR_LINEAR);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the SettlingErrorLinear EVENT Data Item.
		/// </summary>
        public SettlingErrorLinear(float? value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float? to an <see cref="SettlingErrorLinear"/> value.
        /// The float? is converted to uppercase and used to initialize the <see cref="SettlingErrorLinear"/> value.
        /// </summary>
        /// <param name="value">The float? to convert.</param>
        /// <returns>An <see cref="SettlingErrorLinear"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator SettlingErrorLinear(float? value)
            => new SettlingErrorLinear(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="SettlingErrorLinear" />.
		/// </summary>
		public partial class ACTUAL : SettlingErrorLinear
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.SettlingErrorLinearSubTypes.ACTUAL);

			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float? to an <see cref="ACTUAL"/> value.
			/// The float? is converted to uppercase and used to initialize the <see cref="ACTUAL"/> value.
			/// </summary>
			/// <param name="value">The float? to convert.</param>
			/// <returns>An <see cref="ACTUAL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ACTUAL(float? value)
				=> new ACTUAL(value);
		}
    }
}