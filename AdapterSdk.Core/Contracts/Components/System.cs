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
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382020_336298_42297">model.mtconnect.org</seealso>
	/// abstract <see cref="Component">Component</see> that is permanently integrated into the piece of equipment.
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ComponentInterface.scriban", "1.0.12.0")]
	public class System : IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="Controller" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Controller> ControllerComponents { get; set; } = new Dictionary<string, Controller>();
		/// <summary>
		/// Gets the instance of a <see cref="Controller" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Controller ExampleController =&gt; GetOrAddController&lt;Controller&gt;(nameof(ExampleController));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Controller" /> component</param>
		protected TController GetOrAddController<TController>(string propertyName) where TController : Controller
		{
			if (!ControllerComponents.ContainsKey(propertyName))
				ControllerComponents.Add(propertyName, (TController)Activator.CreateInstance(typeof(TController)));
			return (TController)ControllerComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="Coolant" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Coolant> CoolantComponents { get; set; } = new Dictionary<string, Coolant>();
		/// <summary>
		/// Gets the instance of a <see cref="Coolant" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Coolant ExampleCoolant =&gt; GetOrAddCoolant&lt;Coolant&gt;(nameof(ExampleCoolant));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Coolant" /> component</param>
		protected TCoolant GetOrAddCoolant<TCoolant>(string propertyName) where TCoolant : Coolant
		{
			if (!CoolantComponents.ContainsKey(propertyName))
				CoolantComponents.Add(propertyName, (TCoolant)Activator.CreateInstance(typeof(TCoolant)));
			return (TCoolant)CoolantComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="Dielectric" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Dielectric> DielectricComponents { get; set; } = new Dictionary<string, Dielectric>();
		/// <summary>
		/// Gets the instance of a <see cref="Dielectric" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Dielectric ExampleDielectric =&gt; GetOrAddDielectric&lt;Dielectric&gt;(nameof(ExampleDielectric));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Dielectric" /> component</param>
		protected TDielectric GetOrAddDielectric<TDielectric>(string propertyName) where TDielectric : Dielectric
		{
			if (!DielectricComponents.ContainsKey(propertyName))
				DielectricComponents.Add(propertyName, (TDielectric)Activator.CreateInstance(typeof(TDielectric)));
			return (TDielectric)DielectricComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="Electric" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Electric> ElectricComponents { get; set; } = new Dictionary<string, Electric>();
		/// <summary>
		/// Gets the instance of a <see cref="Electric" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Electric ExampleElectric =&gt; GetOrAddElectric&lt;Electric&gt;(nameof(ExampleElectric));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Electric" /> component</param>
		protected TElectric GetOrAddElectric<TElectric>(string propertyName) where TElectric : Electric
		{
			if (!ElectricComponents.ContainsKey(propertyName))
				ElectricComponents.Add(propertyName, (TElectric)Activator.CreateInstance(typeof(TElectric)));
			return (TElectric)ElectricComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="Enclosure" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Enclosure> EnclosureComponents { get; set; } = new Dictionary<string, Enclosure>();
		/// <summary>
		/// Gets the instance of a <see cref="Enclosure" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Enclosure ExampleEnclosure =&gt; GetOrAddEnclosure&lt;Enclosure&gt;(nameof(ExampleEnclosure));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Enclosure" /> component</param>
		protected TEnclosure GetOrAddEnclosure<TEnclosure>(string propertyName) where TEnclosure : Enclosure
		{
			if (!EnclosureComponents.ContainsKey(propertyName))
				EnclosureComponents.Add(propertyName, (TEnclosure)Activator.CreateInstance(typeof(TEnclosure)));
			return (TEnclosure)EnclosureComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="EndEffector" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, EndEffector> EndEffectorComponents { get; set; } = new Dictionary<string, EndEffector>();
		/// <summary>
		/// Gets the instance of a <see cref="EndEffector" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public EndEffector ExampleEndEffector =&gt; GetOrAddEndEffector&lt;EndEffector&gt;(nameof(ExampleEndEffector));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="EndEffector" /> component</param>
		protected TEndEffector GetOrAddEndEffector<TEndEffector>(string propertyName) where TEndEffector : EndEffector
		{
			if (!EndEffectorComponents.ContainsKey(propertyName))
				EndEffectorComponents.Add(propertyName, (TEndEffector)Activator.CreateInstance(typeof(TEndEffector)));
			return (TEndEffector)EndEffectorComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="Feeder" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Feeder> FeederComponents { get; set; } = new Dictionary<string, Feeder>();
		/// <summary>
		/// Gets the instance of a <see cref="Feeder" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Feeder ExampleFeeder =&gt; GetOrAddFeeder&lt;Feeder&gt;(nameof(ExampleFeeder));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Feeder" /> component</param>
		protected TFeeder GetOrAddFeeder<TFeeder>(string propertyName) where TFeeder : Feeder
		{
			if (!FeederComponents.ContainsKey(propertyName))
				FeederComponents.Add(propertyName, (TFeeder)Activator.CreateInstance(typeof(TFeeder)));
			return (TFeeder)FeederComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="Hydraulic" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Hydraulic> HydraulicComponents { get; set; } = new Dictionary<string, Hydraulic>();
		/// <summary>
		/// Gets the instance of a <see cref="Hydraulic" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Hydraulic ExampleHydraulic =&gt; GetOrAddHydraulic&lt;Hydraulic&gt;(nameof(ExampleHydraulic));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Hydraulic" /> component</param>
		protected THydraulic GetOrAddHydraulic<THydraulic>(string propertyName) where THydraulic : Hydraulic
		{
			if (!HydraulicComponents.ContainsKey(propertyName))
				HydraulicComponents.Add(propertyName, (THydraulic)Activator.CreateInstance(typeof(THydraulic)));
			return (THydraulic)HydraulicComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="Lubrication" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Lubrication> LubricationComponents { get; set; } = new Dictionary<string, Lubrication>();
		/// <summary>
		/// Gets the instance of a <see cref="Lubrication" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Lubrication ExampleLubrication =&gt; GetOrAddLubrication&lt;Lubrication&gt;(nameof(ExampleLubrication));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Lubrication" /> component</param>
		protected TLubrication GetOrAddLubrication<TLubrication>(string propertyName) where TLubrication : Lubrication
		{
			if (!LubricationComponents.ContainsKey(propertyName))
				LubricationComponents.Add(propertyName, (TLubrication)Activator.CreateInstance(typeof(TLubrication)));
			return (TLubrication)LubricationComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="Pneumatic" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Pneumatic> PneumaticComponents { get; set; } = new Dictionary<string, Pneumatic>();
		/// <summary>
		/// Gets the instance of a <see cref="Pneumatic" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Pneumatic ExamplePneumatic =&gt; GetOrAddPneumatic&lt;Pneumatic&gt;(nameof(ExamplePneumatic));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Pneumatic" /> component</param>
		protected TPneumatic GetOrAddPneumatic<TPneumatic>(string propertyName) where TPneumatic : Pneumatic
		{
			if (!PneumaticComponents.ContainsKey(propertyName))
				PneumaticComponents.Add(propertyName, (TPneumatic)Activator.CreateInstance(typeof(TPneumatic)));
			return (TPneumatic)PneumaticComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="ProcessPower" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, ProcessPower> ProcessPowerComponents { get; set; } = new Dictionary<string, ProcessPower>();
		/// <summary>
		/// Gets the instance of a <see cref="ProcessPower" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public ProcessPower ExampleProcessPower =&gt; GetOrAddProcessPower&lt;ProcessPower&gt;(nameof(ExampleProcessPower));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="ProcessPower" /> component</param>
		protected TProcessPower GetOrAddProcessPower<TProcessPower>(string propertyName) where TProcessPower : ProcessPower
		{
			if (!ProcessPowerComponents.ContainsKey(propertyName))
				ProcessPowerComponents.Add(propertyName, (TProcessPower)Activator.CreateInstance(typeof(TProcessPower)));
			return (TProcessPower)ProcessPowerComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="Protective" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Protective> ProtectiveComponents { get; set; } = new Dictionary<string, Protective>();
		/// <summary>
		/// Gets the instance of a <see cref="Protective" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Protective ExampleProtective =&gt; GetOrAddProtective&lt;Protective&gt;(nameof(ExampleProtective));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Protective" /> component</param>
		protected TProtective GetOrAddProtective<TProtective>(string propertyName) where TProtective : Protective
		{
			if (!ProtectiveComponents.ContainsKey(propertyName))
				ProtectiveComponents.Add(propertyName, (TProtective)Activator.CreateInstance(typeof(TProtective)));
			return (TProtective)ProtectiveComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="WorkEnvelope" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, WorkEnvelope> WorkEnvelopeComponents { get; set; } = new Dictionary<string, WorkEnvelope>();
		/// <summary>
		/// Gets the instance of a <see cref="WorkEnvelope" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public WorkEnvelope ExampleWorkEnvelope =&gt; GetOrAddWorkEnvelope&lt;WorkEnvelope&gt;(nameof(ExampleWorkEnvelope));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="WorkEnvelope" /> component</param>
		protected TWorkEnvelope GetOrAddWorkEnvelope<TWorkEnvelope>(string propertyName) where TWorkEnvelope : WorkEnvelope
		{
			if (!WorkEnvelopeComponents.ContainsKey(propertyName))
				WorkEnvelopeComponents.Add(propertyName, (TWorkEnvelope)Activator.CreateInstance(typeof(TWorkEnvelope)));
			return (TWorkEnvelope)WorkEnvelopeComponents[propertyName];
		}
		/// <summary>
		/// Sets all data items to <c>UNAVAILABLE</c> by setting the properties to <c>default</c>.
		/// </summary>
		public virtual void Unavailable() {
		}
	}
}