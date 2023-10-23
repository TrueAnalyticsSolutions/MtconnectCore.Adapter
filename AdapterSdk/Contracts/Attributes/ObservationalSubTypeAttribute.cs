using System;

namespace Mtconnect.AdapterSdk.Attributes
{
    /// <summary>
    /// An attribute used to indicate that an enum value that represents an observational type also has relevant sub-type(s).
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class ObservationalSubTypeAttribute : Attribute
    {
        /// <summary>
        /// Reference to the enum for the subtype.
        /// </summary>
        public Type SubTypeEnum { get; set; }

        /// <summary>
        /// Constructs a new <see cref="ObservationalSubTypeAttribute"/>.
        /// </summary>
        /// <param name="subTypeEnum">Reference to the Enum type of the DataItem SubType</param>
        public ObservationalSubTypeAttribute(Type subTypeEnum)
        {
            SubTypeEnum = subTypeEnum;
        }
    }
}
