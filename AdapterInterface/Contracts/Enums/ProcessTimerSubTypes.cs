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
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public enum ProcessTimerSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// time from the beginning of production of a part or product on a piece of equipment until the time that production is complete for that part or product on that piece of equipment.  This includes the time that the piece of equipment is running, producing parts or products, or in the process of producing parts.
		/// </summary>
		PROCESS,
		/// <summary>
		﻿/// elapsed time of a temporary halt of action.
		/// </summary>
		DELAY,
	}
}