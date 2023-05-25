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
	/// A value type for Velocity to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// <item><b>Units</b>: <see cref="MtconnectUnit.MILLIMETER_PER_SECOND" /></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class Velocity : SampleValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.SampleTypes.VELOCITY);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the Velocity EVENT Data Item.
		/// </summary>
        public Velocity(float? value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float? to an <see cref="Velocity"/> value.
        /// The float? is converted to uppercase and used to initialize the <see cref="Velocity"/> value.
        /// </summary>
        /// <param name="value">The float? to convert.</param>
        /// <returns>An <see cref="Velocity"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Velocity(float? value)
            => new Velocity(value);
		
    }
}