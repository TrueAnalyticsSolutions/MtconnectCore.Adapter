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
	/// A value type for OperatingMode to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1637936591972_920420_100">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class OperatingMode : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.OPERATING_MODE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the OperatingMode EVENT Data Item.
		/// </summary>
        public OperatingMode(string value) : base(value) { }

		/// <summary>
		/// Constructs a new value type for the OperatingMode EVENT Data Item.
		/// </summary>
		public OperatingMode(OperatingModeValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="OperatingModeValues.AUTOMATIC" />
		[ObservationalValue(typeof(OperatingModeValues))]
        public static OperatingMode AUTOMATIC => new OperatingMode(OperatingModeValues.AUTOMATIC);
		/// <inheritdoc cref="OperatingModeValues.MANUAL" />
		[ObservationalValue(typeof(OperatingModeValues))]
        public static OperatingMode MANUAL => new OperatingMode(OperatingModeValues.MANUAL);
		/// <inheritdoc cref="OperatingModeValues.SEMI_AUTOMATIC" />
		[ObservationalValue(typeof(OperatingModeValues))]
        public static OperatingMode SEMI_AUTOMATIC => new OperatingMode(OperatingModeValues.SEMI_AUTOMATIC);

        /// <summary>
        /// Implicitly converts the specified <see cref="OperatingModeValues" /> to an <see cref="OperatingMode"/> value.
        /// The <see cref="OperatingModeValues" /> is converted to a string and used to initialize the <see cref="OperatingMode"/> value.
        /// </summary>
        /// <param name="value">The <see cref="OperatingModeValues" /> to convert.</param>
        /// <returns>An <see cref="OperatingMode"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator OperatingMode(OperatingModeValues value)
            => new OperatingMode(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="OperatingMode"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="OperatingMode"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="OperatingMode"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator OperatingMode(string value)
            => new OperatingMode(value.ToUpperInvariant());
		
    }
}