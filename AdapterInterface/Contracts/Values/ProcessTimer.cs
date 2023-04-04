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
	/// A value type for ProcessTimer to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// <item><b>Units</b>: <see cref="MtconnectUnit.SECOND" /></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.6.0")]
	public partial class ProcessTimer : SampleValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.SampleTypes.PROCESS_TIMER);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ProcessTimer EVENT Data Item.
		/// </summary>
        public ProcessTimer(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="ProcessTimer"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="ProcessTimer"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="ProcessTimer"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ProcessTimer(float value)
            => new ProcessTimer(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessTimer" />.
		/// </summary>
		public partial class PROCESS : ProcessTimer
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProcessTimerSubTypes.PROCESS);

			/// <summary>
			/// Constructs a new value type for PROCESS.
			/// </summary>
            public PROCESS(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="PROCESS"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="PROCESS"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="PROCESS"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator PROCESS(float value)
				=> new PROCESS(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessTimer" />.
		/// </summary>
		public partial class DELAY : ProcessTimer
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProcessTimerSubTypes.DELAY);

			/// <summary>
			/// Constructs a new value type for DELAY.
			/// </summary>
            public DELAY(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="DELAY"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="DELAY"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="DELAY"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator DELAY(float value)
				=> new DELAY(value);
		}
    }
}