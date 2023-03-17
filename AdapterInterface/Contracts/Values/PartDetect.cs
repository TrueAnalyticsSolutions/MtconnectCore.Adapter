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
	/// A value type for PartDetect to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class PartDetect : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the PartDetect EVENT Data Item.
		/// </summary>
        public PartDetect(string value) : base(value) { }

        /// <summary>
		﻿/// part or work piece is detected or is present.
        /// </summary>
		[ObservationalValue(typeof(PartDetectValues))]
        public static PartDetect PRESENT => new PartDetect(nameof(PartDetectValues.PRESENT));
        /// <summary>
		﻿/// part or work piece is not detected or is not present.
        /// </summary>
		[ObservationalValue(typeof(PartDetectValues))]
        public static PartDetect NOT_PRESENT => new PartDetect(nameof(PartDetectValues.NOT_PRESENT));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="PartDetect"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="PartDetect"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="PartDetect"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PartDetect(string value)
            => new PartDetect(value.ToUpperInvariant());
		
    }
}