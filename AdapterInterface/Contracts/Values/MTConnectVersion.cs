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
	/// A value type for MTConnectVersion to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class MTConnectVersion : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the MTConnectVersion EVENT Data Item.
		/// </summary>
        public MTConnectVersion(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="MTConnectVersion"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="MTConnectVersion"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="MTConnectVersion"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator MTConnectVersion(string value)
            => new MTConnectVersion(value.ToUpperInvariant());
		
    }
}