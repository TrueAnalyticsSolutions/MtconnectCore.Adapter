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
	/// A value type for ProcessOccurrenceId to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class ProcessOccurrenceId : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PROCESS_OCCURRENCE_ID);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ProcessOccurrenceId EVENT Data Item.
		/// </summary>
        public ProcessOccurrenceId(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ProcessOccurrenceId"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ProcessOccurrenceId"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ProcessOccurrenceId"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ProcessOccurrenceId(string value)
            => new ProcessOccurrenceId(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessOccurrenceId" />.
		/// </summary>
		public partial class ACTIVITY : ProcessOccurrenceId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProcessOccurrenceIdSubTypes.ACTIVITY);

			/// <summary>
			/// Constructs a new value type for ACTIVITY.
			/// </summary>
            public ACTIVITY(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="ACTIVITY"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="ACTIVITY"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="ACTIVITY"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ACTIVITY(string value)
				=> new ACTIVITY(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessOccurrenceId" />.
		/// </summary>
		public partial class SEGMENT : ProcessOccurrenceId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProcessOccurrenceIdSubTypes.SEGMENT);

			/// <summary>
			/// Constructs a new value type for SEGMENT.
			/// </summary>
            public SEGMENT(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="SEGMENT"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="SEGMENT"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="SEGMENT"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator SEGMENT(string value)
				=> new SEGMENT(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessOccurrenceId" />.
		/// </summary>
		public partial class RECIPE : ProcessOccurrenceId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProcessOccurrenceIdSubTypes.RECIPE);

			/// <summary>
			/// Constructs a new value type for RECIPE.
			/// </summary>
            public RECIPE(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="RECIPE"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="RECIPE"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="RECIPE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator RECIPE(string value)
				=> new RECIPE(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessOccurrenceId" />.
		/// </summary>
		public partial class OPERATION : ProcessOccurrenceId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProcessOccurrenceIdSubTypes.OPERATION);

			/// <summary>
			/// Constructs a new value type for OPERATION.
			/// </summary>
            public OPERATION(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="OPERATION"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="OPERATION"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="OPERATION"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator OPERATION(string value)
				=> new OPERATION(value.ToUpperInvariant());
		}
    }
}