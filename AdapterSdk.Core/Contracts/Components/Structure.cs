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
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1587597358521_716746_1028">model.mtconnect.org</seealso>
	/// <see cref="Component">Component</see> composed of part(s) comprising the rigid bodies of the piece of equipment.
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ComponentInterface.scriban", "1.0.12.0")]
	public class Structure : IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="Link" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Link> LinkComponents { get; set; } = new Dictionary<string, Link>();
		/// <summary>
		/// Gets the instance of a <see cref="Link" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Link ExampleLink =&gt; GetOrAddLink&lt;Link&gt;(nameof(ExampleLink));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Link" /> component</param>
		protected TLink GetOrAddLink<TLink>(string propertyName) where TLink : Link
		{
			if (!LinkComponents.ContainsKey(propertyName))
				LinkComponents.Add(propertyName, (TLink)Activator.CreateInstance(typeof(TLink)));
			return (TLink)LinkComponents[propertyName];
		}
		/// <summary>
		/// Sets all data items to <c>UNAVAILABLE</c> by setting the properties to <c>default</c>.
		/// </summary>
		public virtual void Unavailable() {
		}
	}
}