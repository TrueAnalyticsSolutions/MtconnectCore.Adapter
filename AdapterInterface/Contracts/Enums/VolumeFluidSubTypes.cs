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
	public enum VolumeFluidSubTypes
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
		﻿/// reported or measured value of the amount used in the manufacturing process.
		/// </summary>
		CONSUMED,
		/// <summary>
		﻿/// reported or measured value of amount included in the <i>part</i>.
		/// </summary>
		PART,
		/// <summary>
		﻿/// reported or measured value of the amount discarded.
		/// </summary>
		WASTE,
		/// <summary>
		﻿/// boundary when an activity or an event commences.
		/// </summary>
		START,
		/// <summary>
		﻿/// boundary when an activity or an event terminates.
		/// </summary>
		ENDED,
	}
}