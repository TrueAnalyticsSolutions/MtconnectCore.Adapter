#pragma warning disable 0618
#pragma warning disable 1574
#pragma warning disable CS1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk;
using Mtconnect.AdapterSdk.Attributes;
using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.DataItemValues;
using Mtconnect.AdapterSdk.Units;

namespace Mtconnect.AdapterSdk.DataItemValues
{
	/// <summary>
	/// A value type for LeakDetect to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1659073241126_204554_44">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class LeakDetect : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.LEAK_DETECT);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the LeakDetect EVENT Data Item.
		/// </summary>
        public LeakDetect(string value) : base(value) { }

		/// <summary>
		/// Constructs a new value type for the LeakDetect EVENT Data Item.
		/// </summary>
		public LeakDetect(LeakDetectValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="LeakDetectValues.DETECTED" />
		[ObservationalValue(typeof(LeakDetectValues))]
        public static LeakDetect DETECTED => new LeakDetect(LeakDetectValues.DETECTED);
		/// <inheritdoc cref="LeakDetectValues.NOT_DETECTED" />
		[ObservationalValue(typeof(LeakDetectValues))]
        public static LeakDetect NOT_DETECTED => new LeakDetect(LeakDetectValues.NOT_DETECTED);

        /// <summary>
        /// Implicitly converts the specified <see cref="LeakDetectValues" /> to an <see cref="LeakDetect"/> value.
        /// The <see cref="LeakDetectValues" /> is converted to a string and used to initialize the <see cref="LeakDetect"/> value.
        /// </summary>
        /// <param name="value">The <see cref="LeakDetectValues" /> to convert.</param>
        /// <returns>An <see cref="LeakDetect"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator LeakDetect(LeakDetectValues value)
            => new LeakDetect(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="LeakDetect"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="LeakDetect"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="LeakDetect"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator LeakDetect(string value)
            => new LeakDetect(value.ToUpperInvariant());
		
    }
}