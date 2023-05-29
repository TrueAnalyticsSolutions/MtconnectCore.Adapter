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
	/// A value type for LineNumber to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579272271512_537408_674">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class LineNumber : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.LINE_NUMBER);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the LineNumber EVENT Data Item.
		/// </summary>
        public LineNumber(Int32 value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified Int32 to an <see cref="LineNumber"/> value.
        /// The Int32 is converted to uppercase and used to initialize the <see cref="LineNumber"/> value.
        /// </summary>
        /// <param name="value">The Int32 to convert.</param>
        /// <returns>An <see cref="LineNumber"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator LineNumber(Int32 value)
            => new LineNumber(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="LineNumber" />.
		/// </summary>
		public partial class ABSOLUTE : LineNumber
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.LineNumberSubTypes.ABSOLUTE);

			/// <summary>
			/// Constructs a new value type for ABSOLUTE.
			/// </summary>
            public ABSOLUTE(Int32 value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="ABSOLUTE"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="ABSOLUTE"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="ABSOLUTE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ABSOLUTE(Int32 value)
				=> new ABSOLUTE(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="LineNumber" />.
		/// </summary>
		public partial class INCREMENTAL : LineNumber
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.LineNumberSubTypes.INCREMENTAL);

			/// <summary>
			/// Constructs a new value type for INCREMENTAL.
			/// </summary>
            public INCREMENTAL(Int32 value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="INCREMENTAL"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="INCREMENTAL"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="INCREMENTAL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator INCREMENTAL(Int32 value)
				=> new INCREMENTAL(value);
		}
    }
}