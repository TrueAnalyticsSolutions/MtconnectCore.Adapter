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
	/// A value type for WorkholdingId to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class WorkholdingId : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the WorkholdingId EVENT Data Item.
		/// </summary>
        public WorkholdingId(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="WorkholdingId"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="WorkholdingId"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="WorkholdingId"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator WorkholdingId(string value)
        {
            return new WorkholdingId(value.ToUpperInvariant());
        }
		
    }
}