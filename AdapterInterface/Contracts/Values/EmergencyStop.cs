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
	/// A value type for EmergencyStop to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417662_889824_2876">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.7.0")]
	public partial class EmergencyStop : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.EMERGENCY_STOP);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the EmergencyStop EVENT Data Item.
		/// </summary>
        public EmergencyStop(string value) : base(value) { }

        /// <summary>
		﻿/// emergency stop circuit is complete and the piece of equipment, component, or composition is allowed to operate. 
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(EmergencyStopValues))]
        public static EmergencyStop ARMED => new EmergencyStop(nameof(EmergencyStopValues.ARMED));
        /// <summary>
		﻿/// operation of the piece of equipment, component, or composition is inhibited.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(EmergencyStopValues))]
        public static EmergencyStop TRIGGERED => new EmergencyStop(nameof(EmergencyStopValues.TRIGGERED));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="EmergencyStop"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="EmergencyStop"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="EmergencyStop"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator EmergencyStop(string value)
            => new EmergencyStop(value.ToUpperInvariant());
		
    }
}