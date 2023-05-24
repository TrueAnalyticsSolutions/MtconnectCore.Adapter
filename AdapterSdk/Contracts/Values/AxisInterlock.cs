#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk.Contracts.Attributes;
using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.DataItemValues;
using Mtconnect.AdapterSdk.Units;

namespace Mtconnect.AdapterSdk.DataItemValues
{
	/// <summary>
	/// A value type for AxisInterlock to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1632486691907_586773_73">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class AxisInterlock : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.AXIS_INTERLOCK);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the AxisInterlock EVENT Data Item.
		/// </summary>
        public AxisInterlock(string value) : base(value) { }

		public AxisInterlock(AxisInterlockValues value) : this(value.ToString()) { }

        /// <summary>
		﻿/// axis lockout function is activated, power has been removed from the axis, and the axis is allowed to move freely.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(AxisInterlockValues))]
        public static AxisInterlock ACTIVE => new AxisInterlock(AxisInterlockValues.ACTIVE);
        /// <summary>
		﻿/// axis lockout function has not been activated, the axis may be powered, and the axis is capable of being controlled by another component.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(AxisInterlockValues))]
        public static AxisInterlock INACTIVE => new AxisInterlock(AxisInterlockValues.INACTIVE);

        /// <summary>
        /// Implicitly converts the specified <see cref="AxisInterlockValues" /> to an <see cref="AxisInterlock"/> value.
        /// The <see cref="AxisInterlockValues" /> is converted to a string and used to initialize the <see cref="AxisInterlock"/> value.
        /// </summary>
        /// <param name="value">The <see cref="AxisInterlockValues" /> to convert.</param>
        /// <returns>An <see cref="AxisInterlock"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator AxisInterlock(AxisInterlockValues value)
            => new AxisInterlock(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="AxisInterlock"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="AxisInterlock"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="AxisInterlock"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator AxisInterlock(string value)
            => new AxisInterlock(value.ToUpperInvariant());
		
    }
}