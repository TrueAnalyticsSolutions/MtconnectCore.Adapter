using CSharpModels = MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Xmi.UML;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Sinks.ScribanTemplates;

namespace AdapterTranspiler.Models
{
    [ScribanTemplate("Adapter.ComponentInterface.scriban")]
    public class AdapterComponentInterface : CSharpModels.Class
    {
        public UmlClass? ParentComponent { get; set; } = null;

        public List<UmlClass> SubComponents { get; set; } = new List<UmlClass>();

        public List<UmlClass> DataItems { get; set; } = new List<UmlClass>();

        public AdapterComponentInterface(XmiDocument model, UmlClass source) : base(model, source)
        {
            var componentTypes = MTConnectHelper
                .JumpToPackage(model!, MTConnectHelper.PackageNavigationTree.DeviceInformationModel.Components.ComponentTypes);
            var dataItems = MTConnectHelper
                .JumpToPackage(model!, MTConnectHelper.PackageNavigationTree.ObservationInformationModel.ObservationTypes)?
                .Packages
                .SelectMany(o => o.Classes)
                .Where(o => o != null);
            if (source.Properties != null)
            {
                foreach (var property in source.Properties)
                {
                    var dataItem = dataItems?
                        .Where(o => o.Id == property.PropertyType)
                        .FirstOrDefault();
                    if (dataItem != null)
                    {
                        DataItems.Add(dataItem);
                    }
                    else
                    {
                        var subComponent = componentTypes?.Classes.FirstOrDefault(o => o.Id == property.PropertyType);
                        if (subComponent != null)
                        {
                            SubComponents.Add(subComponent);
                        }
                    }
                }
            }

            // Check for parent
            var parentComponent = componentTypes?.Classes.FirstOrDefault(o => o.Id == source.Generalization?.General);
            if (parentComponent != null)
                ParentComponent = parentComponent;

            // Check generalization
            var generalizations = componentTypes?.Classes.Where(o => o.Generalization?.General == source.Id).ToList();
            if (generalizations?.Count > 0)
            {
                foreach (var generalization in generalizations)
                {
                    SubComponents.Add(generalization);
                }
            }
        }
    }
}
