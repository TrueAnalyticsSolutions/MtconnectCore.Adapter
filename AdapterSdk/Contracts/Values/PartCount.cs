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
	/// A value type for PartCount to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579272271512_537408_674">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class PartCount : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PART_COUNT);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the PartCount EVENT Data Item.
		/// </summary>
        public PartCount(Int32? value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified Int32 to an <see cref="PartCount"/> value.
        /// The Int32 is converted to uppercase and used to initialize the <see cref="PartCount"/> value.
        /// </summary>
        /// <param name="value">The Int32 to convert.</param>
        /// <returns>An <see cref="PartCount"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PartCount(Int32? value)
            => new PartCount(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartCount" />.
		/// </summary>
		public partial class ALL : PartCount
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartCountSubTypes.ALL);

			/// <summary>
			/// Constructs a new value type for ALL.
			/// </summary>
            public ALL(Int32? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="ALL"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="ALL"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="ALL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ALL(Int32? value)
				=> new ALL(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartCount" />.
		/// </summary>
		public partial class GOOD : PartCount
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartCountSubTypes.GOOD);

			/// <summary>
			/// Constructs a new value type for GOOD.
			/// </summary>
            public GOOD(Int32? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="GOOD"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="GOOD"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="GOOD"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator GOOD(Int32? value)
				=> new GOOD(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartCount" />.
		/// </summary>
		public partial class BAD : PartCount
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartCountSubTypes.BAD);

			/// <summary>
			/// Constructs a new value type for BAD.
			/// </summary>
            public BAD(Int32? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="BAD"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="BAD"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="BAD"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator BAD(Int32? value)
				=> new BAD(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartCount" />.
		/// </summary>
		public partial class TARGET : PartCount
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartCountSubTypes.TARGET);

			/// <summary>
			/// Constructs a new value type for TARGET.
			/// </summary>
            public TARGET(Int32? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="TARGET"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="TARGET"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="TARGET"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator TARGET(Int32? value)
				=> new TARGET(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartCount" />.
		/// </summary>
		public partial class REMAINING : PartCount
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartCountSubTypes.REMAINING);

			/// <summary>
			/// Constructs a new value type for REMAINING.
			/// </summary>
            public REMAINING(Int32? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="REMAINING"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="REMAINING"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="REMAINING"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator REMAINING(Int32? value)
				=> new REMAINING(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartCount" />.
		/// </summary>
		public partial class COMPLETE : PartCount
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartCountSubTypes.COMPLETE);

			/// <summary>
			/// Constructs a new value type for COMPLETE.
			/// </summary>
            public COMPLETE(Int32? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="COMPLETE"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="COMPLETE"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="COMPLETE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator COMPLETE(Int32? value)
				=> new COMPLETE(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartCount" />.
		/// </summary>
		public partial class ABORTED : PartCount
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartCountSubTypes.ABORTED);

			/// <summary>
			/// Constructs a new value type for ABORTED.
			/// </summary>
            public ABORTED(Int32? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="ABORTED"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="ABORTED"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="ABORTED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ABORTED(Int32? value)
				=> new ABORTED(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PartCount" />.
		/// </summary>
		public partial class FAILED : PartCount
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PartCountSubTypes.FAILED);

			/// <summary>
			/// Constructs a new value type for FAILED.
			/// </summary>
            public FAILED(Int32? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="FAILED"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="FAILED"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="FAILED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator FAILED(Int32? value)
				=> new FAILED(value);
		}
    }
}