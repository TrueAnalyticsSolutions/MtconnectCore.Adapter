using System;

namespace Mtconnect.AdapterInterface.Contracts.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class ObservationalValueAttribute : Attribute
    {
        public Type ValueEnum { get; set; }

        public ObservationalValueAttribute(Type valueEnum)
        {
            ValueEnum = valueEnum;
        }
    }
}
