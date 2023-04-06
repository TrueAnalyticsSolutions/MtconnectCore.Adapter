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
	/// A value type for RotaryVelocityOverride to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579272506322_914606_702">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.7.0")]
	public partial class RotaryVelocityOverride : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.ROTARY_VELOCITY_OVERRIDE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the RotaryVelocityOverride EVENT Data Item.
		/// </summary>
        public RotaryVelocityOverride(Single value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified Single to an <see cref="RotaryVelocityOverride"/> value.
        /// The Single is converted to uppercase and used to initialize the <see cref="RotaryVelocityOverride"/> value.
        /// </summary>
        /// <param name="value">The Single to convert.</param>
        /// <returns>An <see cref="RotaryVelocityOverride"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator RotaryVelocityOverride(Single value)
            => new RotaryVelocityOverride(value);
		
    }
}