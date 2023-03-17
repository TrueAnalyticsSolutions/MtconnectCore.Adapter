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
	/// A value type for ProcessTimer to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class ProcessTimer : SampleValue
    {
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