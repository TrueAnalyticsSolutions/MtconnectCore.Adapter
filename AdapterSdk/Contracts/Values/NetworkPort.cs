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
	/// A value type for NetworkPort to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579272271512_537408_674">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class NetworkPort : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.NETWORK_PORT);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the NetworkPort EVENT Data Item.
		/// </summary>
        public NetworkPort(Int32? value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified Int32 to an <see cref="NetworkPort"/> value.
        /// The Int32 is converted to uppercase and used to initialize the <see cref="NetworkPort"/> value.
        /// </summary>
        /// <param name="value">The Int32 to convert.</param>
        /// <returns>An <see cref="NetworkPort"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator NetworkPort(Int32? value)
            => new NetworkPort(value);
		
    }
}