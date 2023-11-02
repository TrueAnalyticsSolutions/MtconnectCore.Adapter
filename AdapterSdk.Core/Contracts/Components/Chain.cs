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
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1580312106462_246830_44378">model.mtconnect.org</seealso>
	/// leaf <see cref="Component">Component</see> composed of interconnected series of objects that band together and are used to transmit motion for a piece of equipment or to convey materials and objects.
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ComponentInterface.scriban", "1.0.12.0")]
	public class Chain : IAdapterDataModel, IComponentModel {
		/// <summary>
		/// Sets all data items to <c>UNAVAILABLE</c> by setting the properties to <c>default</c>.
		/// </summary>
		public virtual void Unavailable() {
		}
	}
}