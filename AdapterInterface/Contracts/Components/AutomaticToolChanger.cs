using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605551853978_27109_2354">model.mtconnect.org</seealso>
	/// <see cref="ToolingDelivery">ToolingDelivery</see> composed of a tool delivery mechanism that moves tools between a <see cref="ToolMagazine">ToolMagazine</see> and a <i>spindle</i> a <see cref="Turret">Turret</see>./// Description
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.7.0")]
	public class AutomaticToolChanger : ToolingDelivery, IAdapterDataModel, IComponentModel {
	}
}