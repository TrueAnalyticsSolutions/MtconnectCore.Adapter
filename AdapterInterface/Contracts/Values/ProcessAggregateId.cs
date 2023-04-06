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
	/// A value type for ProcessAggregateId to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.7.0")]
	public partial class ProcessAggregateId : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PROCESS_AGGREGATE_ID);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ProcessAggregateId EVENT Data Item.
		/// </summary>
        public ProcessAggregateId(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ProcessAggregateId"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ProcessAggregateId"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ProcessAggregateId"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ProcessAggregateId(string value)
            => new ProcessAggregateId(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessAggregateId" />.
		/// </summary>
		public partial class ORDERNUMBER : ProcessAggregateId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProcessAggregateIdSubTypes.ORDER_NUMBER);

			/// <summary>
			/// Constructs a new value type for ORDER_NUMBER.
			/// </summary>
            public ORDERNUMBER(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="ORDERNUMBER"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="ORDERNUMBER"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="ORDERNUMBER"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ORDERNUMBER(string value)
				=> new ORDERNUMBER(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessAggregateId" />.
		/// </summary>
		public partial class PROCESSSTEP : ProcessAggregateId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProcessAggregateIdSubTypes.PROCESS_STEP);

			/// <summary>
			/// Constructs a new value type for PROCESS_STEP.
			/// </summary>
            public PROCESSSTEP(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="PROCESSSTEP"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="PROCESSSTEP"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="PROCESSSTEP"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator PROCESSSTEP(string value)
				=> new PROCESSSTEP(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessAggregateId" />.
		/// </summary>
		public partial class PROCESSPLAN : ProcessAggregateId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProcessAggregateIdSubTypes.PROCESS_PLAN);

			/// <summary>
			/// Constructs a new value type for PROCESS_PLAN.
			/// </summary>
            public PROCESSPLAN(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="PROCESSPLAN"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="PROCESSPLAN"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="PROCESSPLAN"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator PROCESSPLAN(string value)
				=> new PROCESSPLAN(value.ToUpperInvariant());
		}
    }
}