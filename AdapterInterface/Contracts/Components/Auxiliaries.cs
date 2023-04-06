using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1607345082819_606856_1629">model.mtconnect.org</seealso>
	/// <see cref="Component">Component</see> that <i>organize</i>s <see cref="Auxiliary">Auxiliary</see> types. 
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.7.0")]
	public class Auxiliaries : IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="Auxiliary" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Auxiliary> AuxiliaryComponents { get; set; } = new Dictionary<string, Auxiliary>();
		/// <summary>
		/// Gets the instance of a <see cref="Auxiliary" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Auxiliary ExampleAuxiliary =&gt; GetOrAddAuxiliary&lt;Auxiliary&gt;(nameof(ExampleAuxiliary));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Auxiliary" /> component</param>
		protected TAuxiliary GetOrAddAuxiliary<TAuxiliary>(string propertyName) where TAuxiliary : Auxiliary
		{
			if (!AuxiliaryComponents.ContainsKey(propertyName))
				AuxiliaryComponents.Add(propertyName, (TAuxiliary)Activator.CreateInstance(typeof(TAuxiliary)));
			return (TAuxiliary)AuxiliaryComponents[propertyName];
		}
	}
}