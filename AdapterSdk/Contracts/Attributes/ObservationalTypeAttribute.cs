using System;

namespace Mtconnect.AdapterSdk.Contracts.Attributes
{
    /// <summary>
    /// An attribute used to indicate that an enum value that represents an observational type also has relevant type(s).
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ObservationalTypeAttribute : Attribute
    {
        /// <summary>
        /// Reference to the enum for the type.
        /// </summary>
        public Type TypeEnum { get; set; }

        /// <summary>
        /// Constructs a new <see cref="ObservationalTypeAttribute"/>.
        /// </summary>
        /// <param name="typeEnum">Reference to the Enum type of the DataItem Type</param>
        public ObservationalTypeAttribute(Type typeEnum)
        {
            TypeEnum = typeEnum;
        }
    }
}
