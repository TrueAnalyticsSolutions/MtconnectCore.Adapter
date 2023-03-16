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
	/// A value type for Network to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class Network : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the Network EVENT Data Item.
		/// </summary>
        public Network(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="Network"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="Network"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="Network"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Network(string value)
            => new Network(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Network" />.
		/// </summary>
		public partial class IPV4ADDRESS : Network
		{
			/// <summary>
			/// Constructs a new value type for I_PV4_ADDRESS.
			/// </summary>
            public IPV4ADDRESS(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="IPV4ADDRESS"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="IPV4ADDRESS"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="IPV4ADDRESS"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator IPV4ADDRESS(string value)
				=> new IPV4ADDRESS(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Network" />.
		/// </summary>
		public partial class IPV6ADDRESS : Network
		{
			/// <summary>
			/// Constructs a new value type for I_PV6_ADDRESS.
			/// </summary>
            public IPV6ADDRESS(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="IPV6ADDRESS"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="IPV6ADDRESS"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="IPV6ADDRESS"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator IPV6ADDRESS(string value)
				=> new IPV6ADDRESS(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Network" />.
		/// </summary>
		public partial class GATEWAY : Network
		{
			/// <summary>
			/// Constructs a new value type for GATEWAY.
			/// </summary>
            public GATEWAY(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="GATEWAY"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="GATEWAY"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="GATEWAY"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator GATEWAY(string value)
				=> new GATEWAY(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Network" />.
		/// </summary>
		public partial class SUBNETMASK : Network
		{
			/// <summary>
			/// Constructs a new value type for SUBNET_MASK.
			/// </summary>
            public SUBNETMASK(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="SUBNETMASK"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="SUBNETMASK"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="SUBNETMASK"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator SUBNETMASK(string value)
				=> new SUBNETMASK(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Network" />.
		/// </summary>
		public partial class VLANID : Network
		{
			/// <summary>
			/// Constructs a new value type for V_LAN_ID.
			/// </summary>
            public VLANID(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="VLANID"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="VLANID"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="VLANID"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator VLANID(string value)
				=> new VLANID(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Network" />.
		/// </summary>
		public partial class MACADDRESS : Network
		{
			/// <summary>
			/// Constructs a new value type for MAC_ADDRESS.
			/// </summary>
            public MACADDRESS(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="MACADDRESS"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="MACADDRESS"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="MACADDRESS"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator MACADDRESS(string value)
				=> new MACADDRESS(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Network" />.
		/// </summary>
		public partial class WIRELESS : Network
		{
			/// <summary>
			/// Constructs a new value type for WIRELESS.
			/// </summary>
            public WIRELESS(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="WIRELESS"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="WIRELESS"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="WIRELESS"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator WIRELESS(string value)
				=> new WIRELESS(value.ToUpperInvariant());
		}
    }
}