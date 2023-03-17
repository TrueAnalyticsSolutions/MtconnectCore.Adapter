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
	/// A value type for ProgramLocationType to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class ProgramLocationType : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the ProgramLocationType EVENT Data Item.
		/// </summary>
        public ProgramLocationType(string value) : base(value) { }

        /// <summary>
		﻿/// managed by the controller.
        /// </summary>
		[ObservationalValue(typeof(ProgramLocationTypeValues))]
        public static ProgramLocationType LOCAL => new ProgramLocationType(nameof(ProgramLocationTypeValues.LOCAL));
        /// <summary>
		﻿/// not managed by the controller.
        /// </summary>
		[ObservationalValue(typeof(ProgramLocationTypeValues))]
        public static ProgramLocationType EXTERNAL => new ProgramLocationType(nameof(ProgramLocationTypeValues.EXTERNAL));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ProgramLocationType"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ProgramLocationType"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ProgramLocationType"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ProgramLocationType(string value)
            => new ProgramLocationType(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProgramLocationType" />.
		/// </summary>
		public partial class SCHEDULE : ProgramLocationType
		{
			/// <summary>
			/// Constructs a new value type for SCHEDULE.
			/// </summary>
            public SCHEDULE(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="SCHEDULE"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="SCHEDULE"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="SCHEDULE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator SCHEDULE(string value)
				=> new SCHEDULE(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProgramLocationType" />.
		/// </summary>
		public partial class MAIN : ProgramLocationType
		{
			/// <summary>
			/// Constructs a new value type for MAIN.
			/// </summary>
            public MAIN(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="MAIN"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="MAIN"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="MAIN"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator MAIN(string value)
				=> new MAIN(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProgramLocationType" />.
		/// </summary>
		public partial class ACTIVE : ProgramLocationType
		{
			/// <summary>
			/// Constructs a new value type for ACTIVE.
			/// </summary>
            public ACTIVE(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="ACTIVE"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="ACTIVE"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="ACTIVE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ACTIVE(string value)
				=> new ACTIVE(value.ToUpperInvariant());
		}
    }
}