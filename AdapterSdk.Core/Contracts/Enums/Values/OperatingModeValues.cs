#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk;
using Mtconnect.AdapterSdk.Attributes;

namespace Mtconnect.AdapterSdk.DataItemValues
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1637936591972_920420_100">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
	/// </list>
	/// </remarks>
	[MtconnectVersion(MtconnectVersions.V_2_0_0, "https://model.mtconnect.org/#_Version_2.0")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.Enum.scriban", "1.0.12.0")]
	public enum OperatingModeValues
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// automatically execute instructions from a recipe or program.  > Note: Setpoint comes from a recipe.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_0_0, "https://model.mtconnect.org/#_Version_2.0")]
		AUTOMATIC,
		/// <summary>
		﻿/// execute instructions from an external agent or person.  > Note 1 to entry: Valve or switch is manipulated by an agent/person.  > Note 2 to entry: Direct control of the PID output. % of the range: A user manually sets the % output, not the setpoint.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_0_0, "https://model.mtconnect.org/#_Version_2.0")]
		MANUAL,
		/// <summary>
		﻿/// executes a single instruction from a recipe or program.  > Note 1 to entry: Setpoint is entered and fixed, but the PID is controlling.  > Note 2 to entry: Still goes through the PID control system.  > Note 3 to entry: Manual fixed entry from a recipe.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_0_0, "https://model.mtconnect.org/#_Version_2.0")]
		SEMI_AUTOMATIC,
	}
}