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
	/// A value type for Program to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.6.0")]
	public partial class Program : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PROGRAM);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the Program EVENT Data Item.
		/// </summary>
        public Program(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="Program"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="Program"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="Program"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Program(string value)
            => new Program(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Program" />.
		/// </summary>
		public partial class ACTIVITY : Program
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProgramSubTypes.ACTIVITY);

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
		/// A Data Item SubType implementation of <see cref="Program" />.
		/// </summary>
		public partial class SEGMENT : Program
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProgramSubTypes.SEGMENT);

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
		/// A Data Item SubType implementation of <see cref="Program" />.
		/// </summary>
		public partial class RECIPE : Program
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProgramSubTypes.RECIPE);

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
		/// A Data Item SubType implementation of <see cref="Program" />.
		/// </summary>
		public partial class OPERATION : Program
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProgramSubTypes.OPERATION);

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
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Program" />.
		/// </summary>
		public partial class ACTIVE : Program
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProgramSubTypes.ACTIVE);

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
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Program" />.
		/// </summary>
		public partial class MAIN : Program
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProgramSubTypes.MAIN);

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
		/// A Data Item SubType implementation of <see cref="Program" />.
		/// </summary>
		public partial class SCHEDULE : Program
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ProgramSubTypes.SCHEDULE);

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
    }
}