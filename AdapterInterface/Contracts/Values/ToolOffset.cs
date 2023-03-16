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
	/// A value type for ToolOffset to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class ToolOffset : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the ToolOffset EVENT Data Item.
		/// </summary>
        public ToolOffset(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ToolOffset"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ToolOffset"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ToolOffset"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ToolOffset(string value)
            => new ToolOffset(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ToolOffset" />.
		/// </summary>
		public partial class RADIAL : ToolOffset
		{
			/// <summary>
			/// Constructs a new value type for RADIAL.
			/// </summary>
            public RADIAL(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="RADIAL"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="RADIAL"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="RADIAL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator RADIAL(string value)
				=> new RADIAL(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ToolOffset" />.
		/// </summary>
		public partial class LENGTH : ToolOffset
		{
			/// <summary>
			/// Constructs a new value type for LENGTH.
			/// </summary>
            public LENGTH(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="LENGTH"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="LENGTH"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="LENGTH"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator LENGTH(string value)
				=> new LENGTH(value.ToUpperInvariant());
		}
    }
}