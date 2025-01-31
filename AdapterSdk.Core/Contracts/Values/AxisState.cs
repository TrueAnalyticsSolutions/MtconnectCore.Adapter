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
	/// A value type for AxisState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417658_841501_2872">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class AxisState : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.AXIS_STATE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the AxisState EVENT Data Item.
		/// </summary>
        public AxisState(string value) : base(value) { }

		/// <summary>
		/// Constructs a new value type for the AxisState EVENT Data Item.
		/// </summary>
		public AxisState(AxisStateValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="AxisStateValues.HOME" />
		[ObservationalValue(typeof(AxisStateValues))]
        public static AxisState HOME => new AxisState(AxisStateValues.HOME);
		/// <inheritdoc cref="AxisStateValues.TRAVEL" />
		[ObservationalValue(typeof(AxisStateValues))]
        public static AxisState TRAVEL => new AxisState(AxisStateValues.TRAVEL);
		/// <inheritdoc cref="AxisStateValues.PARKED" />
		[ObservationalValue(typeof(AxisStateValues))]
        public static AxisState PARKED => new AxisState(AxisStateValues.PARKED);
		/// <inheritdoc cref="AxisStateValues.STOPPED" />
		[ObservationalValue(typeof(AxisStateValues))]
        public static AxisState STOPPED => new AxisState(AxisStateValues.STOPPED);

        /// <summary>
        /// Implicitly converts the specified <see cref="AxisStateValues" /> to an <see cref="AxisState"/> value.
        /// The <see cref="AxisStateValues" /> is converted to a string and used to initialize the <see cref="AxisState"/> value.
        /// </summary>
        /// <param name="value">The <see cref="AxisStateValues" /> to convert.</param>
        /// <returns>An <see cref="AxisState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator AxisState(AxisStateValues value)
            => new AxisState(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="AxisState"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="AxisState"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="AxisState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator AxisState(string value)
            => new AxisState(value.ToUpperInvariant());
		
    }
}