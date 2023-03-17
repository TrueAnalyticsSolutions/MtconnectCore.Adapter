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
	/// A value type for SpecificationLimit to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1620206901637_323897_780">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class SpecificationLimit : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the SpecificationLimit EVENT Data Item.
		/// </summary>
        public SpecificationLimit(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="SpecificationLimit"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="SpecificationLimit"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="SpecificationLimit"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator SpecificationLimit(string value)
            => new SpecificationLimit(value.ToUpperInvariant());
		
    }
}