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
	/// A value type for SpindleInterlock to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class SpindleInterlock : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the SpindleInterlock EVENT Data Item.
		/// </summary>
        public SpindleInterlock(string value) : base(value) { }

        /// <summary>
		﻿/// power has been removed and the spindle cannot be operated.
        /// </summary>
		[ObservationalValue(typeof(SpindleInterlockValues))]
        public static SpindleInterlock ACTIVE => new SpindleInterlock(nameof(SpindleInterlockValues.ACTIVE));
        /// <summary>
		﻿/// spindle has not been deactivated.
        /// </summary>
		[ObservationalValue(typeof(SpindleInterlockValues))]
        public static SpindleInterlock INACTIVE => new SpindleInterlock(nameof(SpindleInterlockValues.INACTIVE));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="SpindleInterlock"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="SpindleInterlock"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="SpindleInterlock"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator SpindleInterlock(string value)
        {
            return new SpindleInterlock(value.ToUpperInvariant());
        }
		
    }
}