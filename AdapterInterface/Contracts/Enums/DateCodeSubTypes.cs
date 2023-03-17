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
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public enum DateCodeSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// time and date code relating to the production of a material or other physical item.
		/// </summary>
		MANUFACTURE,
		/// <summary>
		﻿/// time and date code relating to the expiration or end of useful life for a material or other physical item.
		/// </summary>
		EXPIRATION,
		/// <summary>
		﻿/// time and date code relating the first use of a material or other physical item.
		/// </summary>
		FIRST_USE,
	}
}