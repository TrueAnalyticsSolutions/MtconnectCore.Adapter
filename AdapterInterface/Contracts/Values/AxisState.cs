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
	/// A value type for AxisState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class AxisState : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the AxisState EVENT Data Item.
		/// </summary>
        public AxisState(string value) : base(value) { }

        /// <summary>
		﻿/// axis is in its home position.
        /// </summary>
		[ObservationalValue(typeof(AxisStateValues))]
        public static AxisState HOME => new AxisState(nameof(AxisStateValues.HOME));
        /// <summary>
		﻿/// axis is in motion.
        /// </summary>
		[ObservationalValue(typeof(AxisStateValues))]
        public static AxisState TRAVEL => new AxisState(nameof(AxisStateValues.TRAVEL));
        /// <summary>
		﻿/// axis has been moved to a fixed position and is being maintained in that position either electrically or mechanically.   Action is required to release the axis from this position.
        /// </summary>
		[ObservationalValue(typeof(AxisStateValues))]
        public static AxisState PARKED => new AxisState(nameof(AxisStateValues.PARKED));
        /// <summary>
		﻿/// axis is stopped.
        /// </summary>
		[ObservationalValue(typeof(AxisStateValues))]
        public static AxisState STOPPED => new AxisState(nameof(AxisStateValues.STOPPED));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="AxisState"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="AxisState"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="AxisState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator AxisState(string value)
        {
            return new AxisState(value.ToUpperInvariant());
        }
		
    }
}