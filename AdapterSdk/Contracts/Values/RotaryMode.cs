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
	/// A value type for RotaryMode to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417668_463137_2883">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class RotaryMode : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.ROTARY_MODE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the RotaryMode EVENT Data Item.
		/// </summary>
        public RotaryMode(string value) : base(value) { }

		public RotaryMode(RotaryModeValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="RotaryModeValues.SPINDLE" />
		[ObservationalValue(typeof(RotaryModeValues))]
        public static RotaryMode SPINDLE => new RotaryMode(RotaryModeValues.SPINDLE);
		/// <inheritdoc cref="RotaryModeValues.INDEX" />
		[ObservationalValue(typeof(RotaryModeValues))]
        public static RotaryMode INDEX => new RotaryMode(RotaryModeValues.INDEX);
		/// <inheritdoc cref="RotaryModeValues.CONTOUR" />
		[ObservationalValue(typeof(RotaryModeValues))]
        public static RotaryMode CONTOUR => new RotaryMode(RotaryModeValues.CONTOUR);

        /// <summary>
        /// Implicitly converts the specified <see cref="RotaryModeValues" /> to an <see cref="RotaryMode"/> value.
        /// The <see cref="RotaryModeValues" /> is converted to a string and used to initialize the <see cref="RotaryMode"/> value.
        /// </summary>
        /// <param name="value">The <see cref="RotaryModeValues" /> to convert.</param>
        /// <returns>An <see cref="RotaryMode"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator RotaryMode(RotaryModeValues value)
            => new RotaryMode(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="RotaryMode"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="RotaryMode"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="RotaryMode"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator RotaryMode(string value)
            => new RotaryMode(value.ToUpperInvariant());
		
    }
}