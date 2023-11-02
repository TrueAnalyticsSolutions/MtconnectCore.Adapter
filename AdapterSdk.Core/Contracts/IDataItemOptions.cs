using System;

namespace Mtconnect.AdapterSdk
{
    /// <summary>
    /// A DTO for serialized MTConnect DataItem configuration options.
    /// </summary>
    public interface IDataItemOptions
    {
        /// <summary>
        /// Reference to the internal name for the DataItem.
        /// </summary>
        string InternalName { get; }

        /// <summary>
        /// Override of the DataItem name.
        /// </summary>
        string DataItemName { get; set; }

        /// <summary>
        /// Override of the DataItem Value. Useful for creating switches between data values.
        /// </summary>
        Func<object, object> Formatter { get; set; }

        /// <summary>
        /// Flag for whether or not the DataItem should be published by the Adapter.
        /// </summary>
        bool Ignore { get; set; }
    }
}
