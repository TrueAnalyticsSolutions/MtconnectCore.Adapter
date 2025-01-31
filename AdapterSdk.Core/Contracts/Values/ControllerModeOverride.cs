#pragma warning disable 0618
#pragma warning disable 1574
#pragma warning disable CS1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk;
using Mtconnect.AdapterSdk.Attributes;
using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.DataItemValues;
using Mtconnect.AdapterSdk.Units;

namespace Mtconnect.AdapterSdk.DataItemValues
{
	/// <summary>
	/// A value type for ControllerModeOverride to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417661_25421_2875">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class ControllerModeOverride : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.CONTROLLER_MODE_OVERRIDE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ControllerModeOverride EVENT Data Item.
		/// </summary>
        public ControllerModeOverride(string value) : base(value) { }

		/// <summary>
		/// Constructs a new value type for the ControllerModeOverride EVENT Data Item.
		/// </summary>
		public ControllerModeOverride(ControllerModeOverrideValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="ControllerModeOverrideValues.ON" />
		[ObservationalValue(typeof(ControllerModeOverrideValues))]
        public static ControllerModeOverride ON => new ControllerModeOverride(ControllerModeOverrideValues.ON);
		/// <inheritdoc cref="ControllerModeOverrideValues.OFF" />
		[ObservationalValue(typeof(ControllerModeOverrideValues))]
        public static ControllerModeOverride OFF => new ControllerModeOverride(ControllerModeOverrideValues.OFF);

        /// <summary>
        /// Implicitly converts the specified <see cref="ControllerModeOverrideValues" /> to an <see cref="ControllerModeOverride"/> value.
        /// The <see cref="ControllerModeOverrideValues" /> is converted to a string and used to initialize the <see cref="ControllerModeOverride"/> value.
        /// </summary>
        /// <param name="value">The <see cref="ControllerModeOverrideValues" /> to convert.</param>
        /// <returns>An <see cref="ControllerModeOverride"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ControllerModeOverride(ControllerModeOverrideValues value)
            => new ControllerModeOverride(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ControllerModeOverride"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ControllerModeOverride"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ControllerModeOverride"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ControllerModeOverride(string value)
            => new ControllerModeOverride(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ControllerModeOverride" />.
		/// </summary>
		public partial class DRYRUN : ControllerModeOverride
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ControllerModeOverrideSubTypes.DRY_RUN);

			/// <summary>
			/// Constructs a new value type for DRY_RUN.
			/// </summary>
            public DRYRUN(string value) : base(value) { }
			/// <summary>
			/// Constructs a new value type for DRY_RUN using the strict <see cref="Enum" /> value.
			/// </summary>
			public DRYRUN(ControllerModeOverrideValues value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified <see cref="ControllerModeOverrideValues" /> to an <see cref="ControllerModeOverride"/> value.
			/// The <see cref="ControllerModeOverrideValues" /> is converted to a string and used to initialize the <see cref="ControllerModeOverride"/> value.
			/// </summary>
			/// <param name="value">The <see cref="ControllerModeOverrideValues" /> to convert.</param>
			/// <returns>An <see cref="ControllerModeOverride"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator DRYRUN(ControllerModeOverrideValues value)
				=> new DRYRUN(value);
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="DRYRUN"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="DRYRUN"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="DRYRUN"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator DRYRUN(string value)
				=> new DRYRUN(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ControllerModeOverride" />.
		/// </summary>
		public partial class SINGLEBLOCK : ControllerModeOverride
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ControllerModeOverrideSubTypes.SINGLE_BLOCK);

			/// <summary>
			/// Constructs a new value type for SINGLE_BLOCK.
			/// </summary>
            public SINGLEBLOCK(string value) : base(value) { }
			/// <summary>
			/// Constructs a new value type for SINGLE_BLOCK using the strict <see cref="Enum" /> value.
			/// </summary>
			public SINGLEBLOCK(ControllerModeOverrideValues value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified <see cref="ControllerModeOverrideValues" /> to an <see cref="ControllerModeOverride"/> value.
			/// The <see cref="ControllerModeOverrideValues" /> is converted to a string and used to initialize the <see cref="ControllerModeOverride"/> value.
			/// </summary>
			/// <param name="value">The <see cref="ControllerModeOverrideValues" /> to convert.</param>
			/// <returns>An <see cref="ControllerModeOverride"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator SINGLEBLOCK(ControllerModeOverrideValues value)
				=> new SINGLEBLOCK(value);
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="SINGLEBLOCK"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="SINGLEBLOCK"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="SINGLEBLOCK"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator SINGLEBLOCK(string value)
				=> new SINGLEBLOCK(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ControllerModeOverride" />.
		/// </summary>
		public partial class MACHINEAXISLOCK : ControllerModeOverride
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ControllerModeOverrideSubTypes.MACHINE_AXIS_LOCK);

			/// <summary>
			/// Constructs a new value type for MACHINE_AXIS_LOCK.
			/// </summary>
            public MACHINEAXISLOCK(string value) : base(value) { }
			/// <summary>
			/// Constructs a new value type for MACHINE_AXIS_LOCK using the strict <see cref="Enum" /> value.
			/// </summary>
			public MACHINEAXISLOCK(ControllerModeOverrideValues value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified <see cref="ControllerModeOverrideValues" /> to an <see cref="ControllerModeOverride"/> value.
			/// The <see cref="ControllerModeOverrideValues" /> is converted to a string and used to initialize the <see cref="ControllerModeOverride"/> value.
			/// </summary>
			/// <param name="value">The <see cref="ControllerModeOverrideValues" /> to convert.</param>
			/// <returns>An <see cref="ControllerModeOverride"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator MACHINEAXISLOCK(ControllerModeOverrideValues value)
				=> new MACHINEAXISLOCK(value);
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="MACHINEAXISLOCK"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="MACHINEAXISLOCK"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="MACHINEAXISLOCK"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator MACHINEAXISLOCK(string value)
				=> new MACHINEAXISLOCK(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ControllerModeOverride" />.
		/// </summary>
		public partial class OPTIONALSTOP : ControllerModeOverride
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ControllerModeOverrideSubTypes.OPTIONAL_STOP);

			/// <summary>
			/// Constructs a new value type for OPTIONAL_STOP.
			/// </summary>
            public OPTIONALSTOP(string value) : base(value) { }
			/// <summary>
			/// Constructs a new value type for OPTIONAL_STOP using the strict <see cref="Enum" /> value.
			/// </summary>
			public OPTIONALSTOP(ControllerModeOverrideValues value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified <see cref="ControllerModeOverrideValues" /> to an <see cref="ControllerModeOverride"/> value.
			/// The <see cref="ControllerModeOverrideValues" /> is converted to a string and used to initialize the <see cref="ControllerModeOverride"/> value.
			/// </summary>
			/// <param name="value">The <see cref="ControllerModeOverrideValues" /> to convert.</param>
			/// <returns>An <see cref="ControllerModeOverride"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator OPTIONALSTOP(ControllerModeOverrideValues value)
				=> new OPTIONALSTOP(value);
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="OPTIONALSTOP"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="OPTIONALSTOP"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="OPTIONALSTOP"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator OPTIONALSTOP(string value)
				=> new OPTIONALSTOP(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ControllerModeOverride" />.
		/// </summary>
		public partial class TOOLCHANGESTOP : ControllerModeOverride
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ControllerModeOverrideSubTypes.TOOL_CHANGE_STOP);

			/// <summary>
			/// Constructs a new value type for TOOL_CHANGE_STOP.
			/// </summary>
            public TOOLCHANGESTOP(string value) : base(value) { }
			/// <summary>
			/// Constructs a new value type for TOOL_CHANGE_STOP using the strict <see cref="Enum" /> value.
			/// </summary>
			public TOOLCHANGESTOP(ControllerModeOverrideValues value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified <see cref="ControllerModeOverrideValues" /> to an <see cref="ControllerModeOverride"/> value.
			/// The <see cref="ControllerModeOverrideValues" /> is converted to a string and used to initialize the <see cref="ControllerModeOverride"/> value.
			/// </summary>
			/// <param name="value">The <see cref="ControllerModeOverrideValues" /> to convert.</param>
			/// <returns>An <see cref="ControllerModeOverride"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator TOOLCHANGESTOP(ControllerModeOverrideValues value)
				=> new TOOLCHANGESTOP(value);
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="TOOLCHANGESTOP"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="TOOLCHANGESTOP"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="TOOLCHANGESTOP"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator TOOLCHANGESTOP(string value)
				=> new TOOLCHANGESTOP(value.ToUpperInvariant());
		}
    }
}