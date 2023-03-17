using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure__">model.mtconnect.org</seealso>
	/// <see cref="Component">Component</see> composed of a mechanical mechanism or closure that can cover a physical access portal into a piece of equipment allowing or restricting access to other parts of the equipment./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public interface IDoor : IAdapterDataModel {
	
		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.DoorState" />
		DoorState DoorState { get; set; }
	}
}