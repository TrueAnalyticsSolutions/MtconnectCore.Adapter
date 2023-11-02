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
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1648551529939_657918_1127">model.mtconnect.org</seealso>
	/// <see cref="Component">Component</see> that <i>organize</i>s <see cref="Controller">Controller</see> entities.
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ComponentInterface.scriban", "1.0.12.0")]
	public class Controllers : IAdapterDataModel, IComponentModel {

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
		/// Sets all data items to <c>UNAVAILABLE</c> by setting the properties to <c>default</c>.
		/// </summary>
		public virtual void Unavailable() {
		}
	}
}