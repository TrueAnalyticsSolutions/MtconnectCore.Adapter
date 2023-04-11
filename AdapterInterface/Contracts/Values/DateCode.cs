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
	/// A value type for DateCode to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579272233011_597138_670">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class DateCode : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.DATE_CODE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the DateCode EVENT Data Item.
		/// </summary>
        public DateCode(DateTime value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified DateTime to an <see cref="DateCode"/> value.
        /// The DateTime is converted to uppercase and used to initialize the <see cref="DateCode"/> value.
        /// </summary>
        /// <param name="value">The DateTime to convert.</param>
        /// <returns>An <see cref="DateCode"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator DateCode(DateTime value)
            => new DateCode(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="DateCode" />.
		/// </summary>
		public partial class MANUFACTURE : DateCode
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.DateCodeSubTypes.MANUFACTURE);

			/// <summary>
			/// Constructs a new value type for MANUFACTURE.
			/// </summary>
            public MANUFACTURE(DateTime value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified DateTime to an <see cref="MANUFACTURE"/> value.
			/// The DateTime is converted to uppercase and used to initialize the <see cref="MANUFACTURE"/> value.
			/// </summary>
			/// <param name="value">The DateTime to convert.</param>
			/// <returns>An <see cref="MANUFACTURE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator MANUFACTURE(DateTime value)
				=> new MANUFACTURE(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="DateCode" />.
		/// </summary>
		public partial class EXPIRATION : DateCode
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.DateCodeSubTypes.EXPIRATION);

			/// <summary>
			/// Constructs a new value type for EXPIRATION.
			/// </summary>
            public EXPIRATION(DateTime value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified DateTime to an <see cref="EXPIRATION"/> value.
			/// The DateTime is converted to uppercase and used to initialize the <see cref="EXPIRATION"/> value.
			/// </summary>
			/// <param name="value">The DateTime to convert.</param>
			/// <returns>An <see cref="EXPIRATION"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator EXPIRATION(DateTime value)
				=> new EXPIRATION(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="DateCode" />.
		/// </summary>
		public partial class FIRSTUSE : DateCode
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.DateCodeSubTypes.FIRST_USE);

			/// <summary>
			/// Constructs a new value type for FIRST_USE.
			/// </summary>
            public FIRSTUSE(DateTime value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified DateTime to an <see cref="FIRSTUSE"/> value.
			/// The DateTime is converted to uppercase and used to initialize the <see cref="FIRSTUSE"/> value.
			/// </summary>
			/// <param name="value">The DateTime to convert.</param>
			/// <returns>An <see cref="FIRSTUSE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator FIRSTUSE(DateTime value)
				=> new FIRSTUSE(value);
		}
    }
}