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
	/// A value type for ChuckState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417659_742691_2873">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class ChuckState : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.CHUCK_STATE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ChuckState EVENT Data Item.
		/// </summary>
        public ChuckState(string value) : base(value) { }

		/// <summary>
		/// Constructs a new value type for the ChuckState EVENT Data Item.
		/// </summary>
		public ChuckState(ChuckStateValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="ChuckStateValues.OPEN" />
		[ObservationalValue(typeof(ChuckStateValues))]
        public static ChuckState OPEN => new ChuckState(ChuckStateValues.OPEN);
		/// <inheritdoc cref="ChuckStateValues.CLOSED" />
		[ObservationalValue(typeof(ChuckStateValues))]
        public static ChuckState CLOSED => new ChuckState(ChuckStateValues.CLOSED);
		/// <inheritdoc cref="ChuckStateValues.UNLATCHED" />
		[ObservationalValue(typeof(ChuckStateValues))]
        public static ChuckState UNLATCHED => new ChuckState(ChuckStateValues.UNLATCHED);

        /// <summary>
        /// Implicitly converts the specified <see cref="ChuckStateValues" /> to an <see cref="ChuckState"/> value.
        /// The <see cref="ChuckStateValues" /> is converted to a string and used to initialize the <see cref="ChuckState"/> value.
        /// </summary>
        /// <param name="value">The <see cref="ChuckStateValues" /> to convert.</param>
        /// <returns>An <see cref="ChuckState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ChuckState(ChuckStateValues value)
            => new ChuckState(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ChuckState"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ChuckState"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ChuckState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ChuckState(string value)
            => new ChuckState(value.ToUpperInvariant());
		
    }
}