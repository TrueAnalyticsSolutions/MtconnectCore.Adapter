#pragma warning disable 0618
#pragma warning disable 1574
#pragma warning disable CS1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk;
using Mtconnect.AdapterSdk.Attributes;
using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.DataItemValues;
using Mtconnect.AdapterSdk.Units;

namespace Mtconnect.AdapterSdk.DataItemValues
{
	/// <summary>
	/// A value type for ProgramNestLevel to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579272271512_537408_674">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class ProgramNestLevel : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PROGRAM_NEST_LEVEL);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ProgramNestLevel EVENT Data Item.
		/// </summary>
        public ProgramNestLevel(Int32? value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified Int32 to an <see cref="ProgramNestLevel"/> value.
        /// The Int32 is converted to uppercase and used to initialize the <see cref="ProgramNestLevel"/> value.
        /// </summary>
        /// <param name="value">The Int32 to convert.</param>
        /// <returns>An <see cref="ProgramNestLevel"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ProgramNestLevel(Int32? value)
            => new ProgramNestLevel(value);
		
    }
}