using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DataItemValues;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterSdk.DataItemTypes {
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382004_482583_42267">model.mtconnect.org</seealso>
	/// <see cref="Component">Component</see> that organizes an independent operation or function within a <see cref="Controller">Controller</see>./// Description
	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public class Path : IAdapterDataModel, IComponentModel {

		/// <inheritdoc cref="Mtconnect.AdapterSdk.DataItemValues.Execution" />
		public virtual Execution Execution { get; set; }
	}
}