using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572381999_206845_42258">model.mtconnect.org</seealso>
	/// <see cref="Auxiliary">Auxiliary</see> that provides movement and distribution of materials, parts, tooling, and other items to or from a piece of equipment.
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.6.0")]
	public class Loader : IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="BarFeeder" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, BarFeeder> BarFeederComponents { get; set; } = new Dictionary<string, BarFeeder>();
		/// <summary>
		/// Gets the instance of a <see cref="BarFeeder" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public BarFeeder ExampleBarFeeder =&gt; GetOrAddBarFeeder&lt;BarFeeder&gt;(nameof(ExampleBarFeeder));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="BarFeeder" /> component</param>
		protected TBarFeeder GetOrAddBarFeeder<TBarFeeder>(string propertyName) where TBarFeeder : BarFeeder
		{
			if (!BarFeederComponents.ContainsKey(propertyName))
				BarFeederComponents.Add(propertyName, (TBarFeeder)Activator.CreateInstance(typeof(TBarFeeder)));
			return (TBarFeeder)BarFeederComponents[propertyName];
		}
	}
}