using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure__">model.mtconnect.org</seealso>
	/// <see cref="Process">Process</see> that takes place at a specific place and time, such as a specific instance of part-milling occurring at a specific timestamp./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public interface IProcessOccurrence : IAdapterDataModel {
	
		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.ProcessOccurrenceId" />
		ProcessOccurrenceId ProcessOccurrenceId { get; set; }
		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.ProcessAggregateId" />
		ProcessAggregateId ProcessAggregateId { get; set; }
		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.ProcessTime" />
		ProcessTime ProcessTime { get; set; }
		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.ProcessKindId" />
		ProcessKindId ProcessKindId { get; set; }
		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.User" />
		User User { get; set; }
		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.Program" />
		Program Program { get; set; }
		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.PartUniqueId" />
		PartUniqueId PartUniqueId { get; set; }
	}
}