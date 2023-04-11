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
	/// A value type for Hardness to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579272506322_914606_702">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class Hardness : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.HARDNESS);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the Hardness EVENT Data Item.
		/// </summary>
        public Hardness(Single value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified Single to an <see cref="Hardness"/> value.
        /// The Single is converted to uppercase and used to initialize the <see cref="Hardness"/> value.
        /// </summary>
        /// <param name="value">The Single to convert.</param>
        /// <returns>An <see cref="Hardness"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Hardness(Single value)
            => new Hardness(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Hardness" />.
		/// </summary>
		public partial class ROCKWELL : Hardness
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.HardnessSubTypes._ROCKWELL);

			/// <summary>
			/// Constructs a new value type for _ROCKWELL.
			/// </summary>
            public ROCKWELL(Single value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Single to an <see cref="ROCKWELL"/> value.
			/// The Single is converted to uppercase and used to initialize the <see cref="ROCKWELL"/> value.
			/// </summary>
			/// <param name="value">The Single to convert.</param>
			/// <returns>An <see cref="ROCKWELL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ROCKWELL(Single value)
				=> new ROCKWELL(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Hardness" />.
		/// </summary>
		public partial class VICKERS : Hardness
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.HardnessSubTypes._VICKERS);

			/// <summary>
			/// Constructs a new value type for _VICKERS.
			/// </summary>
            public VICKERS(Single value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Single to an <see cref="VICKERS"/> value.
			/// The Single is converted to uppercase and used to initialize the <see cref="VICKERS"/> value.
			/// </summary>
			/// <param name="value">The Single to convert.</param>
			/// <returns>An <see cref="VICKERS"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator VICKERS(Single value)
				=> new VICKERS(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Hardness" />.
		/// </summary>
		public partial class SHORE : Hardness
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.HardnessSubTypes._SHORE);

			/// <summary>
			/// Constructs a new value type for _SHORE.
			/// </summary>
            public SHORE(Single value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Single to an <see cref="SHORE"/> value.
			/// The Single is converted to uppercase and used to initialize the <see cref="SHORE"/> value.
			/// </summary>
			/// <param name="value">The Single to convert.</param>
			/// <returns>An <see cref="SHORE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator SHORE(Single value)
				=> new SHORE(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Hardness" />.
		/// </summary>
		public partial class BRINELL : Hardness
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.HardnessSubTypes._BRINELL);

			/// <summary>
			/// Constructs a new value type for _BRINELL.
			/// </summary>
            public BRINELL(Single value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Single to an <see cref="BRINELL"/> value.
			/// The Single is converted to uppercase and used to initialize the <see cref="BRINELL"/> value.
			/// </summary>
			/// <param name="value">The Single to convert.</param>
			/// <returns>An <see cref="BRINELL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator BRINELL(Single value)
				=> new BRINELL(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Hardness" />.
		/// </summary>
		public partial class LEEB : Hardness
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.HardnessSubTypes._LEEB);

			/// <summary>
			/// Constructs a new value type for _LEEB.
			/// </summary>
            public LEEB(Single value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Single to an <see cref="LEEB"/> value.
			/// The Single is converted to uppercase and used to initialize the <see cref="LEEB"/> value.
			/// </summary>
			/// <param name="value">The Single to convert.</param>
			/// <returns>An <see cref="LEEB"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator LEEB(Single value)
				=> new LEEB(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Hardness" />.
		/// </summary>
		public partial class MOHS : Hardness
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.HardnessSubTypes._MOHS);

			/// <summary>
			/// Constructs a new value type for _MOHS.
			/// </summary>
            public MOHS(Single value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Single to an <see cref="MOHS"/> value.
			/// The Single is converted to uppercase and used to initialize the <see cref="MOHS"/> value.
			/// </summary>
			/// <param name="value">The Single to convert.</param>
			/// <returns>An <see cref="MOHS"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator MOHS(Single value)
				=> new MOHS(value);
		}
    }
}