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
	/// A value type for DoorState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1632488689397_578974_93">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class DoorState : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.DOOR_STATE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the DoorState EVENT Data Item.
		/// </summary>
        public DoorState(string value) : base(value) { }

		/// <summary>
		/// Constructs a new value type for the DoorState EVENT Data Item.
		/// </summary>
		public DoorState(DoorStateValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="DoorStateValues.OPEN" />
		[ObservationalValue(typeof(DoorStateValues))]
        public static DoorState OPEN => new DoorState(DoorStateValues.OPEN);
		/// <inheritdoc cref="DoorStateValues.CLOSED" />
		[ObservationalValue(typeof(DoorStateValues))]
        public static DoorState CLOSED => new DoorState(DoorStateValues.CLOSED);
		/// <inheritdoc cref="DoorStateValues.UNLATCHED" />
		[ObservationalValue(typeof(DoorStateValues))]
        public static DoorState UNLATCHED => new DoorState(DoorStateValues.UNLATCHED);

        /// <summary>
        /// Implicitly converts the specified <see cref="DoorStateValues" /> to an <see cref="DoorState"/> value.
        /// The <see cref="DoorStateValues" /> is converted to a string and used to initialize the <see cref="DoorState"/> value.
        /// </summary>
        /// <param name="value">The <see cref="DoorStateValues" /> to convert.</param>
        /// <returns>An <see cref="DoorState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator DoorState(DoorStateValues value)
            => new DoorState(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="DoorState"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="DoorState"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="DoorState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator DoorState(string value)
            => new DoorState(value.ToUpperInvariant());
		
    }
}