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
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_4_45f01b9_1643678703742_369144_1539">model.mtconnect.org</seealso>
	/// <see cref="Component">Component</see> composed of a sensor or an instrument that measures temperature.  <see cref="Thermostat">Thermostat</see> was <b>DEPRECATED</b> in <i>MTConnect Version 1.2</i> and was replaced by <see cref="Temperature">Temperature</see>.
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
	/// <remarks>Deprecated in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
	[Obsolete("Deprecated in v1.2 according to https://model.mtconnect.org/#_Version_1.2")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ComponentInterface.scriban", "1.0.12.0")]
	public class Thermostat : Sensor, IAdapterDataModel, IComponentModel {
	}
}