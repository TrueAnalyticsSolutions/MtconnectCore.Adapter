using CSharpModels = MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;
using MtconnectTranspiler.Sinks.ScribanTemplates;

namespace AdapterTranspiler.Models
{
    [ScribanTemplate("Adapter.ValueType.scriban")]
    public class AdapterValueType : CSharpModels.Enum
    {
        public virtual string Category { get; set; }

        public virtual string ValueType { get; set; }

        public virtual string ExpectedUnits { get; set; } = string.Empty;

        public List<string> SubTypes { get; set; } = new List<string>();

        public AdapterValueType(string category, string valueType, XmiDocument model, UmlEnumeration source) : base(model, source)
        {
            Category = category;
            ValueType = valueType;
        }

        public AdapterValueType(string category, string valueType, XmiDocument model, XmiElement source) : base(model, source, source.Name)
        {
            Category = category;
            ValueType = valueType;
        }
    }
}
