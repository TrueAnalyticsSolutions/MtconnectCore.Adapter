using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382002_513291_42264">model.mtconnect.org</seealso>
	/// <see cref="Resource">Resource</see> composed of material that is consumed or used by the piece of equipment for production of parts, materials, or other types of goods.
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.7.0")]
	public class Material : Resource, IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="Stock" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Stock> StockComponents { get; set; } = new Dictionary<string, Stock>();
		/// <summary>
		/// Gets the instance of a <see cref="Stock" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Stock ExampleStock =&gt; GetOrAddStock&lt;Stock&gt;(nameof(ExampleStock));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Stock" /> component</param>
		protected TStock GetOrAddStock<TStock>(string propertyName) where TStock : Stock
		{
			if (!StockComponents.ContainsKey(propertyName))
				StockComponents.Add(propertyName, (TStock)Activator.CreateInstance(typeof(TStock)));
			return (TStock)StockComponents[propertyName];
		}
	}
}