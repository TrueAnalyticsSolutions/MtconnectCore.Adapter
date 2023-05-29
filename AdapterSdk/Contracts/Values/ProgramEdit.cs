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
	/// A value type for ProgramEdit to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417667_46066_2882">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class ProgramEdit : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PROGRAM_EDIT);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ProgramEdit EVENT Data Item.
		/// </summary>
        public ProgramEdit(string value) : base(value) { }

		public ProgramEdit(ProgramEditValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="ProgramEditValues.ACTIVE" />
		[ObservationalValue(typeof(ProgramEditValues))]
        public static ProgramEdit ACTIVE => new ProgramEdit(ProgramEditValues.ACTIVE);
		/// <inheritdoc cref="ProgramEditValues.READY" />
		[ObservationalValue(typeof(ProgramEditValues))]
        public static ProgramEdit READY => new ProgramEdit(ProgramEditValues.READY);
		/// <inheritdoc cref="ProgramEditValues.NOT_READY" />
		[ObservationalValue(typeof(ProgramEditValues))]
        public static ProgramEdit NOT_READY => new ProgramEdit(ProgramEditValues.NOT_READY);

        /// <summary>
        /// Implicitly converts the specified <see cref="ProgramEditValues" /> to an <see cref="ProgramEdit"/> value.
        /// The <see cref="ProgramEditValues" /> is converted to a string and used to initialize the <see cref="ProgramEdit"/> value.
        /// </summary>
        /// <param name="value">The <see cref="ProgramEditValues" /> to convert.</param>
        /// <returns>An <see cref="ProgramEdit"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ProgramEdit(ProgramEditValues value)
            => new ProgramEdit(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ProgramEdit"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ProgramEdit"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ProgramEdit"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ProgramEdit(string value)
            => new ProgramEdit(value.ToUpperInvariant());
		
    }
}