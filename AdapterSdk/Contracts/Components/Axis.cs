using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterSdk.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572381972_553005_42207">model.mtconnect.org</seealso>
	/// abstract <see cref="Component">Component</see> composed of a motion system that provides linear or rotational motion for a piece of equipment./// Description
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public class Axis : IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="Linear" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Linear> LinearComponents { get; set; } = new Dictionary<string, Linear>();
		/// <summary>
		/// Gets the instance of a <see cref="Linear" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Linear ExampleLinear =&gt; GetOrAddLinear&lt;Linear&gt;(nameof(ExampleLinear));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Linear" /> component</param>
		protected TLinear GetOrAddLinear<TLinear>(string propertyName) where TLinear : Linear
		{
			if (!LinearComponents.ContainsKey(propertyName))
				LinearComponents.Add(propertyName, (TLinear)Activator.CreateInstance(typeof(TLinear)));
			return (TLinear)LinearComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="Rotary" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Rotary> RotaryComponents { get; set; } = new Dictionary<string, Rotary>();
		/// <summary>
		/// Gets the instance of a <see cref="Rotary" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Rotary ExampleRotary =&gt; GetOrAddRotary&lt;Rotary&gt;(nameof(ExampleRotary));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Rotary" /> component</param>
		protected TRotary GetOrAddRotary<TRotary>(string propertyName) where TRotary : Rotary
		{
			if (!RotaryComponents.ContainsKey(propertyName))
				RotaryComponents.Add(propertyName, (TRotary)Activator.CreateInstance(typeof(TRotary)));
			return (TRotary)RotaryComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="Spindle" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Spindle> SpindleComponents { get; set; } = new Dictionary<string, Spindle>();
		/// <summary>
		/// Gets the instance of a <see cref="Spindle" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Spindle ExampleSpindle =&gt; GetOrAddSpindle&lt;Spindle&gt;(nameof(ExampleSpindle));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Spindle" /> component</param>
		protected TSpindle GetOrAddSpindle<TSpindle>(string propertyName) where TSpindle : Spindle
		{
			if (!SpindleComponents.ContainsKey(propertyName))
				SpindleComponents.Add(propertyName, (TSpindle)Activator.CreateInstance(typeof(TSpindle)));
			return (TSpindle)SpindleComponents[propertyName];
		}
		/// <summary>
		/// Sets all data items to <c>UNAVAILABLE</c> by setting the properties to <c>default</c>.
		/// </summary>
		public virtual void Unavailable() {
		}
	}
}