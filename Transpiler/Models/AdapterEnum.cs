using MtconnectTranspiler.Model;
using CSharpModels = MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Sinks.CSharp.Attributes;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;

namespace AdapterTranspiler.Models
{
    [ScribanTemplate("Adapter.Enum.scriban")]
    public class AdapterEnum : CSharpModels.Enum
    {
        /// <summary>
        /// Reference to the xmi:id
        /// </summary>
        public string ReferenceId { get; set; }

        // NOTE: Only used for CATEGORY types that have subTypes.
        public Dictionary<string, string> SubTypes { get; set; } = new Dictionary<string, string>();

        // NOTE: Only used for CATEGORY types that have value enums.
        public Dictionary<string, string> ValueTypes { get; set; } = new Dictionary<string, string>();

        public AdapterEnum(MTConnectModel model, XmiElement source, string name) : base(model, source, name) { }

        public AdapterEnum(MTConnectModel model, UmlEnumeration source) : base(model, source) { }

        public AdapterEnum(MTConnectModel model, UmlPackage source) : base(model, source) { }

        public AdapterEnum(MTConnectModel model, MTConnectDeviceInformationModel source) : base(model, source) { }
    }
}
