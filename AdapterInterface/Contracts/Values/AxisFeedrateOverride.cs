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
	/// A value type for AxisFeedrateOverride to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579272506322_914606_702">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.5.0")]
	public partial class AxisFeedrateOverride : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.AXIS_FEEDRATE_OVERRIDE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the AxisFeedrateOverride EVENT Data Item.
		/// </summary>
        public AxisFeedrateOverride(Single value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified Single to an <see cref="AxisFeedrateOverride"/> value.
        /// The Single is converted to uppercase and used to initialize the <see cref="AxisFeedrateOverride"/> value.
        /// </summary>
        /// <param name="value">The Single to convert.</param>
        /// <returns>An <see cref="AxisFeedrateOverride"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator AxisFeedrateOverride(Single value)
            => new AxisFeedrateOverride(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="AxisFeedrateOverride" />.
		/// </summary>
		public partial class JOG : AxisFeedrateOverride
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.AxisFeedrateOverrideSubTypes.JOG);

			/// <summary>
			/// Constructs a new value type for JOG.
			/// </summary>
            public JOG(Single value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Single to an <see cref="JOG"/> value.
			/// The Single is converted to uppercase and used to initialize the <see cref="JOG"/> value.
			/// </summary>
			/// <param name="value">The Single to convert.</param>
			/// <returns>An <see cref="JOG"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator JOG(Single value)
				=> new JOG(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="AxisFeedrateOverride" />.
		/// </summary>
		public partial class PROGRAMMED : AxisFeedrateOverride
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.AxisFeedrateOverrideSubTypes.PROGRAMMED);

			/// <summary>
			/// Constructs a new value type for PROGRAMMED.
			/// </summary>
            public PROGRAMMED(Single value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Single to an <see cref="PROGRAMMED"/> value.
			/// The Single is converted to uppercase and used to initialize the <see cref="PROGRAMMED"/> value.
			/// </summary>
			/// <param name="value">The Single to convert.</param>
			/// <returns>An <see cref="PROGRAMMED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator PROGRAMMED(Single value)
				=> new PROGRAMMED(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="AxisFeedrateOverride" />.
		/// </summary>
		public partial class RAPID : AxisFeedrateOverride
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.AxisFeedrateOverrideSubTypes.RAPID);

			/// <summary>
			/// Constructs a new value type for RAPID.
			/// </summary>
            public RAPID(Single value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Single to an <see cref="RAPID"/> value.
			/// The Single is converted to uppercase and used to initialize the <see cref="RAPID"/> value.
			/// </summary>
			/// <param name="value">The Single to convert.</param>
			/// <returns>An <see cref="RAPID"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator RAPID(Single value)
				=> new RAPID(value);
		}
    }
}