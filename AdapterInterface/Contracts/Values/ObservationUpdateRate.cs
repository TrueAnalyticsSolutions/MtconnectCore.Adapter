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
	/// A value type for ObservationUpdateRate to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// <item><b>Units</b>: <see cref="MtconnectUnit.COUNT_PER_SECOND" /></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class ObservationUpdateRate : SampleValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.SampleTypes.OBSERVATION_UPDATE_RATE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ObservationUpdateRate EVENT Data Item.
		/// </summary>
        public ObservationUpdateRate(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="ObservationUpdateRate"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="ObservationUpdateRate"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="ObservationUpdateRate"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ObservationUpdateRate(float value)
            => new ObservationUpdateRate(value);
		
    }
}