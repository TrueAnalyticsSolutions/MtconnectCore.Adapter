#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk;
using Mtconnect.AdapterSdk.Attributes;

namespace Mtconnect.AdapterSdk.DataItemValues
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1660318869483_263921_172">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
	/// </list>
	/// </remarks>
	[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.Enum.scriban", "1.0.12.0")]
	public enum BatteryStateValues
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// <see cref="Component">Component</see> is at it's maximum rated charge level.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		CHARGED,
		/// <summary>
		﻿/// <see cref="Component">Component</see>'s charge is increasing.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		CHARGING,
		/// <summary>
		﻿/// <see cref="Component">Component</see>'s charge is decreasing.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		DISCHARGING,
		/// <summary>
		﻿/// <see cref="Component">Component</see> is at it's minimum charge level.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		DISCHARGED,
	}
}