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
	/// A value type for BatteryState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1660318869483_263921_172">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.6.0")]
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

        /// <summary>
		﻿/// <see cref="Component">Component</see> is at it's maximum rated charge level.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(BatteryStateValues))]
        public static BatteryState CHARGED => new BatteryState(nameof(BatteryStateValues.CHARGED));
        /// <summary>
		﻿/// <see cref="Component">Component</see>'s charge is increasing.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(BatteryStateValues))]
        public static BatteryState CHARGING => new BatteryState(nameof(BatteryStateValues.CHARGING));
        /// <summary>
		﻿/// <see cref="Component">Component</see>'s charge is decreasing.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(BatteryStateValues))]
        public static BatteryState DISCHARGING => new BatteryState(nameof(BatteryStateValues.DISCHARGING));
        /// <summary>
		﻿/// <see cref="Component">Component</see> is at it's minimum charge level.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(BatteryStateValues))]
        public static BatteryState DISCHARGED => new BatteryState(nameof(BatteryStateValues.DISCHARGED));
		
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