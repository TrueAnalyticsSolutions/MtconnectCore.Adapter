using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382021_741508_42300">model.mtconnect.org</seealso>
	/// <see cref="Auxiliary">Auxiliary</see> that manages, positions, stores, and delivers tooling within a piece of equipment. 
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.7.0")]
	public class ToolingDelivery : Auxiliary, IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="GangToolBar" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, GangToolBar> GangToolBarComponents { get; set; } = new Dictionary<string, GangToolBar>();
		/// <summary>
		/// Gets the instance of a <see cref="GangToolBar" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public GangToolBar ExampleGangToolBar =&gt; GetOrAddGangToolBar&lt;GangToolBar&gt;(nameof(ExampleGangToolBar));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="GangToolBar" /> component</param>
		protected TGangToolBar GetOrAddGangToolBar<TGangToolBar>(string propertyName) where TGangToolBar : GangToolBar
		{
			if (!GangToolBarComponents.ContainsKey(propertyName))
				GangToolBarComponents.Add(propertyName, (TGangToolBar)Activator.CreateInstance(typeof(TGangToolBar)));
			return (TGangToolBar)GangToolBarComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="AutomaticToolChanger" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, AutomaticToolChanger> AutomaticToolChangerComponents { get; set; } = new Dictionary<string, AutomaticToolChanger>();
		/// <summary>
		/// Gets the instance of a <see cref="AutomaticToolChanger" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public AutomaticToolChanger ExampleAutomaticToolChanger =&gt; GetOrAddAutomaticToolChanger&lt;AutomaticToolChanger&gt;(nameof(ExampleAutomaticToolChanger));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="AutomaticToolChanger" /> component</param>
		protected TAutomaticToolChanger GetOrAddAutomaticToolChanger<TAutomaticToolChanger>(string propertyName) where TAutomaticToolChanger : AutomaticToolChanger
		{
			if (!AutomaticToolChangerComponents.ContainsKey(propertyName))
				AutomaticToolChangerComponents.Add(propertyName, (TAutomaticToolChanger)Activator.CreateInstance(typeof(TAutomaticToolChanger)));
			return (TAutomaticToolChanger)AutomaticToolChangerComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="ToolMagazine" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, ToolMagazine> ToolMagazineComponents { get; set; } = new Dictionary<string, ToolMagazine>();
		/// <summary>
		/// Gets the instance of a <see cref="ToolMagazine" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public ToolMagazine ExampleToolMagazine =&gt; GetOrAddToolMagazine&lt;ToolMagazine&gt;(nameof(ExampleToolMagazine));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="ToolMagazine" /> component</param>
		protected TToolMagazine GetOrAddToolMagazine<TToolMagazine>(string propertyName) where TToolMagazine : ToolMagazine
		{
			if (!ToolMagazineComponents.ContainsKey(propertyName))
				ToolMagazineComponents.Add(propertyName, (TToolMagazine)Activator.CreateInstance(typeof(TToolMagazine)));
			return (TToolMagazine)ToolMagazineComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="ToolRack" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, ToolRack> ToolRackComponents { get; set; } = new Dictionary<string, ToolRack>();
		/// <summary>
		/// Gets the instance of a <see cref="ToolRack" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public ToolRack ExampleToolRack =&gt; GetOrAddToolRack&lt;ToolRack&gt;(nameof(ExampleToolRack));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="ToolRack" /> component</param>
		protected TToolRack GetOrAddToolRack<TToolRack>(string propertyName) where TToolRack : ToolRack
		{
			if (!ToolRackComponents.ContainsKey(propertyName))
				ToolRackComponents.Add(propertyName, (TToolRack)Activator.CreateInstance(typeof(TToolRack)));
			return (TToolRack)ToolRackComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="Turret" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Turret> TurretComponents { get; set; } = new Dictionary<string, Turret>();
		/// <summary>
		/// Gets the instance of a <see cref="Turret" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Turret ExampleTurret =&gt; GetOrAddTurret&lt;Turret&gt;(nameof(ExampleTurret));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Turret" /> component</param>
		protected TTurret GetOrAddTurret<TTurret>(string propertyName) where TTurret : Turret
		{
			if (!TurretComponents.ContainsKey(propertyName))
				TurretComponents.Add(propertyName, (TTurret)Activator.CreateInstance(typeof(TTurret)));
			return (TTurret)TurretComponents[propertyName];
		}
	}
}