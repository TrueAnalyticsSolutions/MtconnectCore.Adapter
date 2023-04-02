using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1580312106471_40319_44429">model.mtconnect.org</seealso>
	/// leaf <see cref="Component">Component</see> that measures linear motion or position.  <b>DEPRECATION WARNING</b> : May be deprecated in the future. Recommend using <see cref="Encoder">Encoder</see>.
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.5.0")]
	public interface ILinearPositionFeedback : IAdapterDataModel, IComponentModel {
	
	}
}