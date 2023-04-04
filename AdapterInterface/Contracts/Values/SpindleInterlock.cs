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
	/// A value type for SpindleInterlock to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1632486690924_270312_65">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.6.0")]
	public partial class SpindleInterlock : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.SPINDLE_INTERLOCK);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the SpindleInterlock EVENT Data Item.
		/// </summary>
        public SpindleInterlock(string value) : base(value) { }

        /// <summary>
		﻿/// power has been removed and the spindle cannot be operated.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(SpindleInterlockValues))]
        public static SpindleInterlock ACTIVE => new SpindleInterlock(nameof(SpindleInterlockValues.ACTIVE));
        /// <summary>
		﻿/// spindle has not been deactivated.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(SpindleInterlockValues))]
        public static SpindleInterlock INACTIVE => new SpindleInterlock(nameof(SpindleInterlockValues.INACTIVE));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="SpindleInterlock"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="SpindleInterlock"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="SpindleInterlock"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator SpindleInterlock(string value)
            => new SpindleInterlock(value.ToUpperInvariant());
		
    }
}