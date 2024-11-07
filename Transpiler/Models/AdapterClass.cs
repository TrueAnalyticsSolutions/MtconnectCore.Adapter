using CSharpModels = MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Xmi.UML;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Sinks.ScribanTemplates;

namespace AdapterTranspiler.Models
{
    [ScribanTemplate("Adapter.Class.scriban")]
    public class AdapterClass : CSharpModels.Class
    {
        public AdapterClass(XmiDocument model, UmlClass source) : base(model, source) { }
    }
}
