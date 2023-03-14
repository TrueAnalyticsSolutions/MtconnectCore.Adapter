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
	public enum PartKindIdSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// universally unique identifier as specified in ISO 11578 or RFC 4122.
		/// </summary>
		UUID,
		/// <summary>
		﻿/// identifier given to a group of parts having similarities in geometry, manufacturing process, and/or functions.
		/// </summary>
		PART_FAMILY,
		/// <summary>
		﻿/// word or set of words by which a part is known, addressed, or referred to.
		/// </summary>
		PART_NAME,
		/// <summary>
		﻿/// identifier of a particular part design or model.
		/// </summary>
		PART_NUMBER,
	}
}