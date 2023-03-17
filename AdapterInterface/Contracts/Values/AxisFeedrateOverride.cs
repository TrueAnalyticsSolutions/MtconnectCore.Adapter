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
	/// A value type for AxisFeedrateOverride to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579272506322_914606_702">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class AxisFeedrateOverride : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the AxisFeedrateOverride EVENT Data Item.
		/// </summary>
        public AxisFeedrateOverride(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="AxisFeedrateOverride"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="AxisFeedrateOverride"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="AxisFeedrateOverride"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator AxisFeedrateOverride(string value)
            => new AxisFeedrateOverride(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="AxisFeedrateOverride" />.
		/// </summary>
		public partial class JOG : AxisFeedrateOverride
		{
			/// <summary>
			/// Constructs a new value type for JOG.
			/// </summary>
            public JOG(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="JOG"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="JOG"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="JOG"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator JOG(string value)
				=> new JOG(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="AxisFeedrateOverride" />.
		/// </summary>
		public partial class PROGRAMMED : AxisFeedrateOverride
		{
			/// <summary>
			/// Constructs a new value type for PROGRAMMED.
			/// </summary>
            public PROGRAMMED(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="PROGRAMMED"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="PROGRAMMED"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="PROGRAMMED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator PROGRAMMED(string value)
				=> new PROGRAMMED(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="AxisFeedrateOverride" />.
		/// </summary>
		public partial class RAPID : AxisFeedrateOverride
		{
			/// <summary>
			/// Constructs a new value type for RAPID.
			/// </summary>
            public RAPID(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="RAPID"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="RAPID"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="RAPID"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator RAPID(string value)
				=> new RAPID(value.ToUpperInvariant());
		}
    }
}