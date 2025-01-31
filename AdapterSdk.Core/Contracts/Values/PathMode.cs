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
	/// A value type for PathMode to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417667_174664_2881">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class PathMode : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.PATH_MODE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the PathMode EVENT Data Item.
		/// </summary>
        public PathMode(string value) : base(value) { }

		/// <summary>
		/// Constructs a new value type for the PathMode EVENT Data Item.
		/// </summary>
		public PathMode(PathModeValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="PathModeValues.INDEPENDENT" />
		[ObservationalValue(typeof(PathModeValues))]
        public static PathMode INDEPENDENT => new PathMode(PathModeValues.INDEPENDENT);
		/// <inheritdoc cref="PathModeValues.MASTER" />
		[ObservationalValue(typeof(PathModeValues))]
        public static PathMode MASTER => new PathMode(PathModeValues.MASTER);
		/// <inheritdoc cref="PathModeValues.SYNCHRONOUS" />
		[ObservationalValue(typeof(PathModeValues))]
        public static PathMode SYNCHRONOUS => new PathMode(PathModeValues.SYNCHRONOUS);
		/// <inheritdoc cref="PathModeValues.MIRROR" />
		[ObservationalValue(typeof(PathModeValues))]
        public static PathMode MIRROR => new PathMode(PathModeValues.MIRROR);

        /// <summary>
        /// Implicitly converts the specified <see cref="PathModeValues" /> to an <see cref="PathMode"/> value.
        /// The <see cref="PathModeValues" /> is converted to a string and used to initialize the <see cref="PathMode"/> value.
        /// </summary>
        /// <param name="value">The <see cref="PathModeValues" /> to convert.</param>
        /// <returns>An <see cref="PathMode"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PathMode(PathModeValues value)
            => new PathMode(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="PathMode"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="PathMode"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="PathMode"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PathMode(string value)
            => new PathMode(value.ToUpperInvariant());
		
    }
}