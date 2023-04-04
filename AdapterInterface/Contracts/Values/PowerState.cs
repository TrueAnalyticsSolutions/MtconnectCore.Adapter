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
	/// A value type for PowerState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1632489430362_282150_112">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.6.0")]
	public partial class PowerState : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.POWER_STATE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the PowerState EVENT Data Item.
		/// </summary>
        public PowerState(string value) : base(value) { }

        /// <summary>
		﻿/// source of energy for an entity or the enabling signal providing permission for the entity to perform its function(s) is present and active.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(PowerStateValues))]
        public static PowerState ON => new PowerState(nameof(PowerStateValues.ON));
        /// <summary>
		﻿/// source of energy for an entity or the enabling signal providing permission for the entity to perform its function(s) is not present or is disconnected.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(PowerStateValues))]
        public static PowerState OFF => new PowerState(nameof(PowerStateValues.OFF));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="PowerState"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="PowerState"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="PowerState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PowerState(string value)
            => new PowerState(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PowerState" />.
		/// </summary>
		public partial class LINE : PowerState
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PowerStateSubTypes.LINE);

			/// <summary>
			/// Constructs a new value type for LINE.
			/// </summary>
            public LINE(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="LINE"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="LINE"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="LINE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator LINE(string value)
				=> new LINE(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PowerState" />.
		/// </summary>
		public partial class CONTROL : PowerState
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PowerStateSubTypes.CONTROL);

			/// <summary>
			/// Constructs a new value type for CONTROL.
			/// </summary>
            public CONTROL(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="CONTROL"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="CONTROL"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="CONTROL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator CONTROL(string value)
				=> new CONTROL(value.ToUpperInvariant());
		}
    }
}