#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk;
using Mtconnect.AdapterSdk.Attributes;

namespace Mtconnect.AdapterSdk.DataItemValues
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417652_570136_2869">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>
	[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.Enum.scriban", "1.0.12.0")]
	public enum ActuatorStateValues
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// <see cref="Actuator">Actuator</see> is operating.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		ACTIVE,
		/// <summary>
		﻿/// <see cref="Actuator">Actuator</see> is not operating.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		INACTIVE,
	}
}