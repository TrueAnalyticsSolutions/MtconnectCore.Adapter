using Mtconnect.AdapterSdk.DataItems;
using System;

namespace Mtconnect.AdapterSdk.Attributes
{
    /// <summary>
    /// A decorative attribute for indicating a class intended to set the <see cref="DataItem.DevicePrefix"/> of each <see cref="DataItem"/> in a <see cref="IAdapterDataModel"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
    public class DeviceIdAttribute : Attribute
    {
        /// <inheritdoc cref="DataItem.DevicePrefix"/>
        public string Id { get; }

        /// <summary>
        /// Constructs a new instance of a <see cref="DeviceIdAttribute"/>
        /// </summary>
        /// <param name="id"><inheritdoc cref="Id" path="/summary"/></param>
        public DeviceIdAttribute(string id)
        {
            Id = id;
        }
    }
}
