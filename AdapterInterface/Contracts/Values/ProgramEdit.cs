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
	/// A value type for ProgramEdit to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class ProgramEdit : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the ProgramEdit EVENT Data Item.
		/// </summary>
        public ProgramEdit(string value) : base(value) { }

        /// <summary>
		﻿/// <see cref="Controller">Controller</see> is in the program edit mode.
        /// </summary>
		[ObservationalValue(typeof(ProgramEditValues))]
        public static ProgramEdit ACTIVE => new ProgramEdit(nameof(ProgramEditValues.ACTIVE));
        /// <summary>
		﻿/// <see cref="Controller">Controller</see> is capable of entering the program edit mode and no function is inhibiting a change to that mode.
        /// </summary>
		[ObservationalValue(typeof(ProgramEditValues))]
        public static ProgramEdit READY => new ProgramEdit(nameof(ProgramEditValues.READY));
        /// <summary>
		﻿/// <see cref="Controller">Controller</see> is being inhibited by a function from entering the program edit mode.
        /// </summary>
		[ObservationalValue(typeof(ProgramEditValues))]
        public static ProgramEdit NOT_READY => new ProgramEdit(nameof(ProgramEditValues.NOT_READY));
		
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