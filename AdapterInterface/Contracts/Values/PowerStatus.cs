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
	/// A value type for PowerStatus to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_1_0")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class PowerStatus : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the PowerStatus EVENT Data Item.
		/// </summary>
        public PowerStatus(string value) : base(value) { }

        /// <summary>
		﻿        /// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_1_0")]
		[ObservationalValue(typeof(PowerStatusValues))]
        public static PowerStatus ON => new PowerStatus(nameof(PowerStatusValues.ON));
        /// <summary>
		﻿        /// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_1_0")]
		[ObservationalValue(typeof(PowerStatusValues))]
        public static PowerStatus OFF => new PowerStatus(nameof(PowerStatusValues.OFF));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="PowerStatus"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="PowerStatus"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="PowerStatus"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PowerStatus(string value)
            => new PowerStatus(value.ToUpperInvariant());
		
    }
}