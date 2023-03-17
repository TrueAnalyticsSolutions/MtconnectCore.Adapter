#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterInterface.DataItemTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605549692001_598671_1420">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public enum ProcessOccurrenceIdSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// phase or segment of a recipe or program.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see>.</remarks>
		ACTIVITY,
		/// <summary>
		﻿/// phase of a recipe process.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see>.</remarks>
		SEGMENT,
		/// <summary>
		﻿/// process as part of product production; can be a subprocess of a larger process.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see>.</remarks>
		RECIPE,
		/// <summary>
		﻿/// step of a discrete manufacturing process.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see>.</remarks>
		OPERATION,
	}
}