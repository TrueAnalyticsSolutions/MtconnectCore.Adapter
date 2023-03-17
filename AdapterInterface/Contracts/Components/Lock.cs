using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure__">model.mtconnect.org</seealso>
	/// <see cref="Component">Component</see> that physically prohibits a <see cref="Device">Device</see> or <see cref="Component">Component</see> from opening or operating.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public interface ILock : IAdapterDataModel {
	
		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.LockState" />
		LockState LockState { get; set; }
	}
}