#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk.Contracts.Attributes;
using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.DataItemValues;
using Mtconnect.AdapterSdk.Units;

namespace Mtconnect.AdapterSdk.DataItemValues
{
	/// <summary>
	/// A value type for Application to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class Application : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.APPLICATION);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the Application EVENT Data Item.
		/// </summary>
        public Application(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="Application"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="Application"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="Application"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Application(string value)
            => new Application(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Application" />.
		/// </summary>
		public partial class VERSION : Application
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ApplicationSubTypes.VERSION);

			/// <summary>
			/// Constructs a new value type for VERSION.
			/// </summary>
            public VERSION(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="VERSION"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="VERSION"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="VERSION"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator VERSION(string value)
				=> new VERSION(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Application" />.
		/// </summary>
		public partial class RELEASEDATE : Application
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ApplicationSubTypes.RELEASE_DATE);

			/// <summary>
			/// Constructs a new value type for RELEASE_DATE.
			/// </summary>
            public RELEASEDATE(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="RELEASEDATE"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="RELEASEDATE"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="RELEASEDATE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator RELEASEDATE(string value)
				=> new RELEASEDATE(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Application" />.
		/// </summary>
		public partial class MANUFACTURER : Application
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ApplicationSubTypes.MANUFACTURER);

			/// <summary>
			/// Constructs a new value type for MANUFACTURER.
			/// </summary>
            public MANUFACTURER(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="MANUFACTURER"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="MANUFACTURER"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="MANUFACTURER"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator MANUFACTURER(string value)
				=> new MANUFACTURER(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Application" />.
		/// </summary>
		public partial class LICENSE : Application
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ApplicationSubTypes.LICENSE);

			/// <summary>
			/// Constructs a new value type for LICENSE.
			/// </summary>
            public LICENSE(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="LICENSE"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="LICENSE"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="LICENSE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator LICENSE(string value)
				=> new LICENSE(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Application" />.
		/// </summary>
		public partial class INSTALLDATE : Application
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ApplicationSubTypes.INSTALL_DATE);

			/// <summary>
			/// Constructs a new value type for INSTALL_DATE.
			/// </summary>
            public INSTALLDATE(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="INSTALLDATE"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="INSTALLDATE"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="INSTALLDATE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator INSTALLDATE(string value)
				=> new INSTALLDATE(value.ToUpperInvariant());
		}
    }
}