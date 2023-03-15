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
	/// A value type for ProcessTime to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class ProcessTime : EventValue
    {
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
        {
            return new ProcessTime(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessTime" />.
		/// </summary>
		public partial class START : ProcessTime
		{
			/// <summary>
			/// Constructs a new value type for START.
			/// </summary>
            public START(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessTime" />.
		/// </summary>
		public partial class COMPLETE : ProcessTime
		{
			/// <summary>
			/// Constructs a new value type for COMPLETE.
			/// </summary>
            public COMPLETE(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessTime" />.
		/// </summary>
		public partial class TARGETCOMPLETION : ProcessTime
		{
			/// <summary>
			/// Constructs a new value type for TARGET_COMPLETION.
			/// </summary>
            public TARGETCOMPLETION(string value) : base(value) { }
		}
    }
}