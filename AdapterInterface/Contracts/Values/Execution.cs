#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItems;
using Mtconnect.AdapterInterface.DataItemValues;

namespace Mtconnect.AdapterInterface.DataItemValues
{
	/// <summary>
	/// A value type for Execution to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class Execution : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the Execution EVENT Data Item.
		/// </summary>
        public Execution(string value) : base(value) { }

        /// <summary>
		﻿/// <see cref="Component">Component</see> is ready to execute instructions.  It is currently idle.
        /// </summary>
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution READY => new Execution(nameof(ExecutionValues.READY));
        /// <summary>
		﻿/// <see cref="Component">Component</see> is actively executing an instruction.
        /// </summary>
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution ACTIVE => new Execution(nameof(ExecutionValues.ACTIVE));
        /// <summary>
		﻿/// <see cref="Component">Component</see> suspends the execution of the program due to an external signal.  Action is required to resume execution.
        /// </summary>
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution INTERRUPTED => new Execution(nameof(ExecutionValues.INTERRUPTED));
        /// <summary>
		﻿/// motion of the active axes are commanded to stop at their current position.
        /// </summary>
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution FEED_HOLD => new Execution(nameof(ExecutionValues.FEED_HOLD));
        /// <summary>
		﻿/// <see cref="Component">Component</see> program is not <c>READY</c> to execute.
        /// </summary>
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution STOPPED => new Execution(nameof(ExecutionValues.STOPPED));
        /// <summary>
		﻿/// command from the program has intentionally interrupted execution.  The <see cref="Component">Component</see> <b>MAY</b> have another state that indicates if the execution is interrupted or the execution ignores the interrupt instruction.
        /// </summary>
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution OPTIONAL_STOP => new Execution(nameof(ExecutionValues.OPTIONAL_STOP));
        /// <summary>
		﻿/// command from the program has intentionally interrupted execution.  Action is required to resume execution.
        /// </summary>
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution PROGRAM_STOPPED => new Execution(nameof(ExecutionValues.PROGRAM_STOPPED));
        /// <summary>
		﻿/// program completed execution.
        /// </summary>
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution PROGRAM_COMPLETED => new Execution(nameof(ExecutionValues.PROGRAM_COMPLETED));
        /// <summary>
		﻿/// <see cref="Component">Component</see> suspends execution while a secondary operation executes.  Execution resumes automatically once the secondary operation completes.
        /// </summary>
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution WAIT => new Execution(nameof(ExecutionValues.WAIT));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="Execution"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="Execution"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="Execution"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Execution(string value)
            => new Execution(value.ToUpperInvariant());
		
    }
}