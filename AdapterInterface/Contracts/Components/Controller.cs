using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572381977_283525_42216">model.mtconnect.org</seealso>
	/// <see cref="System">System</see> that provides regulation or management of a system or component. <seealso href="https://www.google.com/search?q=ISO 16484-5:2017&btnI=I">ISO 16484-5:2017</seealso>/// Description
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.5.0")]
	public interface IController : IAdapterDataModel, IComponentModel {
		/// <inheritdoc cref="IPath" />
		IPath Path { get; set; }
	
	}
}