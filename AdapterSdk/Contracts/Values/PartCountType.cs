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
	/// A value type for PartCountType to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1640702052373_905765_57">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class PartCountType : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PART_COUNT_TYPE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the PartCountType EVENT Data Item.
		/// </summary>
        public PartCountType(string value) : base(value) { }

		public PartCountType(PartCountTypeValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="PartCountTypeValues.EACH" />
		[ObservationalValue(typeof(PartCountTypeValues))]
        public static PartCountType EACH => new PartCountType(PartCountTypeValues.EACH);
		/// <inheritdoc cref="PartCountTypeValues.BATCH" />
		[ObservationalValue(typeof(PartCountTypeValues))]
        public static PartCountType BATCH => new PartCountType(PartCountTypeValues.BATCH);

        /// <summary>
        /// Implicitly converts the specified <see cref="PartCountTypeValues" /> to an <see cref="PartCountType"/> value.
        /// The <see cref="PartCountTypeValues" /> is converted to a string and used to initialize the <see cref="PartCountType"/> value.
        /// </summary>
        /// <param name="value">The <see cref="PartCountTypeValues" /> to convert.</param>
        /// <returns>An <see cref="PartCountType"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PartCountType(PartCountTypeValues value)
            => new PartCountType(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="PartCountType"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="PartCountType"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="PartCountType"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PartCountType(string value)
            => new PartCountType(value.ToUpperInvariant());
		
    }
}