using System;
using System.Collections.Generic;
using System.Text;

namespace Mtconnect.AdapterInterface.Contracts.Attributes
{
    /// <summary>
    /// A decorative attribute for indicating a property intended to go thru an Adapter stream.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public abstract class DataItemAttribute : Attribute
    {
        /// <summary>
        /// The key for the MTConnect DataItem.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Constructs a new DataItem attribute.
        /// </summary>
        /// <param name="name">Key for the MTConnect DataItem.</param>
        public DataItemAttribute(string name)
        {
            Name = name;
        }
    }
}
