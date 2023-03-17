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
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public enum EndOfBarSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// specific applications <b>MAY</b> reference one or more locations on a piece of bar stock as the indication for the <see cref="EndOfBar">EndOfBar</see>.   The main or most important location <b>MUST</b> be designated as the <see cref="PRIMARY">PRIMARY</see> indication for the <see cref="EndOfBar">EndOfBar</see>.  If no <see cref="subType">subType</see> is specified, <see cref="PRIMARY">PRIMARY</see> <b>MUST</b> be the default <see cref="EndOfBar">EndOfBar</see> indication.
		/// </summary>
		PRIMARY,
		/// <summary>
		﻿/// when multiple locations on a piece of bar stock are referenced as the indication for the <see cref="EndOfBar">EndOfBar</see>, the additional location(s) <b>MUST</b> be designated as <c>AUXILIARY</c> indication(s) for the <see cref="EndOfBar">EndOfBar</see>.  
		/// </summary>
		AUXILIARY,
	}
}