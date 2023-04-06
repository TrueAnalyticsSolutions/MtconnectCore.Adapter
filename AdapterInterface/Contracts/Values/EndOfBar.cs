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
	/// A value type for EndOfBar to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417663_685842_2877">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.7.0")]
	public partial class EndOfBar : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.END_OF_BAR);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the EndOfBar EVENT Data Item.
		/// </summary>
        public EndOfBar(string value) : base(value) { }

        /// <summary>
		﻿/// <see cref="EndOfBar">EndOfBar</see> has been reached.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(EndOfBarValues))]
        public static EndOfBar YES => new EndOfBar(nameof(EndOfBarValues.YES));
        /// <summary>
		﻿/// <see cref="EndOfBar">EndOfBar</see> has not been reached.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(EndOfBarValues))]
        public static EndOfBar NO => new EndOfBar(nameof(EndOfBarValues.NO));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="EndOfBar"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="EndOfBar"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="EndOfBar"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator EndOfBar(string value)
            => new EndOfBar(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="EndOfBar" />.
		/// </summary>
		public partial class PRIMARY : EndOfBar
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.EndOfBarSubTypes.PRIMARY);

			/// <summary>
			/// Constructs a new value type for PRIMARY.
			/// </summary>
            public PRIMARY(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="PRIMARY"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="PRIMARY"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="PRIMARY"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator PRIMARY(string value)
				=> new PRIMARY(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="EndOfBar" />.
		/// </summary>
		public partial class AUXILIARY : EndOfBar
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.EndOfBarSubTypes.AUXILIARY);

			/// <summary>
			/// Constructs a new value type for AUXILIARY.
			/// </summary>
            public AUXILIARY(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="AUXILIARY"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="AUXILIARY"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="AUXILIARY"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator AUXILIARY(string value)
				=> new AUXILIARY(value.ToUpperInvariant());
		}
    }
}