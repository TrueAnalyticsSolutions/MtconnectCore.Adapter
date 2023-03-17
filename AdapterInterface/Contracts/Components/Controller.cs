using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572381977_283525_42216">model.mtconnect.org</seealso>
	/// <see cref="System">System</see> that provides regulation or management of a system or component. {{cite(ISO 16484-5:2017)}}/// Description
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public interface IController : IAdapterDataModel {
		/// <inheritdoc cref="IPath" />
		IPath Path { get; set; }
	
	}
}