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
	/// A value type for ConnectionStatus to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605104600701_22176_1030">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class ConnectionStatus : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.CONNECTION_STATUS);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ConnectionStatus EVENT Data Item.
		/// </summary>
        public ConnectionStatus(string value) : base(value) { }

        /// <summary>
		﻿/// no connection at all.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ConnectionStatusValues))]
        public static ConnectionStatus CLOSED => new ConnectionStatus(nameof(ConnectionStatusValues.CLOSED));
        /// <summary>
		﻿/// <i>agent</i> is waiting for a connection request from an <i>adapter</i>.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ConnectionStatusValues))]
        public static ConnectionStatus LISTEN => new ConnectionStatus(nameof(ConnectionStatusValues.LISTEN));
        /// <summary>
		﻿/// open connection.  The normal state for the data transfer phase of the connection.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ConnectionStatusValues))]
        public static ConnectionStatus ESTABLISHED => new ConnectionStatus(nameof(ConnectionStatusValues.ESTABLISHED));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ConnectionStatus"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ConnectionStatus"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ConnectionStatus"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ConnectionStatus(string value)
            => new ConnectionStatus(value.ToUpperInvariant());
		
    }
}