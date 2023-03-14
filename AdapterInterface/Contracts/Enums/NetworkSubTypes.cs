#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterInterface.DataItemTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public enum NetworkSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// IPV4 network address of the component. 
		/// </summary>
		I_PV4_ADDRESS,
		/// <summary>
		﻿/// IPV6 network address of the component. 
		/// </summary>
		I_PV6_ADDRESS,
		/// <summary>
		﻿/// Gateway for the component network.
		/// </summary>
		GATEWAY,
		/// <summary>
		﻿/// SubNet mask for the component network. 
		/// </summary>
		SUBNET_MASK,
		/// <summary>
		﻿/// layer2 Virtual Local Network (VLAN) ID for the component network.
		/// </summary>
		V_LAN_ID,
		/// <summary>
		﻿/// Media Access Control Address.   The unique physical address of the network hardware. 
		/// </summary>
		MAC_ADDRESS,
		/// <summary>
		﻿/// identifies whether the connection type is wireless.
		/// </summary>
		WIRELESS,
	}
}