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
	public enum HardnessSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		ROCKWELL,
		/// <summary>
		﻿/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		VICKERS,
		/// <summary>
		﻿/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		SHORE,
		/// <summary>
		﻿/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		BRINELL,
		/// <summary>
		﻿/// scale to measure the elasticity of a surface.
		/// </summary>
		LEEB,
		/// <summary>
		﻿/// scale to measure the resistance to scratching of a surface.
		/// </summary>
		MOHS,
	}
}