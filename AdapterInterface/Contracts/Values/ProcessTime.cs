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
	/// A value type for ProcessTime to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.5.0")]
	public partial class ProcessTime : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PROCESS_TIME);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ProcessTime EVENT Data Item.
		/// </summary>
        public ProcessTime(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ProcessTime"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ProcessTime"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ProcessTime"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ProcessTime(string value)
            => new ProcessTime(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessTime" />.
		/// </summary>
		public partial class START : ProcessTime
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProcessTimeSubTypes.START);

			/// <summary>
			/// Constructs a new value type for START.
			/// </summary>
            public START(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="START"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="START"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="START"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator START(string value)
				=> new START(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessTime" />.
		/// </summary>
		public partial class COMPLETE : ProcessTime
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProcessTimeSubTypes.COMPLETE);

			/// <summary>
			/// Constructs a new value type for COMPLETE.
			/// </summary>
            public COMPLETE(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="COMPLETE"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="COMPLETE"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="COMPLETE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator COMPLETE(string value)
				=> new COMPLETE(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessTime" />.
		/// </summary>
		public partial class TARGETCOMPLETION : ProcessTime
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProcessTimeSubTypes.TARGET_COMPLETION);

			/// <summary>
			/// Constructs a new value type for TARGET_COMPLETION.
			/// </summary>
            public TARGETCOMPLETION(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="TARGETCOMPLETION"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="TARGETCOMPLETION"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="TARGETCOMPLETION"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator TARGETCOMPLETION(string value)
				=> new TARGETCOMPLETION(value.ToUpperInvariant());
		}
    }
}