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
        {
            return new Network(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Network" />.
		/// </summary>
		public partial class IPV4ADDRESS : Network
		{
			/// <summary>
			/// Constructs a new value type for I_PV4_ADDRESS.
			/// </summary>
            public IPV4ADDRESS(string value) : base(value) { }
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
		}
    }
}