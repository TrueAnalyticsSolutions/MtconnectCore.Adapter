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
	/// A value type for SensorAttachment to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class SensorAttachment : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the SensorAttachment EVENT Data Item.
		/// </summary>
        public SensorAttachment(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="SensorAttachment"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="SensorAttachment"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="SensorAttachment"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator SensorAttachment(string value)
        {
            return new SensorAttachment(value.ToUpperInvariant());
        }
		
    }
}