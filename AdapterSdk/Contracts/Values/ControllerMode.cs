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
	/// A value type for ControllerMode to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417660_348819_2874">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class ControllerMode : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.CONTROLLER_MODE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ControllerMode EVENT Data Item.
		/// </summary>
        public ControllerMode(string value) : base(value) { }

		/// <summary>
		/// Constructs a new value type for the ControllerMode EVENT Data Item.
		/// </summary>
		public ControllerMode(ControllerModeValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="ControllerModeValues.AUTOMATIC" />
		[ObservationalValue(typeof(ControllerModeValues))]
        public static ControllerMode AUTOMATIC => new ControllerMode(ControllerModeValues.AUTOMATIC);
		/// <inheritdoc cref="ControllerModeValues.MANUAL" />
		[ObservationalValue(typeof(ControllerModeValues))]
        public static ControllerMode MANUAL => new ControllerMode(ControllerModeValues.MANUAL);
		/// <inheritdoc cref="ControllerModeValues.MANUAL_DATA_INPUT" />
		[ObservationalValue(typeof(ControllerModeValues))]
        public static ControllerMode MANUAL_DATA_INPUT => new ControllerMode(ControllerModeValues.MANUAL_DATA_INPUT);
		/// <inheritdoc cref="ControllerModeValues.SEMI_AUTOMATIC" />
		[ObservationalValue(typeof(ControllerModeValues))]
        public static ControllerMode SEMI_AUTOMATIC => new ControllerMode(ControllerModeValues.SEMI_AUTOMATIC);
		/// <inheritdoc cref="ControllerModeValues.EDIT" />
		[ObservationalValue(typeof(ControllerModeValues))]
        public static ControllerMode EDIT => new ControllerMode(ControllerModeValues.EDIT);
		/// <inheritdoc cref="ControllerModeValues.FEED_HOLD" />
		[Obsolete("Deprecated in v1.3 according to https://model.mtconnect.org/#_Version_1.3")]
		[ObservationalValue(typeof(ControllerModeValues))]
        public static ControllerMode FEED_HOLD => new ControllerMode(ControllerModeValues.FEED_HOLD);

        /// <summary>
        /// Implicitly converts the specified <see cref="ControllerModeValues" /> to an <see cref="ControllerMode"/> value.
        /// The <see cref="ControllerModeValues" /> is converted to a string and used to initialize the <see cref="ControllerMode"/> value.
        /// </summary>
        /// <param name="value">The <see cref="ControllerModeValues" /> to convert.</param>
        /// <returns>An <see cref="ControllerMode"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ControllerMode(ControllerModeValues value)
            => new ControllerMode(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ControllerMode"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ControllerMode"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ControllerMode"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ControllerMode(string value)
            => new ControllerMode(value.ToUpperInvariant());
		
    }
}