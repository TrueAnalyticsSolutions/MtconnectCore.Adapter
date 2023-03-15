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
	/// A value type for Hardness to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class Hardness : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the Hardness EVENT Data Item.
		/// </summary>
        public Hardness(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="Hardness"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="Hardness"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="Hardness"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Hardness(string value)
        {
            return new Hardness(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Hardness" />.
		/// </summary>
		public partial class ROCKWELL : Hardness
		{
			/// <summary>
			/// Constructs a new value type for ROCKWELL.
			/// </summary>
            public ROCKWELL(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Hardness" />.
		/// </summary>
		public partial class VICKERS : Hardness
		{
			/// <summary>
			/// Constructs a new value type for VICKERS.
			/// </summary>
            public VICKERS(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Hardness" />.
		/// </summary>
		public partial class SHORE : Hardness
		{
			/// <summary>
			/// Constructs a new value type for SHORE.
			/// </summary>
            public SHORE(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Hardness" />.
		/// </summary>
		public partial class BRINELL : Hardness
		{
			/// <summary>
			/// Constructs a new value type for BRINELL.
			/// </summary>
            public BRINELL(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Hardness" />.
		/// </summary>
		public partial class LEEB : Hardness
		{
			/// <summary>
			/// Constructs a new value type for LEEB.
			/// </summary>
            public LEEB(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Hardness" />.
		/// </summary>
		public partial class MOHS : Hardness
		{
			/// <summary>
			/// Constructs a new value type for MOHS.
			/// </summary>
            public MOHS(string value) : base(value) { }
		}
    }
}