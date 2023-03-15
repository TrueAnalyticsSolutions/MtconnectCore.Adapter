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
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
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
        {
            return new PartKindId(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartKindId" />.
		/// </summary>
		public partial class UUID : PartKindId
		{
			/// <summary>
			/// Constructs a new value type for UUID.
			/// </summary>
            public UUID(string value) : base(value) { }
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
		}
    }
}