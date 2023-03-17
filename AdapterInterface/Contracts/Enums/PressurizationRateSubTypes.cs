#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterInterface.DataItemTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605117348980_941318_2004">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public enum PressurizationRateSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// directive value including adjustments such as an offset or overrides.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
		COMMANDED,
		/// <summary>
		﻿/// measured or reported value of an <i>observation</i>.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
		ACTUAL,
		/// <summary>
		﻿/// directive value without offsets and adjustments.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
		PROGRAMMED,
	}
}