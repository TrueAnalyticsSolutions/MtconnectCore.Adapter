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
	/// A value type for Availability to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417656_729564_2870">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class Availability : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the Availability EVENT Data Item.
		/// </summary>
        public Availability(string value) : base(value) { }

        /// <summary>
		﻿/// data source is active and capable of providing data.
        /// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		[ObservationalValue(typeof(AvailabilityValues))]
        public static Availability AVAILABLE => new Availability(nameof(AvailabilityValues.AVAILABLE));
        /// <summary>
		﻿/// data source is either inactive or not capable of providing data.
        /// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		[ObservationalValue(typeof(AvailabilityValues))]
        public static Availability UNAVAILABLE => new Availability(nameof(AvailabilityValues.UNAVAILABLE));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="Availability"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="Availability"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="Availability"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Availability(string value)
            => new Availability(value.ToUpperInvariant());
		
    }
}