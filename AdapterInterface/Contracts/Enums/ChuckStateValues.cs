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
	public enum ChuckStateValues
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// <see cref="Chuck">Chuck</see> is open to the point of a positive confirmation.
		/// </summary>
		OPEN,
		/// <summary>
		﻿/// <see cref="Chuck">Chuck</see> is closed to the point of a positive confirmation.
		/// </summary>
		CLOSED,
		/// <summary>
		﻿/// <see cref="Chuck">Chuck</see> is not closed to the point of a positive confirmation and not open to the point of a positive confirmation.   It is in an intermediate position.
		/// </summary>
		UNLATCHED,
	}
}