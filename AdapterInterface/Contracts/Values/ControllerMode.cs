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
	/// A value type for ControllerMode to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417660_348819_2874">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.7.0")]
	public partial class ControllerMode : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.CONTROLLER_MODE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ControllerMode EVENT Data Item.
		/// </summary>
        public ControllerMode(string value) : base(value) { }

        /// <summary>
		﻿/// <see cref="Controller">Controller</see> is configured to automatically execute a program.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ControllerModeValues))]
        public static ControllerMode AUTOMATIC => new ControllerMode(nameof(ControllerModeValues.AUTOMATIC));
        /// <summary>
		﻿/// <see cref="Controller">Controller</see> is not executing an active program.   It is capable of receiving instructions from an external source – typically an operator. The <see cref="Controller">Controller</see> executes operations based on the instructions received from the external source.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ControllerModeValues))]
        public static ControllerMode MANUAL => new ControllerMode(nameof(ControllerModeValues.MANUAL));
        /// <summary>
		﻿/// operator can enter a series of operations for the <see cref="Controller">Controller</see> to perform.  The <see cref="Controller">Controller</see> will execute this specific series of operations and then stop.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ControllerModeValues))]
        public static ControllerMode MANUAL_DATA_INPUT => new ControllerMode(nameof(ControllerModeValues.MANUAL_DATA_INPUT));
        /// <summary>
		﻿/// <see cref="Controller">Controller</see> is operating in a mode that restricts the active program from processing its next process step without operator intervention.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ControllerModeValues))]
        public static ControllerMode SEMI_AUTOMATIC => new ControllerMode(nameof(ControllerModeValues.SEMI_AUTOMATIC));
        /// <summary>
		﻿/// <see cref="Controller">Controller</see> is currently functioning as a programming device and is not capable of executing an active program.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ControllerModeValues))]
        public static ControllerMode EDIT => new ControllerMode(nameof(ControllerModeValues.EDIT));
        /// <summary>
		﻿/// axes of the device are commanded to stop, but the spindle continues to function.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.3 according to https://model.mtconnect.org/#_Version_1.3")]
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