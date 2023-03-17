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
	/// A value type for PartStatus to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class PartStatus : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the PartStatus EVENT Data Item.
		/// </summary>
        public PartStatus(string value) : base(value) { }

        /// <summary>
		﻿/// part conforms to given requirements.
        /// </summary>
		[ObservationalValue(typeof(PartStatusValues))]
        public static PartStatus PASS => new PartStatus(nameof(PartStatusValues.PASS));
        /// <summary>
		﻿/// part does not conform to some given requirements.
        /// </summary>
		[ObservationalValue(typeof(PartStatusValues))]
        public static PartStatus FAIL => new PartStatus(nameof(PartStatusValues.FAIL));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="PartStatus"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="PartStatus"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="PartStatus"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PartStatus(string value)
            => new PartStatus(value.ToUpperInvariant());
		
    }
}