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
	/// A value type for ProgramLocation to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.7.0")]
	public partial class ProgramLocation : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PROGRAM_LOCATION);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ProgramLocation EVENT Data Item.
		/// </summary>
        public ProgramLocation(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ProgramLocation"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ProgramLocation"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ProgramLocation"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ProgramLocation(string value)
            => new ProgramLocation(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProgramLocation" />.
		/// </summary>
		public partial class SCHEDULE : ProgramLocation
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProgramLocationSubTypes.SCHEDULE);

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
		/// A Data Item SubType implementation of <see cref="ProgramLocation" />.
		/// </summary>
		public partial class MAIN : ProgramLocation
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProgramLocationSubTypes.MAIN);

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
		/// A Data Item SubType implementation of <see cref="ProgramLocation" />.
		/// </summary>
		public partial class ACTIVE : ProgramLocation
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProgramLocationSubTypes.ACTIVE);

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