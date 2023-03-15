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
	/// A value type for PowerState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class PowerState : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the PowerState EVENT Data Item.
		/// </summary>
        public PowerState(string value) : base(value) { }

        /// <summary>
		﻿/// source of energy for an entity or the enabling signal providing permission for the entity to perform its function(s) is present and active.
        /// </summary>
		[ObservationalValue(typeof(PowerStateValues))]
        public static PowerState ON => new PowerState(nameof(PowerStateValues.ON));
        /// <summary>
		﻿/// source of energy for an entity or the enabling signal providing permission for the entity to perform its function(s) is not present or is disconnected.
        /// </summary>
		[ObservationalValue(typeof(PowerStateValues))]
        public static PowerState OFF => new PowerState(nameof(PowerStateValues.OFF));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="PowerState"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="PowerState"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="PowerState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PowerState(string value)
        {
            return new PowerState(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PowerState" />.
		/// </summary>
		public partial class LINE : PowerState
		{
			/// <summary>
			/// Constructs a new value type for LINE.
			/// </summary>
            public LINE(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PowerState" />.
		/// </summary>
		public partial class CONTROL : PowerState
		{
			/// <summary>
			/// Constructs a new value type for CONTROL.
			/// </summary>
            public CONTROL(string value) : base(value) { }
		}
    }
}