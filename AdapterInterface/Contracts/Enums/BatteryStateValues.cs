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
	public enum BatteryStateValues
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// <see cref="Component">Component</see> is at it's maximum rated charge level.
		/// </summary>
		CHARGED,
		/// <summary>
		﻿/// <see cref="Component">Component</see>'s charge is increasing.
		/// </summary>
		CHARGING,
		/// <summary>
		﻿/// <see cref="Component">Component</see>'s charge is decreasing.
		/// </summary>
		DISCHARGING,
		/// <summary>
		﻿/// <see cref="Component">Component</see> is at it's minimum charge level.
		/// </summary>
		DISCHARGED,
	}
}