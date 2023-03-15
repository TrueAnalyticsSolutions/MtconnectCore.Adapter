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
        public virtual string Category { get; set; }

        public virtual string ValueType { get; set; }

        public List<string> SubTypes { get; set; } = new List<string>();

        public AdapterValueType(string category, string valueType, MTConnectModel model, UmlEnumeration source) : base(model, source)
        {
            Category = category;
            ValueType = valueType;
        }

        public AdapterValueType(string category, string valueType, MTConnectModel model, UmlClass source) : base(model, source, source.Name)
        {
            Category = category;
            ValueType = valueType;
        }
    }
}
