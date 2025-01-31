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
	/// A value type for LockState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622457615279_962450_700">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class LockState : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.LOCK_STATE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the LockState EVENT Data Item.
		/// </summary>
        public LockState(string value) : base(value) { }

		/// <summary>
		/// Constructs a new value type for the LockState EVENT Data Item.
		/// </summary>
		public LockState(LockStateValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="LockStateValues.LOCKED" />
		[ObservationalValue(typeof(LockStateValues))]
        public static LockState LOCKED => new LockState(LockStateValues.LOCKED);
		/// <inheritdoc cref="LockStateValues.UNLOCKED" />
		[ObservationalValue(typeof(LockStateValues))]
        public static LockState UNLOCKED => new LockState(LockStateValues.UNLOCKED);

        /// <summary>
        /// Implicitly converts the specified <see cref="LockStateValues" /> to an <see cref="LockState"/> value.
        /// The <see cref="LockStateValues" /> is converted to a string and used to initialize the <see cref="LockState"/> value.
        /// </summary>
        /// <param name="value">The <see cref="LockStateValues" /> to convert.</param>
        /// <returns>An <see cref="LockState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator LockState(LockStateValues value)
            => new LockState(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="LockState"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="LockState"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="LockState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator LockState(string value)
            => new LockState(value.ToUpperInvariant());
		
    }
}