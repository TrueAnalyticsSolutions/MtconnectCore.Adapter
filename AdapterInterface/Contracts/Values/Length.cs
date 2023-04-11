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
	/// A value type for Length to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// <item><b>Units</b>: <see cref="MtconnectUnit.MILLIMETER" /></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class Length : SampleValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.SampleTypes.LENGTH);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

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
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.LengthSubTypes._STANDARD);

			/// <summary>
			/// Constructs a new value type for _STANDARD.
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
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.LengthSubTypes._REMAINING);

			/// <summary>
			/// Constructs a new value type for _REMAINING.
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
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.LengthSubTypes._USEABLE);

			/// <summary>
			/// Constructs a new value type for _USEABLE.
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