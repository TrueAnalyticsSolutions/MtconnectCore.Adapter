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
	/// A value type for ChuckState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class ChuckState : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the ChuckState EVENT Data Item.
		/// </summary>
        public ChuckState(string value) : base(value) { }

        /// <summary>
		﻿/// <see cref="Chuck">Chuck</see> is open to the point of a positive confirmation.
        /// </summary>
		[ObservationalValue(typeof(ChuckStateValues))]
        public static ChuckState OPEN => new ChuckState(nameof(ChuckStateValues.OPEN));
        /// <summary>
		﻿/// <see cref="Chuck">Chuck</see> is closed to the point of a positive confirmation.
        /// </summary>
		[ObservationalValue(typeof(ChuckStateValues))]
        public static ChuckState CLOSED => new ChuckState(nameof(ChuckStateValues.CLOSED));
        /// <summary>
		﻿/// <see cref="Chuck">Chuck</see> is not closed to the point of a positive confirmation and not open to the point of a positive confirmation.   It is in an intermediate position.
        /// </summary>
		[ObservationalValue(typeof(ChuckStateValues))]
        public static ChuckState UNLATCHED => new ChuckState(nameof(ChuckStateValues.UNLATCHED));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ChuckState"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ChuckState"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ChuckState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ChuckState(string value)
            => new ChuckState(value.ToUpperInvariant());
		
    }
}