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
	/// A value type for LineNumber to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class LineNumber : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the LineNumber EVENT Data Item.
		/// </summary>
        public LineNumber(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="LineNumber"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="LineNumber"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="LineNumber"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator LineNumber(string value)
            => new LineNumber(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="LineNumber" />.
		/// </summary>
		public partial class ABSOLUTE : LineNumber
		{
			/// <summary>
			/// Constructs a new value type for ABSOLUTE.
			/// </summary>
            public ABSOLUTE(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="ABSOLUTE"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="ABSOLUTE"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="ABSOLUTE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ABSOLUTE(string value)
				=> new ABSOLUTE(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="LineNumber" />.
		/// </summary>
		public partial class INCREMENTAL : LineNumber
		{
			/// <summary>
			/// Constructs a new value type for INCREMENTAL.
			/// </summary>
            public INCREMENTAL(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="INCREMENTAL"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="INCREMENTAL"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="INCREMENTAL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator INCREMENTAL(string value)
				=> new INCREMENTAL(value.ToUpperInvariant());
		}
    }
}