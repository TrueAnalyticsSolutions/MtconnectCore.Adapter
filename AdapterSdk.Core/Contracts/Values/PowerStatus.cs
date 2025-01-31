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
	/// A value type for PowerStatus to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643978215664_962279_1402">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class PowerStatus : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.POWER_STATUS);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the PowerStatus EVENT Data Item.
		/// </summary>
        public PowerStatus(string value) : base(value) { }

		/// <summary>
		/// Constructs a new value type for the PowerStatus EVENT Data Item.
		/// </summary>
		public PowerStatus(PowerStatusValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="PowerStatusValues.ON" />
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		[ObservationalValue(typeof(PowerStatusValues))]
        public static PowerStatus ON => new PowerStatus(PowerStatusValues.ON);
		/// <inheritdoc cref="PowerStatusValues.OFF" />
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		[ObservationalValue(typeof(PowerStatusValues))]
        public static PowerStatus OFF => new PowerStatus(PowerStatusValues.OFF);

        /// <summary>
        /// Implicitly converts the specified <see cref="PowerStatusValues" /> to an <see cref="PowerStatus"/> value.
        /// The <see cref="PowerStatusValues" /> is converted to a string and used to initialize the <see cref="PowerStatus"/> value.
        /// </summary>
        /// <param name="value">The <see cref="PowerStatusValues" /> to convert.</param>
        /// <returns>An <see cref="PowerStatus"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PowerStatus(PowerStatusValues value)
            => new PowerStatus(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="PowerStatus"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="PowerStatus"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="PowerStatus"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PowerStatus(string value)
            => new PowerStatus(value.ToUpperInvariant());
		
    }
}