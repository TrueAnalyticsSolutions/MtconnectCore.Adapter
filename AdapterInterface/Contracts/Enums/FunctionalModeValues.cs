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
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public enum FunctionalModeValues
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// <see cref="Component">Component</see> is currently producing product, ready to produce product, or its current intended use is to be producing product.
		/// </summary>
		PRODUCTION,
		/// <summary>
		﻿/// <see cref="Component">Component</see> is not currently producing product.   It is being prepared or modified to begin production of product.
		/// </summary>
		SETUP,
		/// <summary>
		﻿/// <see cref="Component">Component</see> is not currently producing product.  Typically, it has completed the production of a product and is being modified or returned to a neutral state such that it may then be prepared to begin production of a different product.
		/// </summary>
		TEARDOWN,
		/// <summary>
		﻿/// <see cref="Component">Component</see> is not currently producing product.  It is currently being repaired, waiting to be repaired, or has not yet been returned to a normal production status after maintenance has been performed.
		/// </summary>
		MAINTENANCE,
		/// <summary>
		﻿/// <see cref="Component">Component</see> is being used to prove-out a new process, testing of equipment or processes, or any other active use that does not result in the production of product.
		/// </summary>
		PROCESS_DEVELOPMENT,
	}
}