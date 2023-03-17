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
	/// A value type for DateCode to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579272233011_597138_670">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class DateCode : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the DateCode EVENT Data Item.
		/// </summary>
        public DateCode(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="DateCode"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="DateCode"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="DateCode"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator DateCode(string value)
            => new DateCode(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="DateCode" />.
		/// </summary>
		public partial class MANUFACTURE : DateCode
		{
			/// <summary>
			/// Constructs a new value type for MANUFACTURE.
			/// </summary>
            public MANUFACTURE(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="MANUFACTURE"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="MANUFACTURE"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="MANUFACTURE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator MANUFACTURE(string value)
				=> new MANUFACTURE(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="DateCode" />.
		/// </summary>
		public partial class EXPIRATION : DateCode
		{
			/// <summary>
			/// Constructs a new value type for EXPIRATION.
			/// </summary>
            public EXPIRATION(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="EXPIRATION"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="EXPIRATION"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="EXPIRATION"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator EXPIRATION(string value)
				=> new EXPIRATION(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="DateCode" />.
		/// </summary>
		public partial class FIRSTUSE : DateCode
		{
			/// <summary>
			/// Constructs a new value type for FIRST_USE.
			/// </summary>
            public FIRSTUSE(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="FIRSTUSE"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="FIRSTUSE"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="FIRSTUSE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator FIRSTUSE(string value)
				=> new FIRSTUSE(value.ToUpperInvariant());
		}
    }
}