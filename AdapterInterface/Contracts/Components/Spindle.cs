using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_4_45f01b9_1643678227814_87818_1410">model.mtconnect.org</seealso>
	/// <see cref="Component">Component</see> that provides an axis of rotation for the purpose of rapidly rotating a part or a tool to provide sufficient surface speed for cutting operations.  <see cref="Spindle">Spindle</see> was <b>DEPRECATED</b> in <i>MTConnect Version 1.1</i> and was replaced by <see cref="RotaryMode">RotaryMode</see>.
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
	/// <remarks>Deprecated in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
	[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public class Spindle : Axis, IAdapterDataModel, IComponentModel {
	}
}