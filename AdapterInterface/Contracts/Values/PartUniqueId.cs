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
	/// A value type for PartUniqueId to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class PartUniqueId : EventValue
    {
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
        {
            return new PartUniqueId(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartUniqueId" />.
		/// </summary>
		public partial class SERIALNUMBER : PartUniqueId
		{
			/// <summary>
			/// Constructs a new value type for SERIAL_NUMBER.
			/// </summary>
            public SERIALNUMBER(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartUniqueId" />.
		/// </summary>
		public partial class RAWMATERIAL : PartUniqueId
		{
			/// <summary>
			/// Constructs a new value type for RAW_MATERIAL.
			/// </summary>
            public RAWMATERIAL(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartUniqueId" />.
		/// </summary>
		public partial class UUID : PartUniqueId
		{
			/// <summary>
			/// Constructs a new value type for UUID.
			/// </summary>
            public UUID(string value) : base(value) { }
		}
    }
}