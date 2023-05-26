using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterSdk.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1622457074108_581195_524">model.mtconnect.org</seealso>
	/// <see cref="Component">Component</see> that <i>organize</i>s <see cref="Part">Part</see> types.
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public class Parts : IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="Part" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Part> PartComponents { get; set; } = new Dictionary<string, Part>();
		/// <summary>
		/// Gets the instance of a <see cref="Part" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Part ExamplePart =&gt; GetOrAddPart&lt;Part&gt;(nameof(ExamplePart));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Part" /> component</param>
		protected TPart GetOrAddPart<TPart>(string propertyName) where TPart : Part
		{
			if (!PartComponents.ContainsKey(propertyName))
				PartComponents.Add(propertyName, (TPart)Activator.CreateInstance(typeof(TPart)));
			return (TPart)PartComponents[propertyName];
		}
		/// <summary>
		/// Sets all data items to <c>UNAVAILABLE</c> by setting the properties to <c>default</c>.
		/// </summary>
		public virtual void Unavailable() {
		}
	}
}