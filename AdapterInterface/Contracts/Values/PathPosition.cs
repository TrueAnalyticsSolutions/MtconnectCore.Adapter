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
	/// A value type for PathPosition to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579272506322_914606_702">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// <item><b>Units</b>: <see cref="MtconnectUnit.MILLIMETER_3D" /></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.7.0")]
	public partial class PathPosition : Sample3DValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.SampleTypes.PATH_POSITION);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the PathPosition EVENT Data Item.
		/// </summary>
        public PathPosition(float[] value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float[] to an <see cref="PathPosition"/> value.
        /// The float[] is converted to uppercase and used to initialize the <see cref="PathPosition"/> value.
        /// </summary>
        /// <param name="value">The float[] to convert.</param>
        /// <returns>An <see cref="PathPosition"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PathPosition(float[] value)
            => new PathPosition(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PathPosition" />.
		/// </summary>
		public partial class ACTUAL : PathPosition
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PathPositionSubTypes.ACTUAL);

			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float[] value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float[] to an <see cref="ACTUAL"/> value.
			/// The float[] is converted to uppercase and used to initialize the <see cref="ACTUAL"/> value.
			/// </summary>
			/// <param name="value">The float[] to convert.</param>
			/// <returns>An <see cref="ACTUAL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ACTUAL(float[] value)
				=> new ACTUAL(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PathPosition" />.
		/// </summary>
		public partial class COMMANDED : PathPosition
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PathPositionSubTypes.COMMANDED);

			/// <summary>
			/// Constructs a new value type for COMMANDED.
			/// </summary>
            public COMMANDED(float[] value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float[] to an <see cref="COMMANDED"/> value.
			/// The float[] is converted to uppercase and used to initialize the <see cref="COMMANDED"/> value.
			/// </summary>
			/// <param name="value">The float[] to convert.</param>
			/// <returns>An <see cref="COMMANDED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator COMMANDED(float[] value)
				=> new COMMANDED(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PathPosition" />.
		/// </summary>
		public partial class TARGET : PathPosition
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PathPositionSubTypes.TARGET);

			/// <summary>
			/// Constructs a new value type for TARGET.
			/// </summary>
            public TARGET(float[] value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float[] to an <see cref="TARGET"/> value.
			/// The float[] is converted to uppercase and used to initialize the <see cref="TARGET"/> value.
			/// </summary>
			/// <param name="value">The float[] to convert.</param>
			/// <returns>An <see cref="TARGET"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator TARGET(float[] value)
				=> new TARGET(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PathPosition" />.
		/// </summary>
		public partial class PROBE : PathPosition
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.PathPositionSubTypes.PROBE);

			/// <summary>
			/// Constructs a new value type for PROBE.
			/// </summary>
            public PROBE(float[] value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float[] to an <see cref="PROBE"/> value.
			/// The float[] is converted to uppercase and used to initialize the <see cref="PROBE"/> value.
			/// </summary>
			/// <param name="value">The float[] to convert.</param>
			/// <returns>An <see cref="PROBE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator PROBE(float[] value)
				=> new PROBE(value);
		}
    }
}