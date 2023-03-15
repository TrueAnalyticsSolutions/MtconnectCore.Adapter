using MtconnectTranspiler.Model;
using CSharpModels = MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Sinks.CSharp.Attributes;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;

namespace AdapterTranspiler.Models
{
    [ScribanTemplate("Adapter.ValueType.scriban")]
    public class AdapterEventValueType : AdapterValueType
    {
        public override string Category { get; set; } = "Event";

        public override string ValueType { get; set; } = "string";

        public AdapterEventValueType(MTConnectModel model, UmlEnumeration source) : base("Event", "string", model, source) { }

        public AdapterEventValueType(MTConnectModel model, UmlClass source) : base("Event", "string", model, source) { }
    }
}
