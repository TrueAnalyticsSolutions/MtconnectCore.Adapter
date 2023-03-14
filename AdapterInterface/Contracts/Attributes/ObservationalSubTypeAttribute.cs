using System;

namespace Mtconnect.AdapterInterface.Contracts.Attributes
{

    /// <summary>
    /// An attribute used to indicate that an enum value that represents an observational type also has relevant sub-type(s).
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class ObservationalSubTypeAttribute : Attribute
    {
        /// <summary>
        /// Reference to the enum for the subtype.
        /// </summary>
        public Type SubTypeEnum { get; set; }

        public ObservationalSubTypeAttribute(Type subTypeEnum)
        {
            SubTypeEnum = subTypeEnum;
        }
    }
}
