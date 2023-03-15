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
	/// A value type for SpindleSpeed to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_2_0")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class SpindleSpeed : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the SpindleSpeed EVENT Data Item.
		/// </summary>
        public SpindleSpeed(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="SpindleSpeed"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="SpindleSpeed"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="SpindleSpeed"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator SpindleSpeed(float value)
        {
            return new SpindleSpeed(value);
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="SpindleSpeed" />.
		/// </summary>
		public partial class ACTUAL : SpindleSpeed
		{
			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="SpindleSpeed" />.
		/// </summary>
		public partial class COMMANDED : SpindleSpeed
		{
			/// <summary>
			/// Constructs a new value type for COMMANDED.
			/// </summary>
            public COMMANDED(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="SpindleSpeed" />.
		/// </summary>
		public partial class OVERRIDE : SpindleSpeed
		{
			/// <summary>
			/// Constructs a new value type for OVERRIDE.
			/// </summary>
            public OVERRIDE(float value) : base(value) { }
		}
    }
}