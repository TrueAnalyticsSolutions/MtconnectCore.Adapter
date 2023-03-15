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
	/// A value type for PathFeedrate to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class PathFeedrate : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the PathFeedrate EVENT Data Item.
		/// </summary>
        public PathFeedrate(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="PathFeedrate"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="PathFeedrate"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="PathFeedrate"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PathFeedrate(float value)
        {
            return new PathFeedrate(value);
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PathFeedrate" />.
		/// </summary>
		public partial class ACTUAL : PathFeedrate
		{
			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PathFeedrate" />.
		/// </summary>
		public partial class COMMANDED : PathFeedrate
		{
			/// <summary>
			/// Constructs a new value type for COMMANDED.
			/// </summary>
            public COMMANDED(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PathFeedrate" />.
		/// </summary>
		public partial class JOG : PathFeedrate
		{
			/// <summary>
			/// Constructs a new value type for JOG.
			/// </summary>
            public JOG(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PathFeedrate" />.
		/// </summary>
		public partial class PROGRAMMED : PathFeedrate
		{
			/// <summary>
			/// Constructs a new value type for PROGRAMMED.
			/// </summary>
            public PROGRAMMED(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PathFeedrate" />.
		/// </summary>
		public partial class RAPID : PathFeedrate
		{
			/// <summary>
			/// Constructs a new value type for RAPID.
			/// </summary>
            public RAPID(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PathFeedrate" />.
		/// </summary>
		public partial class OVERRIDE : PathFeedrate
		{
			/// <summary>
			/// Constructs a new value type for OVERRIDE.
			/// </summary>
            public OVERRIDE(float value) : base(value) { }
		}
    }
}