using MtconnectTranspiler.Model;
using CSharpModels = MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Sinks.CSharp.Attributes;
using MtconnectTranspiler.Xmi.UML;

namespace AdapterTranspiler.Models
{
    [ScribanTemplate("Adapter.Class.scriban")]
    public class AdapterClass : CSharpModels.Class
    {
        public AdapterClass(MTConnectModel model, UmlClass source) : base(model, source) { }
    }
}
