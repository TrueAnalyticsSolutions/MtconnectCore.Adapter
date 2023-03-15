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
	/// A value type for TransferCount to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class TransferCount : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the TransferCount EVENT Data Item.
		/// </summary>
        public TransferCount(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="TransferCount"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="TransferCount"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="TransferCount"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator TransferCount(string value)
        {
            return new TransferCount(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="TransferCount" />.
		/// </summary>
		public partial class GOOD : TransferCount
		{
			/// <summary>
			/// Constructs a new value type for GOOD.
			/// </summary>
            public GOOD(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="TransferCount" />.
		/// </summary>
		public partial class ABORTED : TransferCount
		{
			/// <summary>
			/// Constructs a new value type for ABORTED.
			/// </summary>
            public ABORTED(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="TransferCount" />.
		/// </summary>
		public partial class FAILED : TransferCount
		{
			/// <summary>
			/// Constructs a new value type for FAILED.
			/// </summary>
            public FAILED(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="TransferCount" />.
		/// </summary>
		public partial class ALL : TransferCount
		{
			/// <summary>
			/// Constructs a new value type for ALL.
			/// </summary>
            public ALL(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="TransferCount" />.
		/// </summary>
		public partial class BAD : TransferCount
		{
			/// <summary>
			/// Constructs a new value type for BAD.
			/// </summary>
            public BAD(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="TransferCount" />.
		/// </summary>
		public partial class REMAINING : TransferCount
		{
			/// <summary>
			/// Constructs a new value type for REMAINING.
			/// </summary>
            public REMAINING(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="TransferCount" />.
		/// </summary>
		public partial class COMPLETE : TransferCount
		{
			/// <summary>
			/// Constructs a new value type for COMPLETE.
			/// </summary>
            public COMPLETE(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="TransferCount" />.
		/// </summary>
		public partial class TARGET : TransferCount
		{
			/// <summary>
			/// Constructs a new value type for TARGET.
			/// </summary>
            public TARGET(string value) : base(value) { }
		}
    }
}