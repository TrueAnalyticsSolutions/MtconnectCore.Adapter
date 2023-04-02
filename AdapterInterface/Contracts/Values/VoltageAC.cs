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
	/// A value type for VoltageAC to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
	/// <item><b>Units</b>: <see cref="MtconnectUnit.VOLT" /></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.5.0")]
	public partial class VoltageAC : SampleValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.SampleTypes.VOLTAGE_A_C);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the VoltageAC EVENT Data Item.
		/// </summary>
        public VoltageAC(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="VoltageAC"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="VoltageAC"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="VoltageAC"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator VoltageAC(float value)
            => new VoltageAC(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="VoltageAC" />.
		/// </summary>
		public partial class ACTUAL : VoltageAC
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.VoltageACSubTypes.ACTUAL);

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
		/// A Data Item SubType implementation of <see cref="VoltageAC" />.
		/// </summary>
		public partial class COMMANDED : VoltageAC
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.VoltageACSubTypes.COMMANDED);

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
		/// A Data Item SubType implementation of <see cref="VoltageAC" />.
		/// </summary>
		public partial class PROGRAMMED : VoltageAC
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.VoltageACSubTypes.PROGRAMMED);

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
    }
}