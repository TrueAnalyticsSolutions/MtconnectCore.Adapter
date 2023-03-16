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
	/// A value type for ProcessState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class ProcessState : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the ProcessState EVENT Data Item.
		/// </summary>
        public ProcessState(string value) : base(value) { }

        /// <summary>
		﻿/// device is preparing to execute the process occurrence.
        /// </summary>
		[ObservationalValue(typeof(ProcessStateValues))]
        public static ProcessState INITIALIZING => new ProcessState(nameof(ProcessStateValues.INITIALIZING));
        /// <summary>
		﻿/// process occurrence is ready to be executed.
        /// </summary>
		[ObservationalValue(typeof(ProcessStateValues))]
        public static ProcessState READY => new ProcessState(nameof(ProcessStateValues.READY));
        /// <summary>
		﻿/// process occurrence is actively executing.
        /// </summary>
		[ObservationalValue(typeof(ProcessStateValues))]
        public static ProcessState ACTIVE => new ProcessState(nameof(ProcessStateValues.ACTIVE));
        /// <summary>
		﻿/// process occurrence is now finished.
        /// </summary>
		[ObservationalValue(typeof(ProcessStateValues))]
        public static ProcessState COMPLETE => new ProcessState(nameof(ProcessStateValues.COMPLETE));
        /// <summary>
		﻿/// process occurrence has been stopped and may be resumed.
        /// </summary>
		[ObservationalValue(typeof(ProcessStateValues))]
        public static ProcessState INTERRUPTED => new ProcessState(nameof(ProcessStateValues.INTERRUPTED));
        /// <summary>
		﻿/// process occurrence has come to a premature end and cannot be resumed.
        /// </summary>
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