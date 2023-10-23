using System;

namespace Mtconnect.AdapterSdk.Attributes
{
    /// <summary>
    /// Attribute indicating the <see cref="Enum"/> listing the possible Values for the attached Field
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class ObservationalValueAttribute : Attribute
    {
        /// <summary>
        /// Reference to the remote <see cref="Enum"/>
        /// </summary>
        public Type ValueEnum { get; set; }

        /// <summary>
        /// Constructs a new instance of this attribute.
        /// </summary>
        /// <param name="valueEnum"><inheritdoc cref="ValueEnum" path="/summary"/></param>
        public ObservationalValueAttribute(Type valueEnum)
        {
            ValueEnum = valueEnum;
        }
    }
}
