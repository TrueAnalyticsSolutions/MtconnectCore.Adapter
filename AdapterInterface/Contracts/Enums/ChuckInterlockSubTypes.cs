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
	public enum ChuckInterlockSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// indication of the state of an operator controlled interlock that can inhibit the ability to initiate an unclamp action of an electronically controlled chuck.  When <see cref="ChuckInterlockManualUnclamp">ChuckInterlockManualUnclamp</see> is <c>ACTIVE</c>, it is expected that a chuck cannot be unclamped until <see cref="ChuckInterlockManualUnclamp">ChuckInterlockManualUnclamp</see> is set to <c>INACTIVE</c>. 
		/// </summary>
		MANUAL_UNCLAMP,
	}
}