using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1607346168906_610073_2052">model.mtconnect.org</seealso>
	/// <see cref="Component">Component</see> that <i>organize</i>s <see cref="Process">Process</see> types. 
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public class Processes : IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="Process" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Process> ProcessComponents { get; set; } = new Dictionary<string, Process>();
		/// <summary>
		/// Gets the instance of a <see cref="Process" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Process ExampleProcess =&gt; GetOrAddProcess&lt;Process&gt;(nameof(ExampleProcess));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Process" /> component</param>
		protected TProcess GetOrAddProcess<TProcess>(string propertyName) where TProcess : Process
		{
			if (!ProcessComponents.ContainsKey(propertyName))
				ProcessComponents.Add(propertyName, (TProcess)Activator.CreateInstance(typeof(TProcess)));
			return (TProcess)ProcessComponents[propertyName];
		}
	}
}