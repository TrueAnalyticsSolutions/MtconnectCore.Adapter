using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterInterface.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605547395898_219029_214">model.mtconnect.org</seealso>
	/// <see cref="Process">Process</see> that takes place at a specific place and time, such as a specific instance of part-milling occurring at a specific timestamp./// Description
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public class ProcessOccurrence : Process, IAdapterDataModel, IComponentModel {

		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.ProcessOccurrenceId" />
		public virtual ProcessOccurrenceId ProcessOccurrenceId { get; set; }

		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.ProcessAggregateId" />
		public virtual ProcessAggregateId ProcessAggregateId { get; set; }

		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.ProcessTime" />
		public virtual ProcessTime ProcessTime { get; set; }

		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.ProcessKindId" />
		public virtual ProcessKindId ProcessKindId { get; set; }

		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.User" />
		public virtual User User { get; set; }

		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.Program" />
		public virtual Program Program { get; set; }

		/// <inheritdoc cref="Mtconnect.AdapterInterface.DataItemValues.PartUniqueId" />
		public virtual PartUniqueId PartUniqueId { get; set; }
	}
}