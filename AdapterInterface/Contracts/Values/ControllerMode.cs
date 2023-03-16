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
	/// A value type for ControllerMode to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class ControllerMode : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the ControllerMode EVENT Data Item.
		/// </summary>
        public ControllerMode(string value) : base(value) { }

        /// <summary>
		﻿/// <see cref="Controller">Controller</see> is configured to automatically execute a program.
        /// </summary>
		[ObservationalValue(typeof(ControllerModeValues))]
        public static ControllerMode AUTOMATIC => new ControllerMode(nameof(ControllerModeValues.AUTOMATIC));
        /// <summary>
		﻿/// <see cref="Controller">Controller</see> is not executing an active program.   It is capable of receiving instructions from an external source – typically an operator. The <see cref="Controller">Controller</see> executes operations based on the instructions received from the external source.
        /// </summary>
		[ObservationalValue(typeof(ControllerModeValues))]
        public static ControllerMode MANUAL => new ControllerMode(nameof(ControllerModeValues.MANUAL));
        /// <summary>
		﻿/// operator can enter a series of operations for the <see cref="Controller">Controller</see> to perform.  The <see cref="Controller">Controller</see> will execute this specific series of operations and then stop.
        /// </summary>
		[ObservationalValue(typeof(ControllerModeValues))]
        public static ControllerMode MANUAL_DATA_INPUT => new ControllerMode(nameof(ControllerModeValues.MANUAL_DATA_INPUT));
        /// <summary>
		﻿/// <see cref="Controller">Controller</see> is operating in a mode that restricts the active program from processing its next process step without operator intervention.
        /// </summary>
		[ObservationalValue(typeof(ControllerModeValues))]
        public static ControllerMode SEMI_AUTOMATIC => new ControllerMode(nameof(ControllerModeValues.SEMI_AUTOMATIC));
        /// <summary>
		﻿/// <see cref="Controller">Controller</see> is currently functioning as a programming device and is not capable of executing an active program.
        /// </summary>
		[ObservationalValue(typeof(ControllerModeValues))]
        public static ControllerMode EDIT => new ControllerMode(nameof(ControllerModeValues.EDIT));
        /// <summary>
		﻿/// axes of the device are commanded to stop, but the spindle continues to function.
        /// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_3_0")]
		[ObservationalValue(typeof(ControllerModeValues))]
        public static ControllerMode FEED_HOLD => new ControllerMode(nameof(ControllerModeValues.FEED_HOLD));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ControllerMode"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ControllerMode"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ControllerMode"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ControllerMode(string value)
            => new ControllerMode(value.ToUpperInvariant());
		
    }
}