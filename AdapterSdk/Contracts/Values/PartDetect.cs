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
	/// A value type for PartDetect to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1581206093299_877100_76">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class PartDetect : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PART_DETECT);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the PartDetect EVENT Data Item.
		/// </summary>
        public PartDetect(string value) : base(value) { }

		public PartDetect(PartDetectValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="PartDetectValues.PRESENT" />
		[ObservationalValue(typeof(PartDetectValues))]
        public static PartDetect PRESENT => new PartDetect(PartDetectValues.PRESENT);
		/// <inheritdoc cref="PartDetectValues.NOT_PRESENT" />
		[ObservationalValue(typeof(PartDetectValues))]
        public static PartDetect NOT_PRESENT => new PartDetect(PartDetectValues.NOT_PRESENT);

        /// <summary>
        /// Implicitly converts the specified <see cref="PartDetectValues" /> to an <see cref="PartDetect"/> value.
        /// The <see cref="PartDetectValues" /> is converted to a string and used to initialize the <see cref="PartDetect"/> value.
        /// </summary>
        /// <param name="value">The <see cref="PartDetectValues" /> to convert.</param>
        /// <returns>An <see cref="PartDetect"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PartDetect(PartDetectValues value)
            => new PartDetect(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="PartDetect"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="PartDetect"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="PartDetect"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PartDetect(string value)
            => new PartDetect(value.ToUpperInvariant());
		
    }
}