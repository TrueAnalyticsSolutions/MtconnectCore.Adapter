#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItems;
using Mtconnect.AdapterInterface.DataItemValues;

namespace Mtconnect.AdapterInterface.DataItemValues
{
	/// <summary>
	/// A value type for PathMode to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class PathMode : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the PathMode EVENT Data Item.
		/// </summary>
        public PathMode(string value) : base(value) { }

        /// <summary>
		﻿/// path is operating independently and without the influence of another path.
        /// </summary>
		[ObservationalValue(typeof(PathModeValues))]
        public static PathMode INDEPENDENT => new PathMode(nameof(PathModeValues.INDEPENDENT));
        /// <summary>
		﻿/// path provides information or state values that influences the operation of other <see cref="DataItem">DataItem</see> of similar type.
        /// </summary>
		[ObservationalValue(typeof(PathModeValues))]
        public static PathMode MASTER => new PathMode(nameof(PathModeValues.MASTER));
        /// <summary>
		﻿/// physical or logical parts which are not physically connected to each other but are operating together.
        /// </summary>
		[ObservationalValue(typeof(PathModeValues))]
        public static PathMode SYNCHRONOUS => new PathMode(nameof(PathModeValues.SYNCHRONOUS));
        /// <summary>
		﻿/// axes associated with the path are mirroring the motion of the <c>MASTER</c> path.
        /// </summary>
		[ObservationalValue(typeof(PathModeValues))]
        public static PathMode MIRROR => new PathMode(nameof(PathModeValues.MIRROR));
		
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