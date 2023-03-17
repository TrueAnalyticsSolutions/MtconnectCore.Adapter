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
	/// A value type for CycleCount to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class CycleCount : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the CycleCount EVENT Data Item.
		/// </summary>
        public CycleCount(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="CycleCount"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="CycleCount"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="CycleCount"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator CycleCount(string value)
            => new CycleCount(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="CycleCount" />.
		/// </summary>
		public partial class GOOD : CycleCount
		{
			/// <summary>
			/// Constructs a new value type for GOOD.
			/// </summary>
            public GOOD(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="GOOD"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="GOOD"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="GOOD"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator GOOD(string value)
				=> new GOOD(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="CycleCount" />.
		/// </summary>
		public partial class REMAINING : CycleCount
		{
			/// <summary>
			/// Constructs a new value type for REMAINING.
			/// </summary>
            public REMAINING(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="REMAINING"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="REMAINING"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="REMAINING"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator REMAINING(string value)
				=> new REMAINING(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="CycleCount" />.
		/// </summary>
		public partial class COMPLETE : CycleCount
		{
			/// <summary>
			/// Constructs a new value type for COMPLETE.
			/// </summary>
            public COMPLETE(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="COMPLETE"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="COMPLETE"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="COMPLETE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator COMPLETE(string value)
				=> new COMPLETE(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="CycleCount" />.
		/// </summary>
		public partial class ABORTED : CycleCount
		{
			/// <summary>
			/// Constructs a new value type for ABORTED.
			/// </summary>
            public ABORTED(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="ABORTED"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="ABORTED"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="ABORTED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ABORTED(string value)
				=> new ABORTED(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="CycleCount" />.
		/// </summary>
		public partial class BAD : CycleCount
		{
			/// <summary>
			/// Constructs a new value type for BAD.
			/// </summary>
            public BAD(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="BAD"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="BAD"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="BAD"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator BAD(string value)
				=> new BAD(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="CycleCount" />.
		/// </summary>
		public partial class FAILED : CycleCount
		{
			/// <summary>
			/// Constructs a new value type for FAILED.
			/// </summary>
            public FAILED(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="FAILED"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="FAILED"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="FAILED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator FAILED(string value)
				=> new FAILED(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="CycleCount" />.
		/// </summary>
		public partial class TARGET : CycleCount
		{
			/// <summary>
			/// Constructs a new value type for TARGET.
			/// </summary>
            public TARGET(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="TARGET"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="TARGET"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="TARGET"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator TARGET(string value)
				=> new TARGET(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="CycleCount" />.
		/// </summary>
		public partial class ALL : CycleCount
		{
			/// <summary>
			/// Constructs a new value type for ALL.
			/// </summary>
            public ALL(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="ALL"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="ALL"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="ALL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ALL(string value)
				=> new ALL(value.ToUpperInvariant());
		}
    }
}