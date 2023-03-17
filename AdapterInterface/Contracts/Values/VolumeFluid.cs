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
	/// A value type for VolumeFluid to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class VolumeFluid : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the VolumeFluid EVENT Data Item.
		/// </summary>
        public VolumeFluid(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="VolumeFluid"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="VolumeFluid"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="VolumeFluid"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator VolumeFluid(float value)
            => new VolumeFluid(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="VolumeFluid" />.
		/// </summary>
		public partial class ACTUAL : VolumeFluid
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
		/// A Data Item SubType implementation of <see cref="VolumeFluid" />.
		/// </summary>
		public partial class CONSUMED : VolumeFluid
		{
			/// <summary>
			/// Constructs a new value type for CONSUMED.
			/// </summary>
            public CONSUMED(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="CONSUMED"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="CONSUMED"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="CONSUMED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator CONSUMED(float value)
				=> new CONSUMED(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="VolumeFluid" />.
		/// </summary>
		public partial class PART : VolumeFluid
		{
			/// <summary>
			/// Constructs a new value type for PART.
			/// </summary>
            public PART(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="PART"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="PART"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="PART"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator PART(float value)
				=> new PART(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="VolumeFluid" />.
		/// </summary>
		public partial class WASTE : VolumeFluid
		{
			/// <summary>
			/// Constructs a new value type for WASTE.
			/// </summary>
            public WASTE(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="WASTE"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="WASTE"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="WASTE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator WASTE(float value)
				=> new WASTE(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="VolumeFluid" />.
		/// </summary>
		public partial class START : VolumeFluid
		{
			/// <summary>
			/// Constructs a new value type for START.
			/// </summary>
            public START(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="START"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="START"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="START"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator START(float value)
				=> new START(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="VolumeFluid" />.
		/// </summary>
		public partial class ENDED : VolumeFluid
		{
			/// <summary>
			/// Constructs a new value type for ENDED.
			/// </summary>
            public ENDED(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="ENDED"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="ENDED"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="ENDED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ENDED(float value)
				=> new ENDED(value);
		}
    }
}