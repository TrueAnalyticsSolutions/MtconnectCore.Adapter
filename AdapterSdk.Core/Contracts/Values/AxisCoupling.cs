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
	/// A value type for AxisCoupling to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417657_726565_2871">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class AxisCoupling : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.AXIS_COUPLING);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the AxisCoupling EVENT Data Item.
		/// </summary>
        public AxisCoupling(string value) : base(value) { }

		/// <summary>
		/// Constructs a new value type for the AxisCoupling EVENT Data Item.
		/// </summary>
		public AxisCoupling(AxisCouplingValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="AxisCouplingValues.TANDEM" />
		[ObservationalValue(typeof(AxisCouplingValues))]
        public static AxisCoupling TANDEM => new AxisCoupling(AxisCouplingValues.TANDEM);
		/// <inheritdoc cref="AxisCouplingValues.SYNCHRONOUS" />
		[ObservationalValue(typeof(AxisCouplingValues))]
        public static AxisCoupling SYNCHRONOUS => new AxisCoupling(AxisCouplingValues.SYNCHRONOUS);
		/// <inheritdoc cref="AxisCouplingValues.MASTER" />
		[ObservationalValue(typeof(AxisCouplingValues))]
        public static AxisCoupling MASTER => new AxisCoupling(AxisCouplingValues.MASTER);
		/// <inheritdoc cref="AxisCouplingValues.SLAVE" />
		[ObservationalValue(typeof(AxisCouplingValues))]
        public static AxisCoupling SLAVE => new AxisCoupling(AxisCouplingValues.SLAVE);

        /// <summary>
        /// Implicitly converts the specified <see cref="AxisCouplingValues" /> to an <see cref="AxisCoupling"/> value.
        /// The <see cref="AxisCouplingValues" /> is converted to a string and used to initialize the <see cref="AxisCoupling"/> value.
        /// </summary>
        /// <param name="value">The <see cref="AxisCouplingValues" /> to convert.</param>
        /// <returns>An <see cref="AxisCoupling"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator AxisCoupling(AxisCouplingValues value)
            => new AxisCoupling(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="AxisCoupling"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="AxisCoupling"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="AxisCoupling"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator AxisCoupling(string value)
            => new AxisCoupling(value.ToUpperInvariant());
		
    }
}