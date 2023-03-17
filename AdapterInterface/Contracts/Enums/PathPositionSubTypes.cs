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
	public enum PathPositionSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// measured or reported value of an <i>observation</i>.
		/// </summary>
		ACTUAL,
		/// <summary>
		﻿/// directive value including adjustments such as an offset or overrides.
		/// </summary>
		COMMANDED,
		/// <summary>
		﻿/// goal of the operation or process.
		/// </summary>
		TARGET,
		/// <summary>
		﻿/// position provided by a measurement probe.  <b>DEPRECATION WARNING</b>: May be deprecated in the future.
		/// </summary>
		PROBE,
	}
}