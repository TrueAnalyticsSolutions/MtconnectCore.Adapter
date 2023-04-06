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
	/// A value type for VolumeSpatial to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// <item><b>Units</b>: <see cref="MtconnectUnit.CUBIC_MILLIMETER" /></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.7.0")]
	public partial class VolumeSpatial : SampleValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.SampleTypes.VOLUME_SPATIAL);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the VolumeSpatial EVENT Data Item.
		/// </summary>
        public VolumeSpatial(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="VolumeSpatial"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="VolumeSpatial"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="VolumeSpatial"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator VolumeSpatial(float value)
            => new VolumeSpatial(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="VolumeSpatial" />.
		/// </summary>
		public partial class ACTUAL : VolumeSpatial
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.VolumeSpatialSubTypes.ACTUAL);

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
		/// A Data Item SubType implementation of <see cref="VolumeSpatial" />.
		/// </summary>
		public partial class CONSUMED : VolumeSpatial
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.VolumeSpatialSubTypes.CONSUMED);

			/// <summary>
			/// Constructs a new value type for CONSUMED.
			/// </summary>
            public CONSUMED(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="CONSUMED"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="CONSUMED"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="CONSUMED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator CONSUMED(float value)
				=> new CONSUMED(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="VolumeSpatial" />.
		/// </summary>
		public partial class PART : VolumeSpatial
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.VolumeSpatialSubTypes.PART);

			/// <summary>
			/// Constructs a new value type for PART.
			/// </summary>
            public PART(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="PART"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="PART"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="PART"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator PART(float value)
				=> new PART(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="VolumeSpatial" />.
		/// </summary>
		public partial class WASTE : VolumeSpatial
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.VolumeSpatialSubTypes.WASTE);

			/// <summary>
			/// Constructs a new value type for WASTE.
			/// </summary>
            public WASTE(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="WASTE"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="WASTE"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="WASTE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator WASTE(float value)
				=> new WASTE(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="VolumeSpatial" />.
		/// </summary>
		public partial class ENDED : VolumeSpatial
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.VolumeSpatialSubTypes.ENDED);

			/// <summary>
			/// Constructs a new value type for ENDED.
			/// </summary>
            public ENDED(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="ENDED"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="ENDED"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="ENDED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ENDED(float value)
				=> new ENDED(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="VolumeSpatial" />.
		/// </summary>
		public partial class START : VolumeSpatial
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.VolumeSpatialSubTypes.START);

			/// <summary>
			/// Constructs a new value type for START.
			/// </summary>
            public START(float value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float to an <see cref="START"/> value.
			/// The float is converted to uppercase and used to initialize the <see cref="START"/> value.
			/// </summary>
			/// <param name="value">The float to convert.</param>
			/// <returns>An <see cref="START"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator START(float value)
				=> new START(value);
		}
    }
}