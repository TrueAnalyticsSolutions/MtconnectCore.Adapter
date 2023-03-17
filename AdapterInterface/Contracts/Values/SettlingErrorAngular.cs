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
	/// A value type for SettlingErrorAngular to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class SettlingErrorAngular : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the SettlingErrorAngular EVENT Data Item.
		/// </summary>
        public SettlingErrorAngular(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="SettlingErrorAngular"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="SettlingErrorAngular"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="SettlingErrorAngular"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator SettlingErrorAngular(float value)
            => new SettlingErrorAngular(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="SettlingErrorAngular" />.
		/// </summary>
		public partial class ACTUAL : SettlingErrorAngular
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
    }
}