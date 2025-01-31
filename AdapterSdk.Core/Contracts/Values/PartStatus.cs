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
	/// A value type for PartStatus to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605550250815_880755_1896">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class PartStatus : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PART_STATUS);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the PartStatus EVENT Data Item.
		/// </summary>
        public PartStatus(string value) : base(value) { }

		/// <summary>
		/// Constructs a new value type for the PartStatus EVENT Data Item.
		/// </summary>
		public PartStatus(PartStatusValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="PartStatusValues.PASS" />
		[ObservationalValue(typeof(PartStatusValues))]
        public static PartStatus PASS => new PartStatus(PartStatusValues.PASS);
		/// <inheritdoc cref="PartStatusValues.FAIL" />
		[ObservationalValue(typeof(PartStatusValues))]
        public static PartStatus FAIL => new PartStatus(PartStatusValues.FAIL);

        /// <summary>
        /// Implicitly converts the specified <see cref="PartStatusValues" /> to an <see cref="PartStatus"/> value.
        /// The <see cref="PartStatusValues" /> is converted to a string and used to initialize the <see cref="PartStatus"/> value.
        /// </summary>
        /// <param name="value">The <see cref="PartStatusValues" /> to convert.</param>
        /// <returns>An <see cref="PartStatus"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PartStatus(PartStatusValues value)
            => new PartStatus(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="PartStatus"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="PartStatus"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="PartStatus"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PartStatus(string value)
            => new PartStatus(value.ToUpperInvariant());
		
    }
}