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
	/// A value type for Velocity to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class Velocity : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the Velocity EVENT Data Item.
		/// </summary>
        public Velocity(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="Velocity"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="Velocity"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="Velocity"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Velocity(float value)
            => new Velocity(value);
		
    }
}