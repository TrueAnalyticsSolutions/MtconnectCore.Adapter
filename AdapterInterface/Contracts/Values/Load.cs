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
	/// A value type for Load to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class Load : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the Load EVENT Data Item.
		/// </summary>
        public Load(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="Load"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="Load"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="Load"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Load(float value)
        {
            return new Load(value);
        }
		
    }
}