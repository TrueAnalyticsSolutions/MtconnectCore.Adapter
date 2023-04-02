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
	/// A value type for Direction to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643977882360_173549_1229">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.5.0")]
	public partial class Direction : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.DIRECTION);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the Direction EVENT Data Item.
		/// </summary>
        public Direction(string value) : base(value) { }

        /// <summary>
		﻿/// clockwise rotation using the right-hand rule.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]
		[ObservationalValue(typeof(DirectionValues))]
        public static Direction CLOCKWISE => new Direction(nameof(DirectionValues.CLOCKWISE));
        /// <summary>
		﻿/// counter-clockwise rotation using the right-hand rule.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]
		[ObservationalValue(typeof(DirectionValues))]
        public static Direction COUNTER_CLOCKWISE => new Direction(nameof(DirectionValues.COUNTER_CLOCKWISE));
        /// <summary>
		﻿        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]
		[ObservationalValue(typeof(DirectionValues))]
        public static Direction POSITIVE => new Direction(nameof(DirectionValues.POSITIVE));
        /// <summary>
		﻿        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]
		[ObservationalValue(typeof(DirectionValues))]
        public static Direction NEGATIVE => new Direction(nameof(DirectionValues.NEGATIVE));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="Direction"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="Direction"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="Direction"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Direction(string value)
            => new Direction(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Direction" />.
		/// </summary>
		public partial class ROTARY : Direction
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.DirectionSubTypes.ROTARY);

			/// <summary>
			/// Constructs a new value type for ROTARY.
			/// </summary>
            public ROTARY(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="ROTARY"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="ROTARY"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="ROTARY"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ROTARY(string value)
				=> new ROTARY(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Direction" />.
		/// </summary>
		public partial class LINEAR : Direction
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.DirectionSubTypes.LINEAR);

			/// <summary>
			/// Constructs a new value type for LINEAR.
			/// </summary>
            public LINEAR(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="LINEAR"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="LINEAR"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="LINEAR"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator LINEAR(string value)
				=> new LINEAR(value.ToUpperInvariant());
		}
    }
}