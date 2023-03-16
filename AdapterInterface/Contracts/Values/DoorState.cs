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
	/// A value type for DoorState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class DoorState : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the DoorState EVENT Data Item.
		/// </summary>
        public DoorState(string value) : base(value) { }

        /// <summary>
		﻿/// <see cref="Door">Door</see> is open to the point of a positive confirmation.
        /// </summary>
		[ObservationalValue(typeof(DoorStateValues))]
        public static DoorState OPEN => new DoorState(nameof(DoorStateValues.OPEN));
        /// <summary>
		﻿/// <see cref="Door">Door</see> is closed to the point of a positive confirmation.
        /// </summary>
		[ObservationalValue(typeof(DoorStateValues))]
        public static DoorState CLOSED => new DoorState(nameof(DoorStateValues.CLOSED));
        /// <summary>
		﻿/// <see cref="Door">Door</see> is not closed to the point of a positive confirmation and not open to the point of a positive confirmation.   It is in an intermediate position.
        /// </summary>
		[ObservationalValue(typeof(DoorStateValues))]
        public static DoorState UNLATCHED => new DoorState(nameof(DoorStateValues.UNLATCHED));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="DoorState"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="DoorState"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="DoorState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator DoorState(string value)
            => new DoorState(value.ToUpperInvariant());
		
    }
}