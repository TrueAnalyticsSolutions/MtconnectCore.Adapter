#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterInterface.DataItemTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378218469_994902_2259">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
	/// <remarks>Deprecated in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
	[Obsolete("Deprecated in v1.6 according to https://model.mtconnect.org/#_Version_1.6")]
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
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		/// <remarks>Deprecated in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		[Obsolete("Deprecated in v1.6 according to https://model.mtconnect.org/#_Version_1.6")]
		ALTERNATING,
		/// <summary>
		﻿/// DC current or voltage.  <b>DEPRECATED</b> in <i>Version 1.6</i>.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		/// <remarks>Deprecated in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		[Obsolete("Deprecated in v1.6 according to https://model.mtconnect.org/#_Version_1.6")]
		DIRECT,
		/// <summary>
		﻿/// measured or reported value of an <i>observation</i>.  <b>DEPRECATED</b> in <i>Version 1.6</i>.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		/// <remarks>Deprecated in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		[Obsolete("Deprecated in v1.6 according to https://model.mtconnect.org/#_Version_1.6")]
		ACTUAL,
		/// <summary>
		﻿/// goal of the operation or process.  <b>DEPRECATED</b> in <i>Version 1.6</i>.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		/// <remarks>Deprecated in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		[Obsolete("Deprecated in v1.6 according to https://model.mtconnect.org/#_Version_1.6")]
		TARGET,
	}
}