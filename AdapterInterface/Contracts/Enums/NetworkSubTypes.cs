#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterInterface.DataItemTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1587752011247_360664_3696">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public enum NetworkSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// IPV4 network address of the component. 
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		I_PV4_ADDRESS,
		/// <summary>
		﻿/// IPV6 network address of the component. 
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		I_PV6_ADDRESS,
		/// <summary>
		﻿/// Gateway for the component network.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		GATEWAY,
		/// <summary>
		﻿/// SubNet mask for the component network. 
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		SUBNET_MASK,
		/// <summary>
		﻿/// layer2 Virtual Local Network (VLAN) ID for the component network.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		V_LAN_ID,
		/// <summary>
		﻿/// Media Access Control Address.   The unique physical address of the network hardware. 
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		MAC_ADDRESS,
		/// <summary>
		﻿/// identifies whether the connection type is wireless.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		WIRELESS,
	}
}