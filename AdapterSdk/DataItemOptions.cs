using Mtconnect.AdapterSdk.Contracts;
using System;

namespace Mtconnect.AdapterSdk
{
    /// <summary>
    /// A DTO for serialized MTConnect DataItem configuration options.
    /// </summary>
    public class DataItemOptions : IDataItemOptions
    {
        /// <summary>
        /// Reference to the internal name for the DataItem.
        /// </summary>
        public string InternalName { get; }

        /// <summary>
        /// Override of the DataItem name.
        /// </summary>
        public string DataItemName { get; set; }

        /// <summary>
        /// Override of the DataItem Value. Useful for creating switches between data values.
        /// </summary>
        public Func<object, object> Formatter { get; set; }

        /// <summary>
        /// Flag for whether or not the DataItem should be published by the Adapter.
        /// </summary>
        public bool Ignore { get; set; } = true;

        /// <summary>
        /// Constructs a new <see cref="DataItemOptions"/> with the specified internal name.
        /// </summary>
        /// <param name="internalName">Reference to the internal name of a DataItem within the context of an Adapter implementation.</param>
        public DataItemOptions(string internalName)
        {
            InternalName = internalName;
        }
    }
}