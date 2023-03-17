#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterInterface.DataItemValues
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1581143980612_724749_76">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public enum WaitStateValues
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// execution is waiting while the equipment is powering up and is not currently available to begin producing parts or products.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		POWERING_UP,
		/// <summary>
		﻿/// execution is waiting while the equipment is powering down but has not fully reached a stopped state.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		POWERING_DOWN,
		/// <summary>
		﻿/// execution is waiting while one or more discrete workpieces are being loaded.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		PART_LOAD,
		/// <summary>
		﻿/// execution is waiting while one or more discrete workpieces are being unloaded.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		PART_UNLOAD,
		/// <summary>
		﻿/// execution is waiting while a tool or tooling is being loaded.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		TOOL_LOAD,
		/// <summary>
		﻿/// execution is waiting while a tool or tooling is being unloaded.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		TOOL_UNLOAD,
		/// <summary>
		﻿/// execution is waiting while material is being loaded.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		MATERIAL_LOAD,
		/// <summary>
		﻿/// execution is waiting while material is being unloaded.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		MATERIAL_UNLOAD,
		/// <summary>
		﻿/// execution is waiting while another process is completed before the execution can resume.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		SECONDARY_PROCESS,
		/// <summary>
		﻿/// execution is waiting while the equipment is pausing but the piece of equipment has not yet reached a fully paused state.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		PAUSING,
		/// <summary>
		﻿/// execution is waiting while the equipment is resuming the production cycle but has not yet resumed execution.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		RESUMING,
	}
}