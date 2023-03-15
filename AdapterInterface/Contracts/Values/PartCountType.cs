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
	/// A value type for PartCountType to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class PartCountType : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the PartCountType EVENT Data Item.
		/// </summary>
        public PartCountType(string value) : base(value) { }

        /// <summary>
		﻿/// count is of individual items.
        /// </summary>
		[ObservationalValue(typeof(PartCountTypeValues))]
        public static PartCountType EACH => new PartCountType(nameof(PartCountTypeValues.EACH));
        /// <summary>
		﻿/// pre-specified group of items.
        /// </summary>
		[ObservationalValue(typeof(PartCountTypeValues))]
        public static PartCountType BATCH => new PartCountType(nameof(PartCountTypeValues.BATCH));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="PartCountType"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="PartCountType"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="PartCountType"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PartCountType(string value)
        {
            return new PartCountType(value.ToUpperInvariant());
        }
		
    }
}