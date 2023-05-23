#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk.Contracts.Attributes;
using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.DataItemValues;
using Mtconnect.AdapterSdk.Units;

namespace Mtconnect.AdapterSdk.DataItemValues
{
	/// <summary>
	/// A value type for Execution to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417664_592980_2878">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class Execution : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.EXECUTION);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the Execution EVENT Data Item.
		/// </summary>
        public Execution(string value) : base(value) { }

        /// <summary>
		﻿/// <see cref="Component">Component</see> is ready to execute instructions.  It is currently idle.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution READY => new Execution(nameof(ExecutionValues.READY));
        /// <summary>
		﻿/// <see cref="Component">Component</see> is actively executing an instruction.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution ACTIVE => new Execution(nameof(ExecutionValues.ACTIVE));
        /// <summary>
		﻿/// <see cref="Component">Component</see> suspends the execution of the program due to an external signal.  Action is required to resume execution.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution INTERRUPTED => new Execution(nameof(ExecutionValues.INTERRUPTED));
        /// <summary>
		﻿/// motion of the active axes are commanded to stop at their current position.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution FEED_HOLD => new Execution(nameof(ExecutionValues.FEED_HOLD));
        /// <summary>
		﻿/// <see cref="Component">Component</see> program is not <c>READY</c> to execute.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution STOPPED => new Execution(nameof(ExecutionValues.STOPPED));
        /// <summary>
		﻿/// command from the program has intentionally interrupted execution.  The <see cref="Component">Component</see> <b>MAY</b> have another state that indicates if the execution is interrupted or the execution ignores the interrupt instruction.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution OPTIONAL_STOP => new Execution(nameof(ExecutionValues.OPTIONAL_STOP));
        /// <summary>
		﻿/// command from the program has intentionally interrupted execution.  Action is required to resume execution.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution PROGRAM_STOPPED => new Execution(nameof(ExecutionValues.PROGRAM_STOPPED));
        /// <summary>
		﻿/// program completed execution.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution PROGRAM_COMPLETED => new Execution(nameof(ExecutionValues.PROGRAM_COMPLETED));
        /// <summary>
		﻿/// <see cref="Component">Component</see> suspends execution while a secondary operation executes.  Execution resumes automatically once the secondary operation completes.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
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