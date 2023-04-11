#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterInterface.DataItemTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605549689754_638221_1396">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public enum ProcessAggregateIdSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// identifier of the authorization of the process occurrence. Synonyms include "job id", "work order".
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		ORDER_NUMBER,
		/// <summary>
		﻿/// identifier of the step in the process plan that this occurrence corresponds to. Synonyms include "operation id".
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		PROCESS_STEP,
		/// <summary>
		﻿/// identifier of the process plan that this occurrence belongs to. Synonyms include "routing id", "job id". 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		PROCESS_PLAN,
	}
}