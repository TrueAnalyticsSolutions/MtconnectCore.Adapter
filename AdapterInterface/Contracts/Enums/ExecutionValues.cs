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
	public enum ExecutionValues
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// <see cref="Component">Component</see> is ready to execute instructions.  It is currently idle.
		/// </summary>
		READY,
		/// <summary>
		﻿/// <see cref="Component">Component</see> is actively executing an instruction.
		/// </summary>
		ACTIVE,
		/// <summary>
		﻿/// <see cref="Component">Component</see> suspends the execution of the program due to an external signal.  Action is required to resume execution.
		/// </summary>
		INTERRUPTED,
		/// <summary>
		﻿/// motion of the active axes are commanded to stop at their current position.
		/// </summary>
		FEED_HOLD,
		/// <summary>
		﻿/// <see cref="Component">Component</see> program is not <c>READY</c> to execute.
		/// </summary>
		STOPPED,
		/// <summary>
		﻿/// command from the program has intentionally interrupted execution.  The <see cref="Component">Component</see> <b>MAY</b> have another state that indicates if the execution is interrupted or the execution ignores the interrupt instruction.
		/// </summary>
		OPTIONAL_STOP,
		/// <summary>
		﻿/// command from the program has intentionally interrupted execution.  Action is required to resume execution.
		/// </summary>
		PROGRAM_STOPPED,
		/// <summary>
		﻿/// program completed execution.
		/// </summary>
		PROGRAM_COMPLETED,
		/// <summary>
		﻿/// <see cref="Component">Component</see> suspends execution while a secondary operation executes.  Execution resumes automatically once the secondary operation completes.
		/// </summary>
		WAIT,
	}
}