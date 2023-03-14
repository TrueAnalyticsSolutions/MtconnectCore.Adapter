using MtconnectTranspiler.Model;
using CSharpModels = MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Sinks.CSharp.Attributes;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;

namespace AdapterTranspiler.Models
{
    [ScribanTemplate("Adapter.ValueType.scriban")]
    public class AdapterValueType : CSharpModels.Enum
    {
        // NOTE: Only used for CATEGORY types that have subTypes.
        public Dictionary<string, string> SubTypes { get; set; } = new Dictionary<string, string>();

        // NOTE: Only used for CATEGORY types that have value enums.
        public Dictionary<string, string> ValueTypes { get; set; } = new Dictionary<string, string>();

        public AdapterValueType(MTConnectModel model, XmiElement source, string name) : base(model, source, name) { }

        public AdapterValueType(MTConnectModel model, UmlEnumeration source) : base(model, source) { }

        public AdapterValueType(MTConnectModel model, UmlPackage source) : base(model, source) { }

        public AdapterValueType(MTConnectModel model, MTConnectDeviceInformationModel source) : base(model, source) { }
    }
}
