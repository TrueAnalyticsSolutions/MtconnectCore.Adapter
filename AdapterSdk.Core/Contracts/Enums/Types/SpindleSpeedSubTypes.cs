#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk;
using Mtconnect.AdapterSdk.Attributes;

namespace Mtconnect.AdapterSdk.DataItemTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378218447_87713_2190">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v1.2 according to https://model.mtconnect.org/#_Version_1.2")]
	[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0", MtconnectVersions.V_1_2_0)]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.Enum.scriban", "1.0.12.0")]
	public enum SpindleSpeedSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// measured or reported value of an <i>observation</i>.  <b>DEPRECATED</b> in <i>Version 1.3</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.2 according to https://model.mtconnect.org/#_Version_1.2")]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0", MtconnectVersions.V_1_2_0)]
		ACTUAL,
		/// <summary>
		﻿/// directive value including adjustments such as an offset or overrides.  <b>DEPRECATED</b> in <i>Version 1.3</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.2 according to https://model.mtconnect.org/#_Version_1.2")]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0", MtconnectVersions.V_1_2_0)]
		COMMANDED,
		/// <summary>
		﻿/// operator's overridden value.  <b>DEPRECATED</b> in <i>Version 1.3</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.2 according to https://model.mtconnect.org/#_Version_1.2")]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0", MtconnectVersions.V_1_2_0)]
		OVERRIDE,
	}
}