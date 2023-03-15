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
	/// A value type for ProgramComment to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class ProgramComment : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the ProgramComment EVENT Data Item.
		/// </summary>
        public ProgramComment(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ProgramComment"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ProgramComment"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ProgramComment"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ProgramComment(string value)
        {
            return new ProgramComment(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProgramComment" />.
		/// </summary>
		public partial class MAIN : ProgramComment
		{
			/// <summary>
			/// Constructs a new value type for MAIN.
			/// </summary>
            public MAIN(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProgramComment" />.
		/// </summary>
		public partial class SCHEDULE : ProgramComment
		{
			/// <summary>
			/// Constructs a new value type for SCHEDULE.
			/// </summary>
            public SCHEDULE(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProgramComment" />.
		/// </summary>
		public partial class ACTIVE : ProgramComment
		{
			/// <summary>
			/// Constructs a new value type for ACTIVE.
			/// </summary>
            public ACTIVE(string value) : base(value) { }
		}
    }
}