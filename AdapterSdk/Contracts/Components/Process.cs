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
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605547261014_920934_161">model.mtconnect.org</seealso>
	/// abstract <see cref="Component">Component</see> composed of a manufacturing process being executed on a piece of equipment. 
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ComponentInterface.scriban", "1.0.12.0")]
	public class Process : IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="ProcessOccurrence" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, ProcessOccurrence> ProcessOccurrenceComponents { get; set; } = new Dictionary<string, ProcessOccurrence>();
		/// <summary>
		/// Gets the instance of a <see cref="ProcessOccurrence" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public ProcessOccurrence ExampleProcessOccurrence =&gt; GetOrAddProcessOccurrence&lt;ProcessOccurrence&gt;(nameof(ExampleProcessOccurrence));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="ProcessOccurrence" /> component</param>
		protected TProcessOccurrence GetOrAddProcessOccurrence<TProcessOccurrence>(string propertyName) where TProcessOccurrence : ProcessOccurrence
		{
			if (!ProcessOccurrenceComponents.ContainsKey(propertyName))
				ProcessOccurrenceComponents.Add(propertyName, (TProcessOccurrence)Activator.CreateInstance(typeof(TProcessOccurrence)));
			return (TProcessOccurrence)ProcessOccurrenceComponents[propertyName];
		}
		/// <summary>
		/// Sets all data items to <c>UNAVAILABLE</c> by setting the properties to <c>default</c>.
		/// </summary>
		public virtual void Unavailable() {
		}
	}
}