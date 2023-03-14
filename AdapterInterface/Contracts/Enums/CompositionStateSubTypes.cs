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
	public enum CompositionStateSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// indication of the operating state of a mechanism.
		/// </summary>
		ACTION,
		/// <summary>
		﻿/// indication of the position of a mechanism that may move in a lateral direction.   
		/// </summary>
		LATERAL,
		/// <summary>
		﻿/// indication of the open or closed state of a mechanism. 
		/// </summary>
		MOTION,
		/// <summary>
		﻿/// indication of the activation state of a mechanism.
		/// </summary>
		SWITCHED,
		/// <summary>
		﻿/// indication of the position of a mechanism that may move in a vertical direction.
		/// </summary>
		VERTICAL,
	}
}