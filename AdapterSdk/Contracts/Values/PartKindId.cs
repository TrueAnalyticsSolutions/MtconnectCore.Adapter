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
	/// A value type for PartKindId to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class PartKindId : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PART_KIND_ID);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the PartKindId EVENT Data Item.
		/// </summary>
        public PartKindId(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="PartKindId"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="PartKindId"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="PartKindId"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PartKindId(string value)
            => new PartKindId(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartKindId" />.
		/// </summary>
		public partial class UUID : PartKindId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartKindIdSubTypes.UUID);

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
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartKindId" />.
		/// </summary>
		public partial class PARTFAMILY : PartKindId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartKindIdSubTypes.PART_FAMILY);

			/// <summary>
			/// Constructs a new value type for PART_FAMILY.
			/// </summary>
            public PARTFAMILY(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="PARTFAMILY"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="PARTFAMILY"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="PARTFAMILY"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator PARTFAMILY(string value)
				=> new PARTFAMILY(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartKindId" />.
		/// </summary>
		public partial class PARTNAME : PartKindId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartKindIdSubTypes.PART_NAME);

			/// <summary>
			/// Constructs a new value type for PART_NAME.
			/// </summary>
            public PARTNAME(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="PARTNAME"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="PARTNAME"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="PARTNAME"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator PARTNAME(string value)
				=> new PARTNAME(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartKindId" />.
		/// </summary>
		public partial class PARTNUMBER : PartKindId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartKindIdSubTypes.PART_NUMBER);

			/// <summary>
			/// Constructs a new value type for PART_NUMBER.
			/// </summary>
            public PARTNUMBER(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="PARTNUMBER"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="PARTNUMBER"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="PARTNUMBER"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator PARTNUMBER(string value)
				=> new PARTNUMBER(value.ToUpperInvariant());
		}
    }
}