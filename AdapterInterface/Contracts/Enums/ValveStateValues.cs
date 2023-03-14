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
	public enum ValveStateValues
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// <see cref="ValveState">ValveState</see> where flow is allowed and the aperture is static.  > Note: For a binary value, <c>OPEN</c> indicates the valve has the maximum possible aperture.
		/// </summary>
		OPEN,
		/// <summary>
		﻿/// valve is transitioning from a <c>CLOSED</c> state to an <c>OPEN</c> state.
		/// </summary>
		OPENING,
		/// <summary>
		﻿/// <see cref="ValveState">ValveState</see> where flow is not possible, the aperture is static, and the valve is completely shut.
		/// </summary>
		CLOSED,
		/// <summary>
		﻿/// valve is transitioning from an <c>OPEN</c> state to a <c>CLOSED</c> state.
		/// </summary>
		CLOSING,
	}
}