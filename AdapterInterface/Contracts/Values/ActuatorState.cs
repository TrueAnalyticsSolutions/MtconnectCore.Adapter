#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItems;
using Mtconnect.AdapterInterface.DataItemValues;
using Mtconnect.AdapterInterface.Units;

namespace Mtconnect.AdapterInterface.DataItemValues
{
	/// <summary>
	/// A value type for ActuatorState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417652_570136_2869">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.6.0")]
	public partial class ActuatorState : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.ACTUATOR_STATE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ActuatorState EVENT Data Item.
		/// </summary>
        public ActuatorState(string value) : base(value) { }

        /// <summary>
		﻿/// <see cref="Actuator">Actuator</see> is operating.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ActuatorStateValues))]
        public static ActuatorState ACTIVE => new ActuatorState(nameof(ActuatorStateValues.ACTIVE));
        /// <summary>
		﻿/// <see cref="Actuator">Actuator</see> is not operating.
        /// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ActuatorStateValues))]
        public static ActuatorState INACTIVE => new ActuatorState(nameof(ActuatorStateValues.INACTIVE));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ActuatorState"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ActuatorState"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ActuatorState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ActuatorState(string value)
            => new ActuatorState(value.ToUpperInvariant());
		
    }
}