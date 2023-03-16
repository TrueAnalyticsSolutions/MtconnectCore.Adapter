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
	/// A value type for User to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class User : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the User EVENT Data Item.
		/// </summary>
        public User(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="User"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="User"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="User"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator User(string value)
            => new User(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="User" />.
		/// </summary>
		public partial class OPERATOR : User
		{
			/// <summary>
			/// Constructs a new value type for OPERATOR.
			/// </summary>
            public OPERATOR(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="OPERATOR"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="OPERATOR"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="OPERATOR"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator OPERATOR(string value)
				=> new OPERATOR(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="User" />.
		/// </summary>
		public partial class MAINTENANCE : User
		{
			/// <summary>
			/// Constructs a new value type for MAINTENANCE.
			/// </summary>
            public MAINTENANCE(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="MAINTENANCE"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="MAINTENANCE"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="MAINTENANCE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator MAINTENANCE(string value)
				=> new MAINTENANCE(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="User" />.
		/// </summary>
		public partial class SETUP : User
		{
			/// <summary>
			/// Constructs a new value type for SET_UP.
			/// </summary>
            public SETUP(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="SETUP"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="SETUP"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="SETUP"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator SETUP(string value)
				=> new SETUP(value.ToUpperInvariant());
		}
    }
}