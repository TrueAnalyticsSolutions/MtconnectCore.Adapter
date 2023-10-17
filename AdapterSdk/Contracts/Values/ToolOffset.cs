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
	/// A value type for ToolOffset to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579272506322_914606_702">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class ToolOffset : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.TOOL_OFFSET);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ToolOffset EVENT Data Item.
		/// </summary>
        public ToolOffset(Single? value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified Single to an <see cref="ToolOffset"/> value.
        /// The Single is converted to uppercase and used to initialize the <see cref="ToolOffset"/> value.
        /// </summary>
        /// <param name="value">The Single to convert.</param>
        /// <returns>An <see cref="ToolOffset"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ToolOffset(Single? value)
            => new ToolOffset(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ToolOffset" />.
		/// </summary>
		public partial class RADIAL : ToolOffset
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ToolOffsetSubTypes.RADIAL);

			/// <summary>
			/// Constructs a new value type for RADIAL.
			/// </summary>
            public RADIAL(Single? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Single to an <see cref="RADIAL"/> value.
			/// The Single is converted to uppercase and used to initialize the <see cref="RADIAL"/> value.
			/// </summary>
			/// <param name="value">The Single to convert.</param>
			/// <returns>An <see cref="RADIAL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator RADIAL(Single? value)
				=> new RADIAL(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ToolOffset" />.
		/// </summary>
		public partial class LENGTH : ToolOffset
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ToolOffsetSubTypes.LENGTH);

			/// <summary>
			/// Constructs a new value type for LENGTH.
			/// </summary>
            public LENGTH(Single? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Single to an <see cref="LENGTH"/> value.
			/// The Single is converted to uppercase and used to initialize the <see cref="LENGTH"/> value.
			/// </summary>
			/// <param name="value">The Single to convert.</param>
			/// <returns>An <see cref="LENGTH"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator LENGTH(Single? value)
				=> new LENGTH(value);
		}
    }
}