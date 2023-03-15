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
	/// A value type for OperatingMode to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class OperatingMode : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the OperatingMode EVENT Data Item.
		/// </summary>
        public OperatingMode(string value) : base(value) { }

        /// <summary>
		﻿/// automatically execute instructions from a recipe or program.  > Note: Setpoint comes from a recipe.
        /// </summary>
		[ObservationalValue(typeof(OperatingModeValues))]
        public static OperatingMode AUTOMATIC => new OperatingMode(nameof(OperatingModeValues.AUTOMATIC));
        /// <summary>
		﻿/// execute instructions from an external agent or person.  > Note 1 to entry: Valve or switch is manipulated by an agent/person.  > Note 2 to entry: Direct control of the PID output. % of the range: A user manually sets the % output, not the setpoint.
        /// </summary>
		[ObservationalValue(typeof(OperatingModeValues))]
        public static OperatingMode MANUAL => new OperatingMode(nameof(OperatingModeValues.MANUAL));
        /// <summary>
		﻿/// executes a single instruction from a recipe or program.  > Note 1 to entry: Setpoint is entered and fixed, but the PID is controlling.  > Note 2 to entry: Still goes through the PID control system.  > Note 3 to entry: Manual fixed entry from a recipe.
        /// </summary>
		[ObservationalValue(typeof(OperatingModeValues))]
        public static OperatingMode SEMI_AUTOMATIC => new OperatingMode(nameof(OperatingModeValues.SEMI_AUTOMATIC));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="OperatingMode"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="OperatingMode"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="OperatingMode"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator OperatingMode(string value)
        {
            return new OperatingMode(value.ToUpperInvariant());
        }
		
    }
}