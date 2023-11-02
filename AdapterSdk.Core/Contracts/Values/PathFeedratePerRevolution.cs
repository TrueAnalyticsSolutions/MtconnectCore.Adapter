#pragma warning disable 0618
#pragma warning disable 1574
#pragma warning disable CS1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk;
using Mtconnect.AdapterSdk.Attributes;
using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.DataItemValues;
using Mtconnect.AdapterSdk.Units;

namespace Mtconnect.AdapterSdk.DataItemValues
{
	/// <summary>
	/// A value type for PathFeedratePerRevolution to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// <item><b>Units</b>: <see cref="MtconnectUnit.MILLIMETER_PER_REVOLUTION" /></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class PathFeedratePerRevolution : SampleValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.SampleTypes.PATH_FEEDRATE_PER_REVOLUTION);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the PathFeedratePerRevolution EVENT Data Item.
		/// </summary>
        public PathFeedratePerRevolution(float? value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float? to an <see cref="PathFeedratePerRevolution"/> value.
        /// The float? is converted to uppercase and used to initialize the <see cref="PathFeedratePerRevolution"/> value.
        /// </summary>
        /// <param name="value">The float? to convert.</param>
        /// <returns>An <see cref="PathFeedratePerRevolution"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PathFeedratePerRevolution(float? value)
            => new PathFeedratePerRevolution(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PathFeedratePerRevolution" />.
		/// </summary>
		public partial class ACTUAL : PathFeedratePerRevolution
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PathFeedratePerRevolutionSubTypes.ACTUAL);

			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float? to an <see cref="ACTUAL"/> value.
			/// The float? is converted to uppercase and used to initialize the <see cref="ACTUAL"/> value.
			/// </summary>
			/// <param name="value">The float? to convert.</param>
			/// <returns>An <see cref="ACTUAL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ACTUAL(float? value)
				=> new ACTUAL(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PathFeedratePerRevolution" />.
		/// </summary>
		public partial class COMMANDED : PathFeedratePerRevolution
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PathFeedratePerRevolutionSubTypes.COMMANDED);

			/// <summary>
			/// Constructs a new value type for COMMANDED.
			/// </summary>
            public COMMANDED(float? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float? to an <see cref="COMMANDED"/> value.
			/// The float? is converted to uppercase and used to initialize the <see cref="COMMANDED"/> value.
			/// </summary>
			/// <param name="value">The float? to convert.</param>
			/// <returns>An <see cref="COMMANDED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator COMMANDED(float? value)
				=> new COMMANDED(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PathFeedratePerRevolution" />.
		/// </summary>
		public partial class PROGRAMMED : PathFeedratePerRevolution
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PathFeedratePerRevolutionSubTypes.PROGRAMMED);

			/// <summary>
			/// Constructs a new value type for PROGRAMMED.
			/// </summary>
            public PROGRAMMED(float? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float? to an <see cref="PROGRAMMED"/> value.
			/// The float? is converted to uppercase and used to initialize the <see cref="PROGRAMMED"/> value.
			/// </summary>
			/// <param name="value">The float? to convert.</param>
			/// <returns>An <see cref="PROGRAMMED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator PROGRAMMED(float? value)
				=> new PROGRAMMED(value);
		}
    }
}