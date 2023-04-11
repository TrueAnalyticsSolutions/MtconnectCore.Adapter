using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1607344852741_562899_1488">model.mtconnect.org</seealso>
	/// <see cref="Component">Component</see> that <i>organize</i>s <see cref="System">System</see> types. 
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public class Systems : IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="System" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, System> SystemComponents { get; set; } = new Dictionary<string, System>();
		/// <summary>
		/// Gets the instance of a <see cref="System" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public System ExampleSystem =&gt; GetOrAddSystem&lt;System&gt;(nameof(ExampleSystem));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="System" /> component</param>
		protected TSystem GetOrAddSystem<TSystem>(string propertyName) where TSystem : System
		{
			if (!SystemComponents.ContainsKey(propertyName))
				SystemComponents.Add(propertyName, (TSystem)Activator.CreateInstance(typeof(TSystem)));
			return (TSystem)SystemComponents[propertyName];
		}
	}
}