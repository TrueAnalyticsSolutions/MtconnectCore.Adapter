#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk;
using Mtconnect.AdapterSdk.Attributes;

namespace Mtconnect.AdapterSdk.DataItemTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378218246_14931_1680">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>
	[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.Enum.scriban", "1.0.12.0")]
	public enum CuttingSpeedSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// measured or reported value of an <i>observation</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		ACTUAL,
		/// <summary>
		﻿/// directive value including adjustments such as an offset or overrides.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		COMMANDED,
		/// <summary>
		﻿/// directive value without offsets and adjustments.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		PROGRAMMED,
	}
}