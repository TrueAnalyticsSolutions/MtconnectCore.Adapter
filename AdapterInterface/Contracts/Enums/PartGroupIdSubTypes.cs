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
	public enum PartGroupIdSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// identifier that references a group of parts tracked as a lot. 
		/// </summary>
		LOT,
		/// <summary>
		﻿/// material that is used to produce parts.
		/// </summary>
		RAW_MATERIAL,
		/// <summary>
		﻿/// identifier that references a group of parts produced in a batch.
		/// </summary>
		BATCH,
		/// <summary>
		﻿/// universally unique identifier as specified in ISO 11578 or RFC 4122.
		/// </summary>
		UUID,
		/// <summary>
		﻿/// identifier used to reference a material heat number.
		/// </summary>
		HEAT_TREAT,
	}
}