using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure__">model.mtconnect.org</seealso>
	/// <see cref="Part">Part</see> that exists at a specific place and time, such as a specific instance of a bracket at a specific timestamp./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public interface IPartOccurrence : IAdapterDataModel {
	
		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.PartId" />
		PartId PartId { get; set; }
		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.PartUniqueId" />
		PartUniqueId PartUniqueId { get; set; }
		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.PartGroupId" />
		PartGroupId PartGroupId { get; set; }
		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.PartKindId" />
		PartKindId PartKindId { get; set; }
		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.PartCount" />
		PartCount PartCount { get; set; }
		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.PartStatus" />
		PartStatus PartStatus { get; set; }
		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.ProcessOccurrenceId" />
		ProcessOccurrenceId ProcessOccurrenceId { get; set; }
		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.ProcessTime" />
		ProcessTime ProcessTime { get; set; }
		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.User" />
		User User { get; set; }
	}
}