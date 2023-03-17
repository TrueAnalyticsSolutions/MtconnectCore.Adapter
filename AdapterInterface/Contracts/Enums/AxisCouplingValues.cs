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
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public enum AxisCouplingValues
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// axes are physically connected to each other and operate as a single unit.
		/// </summary>
		TANDEM,
		/// <summary>
		﻿/// axes are not physically connected to each other but are operating together in lockstep.
		/// </summary>
		SYNCHRONOUS,
		/// <summary>
		﻿/// axis is the master of the <see cref="CoupledAxes">CoupledAxes</see>.
		/// </summary>
		MASTER,
		/// <summary>
		﻿/// axis is a slave to the <see cref="CoupledAxes">CoupledAxes</see>.
		/// </summary>
		SLAVE,
	}
}