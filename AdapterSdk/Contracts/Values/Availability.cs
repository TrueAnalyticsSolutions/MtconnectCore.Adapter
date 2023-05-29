#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk.Contracts.Attributes;
using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.DataItemValues;
using Mtconnect.AdapterSdk.Units;

namespace Mtconnect.AdapterSdk.DataItemValues
{
	/// <summary>
	/// A value type for Availability to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417656_729564_2870">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class Availability : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.AVAILABILITY);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the Availability EVENT Data Item.
		/// </summary>
        public Availability(string value) : base(value) { }

		public Availability(AvailabilityValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="AvailabilityValues.AVAILABLE" />
		[ObservationalValue(typeof(AvailabilityValues))]
        public static Availability AVAILABLE => new Availability(AvailabilityValues.AVAILABLE);
		/// <inheritdoc cref="AvailabilityValues.UNAVAILABLE" />
		[ObservationalValue(typeof(AvailabilityValues))]
        public static Availability UNAVAILABLE => new Availability(AvailabilityValues.UNAVAILABLE);

        /// <summary>
        /// Implicitly converts the specified <see cref="AvailabilityValues" /> to an <see cref="Availability"/> value.
        /// The <see cref="AvailabilityValues" /> is converted to a string and used to initialize the <see cref="Availability"/> value.
        /// </summary>
        /// <param name="value">The <see cref="AvailabilityValues" /> to convert.</param>
        /// <returns>An <see cref="Availability"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Availability(AvailabilityValues value)
            => new Availability(value);
		
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