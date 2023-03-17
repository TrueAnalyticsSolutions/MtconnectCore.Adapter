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
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
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
            => new AxisFeedrate(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="AxisFeedrate" />.
		/// </summary>
		public partial class ACTUAL : AxisFeedrate
		{
			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="ACTUAL"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="ACTUAL"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="ACTUAL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ACTUAL(float value)
				=> new ACTUAL(value);
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
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="COMMANDED"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="COMMANDED"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="COMMANDED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator COMMANDED(float value)
				=> new COMMANDED(value);
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
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="JOG"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="JOG"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="JOG"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator JOG(float value)
				=> new JOG(value);
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
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="PROGRAMMED"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="PROGRAMMED"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="PROGRAMMED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator PROGRAMMED(float value)
				=> new PROGRAMMED(value);
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
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="RAPID"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="RAPID"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="RAPID"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator RAPID(float value)
				=> new RAPID(value);
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
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="OVERRIDE"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="OVERRIDE"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="OVERRIDE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator OVERRIDE(float value)
				=> new OVERRIDE(value);
		}
    }
}