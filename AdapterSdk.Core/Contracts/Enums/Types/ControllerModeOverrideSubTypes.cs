#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk;
using Mtconnect.AdapterSdk.Attributes;

namespace Mtconnect.AdapterSdk.DataItemTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378218236_117661_1659">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.Enum.scriban", "1.0.12.0")]
	public enum ControllerModeOverrideSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// setting or operator selection used to execute a test mode to confirm the execution of machine functions.   When <c>DRY_RUN</c> is <c>ON</c>, the equipment performs all of its normal functions, except no part or product is produced.  If the equipment has a spindle, spindle operation is suspended.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		DRY_RUN,
		/// <summary>
		﻿/// setting or operator selection that changes the behavior of the controller on a piece of equipment.   Program execution is paused after each block of code is executed when <c>SINGLE_BLOCK</c> is <c>ON</c>.     When <c>SINGLE_BLOCK</c> is <c>ON</c>, <see cref="Execution">Execution</see> <b>MUST</b> change to <c>INTERRUPTED</c> after completion of each block of code. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		SINGLE_BLOCK,
		/// <summary>
		﻿/// setting or operator selection that changes the behavior of the controller on a piece of equipment.    When <c>MACHINE_AXIS_LOCK</c> is <c>ON</c>, program execution continues normally, but no equipment motion occurs.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		MACHINE_AXIS_LOCK,
		/// <summary>
		﻿/// setting or operator selection that changes the behavior of the controller on a piece of equipment.   The program execution is stopped after a specific program block is executed when <c>OPTIONAL_STOP</c> is <c>ON</c>.      In the case of a G-Code program, a program block containing a M01 code designates the command for an <c>OPTIONAL_STOP</c>.   <see cref="Execution">Execution</see> <b>MUST</b> change to <c>OPTIONAL_STOP</c> after a program block specifying an optional stop is executed and the <see cref="ControllerModeOverride">ControllerModeOverride</see> <c>OPTIONAL_STOP</c> selection is <c>ON</c>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		OPTIONAL_STOP,
		/// <summary>
		﻿/// setting or operator selection that changes the behavior of the controller on a piece of equipment.    Program execution is paused when a command is executed requesting a cutting tool to be changed.   <see cref="Execution">Execution</see> <b>MUST</b> change to <c>INTERRUPTED</c> after completion of the command requesting a cutting tool to be changed and <c>TOOL_CHANGE_STOP</c> is <c>ON</c>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		TOOL_CHANGE_STOP,
	}
}