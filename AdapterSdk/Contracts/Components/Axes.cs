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
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1607344218033_657673_1055">model.mtconnect.org</seealso>
	/// <see cref="Component">Component</see> that <i>organize</i>s <see cref="Component Types::Axis">Component Types::Axis</see> types. 
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ComponentInterface.scriban", "1.0.12.0")]
	public class Axes : IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="Axis" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Axis> AxisComponents { get; set; } = new Dictionary<string, Axis>();
		/// <summary>
		/// Gets the instance of a <see cref="Axis" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Axis ExampleAxis =&gt; GetOrAddAxis&lt;Axis&gt;(nameof(ExampleAxis));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Axis" /> component</param>
		protected TAxis GetOrAddAxis<TAxis>(string propertyName) where TAxis : Axis
		{
			if (!AxisComponents.ContainsKey(propertyName))
				AxisComponents.Add(propertyName, (TAxis)Activator.CreateInstance(typeof(TAxis)));
			return (TAxis)AxisComponents[propertyName];
		}
		/// <summary>
		/// Sets all data items to <c>UNAVAILABLE</c> by setting the properties to <c>default</c>.
		/// </summary>
		public virtual void Unavailable() {
		}
	}
}