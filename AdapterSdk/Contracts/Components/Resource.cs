using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterSdk.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382014_307743_42285">model.mtconnect.org</seealso>
	/// abstract <see cref="Component">Component</see> composed of material or personnel involved in a manufacturing process.
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public class Resource : IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="Material" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Material> MaterialComponents { get; set; } = new Dictionary<string, Material>();
		/// <summary>
		/// Gets the instance of a <see cref="Material" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Material ExampleMaterial =&gt; GetOrAddMaterial&lt;Material&gt;(nameof(ExampleMaterial));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Material" /> component</param>
		protected TMaterial GetOrAddMaterial<TMaterial>(string propertyName) where TMaterial : Material
		{
			if (!MaterialComponents.ContainsKey(propertyName))
				MaterialComponents.Add(propertyName, (TMaterial)Activator.CreateInstance(typeof(TMaterial)));
			return (TMaterial)MaterialComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="Personnel" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Personnel> PersonnelComponents { get; set; } = new Dictionary<string, Personnel>();
		/// <summary>
		/// Gets the instance of a <see cref="Personnel" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Personnel ExamplePersonnel =&gt; GetOrAddPersonnel&lt;Personnel&gt;(nameof(ExamplePersonnel));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Personnel" /> component</param>
		protected TPersonnel GetOrAddPersonnel<TPersonnel>(string propertyName) where TPersonnel : Personnel
		{
			if (!PersonnelComponents.ContainsKey(propertyName))
				PersonnelComponents.Add(propertyName, (TPersonnel)Activator.CreateInstance(typeof(TPersonnel)));
			return (TPersonnel)PersonnelComponents[propertyName];
		}
		/// <summary>
		/// Sets all data items to <c>UNAVAILABLE</c> by setting the properties to <c>default</c>.
		/// </summary>
		public virtual void Unavailable() {
		}
	}
}