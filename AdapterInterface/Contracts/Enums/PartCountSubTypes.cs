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
	public enum PartCountSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// accumulation of all actions, items, or activities being counted independent of the outcome.
		/// </summary>
		ALL,
		/// <summary>
		﻿/// accumulation of actions, items, or activities being counted that conform to specification or expectation.
		/// </summary>
		GOOD,
		/// <summary>
		﻿/// accumulation of actions, items, or activities being counted that do not conform to specification or expectation.
		/// </summary>
		BAD,
		/// <summary>
		﻿/// goal of the operation or process.
		/// </summary>
		TARGET,
		/// <summary>
		﻿/// accumulation of actions, items, or activities yet to be counted.
		/// </summary>
		REMAINING,
		/// <summary>
		﻿/// accumulation of actions, items, or activities that have been completed, independent of the outcome.
		/// </summary>
		COMPLETE,
		/// <summary>
		﻿/// accumulation of actions or activities that were attempted, but terminated before they could be completed.
		/// </summary>
		ABORTED,
		/// <summary>
		﻿/// accumulation of actions or activities that were attempted, but failed to complete or resulted in an unexpected or unacceptable outcome.
		/// </summary>
		FAILED,
	}
}