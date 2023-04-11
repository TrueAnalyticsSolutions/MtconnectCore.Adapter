using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1622457426342_839834_623">model.mtconnect.org</seealso>
	/// <see cref="Component">Component</see> that physically prohibits a <see cref="Device">Device</see> or <see cref="Component">Component</see> from opening or operating.
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public class Lock : IAdapterDataModel, IComponentModel {

		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.LockState" />
		public virtual LockState LockState { get; set; }
	}
}