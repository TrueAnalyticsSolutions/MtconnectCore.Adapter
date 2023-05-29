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
	/// A value type for ClockTime to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579272233011_597138_670">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class ClockTime : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.CLOCK_TIME);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ClockTime EVENT Data Item.
		/// </summary>
        public ClockTime(DateTime value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified DateTime to an <see cref="ClockTime"/> value.
        /// The DateTime is converted to uppercase and used to initialize the <see cref="ClockTime"/> value.
        /// </summary>
        /// <param name="value">The DateTime to convert.</param>
        /// <returns>An <see cref="ClockTime"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ClockTime(DateTime value)
            => new ClockTime(value);
		
    }
}