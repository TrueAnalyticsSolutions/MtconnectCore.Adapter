#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk.Contracts.Attributes;
using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.DataItemValues;
using Mtconnect.AdapterSdk.Units;

namespace Mtconnect.AdapterSdk.DataItemValues
{
	/// <summary>
	/// A value type for EquipmentMode to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1632489429268_660861_104">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class EquipmentMode : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.EQUIPMENT_MODE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the EquipmentMode EVENT Data Item.
		/// </summary>
        public EquipmentMode(string value) : base(value) { }

		public EquipmentMode(EquipmentModeValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="EquipmentModeValues.ON" />
		[ObservationalValue(typeof(EquipmentModeValues))]
        public static EquipmentMode ON => new EquipmentMode(EquipmentModeValues.ON);
		/// <inheritdoc cref="EquipmentModeValues.OFF" />
		[ObservationalValue(typeof(EquipmentModeValues))]
        public static EquipmentMode OFF => new EquipmentMode(EquipmentModeValues.OFF);

        /// <summary>
        /// Implicitly converts the specified <see cref="EquipmentModeValues" /> to an <see cref="EquipmentMode"/> value.
        /// The <see cref="EquipmentModeValues" /> is converted to a string and used to initialize the <see cref="EquipmentMode"/> value.
        /// </summary>
        /// <param name="value">The <see cref="EquipmentModeValues" /> to convert.</param>
        /// <returns>An <see cref="EquipmentMode"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator EquipmentMode(EquipmentModeValues value)
            => new EquipmentMode(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="EquipmentMode"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="EquipmentMode"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="EquipmentMode"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator EquipmentMode(string value)
            => new EquipmentMode(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="EquipmentMode" />.
		/// </summary>
		public partial class LOADED : EquipmentMode
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.EquipmentModeSubTypes.LOADED);

			/// <summary>
			/// Constructs a new value type for LOADED.
			/// </summary>
            public LOADED(string value) : base(value) { }
			public LOADED(EquipmentModeValues value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified <see cref="EquipmentModeValues" /> to an <see cref="EquipmentMode"/> value.
			/// The <see cref="EquipmentModeValues" /> is converted to a string and used to initialize the <see cref="EquipmentMode"/> value.
			/// </summary>
			/// <param name="value">The <see cref="EquipmentModeValues" /> to convert.</param>
			/// <returns>An <see cref="EquipmentMode"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator LOADED(EquipmentModeValues value)
				=> new LOADED(value);
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="LOADED"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="LOADED"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="LOADED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator LOADED(string value)
				=> new LOADED(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="EquipmentMode" />.
		/// </summary>
		public partial class WORKING : EquipmentMode
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.EquipmentModeSubTypes.WORKING);

			/// <summary>
			/// Constructs a new value type for WORKING.
			/// </summary>
            public WORKING(string value) : base(value) { }
			public WORKING(EquipmentModeValues value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified <see cref="EquipmentModeValues" /> to an <see cref="EquipmentMode"/> value.
			/// The <see cref="EquipmentModeValues" /> is converted to a string and used to initialize the <see cref="EquipmentMode"/> value.
			/// </summary>
			/// <param name="value">The <see cref="EquipmentModeValues" /> to convert.</param>
			/// <returns>An <see cref="EquipmentMode"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator WORKING(EquipmentModeValues value)
				=> new WORKING(value);
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="WORKING"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="WORKING"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="WORKING"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator WORKING(string value)
				=> new WORKING(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="EquipmentMode" />.
		/// </summary>
		public partial class OPERATING : EquipmentMode
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.EquipmentModeSubTypes.OPERATING);

			/// <summary>
			/// Constructs a new value type for OPERATING.
			/// </summary>
            public OPERATING(string value) : base(value) { }
			public OPERATING(EquipmentModeValues value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified <see cref="EquipmentModeValues" /> to an <see cref="EquipmentMode"/> value.
			/// The <see cref="EquipmentModeValues" /> is converted to a string and used to initialize the <see cref="EquipmentMode"/> value.
			/// </summary>
			/// <param name="value">The <see cref="EquipmentModeValues" /> to convert.</param>
			/// <returns>An <see cref="EquipmentMode"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator OPERATING(EquipmentModeValues value)
				=> new OPERATING(value);
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="OPERATING"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="OPERATING"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="OPERATING"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator OPERATING(string value)
				=> new OPERATING(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="EquipmentMode" />.
		/// </summary>
		public partial class POWERED : EquipmentMode
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.EquipmentModeSubTypes.POWERED);

			/// <summary>
			/// Constructs a new value type for POWERED.
			/// </summary>
            public POWERED(string value) : base(value) { }
			public POWERED(EquipmentModeValues value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified <see cref="EquipmentModeValues" /> to an <see cref="EquipmentMode"/> value.
			/// The <see cref="EquipmentModeValues" /> is converted to a string and used to initialize the <see cref="EquipmentMode"/> value.
			/// </summary>
			/// <param name="value">The <see cref="EquipmentModeValues" /> to convert.</param>
			/// <returns>An <see cref="EquipmentMode"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator POWERED(EquipmentModeValues value)
				=> new POWERED(value);
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="POWERED"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="POWERED"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="POWERED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator POWERED(string value)
				=> new POWERED(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="EquipmentMode" />.
		/// </summary>
		public partial class DELAY : EquipmentMode
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.EquipmentModeSubTypes.DELAY);

			/// <summary>
			/// Constructs a new value type for DELAY.
			/// </summary>
            public DELAY(string value) : base(value) { }
			public DELAY(EquipmentModeValues value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified <see cref="EquipmentModeValues" /> to an <see cref="EquipmentMode"/> value.
			/// The <see cref="EquipmentModeValues" /> is converted to a string and used to initialize the <see cref="EquipmentMode"/> value.
			/// </summary>
			/// <param name="value">The <see cref="EquipmentModeValues" /> to convert.</param>
			/// <returns>An <see cref="EquipmentMode"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator DELAY(EquipmentModeValues value)
				=> new DELAY(value);
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="DELAY"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="DELAY"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="DELAY"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator DELAY(string value)
				=> new DELAY(value.ToUpperInvariant());
		}
    }
}