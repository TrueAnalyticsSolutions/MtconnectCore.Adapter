#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItems;
using Mtconnect.AdapterInterface.DataItemValues;

namespace Mtconnect.AdapterInterface.DataItemValues
{
	/// <summary>
	/// A value type for EndOfBar to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class EndOfBar : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the EndOfBar EVENT Data Item.
		/// </summary>
        public EndOfBar(string value) : base(value) { }

        /// <summary>
		﻿/// <see cref="EndOfBar">EndOfBar</see> has been reached.
        /// </summary>
		[ObservationalValue(typeof(EndOfBarValues))]
        public static EndOfBar YES => new EndOfBar(nameof(EndOfBarValues.YES));
        /// <summary>
		﻿/// <see cref="EndOfBar">EndOfBar</see> has not been reached.
        /// </summary>
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