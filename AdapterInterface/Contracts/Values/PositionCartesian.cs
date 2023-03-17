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
	/// A value type for PositionCartesian to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579272506322_914606_702">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class PositionCartesian : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the PositionCartesian EVENT Data Item.
		/// </summary>
        public PositionCartesian(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="PositionCartesian"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="PositionCartesian"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="PositionCartesian"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PositionCartesian(float value)
            => new PositionCartesian(value);
		
    }
}