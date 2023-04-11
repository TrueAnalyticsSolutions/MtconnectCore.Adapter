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
	/// A value type for ChuckInterlock to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1632486692761_582059_81">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class ChuckInterlock : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.CHUCK_INTERLOCK);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ChuckInterlock EVENT Data Item.
		/// </summary>
        public ChuckInterlock(string value) : base(value) { }

        /// <summary>
		﻿/// chuck cannot be unclamped.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ChuckInterlockValues))]
        public static ChuckInterlock ACTIVE => new ChuckInterlock(nameof(ChuckInterlockValues.ACTIVE));
        /// <summary>
		﻿/// chuck can be unclamped.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ChuckInterlockValues))]
        public static ChuckInterlock INACTIVE => new ChuckInterlock(nameof(ChuckInterlockValues.INACTIVE));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ChuckInterlock"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ChuckInterlock"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ChuckInterlock"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ChuckInterlock(string value)
            => new ChuckInterlock(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ChuckInterlock" />.
		/// </summary>
		public partial class MANUALUNCLAMP : ChuckInterlock
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ChuckInterlockSubTypes.MANUAL_UNCLAMP);

			/// <summary>
			/// Constructs a new value type for MANUAL_UNCLAMP.
			/// </summary>
            public MANUALUNCLAMP(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="MANUALUNCLAMP"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="MANUALUNCLAMP"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="MANUALUNCLAMP"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator MANUALUNCLAMP(string value)
				=> new MANUALUNCLAMP(value.ToUpperInvariant());
		}
    }
}