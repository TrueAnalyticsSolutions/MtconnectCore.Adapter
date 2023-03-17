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
	/// A value type for ValveState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class ValveState : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the ValveState EVENT Data Item.
		/// </summary>
        public ValveState(string value) : base(value) { }

        /// <summary>
		﻿/// <see cref="ValveState">ValveState</see> where flow is allowed and the aperture is static.  > Note: For a binary value, <c>OPEN</c> indicates the valve has the maximum possible aperture.
        /// </summary>
		[ObservationalValue(typeof(ValveStateValues))]
        public static ValveState OPEN => new ValveState(nameof(ValveStateValues.OPEN));
        /// <summary>
		﻿/// valve is transitioning from a <c>CLOSED</c> state to an <c>OPEN</c> state.
        /// </summary>
		[ObservationalValue(typeof(ValveStateValues))]
        public static ValveState OPENING => new ValveState(nameof(ValveStateValues.OPENING));
        /// <summary>
		﻿/// <see cref="ValveState">ValveState</see> where flow is not possible, the aperture is static, and the valve is completely shut.
        /// </summary>
		[ObservationalValue(typeof(ValveStateValues))]
        public static ValveState CLOSED => new ValveState(nameof(ValveStateValues.CLOSED));
        /// <summary>
		﻿/// valve is transitioning from an <c>OPEN</c> state to a <c>CLOSED</c> state.
        /// </summary>
		[ObservationalValue(typeof(ValveStateValues))]
        public static ValveState CLOSING => new ValveState(nameof(ValveStateValues.CLOSING));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ValveState"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ValveState"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ValveState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ValveState(string value)
            => new ValveState(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ValveState" />.
		/// </summary>
		public partial class ACTUAL : ValveState
		{
			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="ACTUAL"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="ACTUAL"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="ACTUAL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ACTUAL(string value)
				=> new ACTUAL(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ValveState" />.
		/// </summary>
		public partial class PROGRAMMED : ValveState
		{
			/// <summary>
			/// Constructs a new value type for PROGRAMMED.
			/// </summary>
            public PROGRAMMED(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="PROGRAMMED"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="PROGRAMMED"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="PROGRAMMED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator PROGRAMMED(string value)
				=> new PROGRAMMED(value.ToUpperInvariant());
		}
    }
}