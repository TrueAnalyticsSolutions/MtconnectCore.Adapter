using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure__">model.mtconnect.org</seealso>
	/// <see cref="Component">Component</see> that organizes an independent operation or function within a <see cref="Controller">Controller</see>./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public interface IPath : IAdapterDataModel {
	
		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.Execution" />
		Execution Execution { get; set; }
	}
}