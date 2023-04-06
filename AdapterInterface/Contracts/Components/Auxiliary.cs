using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572381970_785259_42204">model.mtconnect.org</seealso>
	/// abstract <see cref="Component">Component</see> composed of removable part(s) of a piece of equipment that provides supplementary or extended functionality.
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.7.0")]
	public class Auxiliary : IAdapterDataModel, IComponentModel {

		/// <summary>
		/// Internal collection of <see cref="Deposition" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Deposition> DepositionComponents { get; set; } = new Dictionary<string, Deposition>();
		/// <summary>
		/// Gets the instance of a <see cref="Deposition" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Deposition ExampleDeposition =&gt; GetOrAddDeposition&lt;Deposition&gt;(nameof(ExampleDeposition));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Deposition" /> component</param>
		protected TDeposition GetOrAddDeposition<TDeposition>(string propertyName) where TDeposition : Deposition
		{
			if (!DepositionComponents.ContainsKey(propertyName))
				DepositionComponents.Add(propertyName, (TDeposition)Activator.CreateInstance(typeof(TDeposition)));
			return (TDeposition)DepositionComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="Environmental" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Environmental> EnvironmentalComponents { get; set; } = new Dictionary<string, Environmental>();
		/// <summary>
		/// Gets the instance of a <see cref="Environmental" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Environmental ExampleEnvironmental =&gt; GetOrAddEnvironmental&lt;Environmental&gt;(nameof(ExampleEnvironmental));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Environmental" /> component</param>
		protected TEnvironmental GetOrAddEnvironmental<TEnvironmental>(string propertyName) where TEnvironmental : Environmental
		{
			if (!EnvironmentalComponents.ContainsKey(propertyName))
				EnvironmentalComponents.Add(propertyName, (TEnvironmental)Activator.CreateInstance(typeof(TEnvironmental)));
			return (TEnvironmental)EnvironmentalComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="Loader" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, Loader> LoaderComponents { get; set; } = new Dictionary<string, Loader>();
		/// <summary>
		/// Gets the instance of a <see cref="Loader" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public Loader ExampleLoader =&gt; GetOrAddLoader&lt;Loader&gt;(nameof(ExampleLoader));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="Loader" /> component</param>
		protected TLoader GetOrAddLoader<TLoader>(string propertyName) where TLoader : Loader
		{
			if (!LoaderComponents.ContainsKey(propertyName))
				LoaderComponents.Add(propertyName, (TLoader)Activator.CreateInstance(typeof(TLoader)));
			return (TLoader)LoaderComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="ToolingDelivery" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, ToolingDelivery> ToolingDeliveryComponents { get; set; } = new Dictionary<string, ToolingDelivery>();
		/// <summary>
		/// Gets the instance of a <see cref="ToolingDelivery" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public ToolingDelivery ExampleToolingDelivery =&gt; GetOrAddToolingDelivery&lt;ToolingDelivery&gt;(nameof(ExampleToolingDelivery));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="ToolingDelivery" /> component</param>
		protected TToolingDelivery GetOrAddToolingDelivery<TToolingDelivery>(string propertyName) where TToolingDelivery : ToolingDelivery
		{
			if (!ToolingDeliveryComponents.ContainsKey(propertyName))
				ToolingDeliveryComponents.Add(propertyName, (TToolingDelivery)Activator.CreateInstance(typeof(TToolingDelivery)));
			return (TToolingDelivery)ToolingDeliveryComponents[propertyName];
		}

		/// <summary>
		/// Internal collection of <see cref="WasteDisposal" /> to be maintained by the implementer. The dictionary key is recommended to be the names of any hard-coded properties
		/// </summary>
		private Dictionary<string, WasteDisposal> WasteDisposalComponents { get; set; } = new Dictionary<string, WasteDisposal>();
		/// <summary>
		/// Gets the instance of a <see cref="WasteDisposal" /> by name. <b>NOTE</b>: The <paramref name="propertyName"/> should usually be the name of a property within the class.
		/// <br /><example>
		/// Expected use:
		/// <code>
		/// public WasteDisposal ExampleWasteDisposal =&gt; GetOrAddWasteDisposal&lt;WasteDisposal&gt;(nameof(ExampleWasteDisposal));
		/// </code>
		/// </example>
		/// </summary>
		/// <param name="propertyName">Reference to the name of the property that is the entry point for this <see cref="WasteDisposal" /> component</param>
		protected TWasteDisposal GetOrAddWasteDisposal<TWasteDisposal>(string propertyName) where TWasteDisposal : WasteDisposal
		{
			if (!WasteDisposalComponents.ContainsKey(propertyName))
				WasteDisposalComponents.Add(propertyName, (TWasteDisposal)Activator.CreateInstance(typeof(TWasteDisposal)));
			return (TWasteDisposal)WasteDisposalComponents[propertyName];
		}
	}
}