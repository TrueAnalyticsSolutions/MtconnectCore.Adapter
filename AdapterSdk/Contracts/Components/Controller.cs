using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterSdk.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572381977_283525_42216">model.mtconnect.org</seealso>
	/// <see cref="System">System</see> that provides regulation or management of a system or component. <seealso href="https://www.google.com/search?q=ISO 16484-5:2017&btnI=I">ISO 16484-5:2017</seealso>/// Description
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public class Controller : System, IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="Path" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Path> PathComponents { get; set; } = new Dictionary<string, Path>();
		/// <summary>
		/// Gets the instance of a <see cref="Path" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Path ExamplePath =&gt; GetOrAddPath&lt;Path&gt;(nameof(ExamplePath));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Path" /> component</param>
		protected TPath GetOrAddPath<TPath>(string propertyName) where TPath : Path
		{
			if (!PathComponents.ContainsKey(propertyName))
				PathComponents.Add(propertyName, (TPath)Activator.CreateInstance(typeof(TPath)));
			return (TPath)PathComponents[propertyName];
		}
	}
}