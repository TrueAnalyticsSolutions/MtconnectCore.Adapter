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
	/// A value type for SoundLevel to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class SoundLevel : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the SoundLevel EVENT Data Item.
		/// </summary>
        public SoundLevel(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="SoundLevel"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="SoundLevel"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="SoundLevel"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator SoundLevel(float value)
            => new SoundLevel(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="SoundLevel" />.
		/// </summary>
		public partial class NOSCALE : SoundLevel
		{
			/// <summary>
			/// Constructs a new value type for NO_SCALE.
			/// </summary>
            public NOSCALE(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="NOSCALE"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="NOSCALE"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="NOSCALE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator NOSCALE(float value)
				=> new NOSCALE(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="SoundLevel" />.
		/// </summary>
		public partial class ASCALE : SoundLevel
		{
			/// <summary>
			/// Constructs a new value type for A_SCALE.
			/// </summary>
            public ASCALE(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="ASCALE"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="ASCALE"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="ASCALE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ASCALE(float value)
				=> new ASCALE(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="SoundLevel" />.
		/// </summary>
		public partial class BSCALE : SoundLevel
		{
			/// <summary>
			/// Constructs a new value type for B_SCALE.
			/// </summary>
            public BSCALE(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="BSCALE"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="BSCALE"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="BSCALE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator BSCALE(float value)
				=> new BSCALE(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="SoundLevel" />.
		/// </summary>
		public partial class CSCALE : SoundLevel
		{
			/// <summary>
			/// Constructs a new value type for C_SCALE.
			/// </summary>
            public CSCALE(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="CSCALE"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="CSCALE"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="CSCALE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator CSCALE(float value)
				=> new CSCALE(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="SoundLevel" />.
		/// </summary>
		public partial class DSCALE : SoundLevel
		{
			/// <summary>
			/// Constructs a new value type for D_SCALE.
			/// </summary>
            public DSCALE(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="DSCALE"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="DSCALE"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="DSCALE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator DSCALE(float value)
				=> new DSCALE(value);
		}
    }
}