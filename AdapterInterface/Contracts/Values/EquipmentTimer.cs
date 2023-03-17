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
	/// A value type for EquipmentTimer to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class EquipmentTimer : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the EquipmentTimer EVENT Data Item.
		/// </summary>
        public EquipmentTimer(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="EquipmentTimer"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="EquipmentTimer"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="EquipmentTimer"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator EquipmentTimer(float value)
            => new EquipmentTimer(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="EquipmentTimer" />.
		/// </summary>
		public partial class LOADED : EquipmentTimer
		{
			/// <summary>
			/// Constructs a new value type for LOADED.
			/// </summary>
            public LOADED(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="LOADED"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="LOADED"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="LOADED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator LOADED(float value)
				=> new LOADED(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="EquipmentTimer" />.
		/// </summary>
		public partial class WORKING : EquipmentTimer
		{
			/// <summary>
			/// Constructs a new value type for WORKING.
			/// </summary>
            public WORKING(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="WORKING"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="WORKING"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="WORKING"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator WORKING(float value)
				=> new WORKING(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="EquipmentTimer" />.
		/// </summary>
		public partial class OPERATING : EquipmentTimer
		{
			/// <summary>
			/// Constructs a new value type for OPERATING.
			/// </summary>
            public OPERATING(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="OPERATING"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="OPERATING"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="OPERATING"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator OPERATING(float value)
				=> new OPERATING(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="EquipmentTimer" />.
		/// </summary>
		public partial class POWERED : EquipmentTimer
		{
			/// <summary>
			/// Constructs a new value type for POWERED.
			/// </summary>
            public POWERED(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="POWERED"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="POWERED"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="POWERED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator POWERED(float value)
				=> new POWERED(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="EquipmentTimer" />.
		/// </summary>
		public partial class DELAY : EquipmentTimer
		{
			/// <summary>
			/// Constructs a new value type for DELAY.
			/// </summary>
            public DELAY(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="DELAY"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="DELAY"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="DELAY"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator DELAY(float value)
				=> new DELAY(value);
		}
    }
}