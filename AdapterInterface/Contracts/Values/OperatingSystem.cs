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
	/// A value type for OperatingSystem to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class OperatingSystem : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the OperatingSystem EVENT Data Item.
		/// </summary>
        public OperatingSystem(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="OperatingSystem"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="OperatingSystem"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="OperatingSystem"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator OperatingSystem(string value)
        {
            return new OperatingSystem(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="OperatingSystem" />.
		/// </summary>
		public partial class LICENSE : OperatingSystem
		{
			/// <summary>
			/// Constructs a new value type for LICENSE.
			/// </summary>
            public LICENSE(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="OperatingSystem" />.
		/// </summary>
		public partial class VERSION : OperatingSystem
		{
			/// <summary>
			/// Constructs a new value type for VERSION.
			/// </summary>
            public VERSION(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="OperatingSystem" />.
		/// </summary>
		public partial class RELEASEDATE : OperatingSystem
		{
			/// <summary>
			/// Constructs a new value type for RELEASE_DATE.
			/// </summary>
            public RELEASEDATE(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="OperatingSystem" />.
		/// </summary>
		public partial class INSTALLDATE : OperatingSystem
		{
			/// <summary>
			/// Constructs a new value type for INSTALL_DATE.
			/// </summary>
            public INSTALLDATE(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="OperatingSystem" />.
		/// </summary>
		public partial class MANUFACTURER : OperatingSystem
		{
			/// <summary>
			/// Constructs a new value type for MANUFACTURER.
			/// </summary>
            public MANUFACTURER(string value) : base(value) { }
		}
    }
}