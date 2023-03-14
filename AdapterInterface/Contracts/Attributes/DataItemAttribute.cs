using Mtconnect.AdapterInterface.DataItems;
using System;

namespace Mtconnect.AdapterInterface.Contracts.Attributes
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
        public string Type { get; }

        /// <summary>
        /// <inheritdoc cref="DataItem.ObservationalSubType" path="/summary"/>
        /// </summary>
        public string SubType { get; }

        /// <summary>
        /// Constructs a new DataItem attribute.
        /// </summary>
        /// <param name="name"><inheritdoc cref="DataItemAttribute.Name" path="/summary"/></param>
        /// <param name="description"><inheritdoc cref="DataItemAttribute.Description" path="/summary"/></param>
        /// <param name="type"><inheritdoc cref="DataItemAttribute.Type" path="/summary"/></param>
        /// <param name="subtype"><inheritdoc cref="DataItemAttribute.SubType" path="/summary"/></param>
        public DataItemAttribute(string name, string description = null, string type = null, string subtype = null)
        {
            Name = name;
            Description = description;
            Type = type;
            SubType = subtype;
        }
    }
}
