#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItems;
using Mtconnect.AdapterInterface.DataItemValues;
using Mtconnect.AdapterInterface.Units;

namespace Mtconnect.AdapterInterface.DataItemValues
{
	/// <summary>
	/// A value type for ProcessState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605550283222_680737_1925">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.5.0")]
	public partial class ProcessState : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PROCESS_STATE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ProcessState EVENT Data Item.
		/// </summary>
        public ProcessState(string value) : base(value) { }

        /// <summary>
		﻿/// device is preparing to execute the process occurrence.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ProcessStateValues))]
        public static ProcessState INITIALIZING => new ProcessState(nameof(ProcessStateValues.INITIALIZING));
        /// <summary>
		﻿/// process occurrence is ready to be executed.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ProcessStateValues))]
        public static ProcessState READY => new ProcessState(nameof(ProcessStateValues.READY));
        /// <summary>
		﻿/// process occurrence is actively executing.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ProcessStateValues))]
        public static ProcessState ACTIVE => new ProcessState(nameof(ProcessStateValues.ACTIVE));
        /// <summary>
		﻿/// process occurrence is now finished.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ProcessStateValues))]
        public static ProcessState COMPLETE => new ProcessState(nameof(ProcessStateValues.COMPLETE));
        /// <summary>
		﻿/// process occurrence has been stopped and may be resumed.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ProcessStateValues))]
        public static ProcessState INTERRUPTED => new ProcessState(nameof(ProcessStateValues.INTERRUPTED));
        /// <summary>
		﻿/// process occurrence has come to a premature end and cannot be resumed.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ProcessStateValues))]
        public static ProcessState ABORTED => new ProcessState(nameof(ProcessStateValues.ABORTED));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ProcessState"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ProcessState"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ProcessState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ProcessState(string value)
            => new ProcessState(value.ToUpperInvariant());
		
    }
}