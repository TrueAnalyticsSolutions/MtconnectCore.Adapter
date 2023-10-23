using Mtconnect.AdapterSdk.DataItems;
using System;

namespace Mtconnect.AdapterSdk.Attributes
{
    /// <summary>
    /// A decorative attribute for indicating a property intended to go thru an Adapter stream.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public abstract class DataItemAttribute : Attribute
    {
        /// <summary>
        /// <inheritdoc cref="DataItem.Name" path="/summary"/>
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// <inheritdoc cref="DataItem.Description" path="/summary"/>
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// <inheritdoc cref="DataItem.ObservationalType" path="/summary"/>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// <inheritdoc cref="DataItem.ObservationalSubType" path="/summary"/>
        /// </summary>
        public string SubType { get; set; }

        /// <summary>
        /// <inheritdoc cref="DataItem.Units" path="/summary"/>
        /// </summary>
        public string Units { get; set; }

        /// <summary>
        /// Constructs a new DataItem attribute.
        /// </summary>
        /// <param name="name"><inheritdoc cref="DataItemAttribute.Name" path="/summary"/></param>
        /// <param name="description"><inheritdoc cref="DataItemAttribute.Description" path="/summary"/></param>
        public DataItemAttribute(string name, string description = null)
        {
            Name = name;
            Description = description;
        }
    }
}
