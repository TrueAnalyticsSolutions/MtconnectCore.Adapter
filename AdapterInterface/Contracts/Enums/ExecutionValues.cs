#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterInterface.DataItemValues
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417664_592980_2878">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public enum ExecutionValues
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// <see cref="Component">Component</see> is ready to execute instructions.  It is currently idle.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		READY,
		/// <summary>
		﻿/// <see cref="Component">Component</see> is actively executing an instruction.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		ACTIVE,
		/// <summary>
		﻿/// <see cref="Component">Component</see> suspends the execution of the program due to an external signal.  Action is required to resume execution.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		INTERRUPTED,
		/// <summary>
		﻿/// motion of the active axes are commanded to stop at their current position.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		FEED_HOLD,
		/// <summary>
		﻿/// <see cref="Component">Component</see> program is not <c>READY</c> to execute.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		STOPPED,
		/// <summary>
		﻿/// command from the program has intentionally interrupted execution.  The <see cref="Component">Component</see> <b>MAY</b> have another state that indicates if the execution is interrupted or the execution ignores the interrupt instruction.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		OPTIONAL_STOP,
		/// <summary>
		﻿/// command from the program has intentionally interrupted execution.  Action is required to resume execution.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		PROGRAM_STOPPED,
		/// <summary>
		﻿/// program completed execution.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		PROGRAM_COMPLETED,
		/// <summary>
		﻿/// <see cref="Component">Component</see> suspends execution while a secondary operation executes.  Execution resumes automatically once the secondary operation completes.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		WAIT,
	}
}