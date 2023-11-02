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
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1622457426342_839834_623">model.mtconnect.org</seealso>
	/// <see cref="Component">Component</see> that physically prohibits a <see cref="Device">Device</see> or <see cref="Component">Component</see> from opening or operating.
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ComponentInterface.scriban", "1.0.12.0")]
	public class Lock : IAdapterDataModel, IComponentModel {

		/// <inheritdoc cref="Mtconnect.AdapterSdk.DataItemValues.LockState" />
		public virtual LockState LockState { get; set; }
		/// <summary>
		/// Sets all data items to <c>UNAVAILABLE</c> by setting the properties to <c>default</c>.
		/// </summary>
		public virtual void Unavailable() {
			LockState?.Unavailable();
		}
	}
}