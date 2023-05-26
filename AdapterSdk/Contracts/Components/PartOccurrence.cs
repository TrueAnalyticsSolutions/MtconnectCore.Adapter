using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterSdk.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605547467172_656422_264">model.mtconnect.org</seealso>
	/// <see cref="Part">Part</see> that exists at a specific place and time, such as a specific instance of a bracket at a specific timestamp./// Description
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public class PartOccurrence : Part, IAdapterDataModel, IComponentModel {

		/// <inheritdoc cref="Mtconnect.AdapterSdk.DataItemValues.PartId" />
		public virtual PartId PartId { get; set; }

		/// <inheritdoc cref="Mtconnect.AdapterSdk.DataItemValues.PartUniqueId" />
		public virtual PartUniqueId PartUniqueId { get; set; }

		/// <inheritdoc cref="Mtconnect.AdapterSdk.DataItemValues.PartGroupId" />
		public virtual PartGroupId PartGroupId { get; set; }

		/// <inheritdoc cref="Mtconnect.AdapterSdk.DataItemValues.PartKindId" />
		public virtual PartKindId PartKindId { get; set; }

		/// <inheritdoc cref="Mtconnect.AdapterSdk.DataItemValues.PartCount" />
		public virtual PartCount PartCount { get; set; }

		/// <inheritdoc cref="Mtconnect.AdapterSdk.DataItemValues.PartStatus" />
		public virtual PartStatus PartStatus { get; set; }

		/// <inheritdoc cref="Mtconnect.AdapterSdk.DataItemValues.ProcessOccurrenceId" />
		public virtual ProcessOccurrenceId ProcessOccurrenceId { get; set; }

		/// <inheritdoc cref="Mtconnect.AdapterSdk.DataItemValues.ProcessTime" />
		public virtual ProcessTime ProcessTime { get; set; }

		/// <inheritdoc cref="Mtconnect.AdapterSdk.DataItemValues.User" />
		public virtual User User { get; set; }
		/// <summary>
		/// Sets all data items to <c>UNAVAILABLE</c> by setting the properties to <c>default</c>.
		/// </summary>
		public override void Unavailable() {
			PartId?.Unavailable();
			PartUniqueId?.Unavailable();
			PartGroupId?.Unavailable();
			PartKindId?.Unavailable();
			PartCount?.Unavailable();
			PartStatus?.Unavailable();
			ProcessOccurrenceId?.Unavailable();
			ProcessTime?.Unavailable();
			User?.Unavailable();
		}
	}
}