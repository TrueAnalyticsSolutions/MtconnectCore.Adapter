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
	/// A value type for Amperage to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
	/// <item><b>Units</b>: <see cref="MtconnectUnit.AMPERE" /></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v1.6 according to https://model.mtconnect.org/#_Version_1.6")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class Amperage : SampleValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.SampleTypes.AMPERAGE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the Amperage EVENT Data Item.
		/// </summary>
        public Amperage(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="Amperage"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="Amperage"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="Amperage"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Amperage(float value)
            => new Amperage(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Amperage" />.
		/// </summary>
		public partial class ALTERNATING : Amperage
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.AmperageSubTypes.ALTERNATING);

			/// <summary>
			/// Constructs a new value type for ALTERNATING.
			/// </summary>
            public ALTERNATING(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="ALTERNATING"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="ALTERNATING"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="ALTERNATING"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ALTERNATING(float value)
				=> new ALTERNATING(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Amperage" />.
		/// </summary>
		public partial class DIRECT : Amperage
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.AmperageSubTypes.DIRECT);

			/// <summary>
			/// Constructs a new value type for DIRECT.
			/// </summary>
            public DIRECT(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="DIRECT"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="DIRECT"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="DIRECT"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator DIRECT(float value)
				=> new DIRECT(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Amperage" />.
		/// </summary>
		public partial class ACTUAL : Amperage
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.AmperageSubTypes.ACTUAL);

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
		/// A Data Item SubType implementation of <see cref="Amperage" />.
		/// </summary>
		public partial class TARGET : Amperage
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.AmperageSubTypes.TARGET);

			/// <summary>
			/// Constructs a new value type for TARGET.
			/// </summary>
            public TARGET(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="TARGET"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="TARGET"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="TARGET"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator TARGET(float value)
				=> new TARGET(value);
		}
    }
}