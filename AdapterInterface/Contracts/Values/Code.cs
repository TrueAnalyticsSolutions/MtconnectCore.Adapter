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
	/// A value type for Code to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
	/// <remarks>Deprecated in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
	[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class Code : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the Code EVENT Data Item.
		/// </summary>
        public Code(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="Code"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="Code"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="Code"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Code(string value)
            => new Code(value.ToUpperInvariant());
		
    }
}