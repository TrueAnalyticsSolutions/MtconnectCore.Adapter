using MtconnectTranspiler.Model;
using CSharpModels = MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Sinks.CSharp.Attributes;
using MtconnectTranspiler.Xmi.UML;

namespace AdapterTranspiler.Models
{
    [ScribanTemplate("Adapter.ComponentInterface.scriban")]
    public class AdapterComponentInterface : CSharpModels.Class
    {
        public List<UmlClass> SubComponents { get; set; } = new List<UmlClass>();

        public List<UmlClass> DataItems { get; set; } = new List<UmlClass>();

        public AdapterComponentInterface(MTConnectModel model, UmlClass source) : base(model, source)
        {
            var componentTypes = model.DeviceModel.SubModels
                .FirstOrDefault(o => o.Name == "Components")
                .SubModels
                .FirstOrDefault(o => o.Name == "Component Types");
            var dataItems = model.ObservationInformationModel
                    .ObservationTypes
                    .Elements
                    .Where(o => o is UmlPackage)
                    .Select(o => o as UmlPackage)
                    .SelectMany(o => o.Elements)
                    .Where(o => o is UmlClass)
                    .Select(o => o as UmlClass);
            foreach (var property in source.Properties)
            {
                var dataItem = dataItems
                    .Where(o => o.Id == property.PropertyType)
                    .FirstOrDefault();
                if (dataItem != null)
                {
                    DataItems.Add(dataItem);
                } else
                {
                    var subComponent = componentTypes.Classes.FirstOrDefault(o => o.Id == property.PropertyType);
                    if (subComponent != null)
                    {
                        SubComponents.Add(subComponent);
                    }
                }
            }
        }
    }
}
