using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterSdk.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1607371600474_90853_450">model.mtconnect.org</seealso>
	/// <see cref="Component">Component</see> that <i>organize</i>s <see cref="Structure">Structure</see> types. 
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public class Structures : IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="Structure" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Structure> StructureComponents { get; set; } = new Dictionary<string, Structure>();
		/// <summary>
		/// Gets the instance of a <see cref="Structure" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Structure ExampleStructure =&gt; GetOrAddStructure&lt;Structure&gt;(nameof(ExampleStructure));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Structure" /> component</param>
		protected TStructure GetOrAddStructure<TStructure>(string propertyName) where TStructure : Structure
		{
			if (!StructureComponents.ContainsKey(propertyName))
				StructureComponents.Add(propertyName, (TStructure)Activator.CreateInstance(typeof(TStructure)));
			return (TStructure)StructureComponents[propertyName];
		}
		/// <summary>
		/// Sets all data items to <c>UNAVAILABLE</c> by setting the properties to <c>default</c>.
		/// </summary>
		public virtual void Unavailable() {
		}
	}
}