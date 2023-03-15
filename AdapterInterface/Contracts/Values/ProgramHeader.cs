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
	/// A value type for ProgramHeader to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class ProgramHeader : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the ProgramHeader EVENT Data Item.
		/// </summary>
        public ProgramHeader(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ProgramHeader"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ProgramHeader"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ProgramHeader"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ProgramHeader(string value)
        {
            return new ProgramHeader(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProgramHeader" />.
		/// </summary>
		public partial class MAIN : ProgramHeader
		{
			/// <summary>
			/// Constructs a new value type for MAIN.
			/// </summary>
            public MAIN(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProgramHeader" />.
		/// </summary>
		public partial class SCHEDULE : ProgramHeader
		{
			/// <summary>
			/// Constructs a new value type for SCHEDULE.
			/// </summary>
            public SCHEDULE(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProgramHeader" />.
		/// </summary>
		public partial class ACTIVE : ProgramHeader
		{
			/// <summary>
			/// Constructs a new value type for ACTIVE.
			/// </summary>
            public ACTIVE(string value) : base(value) { }
		}
    }
}