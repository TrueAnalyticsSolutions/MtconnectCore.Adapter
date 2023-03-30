using CSharpModels = MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Sinks.CSharp.Attributes;
using MtconnectTranspiler.Xmi.UML;
using MtconnectTranspiler.Xmi;

namespace AdapterTranspiler.Models
{
    [ScribanTemplate("Adapter.Class.scriban")]
    public class AdapterClass : CSharpModels.Class
    {
        public AdapterClass(XmiDocument model, UmlClass source) : base(model, source) { }
    }
}
