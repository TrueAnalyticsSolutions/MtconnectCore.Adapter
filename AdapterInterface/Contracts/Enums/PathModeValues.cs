#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterInterface.DataItemValues
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public enum PathModeValues
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// path is operating independently and without the influence of another path.
		/// </summary>
		INDEPENDENT,
		/// <summary>
		﻿/// path provides information or state values that influences the operation of other <see cref="DataItem">DataItem</see> of similar type.
		/// </summary>
		MASTER,
		/// <summary>
		﻿/// physical or logical parts which are not physically connected to each other but are operating together.
		/// </summary>
		SYNCHRONOUS,
		/// <summary>
		﻿/// axes associated with the path are mirroring the motion of the <c>MASTER</c> path.
		/// </summary>
		MIRROR,
	}
}