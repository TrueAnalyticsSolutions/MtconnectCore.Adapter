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
	/// A value type for AxisFeedrate to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class AxisFeedrate : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the AxisFeedrate EVENT Data Item.
		/// </summary>
        public AxisFeedrate(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="AxisFeedrate"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="AxisFeedrate"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="AxisFeedrate"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator AxisFeedrate(float value)
        {
            return new AxisFeedrate(value);
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="AxisFeedrate" />.
		/// </summary>
		public partial class ACTUAL : AxisFeedrate
		{
			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="AxisFeedrate" />.
		/// </summary>
		public partial class COMMANDED : AxisFeedrate
		{
			/// <summary>
			/// Constructs a new value type for COMMANDED.
			/// </summary>
            public COMMANDED(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="AxisFeedrate" />.
		/// </summary>
		public partial class JOG : AxisFeedrate
		{
			/// <summary>
			/// Constructs a new value type for JOG.
			/// </summary>
            public JOG(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="AxisFeedrate" />.
		/// </summary>
		public partial class PROGRAMMED : AxisFeedrate
		{
			/// <summary>
			/// Constructs a new value type for PROGRAMMED.
			/// </summary>
            public PROGRAMMED(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="AxisFeedrate" />.
		/// </summary>
		public partial class RAPID : AxisFeedrate
		{
			/// <summary>
			/// Constructs a new value type for RAPID.
			/// </summary>
            public RAPID(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="AxisFeedrate" />.
		/// </summary>
		public partial class OVERRIDE : AxisFeedrate
		{
			/// <summary>
			/// Constructs a new value type for OVERRIDE.
			/// </summary>
            public OVERRIDE(float value) : base(value) { }
		}
    }
}