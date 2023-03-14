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
	public enum SoundLevelSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// No weighting factor on the frequency scale
		/// </summary>
		NO_SCALE,
		/// <summary>
		﻿/// A Scale weighting factor.   This is the default weighting factor if no factor is specified
		/// </summary>
		A_SCALE,
		/// <summary>
		﻿/// B Scale weighting factor
		/// </summary>
		B_SCALE,
		/// <summary>
		﻿/// C Scale weighting factor
		/// </summary>
		C_SCALE,
		/// <summary>
		﻿/// D Scale weighting factor
		/// </summary>
		D_SCALE,
	}
}