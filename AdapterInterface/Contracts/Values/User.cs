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
        {
            return new User(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="User" />.
		/// </summary>
		public partial class OPERATOR : User
		{
			/// <summary>
			/// Constructs a new value type for OPERATOR.
			/// </summary>
            public OPERATOR(string value) : base(value) { }
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
		}
    }
}