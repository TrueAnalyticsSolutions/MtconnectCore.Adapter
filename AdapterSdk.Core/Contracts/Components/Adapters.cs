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
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1607345849016_787585_1914">model.mtconnect.org</seealso>
	/// <see cref="Component">Component</see> that <i>organize</i>s <see cref="Adapter">Adapter</see> types. 
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ComponentInterface.scriban", "1.0.12.0")]
	public class Adapters : IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="Adapter" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Adapter> AdapterComponents { get; set; } = new Dictionary<string, Adapter>();
		/// <summary>
		/// Gets the instance of a <see cref="Adapter" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Adapter ExampleAdapter =&gt; GetOrAddAdapter&lt;Adapter&gt;(nameof(ExampleAdapter));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Adapter" /> component</param>
		protected TAdapter GetOrAddAdapter<TAdapter>(string propertyName) where TAdapter : Adapter
		{
			if (!AdapterComponents.ContainsKey(propertyName))
				AdapterComponents.Add(propertyName, (TAdapter)Activator.CreateInstance(typeof(TAdapter)));
			return (TAdapter)AdapterComponents[propertyName];
		}
		/// <summary>
		/// Sets all data items to <c>UNAVAILABLE</c> by setting the properties to <c>default</c>.
		/// </summary>
		public virtual void Unavailable() {
		}
	}
}