#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk.Contracts.Attributes;
using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.DataItemValues;
using Mtconnect.AdapterSdk.Units;

namespace Mtconnect.AdapterSdk.DataItemValues
{
	/// <summary>
	/// A value type for HumidityRelative to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
	/// <item><b>Units</b>: <see cref="MtconnectUnit.PERCENT" /></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class HumidityRelative : SampleValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.SampleTypes.HUMIDITY_RELATIVE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the HumidityRelative EVENT Data Item.
		/// </summary>
        public HumidityRelative(float? value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float? to an <see cref="HumidityRelative"/> value.
        /// The float? is converted to uppercase and used to initialize the <see cref="HumidityRelative"/> value.
        /// </summary>
        /// <param name="value">The float? to convert.</param>
        /// <returns>An <see cref="HumidityRelative"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator HumidityRelative(float? value)
            => new HumidityRelative(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="HumidityRelative" />.
		/// </summary>
		public partial class COMMANDED : HumidityRelative
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.HumidityRelativeSubTypes.COMMANDED);

			/// <summary>
			/// Constructs a new value type for COMMANDED.
			/// </summary>
            public COMMANDED(float? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float? to an <see cref="COMMANDED"/> value.
			/// The float? is converted to uppercase and used to initialize the <see cref="COMMANDED"/> value.
			/// </summary>
			/// <param name="value">The float? to convert.</param>
			/// <returns>An <see cref="COMMANDED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator COMMANDED(float? value)
				=> new COMMANDED(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="HumidityRelative" />.
		/// </summary>
		public partial class ACTUAL : HumidityRelative
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.HumidityRelativeSubTypes.ACTUAL);

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