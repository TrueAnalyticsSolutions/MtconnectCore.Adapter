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
	public enum ProcessAggregateIdSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// identifier of the authorization of the process occurrence. Synonyms include "job id", "work order".
		/// </summary>
		ORDER_NUMBER,
		/// <summary>
		﻿/// identifier of the step in the process plan that this occurrence corresponds to. Synonyms include "operation id".
		/// </summary>
		PROCESS_STEP,
		/// <summary>
		﻿/// identifier of the process plan that this occurrence belongs to. Synonyms include "routing id", "job id". 
		/// </summary>
		PROCESS_PLAN,
	}
}