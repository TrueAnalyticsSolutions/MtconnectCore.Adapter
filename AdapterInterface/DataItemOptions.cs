using System;

namespace Mtconnect.AdapterInterface
{
    public class DataItemOptions
    {
        public string InternalName { get; }

        public string DataItemName { get; set; }

        public Func<object, object> Formatter { get; set; }

        public DataItemOptions(string internalName)
        {
            InternalName = internalName;
        }
    }
}