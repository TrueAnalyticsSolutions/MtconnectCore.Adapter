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
	/// A value type for MaterialLayer to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579272271512_537408_674">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class MaterialLayer : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.MATERIAL_LAYER);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the MaterialLayer EVENT Data Item.
		/// </summary>
        public MaterialLayer(Int32 value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified Int32 to an <see cref="MaterialLayer"/> value.
        /// The Int32 is converted to uppercase and used to initialize the <see cref="MaterialLayer"/> value.
        /// </summary>
        /// <param name="value">The Int32 to convert.</param>
        /// <returns>An <see cref="MaterialLayer"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator MaterialLayer(Int32 value)
            => new MaterialLayer(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="MaterialLayer" />.
		/// </summary>
		public partial class ACTUAL : MaterialLayer
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.MaterialLayerSubTypes.ACTUAL);

			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(Int32 value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="ACTUAL"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="ACTUAL"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="ACTUAL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ACTUAL(Int32 value)
				=> new ACTUAL(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="MaterialLayer" />.
		/// </summary>
		public partial class TARGET : MaterialLayer
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.MaterialLayerSubTypes.TARGET);

			/// <summary>
			/// Constructs a new value type for TARGET.
			/// </summary>
            public TARGET(Int32 value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="TARGET"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="TARGET"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="TARGET"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator TARGET(Int32 value)
				=> new TARGET(value);
		}
    }
}