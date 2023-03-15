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
	/// A value type for VolumeSpatial to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class VolumeSpatial : SampleValue
    {
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
        {
            return new VolumeSpatial(value);
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="VolumeSpatial" />.
		/// </summary>
		public partial class ACTUAL : VolumeSpatial
		{
			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="VolumeSpatial" />.
		/// </summary>
		public partial class CONSUMED : VolumeSpatial
		{
			/// <summary>
			/// Constructs a new value type for CONSUMED.
			/// </summary>
            public CONSUMED(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="VolumeSpatial" />.
		/// </summary>
		public partial class PART : VolumeSpatial
		{
			/// <summary>
			/// Constructs a new value type for PART.
			/// </summary>
            public PART(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="VolumeSpatial" />.
		/// </summary>
		public partial class WASTE : VolumeSpatial
		{
			/// <summary>
			/// Constructs a new value type for WASTE.
			/// </summary>
            public WASTE(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="VolumeSpatial" />.
		/// </summary>
		public partial class ENDED : VolumeSpatial
		{
			/// <summary>
			/// Constructs a new value type for ENDED.
			/// </summary>
            public ENDED(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="VolumeSpatial" />.
		/// </summary>
		public partial class START : VolumeSpatial
		{
			/// <summary>
			/// Constructs a new value type for START.
			/// </summary>
            public START(float value) : base(value) { }
		}
    }
}