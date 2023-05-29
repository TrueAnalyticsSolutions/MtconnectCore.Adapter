#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk.Contracts.Attributes;
using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.DataItemValues;
using Mtconnect.AdapterSdk.Units;

namespace Mtconnect.AdapterSdk.DataItemValues
{
	/// <summary>
	/// A value type for AdapterSoftwareVersion to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class AdapterSoftwareVersion : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.ADAPTER_SOFTWARE_VERSION);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the AdapterSoftwareVersion EVENT Data Item.
		/// </summary>
        public AdapterSoftwareVersion(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="AdapterSoftwareVersion"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="AdapterSoftwareVersion"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="AdapterSoftwareVersion"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator AdapterSoftwareVersion(string value)
            => new AdapterSoftwareVersion(value.ToUpperInvariant());
		
    }
}