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
	/// A value type for DepositionRateVolumetric to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class DepositionRateVolumetric : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the DepositionRateVolumetric EVENT Data Item.
		/// </summary>
        public DepositionRateVolumetric(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="DepositionRateVolumetric"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="DepositionRateVolumetric"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="DepositionRateVolumetric"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator DepositionRateVolumetric(float value)
            => new DepositionRateVolumetric(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="DepositionRateVolumetric" />.
		/// </summary>
		public partial class ACTUAL : DepositionRateVolumetric
		{
			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="ACTUAL"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="ACTUAL"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="ACTUAL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ACTUAL(float value)
				=> new ACTUAL(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="DepositionRateVolumetric" />.
		/// </summary>
		public partial class COMMANDED : DepositionRateVolumetric
		{
			/// <summary>
			/// Constructs a new value type for COMMANDED.
			/// </summary>
            public COMMANDED(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="COMMANDED"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="COMMANDED"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="COMMANDED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator COMMANDED(float value)
				=> new COMMANDED(value);
		}
    }
}