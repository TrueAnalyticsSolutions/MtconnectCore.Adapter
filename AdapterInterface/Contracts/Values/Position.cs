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
	/// A value type for Position to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class Position : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the Position EVENT Data Item.
		/// </summary>
        public Position(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="Position"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="Position"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="Position"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Position(float value)
        {
            return new Position(value);
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Position" />.
		/// </summary>
		public partial class ACTUAL : Position
		{
			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Position" />.
		/// </summary>
		public partial class COMMANDED : Position
		{
			/// <summary>
			/// Constructs a new value type for COMMANDED.
			/// </summary>
            public COMMANDED(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Position" />.
		/// </summary>
		public partial class PROGRAMMED : Position
		{
			/// <summary>
			/// Constructs a new value type for PROGRAMMED.
			/// </summary>
            public PROGRAMMED(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Position" />.
		/// </summary>
		public partial class TARGET : Position
		{
			/// <summary>
			/// Constructs a new value type for TARGET.
			/// </summary>
            public TARGET(float value) : base(value) { }
		}
    }
}