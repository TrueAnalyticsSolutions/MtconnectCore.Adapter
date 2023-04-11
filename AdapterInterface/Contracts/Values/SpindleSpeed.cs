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
	/// A value type for SpindleSpeed to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// <item><b>Units</b>: <see cref="MtconnectUnit.REVOLUTION_PER_MINUTE" /></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v1.2 according to https://model.mtconnect.org/#_Version_1.2")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class SpindleSpeed : SampleValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.SampleTypes.SPINDLE_SPEED);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the SpindleSpeed EVENT Data Item.
		/// </summary>
        public SpindleSpeed(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="SpindleSpeed"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="SpindleSpeed"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="SpindleSpeed"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator SpindleSpeed(float value)
            => new SpindleSpeed(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="SpindleSpeed" />.
		/// </summary>
		public partial class ACTUAL : SpindleSpeed
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.SpindleSpeedSubTypes._ACTUAL);

			/// <summary>
			/// Constructs a new value type for _ACTUAL.
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
		/// A Data Item SubType implementation of <see cref="SpindleSpeed" />.
		/// </summary>
		public partial class COMMANDED : SpindleSpeed
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.SpindleSpeedSubTypes._COMMANDED);

			/// <summary>
			/// Constructs a new value type for _COMMANDED.
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
		/// A Data Item SubType implementation of <see cref="SpindleSpeed" />.
		/// </summary>
		public partial class OVERRIDE : SpindleSpeed
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.SpindleSpeedSubTypes._OVERRIDE);

			/// <summary>
			/// Constructs a new value type for _OVERRIDE.
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