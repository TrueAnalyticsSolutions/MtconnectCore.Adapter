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
	/// A value type for Line to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.5.0")]
	public partial class Line : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.LINE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the Line EVENT Data Item.
		/// </summary>
        public Line(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="Line"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="Line"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="Line"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Line(string value)
            => new Line(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Line" />.
		/// </summary>
		public partial class MAXIMUM : Line
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.LineSubTypes.MAXIMUM);

			/// <summary>
			/// Constructs a new value type for MAXIMUM.
			/// </summary>
            public MAXIMUM(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="MAXIMUM"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="MAXIMUM"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="MAXIMUM"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator MAXIMUM(string value)
				=> new MAXIMUM(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Line" />.
		/// </summary>
		public partial class MINIMUM : Line
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.LineSubTypes.MINIMUM);

			/// <summary>
			/// Constructs a new value type for MINIMUM.
			/// </summary>
            public MINIMUM(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="MINIMUM"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="MINIMUM"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="MINIMUM"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator MINIMUM(string value)
				=> new MINIMUM(value.ToUpperInvariant());
		}
    }
}