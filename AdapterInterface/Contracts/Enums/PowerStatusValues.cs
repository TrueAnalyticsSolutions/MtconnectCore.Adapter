#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterInterface.DataItemValues
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_1_0")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public enum PowerStatusValues
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿		/// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_1_0")]
		ON,
		/// <summary>
		﻿		/// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_1_0")]
		OFF,
	}
}