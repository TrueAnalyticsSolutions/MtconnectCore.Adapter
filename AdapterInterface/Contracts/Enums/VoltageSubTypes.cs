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
	[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_6_0")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public enum VoltageSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// alternating voltage or current.   If not specified further in statistic, defaults to RMS voltage.   <b>DEPRECATED</b> in <i>Version 1.6</i>.
		/// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_6_0")]
		ALTERNATING,
		/// <summary>
		﻿/// DC current or voltage.  <b>DEPRECATED</b> in <i>Version 1.6</i>.
		/// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_6_0")]
		DIRECT,
		/// <summary>
		﻿/// measured or reported value of an <i>observation</i>.  <b>DEPRECATED</b> in <i>Version 1.6</i>.
		/// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_6_0")]
		ACTUAL,
		/// <summary>
		﻿/// goal of the operation or process.  <b>DEPRECATED</b> in <i>Version 1.6</i>.
		/// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_6_0")]
		TARGET,
	}
}