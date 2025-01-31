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
	/// A value type for SpindleInterlock to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1632486690924_270312_65">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class SpindleInterlock : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.SPINDLE_INTERLOCK);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the SpindleInterlock EVENT Data Item.
		/// </summary>
        public SpindleInterlock(string value) : base(value) { }

		/// <summary>
		/// Constructs a new value type for the SpindleInterlock EVENT Data Item.
		/// </summary>
		public SpindleInterlock(SpindleInterlockValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="SpindleInterlockValues.ACTIVE" />
		[ObservationalValue(typeof(SpindleInterlockValues))]
        public static SpindleInterlock ACTIVE => new SpindleInterlock(SpindleInterlockValues.ACTIVE);
		/// <inheritdoc cref="SpindleInterlockValues.INACTIVE" />
		[ObservationalValue(typeof(SpindleInterlockValues))]
        public static SpindleInterlock INACTIVE => new SpindleInterlock(SpindleInterlockValues.INACTIVE);

        /// <summary>
        /// Implicitly converts the specified <see cref="SpindleInterlockValues" /> to an <see cref="SpindleInterlock"/> value.
        /// The <see cref="SpindleInterlockValues" /> is converted to a string and used to initialize the <see cref="SpindleInterlock"/> value.
        /// </summary>
        /// <param name="value">The <see cref="SpindleInterlockValues" /> to convert.</param>
        /// <returns>An <see cref="SpindleInterlock"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator SpindleInterlock(SpindleInterlockValues value)
            => new SpindleInterlock(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="SpindleInterlock"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="SpindleInterlock"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="SpindleInterlock"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator SpindleInterlock(string value)
            => new SpindleInterlock(value.ToUpperInvariant());
		
    }
}