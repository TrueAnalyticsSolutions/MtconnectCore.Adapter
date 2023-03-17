#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterInterface.DataItemTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1587751252597_838265_2577">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public enum LibrarySubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// version of the hardware or software.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		VERSION,
		/// <summary>
		﻿/// date the hardware or software was released for general use.  
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		RELEASE_DATE,
		/// <summary>
		﻿/// corporate identity for the maker of the hardware or software.  
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		MANUFACTURER,
		/// <summary>
		﻿/// license code to validate or activate the hardware or software.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		LICENSE,
		/// <summary>
		﻿/// date the hardware or software was installed.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		INSTALL_DATE,
	}
}