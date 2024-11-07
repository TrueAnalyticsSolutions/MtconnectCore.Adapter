using MtconnectTranspiler.Sinks.ScribanTemplates;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;

namespace AdapterTranspiler.Models
{
    [ScribanTemplate("Adapter.ValueType.scriban")]
    public class AdapterEventValueType : AdapterValueType
    {
        public override string Category { get; set; } = "Event";

        public override string ValueType { get; set; } = "string";

        public AdapterEventValueType(XmiDocument model, UmlEnumeration source) : base("Event", "string", model, source) { }

        public AdapterEventValueType(XmiDocument model, UmlClass source) : base("Event", "string", model, source) { }
    }
}
