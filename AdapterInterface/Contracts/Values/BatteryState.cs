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
	/// A value type for BatteryState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class BatteryState : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the BatteryState EVENT Data Item.
		/// </summary>
        public BatteryState(string value) : base(value) { }

        /// <summary>
		﻿/// <see cref="Component">Component</see> is at it's maximum rated charge level.
        /// </summary>
		[ObservationalValue(typeof(BatteryStateValues))]
        public static BatteryState CHARGED => new BatteryState(nameof(BatteryStateValues.CHARGED));
        /// <summary>
		﻿/// <see cref="Component">Component</see>'s charge is increasing.
        /// </summary>
		[ObservationalValue(typeof(BatteryStateValues))]
        public static BatteryState CHARGING => new BatteryState(nameof(BatteryStateValues.CHARGING));
        /// <summary>
		﻿/// <see cref="Component">Component</see>'s charge is decreasing.
        /// </summary>
		[ObservationalValue(typeof(BatteryStateValues))]
        public static BatteryState DISCHARGING => new BatteryState(nameof(BatteryStateValues.DISCHARGING));
        /// <summary>
		﻿/// <see cref="Component">Component</see> is at it's minimum charge level.
        /// </summary>
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