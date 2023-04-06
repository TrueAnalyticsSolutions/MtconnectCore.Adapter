using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1630059859468_228796_88">model.mtconnect.org</seealso>
	/// <see cref="Resources">Resources</see> that <i>organize</i>s <see cref="Material">Material</see> types.
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.7.0")]
	public class Materials : IAdapterDataModel, IComponentModel {

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
	}
}