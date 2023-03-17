#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterInterface.DataItemTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378218480_687893_2289">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public enum VolumeSpatialSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// measured or reported value of an <i>observation</i>.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		ACTUAL,
		/// <summary>
		﻿/// reported or measured value of the amount used in the manufacturing process.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		CONSUMED,
		/// <summary>
		﻿/// reported or measured value of amount included in the <i>part</i>.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
		PART,
		/// <summary>
		﻿/// reported or measured value of the amount discarded
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
		WASTE,
		/// <summary>
		﻿/// boundary when an activity or an event terminates.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
		ENDED,
		/// <summary>
		﻿/// boundary when an activity or an event commences.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
		START,
	}
}