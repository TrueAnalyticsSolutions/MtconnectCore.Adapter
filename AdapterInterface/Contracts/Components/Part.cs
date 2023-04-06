using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1622456766067_72580_282">model.mtconnect.org</seealso>
	/// abstract <see cref="Component">Component</see> composed of a <i>part</i> being processed by a piece of equipment.
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.6.0")]
	public class Part : IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="PartOccurrence" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, PartOccurrence> PartOccurrenceComponents { get; set; } = new Dictionary<string, PartOccurrence>();
		/// <summary>
		/// Gets the instance of a <see cref="PartOccurrence" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public PartOccurrence ExamplePartOccurrence =&gt; GetOrAddPartOccurrence&lt;PartOccurrence&gt;(nameof(ExamplePartOccurrence));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="PartOccurrence" /> component</param>
		protected TPartOccurrence GetOrAddPartOccurrence<TPartOccurrence>(string propertyName) where TPartOccurrence : PartOccurrence
		{
			if (!PartOccurrenceComponents.ContainsKey(propertyName))
				PartOccurrenceComponents.Add(propertyName, (TPartOccurrence)Activator.CreateInstance(typeof(TPartOccurrence)));
			return (TPartOccurrence)PartOccurrenceComponents[propertyName];
		}
	}
}