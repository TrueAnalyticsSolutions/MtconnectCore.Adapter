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
	/// A value type for PartGroupId to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class PartGroupId : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the PartGroupId EVENT Data Item.
		/// </summary>
        public PartGroupId(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="PartGroupId"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="PartGroupId"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="PartGroupId"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PartGroupId(string value)
        {
            return new PartGroupId(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartGroupId" />.
		/// </summary>
		public partial class LOT : PartGroupId
		{
			/// <summary>
			/// Constructs a new value type for LOT.
			/// </summary>
            public LOT(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartGroupId" />.
		/// </summary>
		public partial class RAWMATERIAL : PartGroupId
		{
			/// <summary>
			/// Constructs a new value type for RAW_MATERIAL.
			/// </summary>
            public RAWMATERIAL(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartGroupId" />.
		/// </summary>
		public partial class BATCH : PartGroupId
		{
			/// <summary>
			/// Constructs a new value type for BATCH.
			/// </summary>
            public BATCH(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartGroupId" />.
		/// </summary>
		public partial class UUID : PartGroupId
		{
			/// <summary>
			/// Constructs a new value type for UUID.
			/// </summary>
            public UUID(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartGroupId" />.
		/// </summary>
		public partial class HEATTREAT : PartGroupId
		{
			/// <summary>
			/// Constructs a new value type for HEAT_TREAT.
			/// </summary>
            public HEATTREAT(string value) : base(value) { }
		}
    }
}