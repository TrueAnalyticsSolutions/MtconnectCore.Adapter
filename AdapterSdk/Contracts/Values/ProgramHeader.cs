#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk.Contracts.Attributes;
using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.DataItemValues;
using Mtconnect.AdapterSdk.Units;

namespace Mtconnect.AdapterSdk.DataItemValues
{
	/// <summary>
	/// A value type for ProgramHeader to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class ProgramHeader : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PROGRAM_HEADER);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

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
            => new ProgramHeader(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProgramHeader" />.
		/// </summary>
		public partial class MAIN : ProgramHeader
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProgramHeaderSubTypes.MAIN);

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
		/// A Data Item SubType implementation of <see cref="ProgramHeader" />.
		/// </summary>
		public partial class SCHEDULE : ProgramHeader
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProgramHeaderSubTypes.SCHEDULE);

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
		/// A Data Item SubType implementation of <see cref="ProgramHeader" />.
		/// </summary>
		public partial class ACTIVE : ProgramHeader
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProgramHeaderSubTypes.ACTIVE);

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