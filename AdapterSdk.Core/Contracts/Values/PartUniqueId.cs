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
	/// A value type for PartUniqueId to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class PartUniqueId : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PART_UNIQUE_ID);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the PartUniqueId EVENT Data Item.
		/// </summary>
        public PartUniqueId(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="PartUniqueId"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="PartUniqueId"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="PartUniqueId"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PartUniqueId(string value)
            => new PartUniqueId(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartUniqueId" />.
		/// </summary>
		public partial class SERIALNUMBER : PartUniqueId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartUniqueIdSubTypes.SERIAL_NUMBER);

			/// <summary>
			/// Constructs a new value type for SERIAL_NUMBER.
			/// </summary>
            public SERIALNUMBER(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="SERIALNUMBER"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="SERIALNUMBER"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="SERIALNUMBER"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator SERIALNUMBER(string value)
				=> new SERIALNUMBER(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartUniqueId" />.
		/// </summary>
		public partial class RAWMATERIAL : PartUniqueId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartUniqueIdSubTypes.RAW_MATERIAL);

			/// <summary>
			/// Constructs a new value type for RAW_MATERIAL.
			/// </summary>
            public RAWMATERIAL(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="RAWMATERIAL"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="RAWMATERIAL"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="RAWMATERIAL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator RAWMATERIAL(string value)
				=> new RAWMATERIAL(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartUniqueId" />.
		/// </summary>
		public partial class UUID : PartUniqueId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartUniqueIdSubTypes.UUID);

			/// <summary>
			/// Constructs a new value type for UUID.
			/// </summary>
            public UUID(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="UUID"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="UUID"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="UUID"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator UUID(string value)
				=> new UUID(value.ToUpperInvariant());
		}
    }
}