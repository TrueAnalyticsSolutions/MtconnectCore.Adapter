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
	/// A value type for CompositionState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class CompositionState : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.COMPOSITION_STATE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the CompositionState EVENT Data Item.
		/// </summary>
        public CompositionState(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="CompositionState"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="CompositionState"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="CompositionState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator CompositionState(string value)
            => new CompositionState(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="CompositionState" />.
		/// </summary>
		public partial class ACTION : CompositionState
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.CompositionStateSubTypes._ACTION);

			/// <summary>
			/// Constructs a new value type for _ACTION.
			/// </summary>
            public ACTION(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="ACTION"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="ACTION"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="ACTION"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ACTION(string value)
				=> new ACTION(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="CompositionState" />.
		/// </summary>
		public partial class LATERAL : CompositionState
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.CompositionStateSubTypes._LATERAL);

			/// <summary>
			/// Constructs a new value type for _LATERAL.
			/// </summary>
            public LATERAL(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="LATERAL"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="LATERAL"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="LATERAL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator LATERAL(string value)
				=> new LATERAL(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="CompositionState" />.
		/// </summary>
		public partial class MOTION : CompositionState
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.CompositionStateSubTypes._MOTION);

			/// <summary>
			/// Constructs a new value type for _MOTION.
			/// </summary>
            public MOTION(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="MOTION"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="MOTION"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="MOTION"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator MOTION(string value)
				=> new MOTION(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="CompositionState" />.
		/// </summary>
		public partial class SWITCHED : CompositionState
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.CompositionStateSubTypes._SWITCHED);

			/// <summary>
			/// Constructs a new value type for _SWITCHED.
			/// </summary>
            public SWITCHED(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="SWITCHED"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="SWITCHED"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="SWITCHED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator SWITCHED(string value)
				=> new SWITCHED(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="CompositionState" />.
		/// </summary>
		public partial class VERTICAL : CompositionState
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.CompositionStateSubTypes._VERTICAL);

			/// <summary>
			/// Constructs a new value type for _VERTICAL.
			/// </summary>
            public VERTICAL(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="VERTICAL"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="VERTICAL"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="VERTICAL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator VERTICAL(string value)
				=> new VERTICAL(value.ToUpperInvariant());
		}
    }
}