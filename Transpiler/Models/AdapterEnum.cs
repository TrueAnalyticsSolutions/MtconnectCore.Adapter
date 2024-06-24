using CSharpModels = MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;
using MtconnectTranspiler.Sinks.ScribanTemplates;

namespace AdapterTranspiler.Models
{
    [ScribanTemplate("Adapter.Enum.scriban")]
    public class AdapterEnum : CSharpModels.Enum
    {
        // NOTE: Only used for CATEGORY types that have subTypes.
        public Dictionary<string, string> SubTypes { get; set; } = new Dictionary<string, string>();

        // NOTE: Only used for CATEGORY types that have value enums.
        public Dictionary<string, string> ValueTypes { get; set; } = new Dictionary<string, string>();

        public AdapterEnum(XmiDocument model, XmiElement source, string name) : base(model, source, name) { }

        public AdapterEnum(XmiDocument model, UmlEnumeration source) : base(model, source) { }

        public AdapterEnum(XmiDocument model, UmlPackage source) : base(model, source) { }
    }
}
