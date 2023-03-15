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
	/// A value type for Hardware to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class Hardware : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the Hardware EVENT Data Item.
		/// </summary>
        public Hardware(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="Hardware"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="Hardware"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="Hardware"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Hardware(string value)
        {
            return new Hardware(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Hardware" />.
		/// </summary>
		public partial class VERSION : Hardware
		{
			/// <summary>
			/// Constructs a new value type for VERSION.
			/// </summary>
            public VERSION(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Hardware" />.
		/// </summary>
		public partial class RELEASEDATE : Hardware
		{
			/// <summary>
			/// Constructs a new value type for RELEASE_DATE.
			/// </summary>
            public RELEASEDATE(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Hardware" />.
		/// </summary>
		public partial class MANUFACTURER : Hardware
		{
			/// <summary>
			/// Constructs a new value type for MANUFACTURER.
			/// </summary>
            public MANUFACTURER(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Hardware" />.
		/// </summary>
		public partial class LICENSE : Hardware
		{
			/// <summary>
			/// Constructs a new value type for LICENSE.
			/// </summary>
            public LICENSE(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Hardware" />.
		/// </summary>
		public partial class INSTALLDATE : Hardware
		{
			/// <summary>
			/// Constructs a new value type for INSTALL_DATE.
			/// </summary>
            public INSTALLDATE(string value) : base(value) { }
		}
    }
}