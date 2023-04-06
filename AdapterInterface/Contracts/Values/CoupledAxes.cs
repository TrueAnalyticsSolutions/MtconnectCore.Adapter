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
	/// A value type for CoupledAxes to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579272360416_763325_681">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.7.0")]
	public partial class CoupledAxes : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.COUPLED_AXES);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the CoupledAxes EVENT Data Item.
		/// </summary>
        public CoupledAxes(String value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified String to an <see cref="CoupledAxes"/> value.
        /// The String is converted to uppercase and used to initialize the <see cref="CoupledAxes"/> value.
        /// </summary>
        /// <param name="value">The String to convert.</param>
        /// <returns>An <see cref="CoupledAxes"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator CoupledAxes(String value)
            => new CoupledAxes(value);
		
    }
}