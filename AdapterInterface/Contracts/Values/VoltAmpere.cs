#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItems;
using Mtconnect.AdapterInterface.DataItemValues;
using Mtconnect.AdapterInterface.Units;

namespace Mtconnect.AdapterInterface.DataItemValues
{
	/// <summary>
	/// A value type for VoltAmpere to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// <item><b>Units</b>: <see cref="MtconnectUnit.VOLT_AMPERE" /></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.5.0")]
	public partial class VoltAmpere : SampleValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.SampleTypes.VOLT_AMPERE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the VoltAmpere EVENT Data Item.
		/// </summary>
        public VoltAmpere(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="VoltAmpere"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="VoltAmpere"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="VoltAmpere"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator VoltAmpere(float value)
            => new VoltAmpere(value);
		
    }
}