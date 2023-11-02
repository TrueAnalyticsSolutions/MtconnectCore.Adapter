#pragma warning disable CS0618
#pragma warning disable CS1574
#pragma warning disable CS1570
#pragma warning disable CS1584
using Mtconnect.AdapterSdk;
using Mtconnect.AdapterSdk.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterSdk.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382017_874684_42291">model.mtconnect.org</seealso>
	/// <see cref="Component">Component</see> that responds to a physical stimulus and transmits a resulting impulse or value from a sensing unit./// Description
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ComponentInterface.scriban", "1.0.12.0")]
	public class Sensor : IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="Thermostat" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Thermostat> ThermostatComponents { get; set; } = new Dictionary<string, Thermostat>();
		/// <summary>
		/// Gets the instance of a <see cref="Thermostat" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Thermostat ExampleThermostat =&gt; GetOrAddThermostat&lt;Thermostat&gt;(nameof(ExampleThermostat));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Thermostat" /> component</param>
		protected TThermostat GetOrAddThermostat<TThermostat>(string propertyName) where TThermostat : Thermostat
		{
			if (!ThermostatComponents.ContainsKey(propertyName))
				ThermostatComponents.Add(propertyName, (TThermostat)Activator.CreateInstance(typeof(TThermostat)));
			return (TThermostat)ThermostatComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="Vibration" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Vibration> VibrationComponents { get; set; } = new Dictionary<string, Vibration>();
		/// <summary>
		/// Gets the instance of a <see cref="Vibration" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Vibration ExampleVibration =&gt; GetOrAddVibration&lt;Vibration&gt;(nameof(ExampleVibration));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Vibration" /> component</param>
		protected TVibration GetOrAddVibration<TVibration>(string propertyName) where TVibration : Vibration
		{
			if (!VibrationComponents.ContainsKey(propertyName))
				VibrationComponents.Add(propertyName, (TVibration)Activator.CreateInstance(typeof(TVibration)));
			return (TVibration)VibrationComponents[propertyName];
		}
		/// <summary>
		/// Sets all data items to <c>UNAVAILABLE</c> by setting the properties to <c>default</c>.
		/// </summary>
		public virtual void Unavailable() {
		}
	}
}