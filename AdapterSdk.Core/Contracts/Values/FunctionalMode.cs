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
	/// A value type for FunctionalMode to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417665_982246_2879">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class FunctionalMode : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.FUNCTIONAL_MODE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the FunctionalMode EVENT Data Item.
		/// </summary>
        public FunctionalMode(string value) : base(value) { }

		/// <summary>
		/// Constructs a new value type for the FunctionalMode EVENT Data Item.
		/// </summary>
		public FunctionalMode(FunctionalModeValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="FunctionalModeValues.PRODUCTION" />
		[ObservationalValue(typeof(FunctionalModeValues))]
        public static FunctionalMode PRODUCTION => new FunctionalMode(FunctionalModeValues.PRODUCTION);
		/// <inheritdoc cref="FunctionalModeValues.SETUP" />
		[ObservationalValue(typeof(FunctionalModeValues))]
        public static FunctionalMode SETUP => new FunctionalMode(FunctionalModeValues.SETUP);
		/// <inheritdoc cref="FunctionalModeValues.TEARDOWN" />
		[ObservationalValue(typeof(FunctionalModeValues))]
        public static FunctionalMode TEARDOWN => new FunctionalMode(FunctionalModeValues.TEARDOWN);
		/// <inheritdoc cref="FunctionalModeValues.MAINTENANCE" />
		[ObservationalValue(typeof(FunctionalModeValues))]
        public static FunctionalMode MAINTENANCE => new FunctionalMode(FunctionalModeValues.MAINTENANCE);
		/// <inheritdoc cref="FunctionalModeValues.PROCESS_DEVELOPMENT" />
		[ObservationalValue(typeof(FunctionalModeValues))]
        public static FunctionalMode PROCESS_DEVELOPMENT => new FunctionalMode(FunctionalModeValues.PROCESS_DEVELOPMENT);

        /// <summary>
        /// Implicitly converts the specified <see cref="FunctionalModeValues" /> to an <see cref="FunctionalMode"/> value.
        /// The <see cref="FunctionalModeValues" /> is converted to a string and used to initialize the <see cref="FunctionalMode"/> value.
        /// </summary>
        /// <param name="value">The <see cref="FunctionalModeValues" /> to convert.</param>
        /// <returns>An <see cref="FunctionalMode"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator FunctionalMode(FunctionalModeValues value)
            => new FunctionalMode(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="FunctionalMode"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="FunctionalMode"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="FunctionalMode"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator FunctionalMode(string value)
            => new FunctionalMode(value.ToUpperInvariant());
		
    }
}