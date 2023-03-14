#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterInterface.DataItemValues
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public enum AxisStateValues
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// axis is in its home position.
		/// </summary>
		HOME,
		/// <summary>
		﻿/// axis is in motion.
		/// </summary>
		TRAVEL,
		/// <summary>
		﻿/// axis has been moved to a fixed position and is being maintained in that position either electrically or mechanically.   Action is required to release the axis from this position.
		/// </summary>
		PARKED,
		/// <summary>
		﻿/// axis is stopped.
		/// </summary>
		STOPPED,
	}
}