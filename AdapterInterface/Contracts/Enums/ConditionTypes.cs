#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterInterface.DataItemTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public enum ConditionTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// {{def(ConditionEnum:ACTUATOR)}}
		/// </summary>
		ACTUATOR,
		/// <summary>
		﻿/// {{def(ConditionEnum:COMMUNICATIONS)}}
		/// </summary>
		COMMUNICATIONS,
		/// <summary>
		﻿/// {{def(ConditionEnum:DATA_RANGE)}}
		/// </summary>
		DATA_RANGE,
		/// <summary>
		﻿/// {{def(ConditionEnum:LOGIC_PROGRAM)}}
		/// </summary>
		LOGIC_PROGRAM,
		/// <summary>
		﻿/// {{def(ConditionEnum:MOTION_PROGRAM)}}
		/// </summary>
		MOTION_PROGRAM,
		/// <summary>
		﻿/// {{def(ConditionEnum:SYSTEM)}}
		/// </summary>
		SYSTEM,
	}
}