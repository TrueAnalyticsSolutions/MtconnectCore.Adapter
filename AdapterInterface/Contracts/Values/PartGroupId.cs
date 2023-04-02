#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItems;
using Mtconnect.AdapterInterface.DataItemValues;
using Mtconnect.AdapterInterface.Units;

namespace Mtconnect.AdapterInterface.DataItemValues
{
	/// <summary>
	/// A value type for PartGroupId to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.5.0")]
	public partial class PartGroupId : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PART_GROUP_ID);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the PartGroupId EVENT Data Item.
		/// </summary>
        public PartGroupId(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="PartGroupId"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="PartGroupId"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="PartGroupId"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PartGroupId(string value)
            => new PartGroupId(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartGroupId" />.
		/// </summary>
		public partial class LOT : PartGroupId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartGroupIdSubTypes.LOT);

			/// <summary>
			/// Constructs a new value type for LOT.
			/// </summary>
            public LOT(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="LOT"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="LOT"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="LOT"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator LOT(string value)
				=> new LOT(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartGroupId" />.
		/// </summary>
		public partial class RAWMATERIAL : PartGroupId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartGroupIdSubTypes.RAW_MATERIAL);

			/// <summary>
			/// Constructs a new value type for RAW_MATERIAL.
			/// </summary>
            public RAWMATERIAL(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="RAWMATERIAL"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="RAWMATERIAL"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="RAWMATERIAL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator RAWMATERIAL(string value)
				=> new RAWMATERIAL(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartGroupId" />.
		/// </summary>
		public partial class BATCH : PartGroupId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartGroupIdSubTypes.BATCH);

			/// <summary>
			/// Constructs a new value type for BATCH.
			/// </summary>
            public BATCH(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="BATCH"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="BATCH"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="BATCH"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator BATCH(string value)
				=> new BATCH(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartGroupId" />.
		/// </summary>
		public partial class UUID : PartGroupId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartGroupIdSubTypes.UUID);

			/// <summary>
			/// Constructs a new value type for UUID.
			/// </summary>
            public UUID(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="UUID"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="UUID"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="UUID"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator UUID(string value)
				=> new UUID(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartGroupId" />.
		/// </summary>
		public partial class HEATTREAT : PartGroupId
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartGroupIdSubTypes.HEAT_TREAT);

			/// <summary>
			/// Constructs a new value type for HEAT_TREAT.
			/// </summary>
            public HEATTREAT(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="HEATTREAT"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="HEATTREAT"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="HEATTREAT"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator HEATTREAT(string value)
				=> new HEATTREAT(value.ToUpperInvariant());
		}
    }
}