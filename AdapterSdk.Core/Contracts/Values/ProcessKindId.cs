#pragma warning disable 0618
#pragma warning disable 1574
#pragma warning disable CS1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk;
using Mtconnect.AdapterSdk.Attributes;
using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.DataItemValues;
using Mtconnect.AdapterSdk.Units;

namespace Mtconnect.AdapterSdk.DataItemValues
{
	/// <summary>
	/// A value type for ProcessKindId to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class ProcessKindId : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PROCESS_KIND_ID);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ProcessKindId EVENT Data Item.
		/// </summary>
        public ProcessKindId(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ProcessKindId"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ProcessKindId"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ProcessKindId"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ProcessKindId(string value)
            => new ProcessKindId(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessKindId" />.
		/// </summary>
		public partial class UUID : ProcessKindId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProcessKindIdSubTypes.UUID);

			/// <summary>
			/// Constructs a new value type for UUID.
			/// </summary>
            public UUID(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="UUID"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="UUID"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="UUID"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator UUID(string value)
				=> new UUID(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessKindId" />.
		/// </summary>
		public partial class ISOSTEPEXECUTABLE : ProcessKindId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProcessKindIdSubTypes.ISO_STEP_EXECUTABLE);

			/// <summary>
			/// Constructs a new value type for ISO_STEP_EXECUTABLE.
			/// </summary>
            public ISOSTEPEXECUTABLE(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="ISOSTEPEXECUTABLE"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="ISOSTEPEXECUTABLE"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="ISOSTEPEXECUTABLE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ISOSTEPEXECUTABLE(string value)
				=> new ISOSTEPEXECUTABLE(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessKindId" />.
		/// </summary>
		public partial class PROCESSNAME : ProcessKindId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProcessKindIdSubTypes.PROCESS_NAME);

			/// <summary>
			/// Constructs a new value type for PROCESS_NAME.
			/// </summary>
            public PROCESSNAME(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="PROCESSNAME"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="PROCESSNAME"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="PROCESSNAME"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator PROCESSNAME(string value)
				=> new PROCESSNAME(value.ToUpperInvariant());
		}
    }
}