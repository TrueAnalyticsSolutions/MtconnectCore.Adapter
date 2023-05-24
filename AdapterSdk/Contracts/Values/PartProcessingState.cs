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
	/// A value type for PartProcessingState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622460092329_383445_1384">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class PartProcessingState : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PART_PROCESSING_STATE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the PartProcessingState EVENT Data Item.
		/// </summary>
        public PartProcessingState(string value) : base(value) { }

		public PartProcessingState(PartProcessingStateValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="PartProcessingStateValues.NEEDS_PROCESSING" />
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState NEEDS_PROCESSING => new PartProcessingState(PartProcessingStateValues.NEEDS_PROCESSING);
		/// <inheritdoc cref="PartProcessingStateValues.IN_PROCESS" />
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState IN_PROCESS => new PartProcessingState(PartProcessingStateValues.IN_PROCESS);
		/// <inheritdoc cref="PartProcessingStateValues.PROCESSING_ENDED" />
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState PROCESSING_ENDED => new PartProcessingState(PartProcessingStateValues.PROCESSING_ENDED);
		/// <inheritdoc cref="PartProcessingStateValues.PROCESSING_ENDED_COMPLETE" />
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState PROCESSING_ENDED_COMPLETE => new PartProcessingState(PartProcessingStateValues.PROCESSING_ENDED_COMPLETE);
		/// <inheritdoc cref="PartProcessingStateValues.PROCESSING_ENDED_STOPPED" />
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState PROCESSING_ENDED_STOPPED => new PartProcessingState(PartProcessingStateValues.PROCESSING_ENDED_STOPPED);
		/// <inheritdoc cref="PartProcessingStateValues.PROCESSING_ENDED_ABORTED" />
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState PROCESSING_ENDED_ABORTED => new PartProcessingState(PartProcessingStateValues.PROCESSING_ENDED_ABORTED);
		/// <inheritdoc cref="PartProcessingStateValues.PROCESSING_ENDED_LOST" />
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState PROCESSING_ENDED_LOST => new PartProcessingState(PartProcessingStateValues.PROCESSING_ENDED_LOST);
		/// <inheritdoc cref="PartProcessingStateValues.PROCESSING_ENDED_SKIPPED" />
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState PROCESSING_ENDED_SKIPPED => new PartProcessingState(PartProcessingStateValues.PROCESSING_ENDED_SKIPPED);
		/// <inheritdoc cref="PartProcessingStateValues.PROCESSING_ENDED_REJECTED" />
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState PROCESSING_ENDED_REJECTED => new PartProcessingState(PartProcessingStateValues.PROCESSING_ENDED_REJECTED);
		/// <inheritdoc cref="PartProcessingStateValues.WAITING_FOR_TRANSIT" />
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState WAITING_FOR_TRANSIT => new PartProcessingState(PartProcessingStateValues.WAITING_FOR_TRANSIT);
		/// <inheritdoc cref="PartProcessingStateValues.IN_TRANSIT" />
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState IN_TRANSIT => new PartProcessingState(PartProcessingStateValues.IN_TRANSIT);
		/// <inheritdoc cref="PartProcessingStateValues.TRANSIT_COMPLETE" />
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState TRANSIT_COMPLETE => new PartProcessingState(PartProcessingStateValues.TRANSIT_COMPLETE);

        /// <summary>
        /// Implicitly converts the specified <see cref="PartProcessingStateValues" /> to an <see cref="PartProcessingState"/> value.
        /// The <see cref="PartProcessingStateValues" /> is converted to a string and used to initialize the <see cref="PartProcessingState"/> value.
        /// </summary>
        /// <param name="value">The <see cref="PartProcessingStateValues" /> to convert.</param>
        /// <returns>An <see cref="PartProcessingState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PartProcessingState(PartProcessingStateValues value)
            => new PartProcessingState(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="PartProcessingState"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="PartProcessingState"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="PartProcessingState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PartProcessingState(string value)
            => new PartProcessingState(value.ToUpperInvariant());
		
    }
}