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
	/// A value type for Direction to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_4_0")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class Direction : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the Direction EVENT Data Item.
		/// </summary>
        public Direction(string value) : base(value) { }

        /// <summary>
		﻿/// clockwise rotation using the right-hand rule.
        /// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_4_0")]
		[ObservationalValue(typeof(DirectionValues))]
        public static Direction CLOCKWISE => new Direction(nameof(DirectionValues.CLOCKWISE));
        /// <summary>
		﻿/// counter-clockwise rotation using the right-hand rule.
        /// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_4_0")]
		[ObservationalValue(typeof(DirectionValues))]
        public static Direction COUNTER_CLOCKWISE => new Direction(nameof(DirectionValues.COUNTER_CLOCKWISE));
        /// <summary>
		﻿        /// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_4_0")]
		[ObservationalValue(typeof(DirectionValues))]
        public static Direction POSITIVE => new Direction(nameof(DirectionValues.POSITIVE));
        /// <summary>
		﻿        /// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_4_0")]
		[ObservationalValue(typeof(DirectionValues))]
        public static Direction NEGATIVE => new Direction(nameof(DirectionValues.NEGATIVE));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="Direction"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="Direction"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="Direction"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Direction(string value)
        {
            return new Direction(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Direction" />.
		/// </summary>
		public partial class ROTARY : Direction
		{
			/// <summary>
			/// Constructs a new value type for ROTARY.
			/// </summary>
            public ROTARY(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Direction" />.
		/// </summary>
		public partial class LINEAR : Direction
		{
			/// <summary>
			/// Constructs a new value type for LINEAR.
			/// </summary>
            public LINEAR(string value) : base(value) { }
		}
    }
}