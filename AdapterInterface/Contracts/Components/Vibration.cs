using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure__">model.mtconnect.org</seealso>
	/// <see cref="Component">Component</see> composed of a sensor or an instrument that measures the amount and/or frequency of vibration within a system.  <see cref="Vibration">Vibration</see> was <b>DEPRECATED</b> in <i>MTConnect Version 1.2</i> and was replaced by <see cref="Displacement">Displacement</see>, <see cref="Frequency">Frequency</see> etc.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public interface IVibration : IAdapterDataModel {
	
	}
}