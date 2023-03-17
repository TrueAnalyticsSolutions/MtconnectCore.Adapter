#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItems;
using Mtconnect.AdapterInterface.DataItemValues;

namespace Mtconnect.AdapterInterface.DataItemValues
{
	/// <summary>
	/// A value type for PartKindId to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class PartKindId : EventValue
    {
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