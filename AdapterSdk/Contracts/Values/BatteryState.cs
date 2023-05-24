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
	/// A value type for BatteryState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1660318869483_263921_172">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class BatteryState : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.BATTERY_STATE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the BatteryState EVENT Data Item.
		/// </summary>
        public BatteryState(string value) : base(value) { }

		public BatteryState(BatteryStateValues value) : this(value.ToString()) { }

        /// <summary>
		﻿/// <see cref="Component">Component</see> is at it's maximum rated charge level.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(BatteryStateValues))]
        public static BatteryState CHARGED => new BatteryState(BatteryStateValues.CHARGED);
        /// <summary>
		﻿/// <see cref="Component">Component</see>'s charge is increasing.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(BatteryStateValues))]
        public static BatteryState CHARGING => new BatteryState(BatteryStateValues.CHARGING);
        /// <summary>
		﻿/// <see cref="Component">Component</see>'s charge is decreasing.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(BatteryStateValues))]
        public static BatteryState DISCHARGING => new BatteryState(BatteryStateValues.DISCHARGING);
        /// <summary>
		﻿/// <see cref="Component">Component</see> is at it's minimum charge level.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(BatteryStateValues))]
        public static BatteryState DISCHARGED => new BatteryState(BatteryStateValues.DISCHARGED);

        /// <summary>
        /// Implicitly converts the specified <see cref="BatteryStateValues" /> to an <see cref="BatteryState"/> value.
        /// The <see cref="BatteryStateValues" /> is converted to a string and used to initialize the <see cref="BatteryState"/> value.
        /// </summary>
        /// <param name="value">The <see cref="BatteryStateValues" /> to convert.</param>
        /// <returns>An <see cref="BatteryState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator BatteryState(BatteryStateValues value)
            => new BatteryState(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="BatteryState"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="BatteryState"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="BatteryState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator BatteryState(string value)
            => new BatteryState(value.ToUpperInvariant());
		
    }
}