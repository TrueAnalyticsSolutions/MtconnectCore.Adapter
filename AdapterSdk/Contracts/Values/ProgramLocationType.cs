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
	/// A value type for ProgramLocationType to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643980698480_209668_2427">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class ProgramLocationType : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PROGRAM_LOCATION_TYPE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ProgramLocationType EVENT Data Item.
		/// </summary>
        public ProgramLocationType(string value) : base(value) { }

		public ProgramLocationType(ProgramLocationTypeValues value) : this(value.ToString()) { }

        /// <summary>
		﻿/// managed by the controller.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ProgramLocationTypeValues))]
        public static ProgramLocationType LOCAL => new ProgramLocationType(ProgramLocationTypeValues.LOCAL);
        /// <summary>
		﻿/// not managed by the controller.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ProgramLocationTypeValues))]
        public static ProgramLocationType EXTERNAL => new ProgramLocationType(ProgramLocationTypeValues.EXTERNAL);

        /// <summary>
        /// Implicitly converts the specified <see cref="ProgramLocationTypeValues" /> to an <see cref="ProgramLocationType"/> value.
        /// The <see cref="ProgramLocationTypeValues" /> is converted to a string and used to initialize the <see cref="ProgramLocationType"/> value.
        /// </summary>
        /// <param name="value">The <see cref="ProgramLocationTypeValues" /> to convert.</param>
        /// <returns>An <see cref="ProgramLocationType"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ProgramLocationType(ProgramLocationTypeValues value)
            => new ProgramLocationType(value);
		
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
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProgramLocationTypeSubTypes.SCHEDULE);

			/// <summary>
			/// Constructs a new value type for SCHEDULE.
			/// </summary>
            public SCHEDULE(string value) : base(value) { }
			public SCHEDULE(ProgramLocationTypeValues value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified <see cref="ProgramLocationTypeValues" /> to an <see cref="ProgramLocationType"/> value.
			/// The <see cref="ProgramLocationTypeValues" /> is converted to a string and used to initialize the <see cref="ProgramLocationType"/> value.
			/// </summary>
			/// <param name="value">The <see cref="ProgramLocationTypeValues" /> to convert.</param>
			/// <returns>An <see cref="ProgramLocationType"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator SCHEDULE(ProgramLocationTypeValues value)
				=> new SCHEDULE(value);
			
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
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProgramLocationTypeSubTypes.MAIN);

			/// <summary>
			/// Constructs a new value type for MAIN.
			/// </summary>
            public MAIN(string value) : base(value) { }
			public MAIN(ProgramLocationTypeValues value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified <see cref="ProgramLocationTypeValues" /> to an <see cref="ProgramLocationType"/> value.
			/// The <see cref="ProgramLocationTypeValues" /> is converted to a string and used to initialize the <see cref="ProgramLocationType"/> value.
			/// </summary>
			/// <param name="value">The <see cref="ProgramLocationTypeValues" /> to convert.</param>
			/// <returns>An <see cref="ProgramLocationType"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator MAIN(ProgramLocationTypeValues value)
				=> new MAIN(value);
			
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
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProgramLocationTypeSubTypes.ACTIVE);

			/// <summary>
			/// Constructs a new value type for ACTIVE.
			/// </summary>
            public ACTIVE(string value) : base(value) { }
			public ACTIVE(ProgramLocationTypeValues value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified <see cref="ProgramLocationTypeValues" /> to an <see cref="ProgramLocationType"/> value.
			/// The <see cref="ProgramLocationTypeValues" /> is converted to a string and used to initialize the <see cref="ProgramLocationType"/> value.
			/// </summary>
			/// <param name="value">The <see cref="ProgramLocationTypeValues" /> to convert.</param>
			/// <returns>An <see cref="ProgramLocationType"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ACTIVE(ProgramLocationTypeValues value)
				=> new ACTIVE(value);
			
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