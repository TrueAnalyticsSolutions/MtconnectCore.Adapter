#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItems;
using Mtconnect.AdapterInterface.DataItemValues;

namespace Mtconnect.AdapterInterface.DataItemValues
{
	/// <summary>
	/// A value type for WaitState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1581143980612_724749_76">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class WaitState : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the WaitState EVENT Data Item.
		/// </summary>
        public WaitState(string value) : base(value) { }

        /// <summary>
		﻿/// execution is waiting while the equipment is powering up and is not currently available to begin producing parts or products.
        /// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState POWERING_UP => new WaitState(nameof(WaitStateValues.POWERING_UP));
        /// <summary>
		﻿/// execution is waiting while the equipment is powering down but has not fully reached a stopped state.
        /// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState POWERING_DOWN => new WaitState(nameof(WaitStateValues.POWERING_DOWN));
        /// <summary>
		﻿/// execution is waiting while one or more discrete workpieces are being loaded.
        /// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState PART_LOAD => new WaitState(nameof(WaitStateValues.PART_LOAD));
        /// <summary>
		﻿/// execution is waiting while one or more discrete workpieces are being unloaded.
        /// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState PART_UNLOAD => new WaitState(nameof(WaitStateValues.PART_UNLOAD));
        /// <summary>
		﻿/// execution is waiting while a tool or tooling is being loaded.
        /// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState TOOL_LOAD => new WaitState(nameof(WaitStateValues.TOOL_LOAD));
        /// <summary>
		﻿/// execution is waiting while a tool or tooling is being unloaded.
        /// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState TOOL_UNLOAD => new WaitState(nameof(WaitStateValues.TOOL_UNLOAD));
        /// <summary>
		﻿/// execution is waiting while material is being loaded.
        /// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState MATERIAL_LOAD => new WaitState(nameof(WaitStateValues.MATERIAL_LOAD));
        /// <summary>
		﻿/// execution is waiting while material is being unloaded.
        /// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState MATERIAL_UNLOAD => new WaitState(nameof(WaitStateValues.MATERIAL_UNLOAD));
        /// <summary>
		﻿/// execution is waiting while another process is completed before the execution can resume.
        /// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState SECONDARY_PROCESS => new WaitState(nameof(WaitStateValues.SECONDARY_PROCESS));
        /// <summary>
		﻿/// execution is waiting while the equipment is pausing but the piece of equipment has not yet reached a fully paused state.
        /// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState PAUSING => new WaitState(nameof(WaitStateValues.PAUSING));
        /// <summary>
		﻿/// execution is waiting while the equipment is resuming the production cycle but has not yet resumed execution.
        /// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalValue(typeof(WaitStateValues))]
        public static WaitState RESUMING => new WaitState(nameof(WaitStateValues.RESUMING));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="WaitState"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="WaitState"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="WaitState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator WaitState(string value)
            => new WaitState(value.ToUpperInvariant());
		
    }
}