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
	/// A value type for Length to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class Length : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the Length EVENT Data Item.
		/// </summary>
        public Length(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="Length"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="Length"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="Length"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Length(float value)
            => new Length(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Length" />.
		/// </summary>
		public partial class STANDARD : Length
		{
			/// <summary>
			/// Constructs a new value type for STANDARD.
			/// </summary>
            public STANDARD(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="STANDARD"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="STANDARD"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="STANDARD"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator STANDARD(float value)
				=> new STANDARD(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Length" />.
		/// </summary>
		public partial class REMAINING : Length
		{
			/// <summary>
			/// Constructs a new value type for REMAINING.
			/// </summary>
            public REMAINING(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="REMAINING"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="REMAINING"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="REMAINING"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator REMAINING(float value)
				=> new REMAINING(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Length" />.
		/// </summary>
		public partial class USEABLE : Length
		{
			/// <summary>
			/// Constructs a new value type for USEABLE.
			/// </summary>
            public USEABLE(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="USEABLE"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="USEABLE"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="USEABLE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator USEABLE(float value)
				=> new USEABLE(value);
		}
    }
}