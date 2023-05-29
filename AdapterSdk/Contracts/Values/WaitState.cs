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
	/// A value type for WaitState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1581143980612_724749_76">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class WaitState : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.WAIT_STATE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the WaitState EVENT Data Item.
		/// </summary>
        public WaitState(string value) : base(value) { }

		public WaitState(WaitStateValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="WaitStateValues.POWERING_UP" />
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState POWERING_UP => new WaitState(WaitStateValues.POWERING_UP);
		/// <inheritdoc cref="WaitStateValues.POWERING_DOWN" />
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState POWERING_DOWN => new WaitState(WaitStateValues.POWERING_DOWN);
		/// <inheritdoc cref="WaitStateValues.PART_LOAD" />
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState PART_LOAD => new WaitState(WaitStateValues.PART_LOAD);
		/// <inheritdoc cref="WaitStateValues.PART_UNLOAD" />
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState PART_UNLOAD => new WaitState(WaitStateValues.PART_UNLOAD);
		/// <inheritdoc cref="WaitStateValues.TOOL_LOAD" />
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState TOOL_LOAD => new WaitState(WaitStateValues.TOOL_LOAD);
		/// <inheritdoc cref="WaitStateValues.TOOL_UNLOAD" />
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState TOOL_UNLOAD => new WaitState(WaitStateValues.TOOL_UNLOAD);
		/// <inheritdoc cref="WaitStateValues.MATERIAL_LOAD" />
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState MATERIAL_LOAD => new WaitState(WaitStateValues.MATERIAL_LOAD);
		/// <inheritdoc cref="WaitStateValues.MATERIAL_UNLOAD" />
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState MATERIAL_UNLOAD => new WaitState(WaitStateValues.MATERIAL_UNLOAD);
		/// <inheritdoc cref="WaitStateValues.SECONDARY_PROCESS" />
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState SECONDARY_PROCESS => new WaitState(WaitStateValues.SECONDARY_PROCESS);
		/// <inheritdoc cref="WaitStateValues.PAUSING" />
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState PAUSING => new WaitState(WaitStateValues.PAUSING);
		/// <inheritdoc cref="WaitStateValues.RESUMING" />
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState RESUMING => new WaitState(WaitStateValues.RESUMING);

        /// <summary>
        /// Implicitly converts the specified <see cref="WaitStateValues" /> to an <see cref="WaitState"/> value.
        /// The <see cref="WaitStateValues" /> is converted to a string and used to initialize the <see cref="WaitState"/> value.
        /// </summary>
        /// <param name="value">The <see cref="WaitStateValues" /> to convert.</param>
        /// <returns>An <see cref="WaitState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator WaitState(WaitStateValues value)
            => new WaitState(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="WaitState"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="WaitState"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="WaitState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator WaitState(string value)
            => new WaitState(value.ToUpperInvariant());
		
    }
}