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
	public enum ProgramEditValues
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// <see cref="Controller">Controller</see> is in the program edit mode.
		/// </summary>
		ACTIVE,
		/// <summary>
		﻿/// <see cref="Controller">Controller</see> is capable of entering the program edit mode and no function is inhibiting a change to that mode.
		/// </summary>
		READY,
		/// <summary>
		﻿/// <see cref="Controller">Controller</see> is being inhibited by a function from entering the program edit mode.
		/// </summary>
		NOT_READY,
	}
}