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
	/// A value type for EquipmentMode to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class EquipmentMode : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the EquipmentMode EVENT Data Item.
		/// </summary>
        public EquipmentMode(string value) : base(value) { }

        /// <summary>
		﻿/// equipment is functioning in the mode designated by the <c>subType</c>.
        /// </summary>
		[ObservationalValue(typeof(EquipmentModeValues))]
        public static EquipmentMode ON => new EquipmentMode(nameof(EquipmentModeValues.ON));
        /// <summary>
		﻿/// equipment is not functioning in the mode designated by the <c>subType</c>.
        /// </summary>
		[ObservationalValue(typeof(EquipmentModeValues))]
        public static EquipmentMode OFF => new EquipmentMode(nameof(EquipmentModeValues.OFF));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="EquipmentMode"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="EquipmentMode"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="EquipmentMode"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator EquipmentMode(string value)
        {
            return new EquipmentMode(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="EquipmentMode" />.
		/// </summary>
		public partial class LOADED : EquipmentMode
		{
			/// <summary>
			/// Constructs a new value type for LOADED.
			/// </summary>
            public LOADED(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="EquipmentMode" />.
		/// </summary>
		public partial class WORKING : EquipmentMode
		{
			/// <summary>
			/// Constructs a new value type for WORKING.
			/// </summary>
            public WORKING(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="EquipmentMode" />.
		/// </summary>
		public partial class OPERATING : EquipmentMode
		{
			/// <summary>
			/// Constructs a new value type for OPERATING.
			/// </summary>
            public OPERATING(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="EquipmentMode" />.
		/// </summary>
		public partial class POWERED : EquipmentMode
		{
			/// <summary>
			/// Constructs a new value type for POWERED.
			/// </summary>
            public POWERED(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="EquipmentMode" />.
		/// </summary>
		public partial class DELAY : EquipmentMode
		{
			/// <summary>
			/// Constructs a new value type for DELAY.
			/// </summary>
            public DELAY(string value) : base(value) { }
		}
    }
}