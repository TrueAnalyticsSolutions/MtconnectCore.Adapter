using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572381990_149427_42240">model.mtconnect.org</seealso>
	/// <see cref="Auxiliary">Auxiliary</see> that monitors, manages, or conditions the environment around or within a piece of equipment.
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public class Environmental : Auxiliary, IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="Heating" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Heating> HeatingComponents { get; set; } = new Dictionary<string, Heating>();
		/// <summary>
		/// Gets the instance of a <see cref="Heating" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Heating ExampleHeating =&gt; GetOrAddHeating&lt;Heating&gt;(nameof(ExampleHeating));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Heating" /> component</param>
		protected THeating GetOrAddHeating<THeating>(string propertyName) where THeating : Heating
		{
			if (!HeatingComponents.ContainsKey(propertyName))
				HeatingComponents.Add(propertyName, (THeating)Activator.CreateInstance(typeof(THeating)));
			return (THeating)HeatingComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="Vacuum" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Vacuum> VacuumComponents { get; set; } = new Dictionary<string, Vacuum>();
		/// <summary>
		/// Gets the instance of a <see cref="Vacuum" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Vacuum ExampleVacuum =&gt; GetOrAddVacuum&lt;Vacuum&gt;(nameof(ExampleVacuum));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Vacuum" /> component</param>
		protected TVacuum GetOrAddVacuum<TVacuum>(string propertyName) where TVacuum : Vacuum
		{
			if (!VacuumComponents.ContainsKey(propertyName))
				VacuumComponents.Add(propertyName, (TVacuum)Activator.CreateInstance(typeof(TVacuum)));
			return (TVacuum)VacuumComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="Cooling" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Cooling> CoolingComponents { get; set; } = new Dictionary<string, Cooling>();
		/// <summary>
		/// Gets the instance of a <see cref="Cooling" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Cooling ExampleCooling =&gt; GetOrAddCooling&lt;Cooling&gt;(nameof(ExampleCooling));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Cooling" /> component</param>
		protected TCooling GetOrAddCooling<TCooling>(string propertyName) where TCooling : Cooling
		{
			if (!CoolingComponents.ContainsKey(propertyName))
				CoolingComponents.Add(propertyName, (TCooling)Activator.CreateInstance(typeof(TCooling)));
			return (TCooling)CoolingComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="Pressure" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Pressure> PressureComponents { get; set; } = new Dictionary<string, Pressure>();
		/// <summary>
		/// Gets the instance of a <see cref="Pressure" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Pressure ExamplePressure =&gt; GetOrAddPressure&lt;Pressure&gt;(nameof(ExamplePressure));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Pressure" /> component</param>
		protected TPressure GetOrAddPressure<TPressure>(string propertyName) where TPressure : Pressure
		{
			if (!PressureComponents.ContainsKey(propertyName))
				PressureComponents.Add(propertyName, (TPressure)Activator.CreateInstance(typeof(TPressure)));
			return (TPressure)PressureComponents[propertyName];
		}
	}
}