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
	/// A value type for ValveState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622456100008_63209_110">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class ValveState : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.VALVE_STATE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ValveState EVENT Data Item.
		/// </summary>
        public ValveState(string value) : base(value) { }

		public ValveState(ValveStateValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="ValveStateValues.OPEN" />
		[ObservationalValue(typeof(ValveStateValues))]
        public static ValveState OPEN => new ValveState(ValveStateValues.OPEN);
		/// <inheritdoc cref="ValveStateValues.OPENING" />
		[ObservationalValue(typeof(ValveStateValues))]
        public static ValveState OPENING => new ValveState(ValveStateValues.OPENING);
		/// <inheritdoc cref="ValveStateValues.CLOSED" />
		[ObservationalValue(typeof(ValveStateValues))]
        public static ValveState CLOSED => new ValveState(ValveStateValues.CLOSED);
		/// <inheritdoc cref="ValveStateValues.CLOSING" />
		[ObservationalValue(typeof(ValveStateValues))]
        public static ValveState CLOSING => new ValveState(ValveStateValues.CLOSING);

        /// <summary>
        /// Implicitly converts the specified <see cref="ValveStateValues" /> to an <see cref="ValveState"/> value.
        /// The <see cref="ValveStateValues" /> is converted to a string and used to initialize the <see cref="ValveState"/> value.
        /// </summary>
        /// <param name="value">The <see cref="ValveStateValues" /> to convert.</param>
        /// <returns>An <see cref="ValveState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ValveState(ValveStateValues value)
            => new ValveState(value);
		
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
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ValveStateSubTypes.ACTUAL);

			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(string value) : base(value) { }
			public ACTUAL(ValveStateValues value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified <see cref="ValveStateValues" /> to an <see cref="ValveState"/> value.
			/// The <see cref="ValveStateValues" /> is converted to a string and used to initialize the <see cref="ValveState"/> value.
			/// </summary>
			/// <param name="value">The <see cref="ValveStateValues" /> to convert.</param>
			/// <returns>An <see cref="ValveState"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ACTUAL(ValveStateValues value)
				=> new ACTUAL(value);
			
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
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ValveStateSubTypes.PROGRAMMED);

			/// <summary>
			/// Constructs a new value type for PROGRAMMED.
			/// </summary>
            public PROGRAMMED(string value) : base(value) { }
			public PROGRAMMED(ValveStateValues value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified <see cref="ValveStateValues" /> to an <see cref="ValveState"/> value.
			/// The <see cref="ValveStateValues" /> is converted to a string and used to initialize the <see cref="ValveState"/> value.
			/// </summary>
			/// <param name="value">The <see cref="ValveStateValues" /> to convert.</param>
			/// <returns>An <see cref="ValveState"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator PROGRAMMED(ValveStateValues value)
				=> new PROGRAMMED(value);
			
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