using AdapterTranspiler.Models;
using Microsoft.Extensions.Logging;
using MtconnectTranspiler.Model;
using MtconnectTranspiler.Sinks.CSharp;
using MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Xmi.UML;
using Scriban.Runtime;

namespace AdapterTranspiler
{
    public class CategoryFunctions : ScriptObject
    {
        public static bool CategoryContainsType(AdapterEnum @enum, EnumItem item) => @enum.SubTypes.ContainsKey(item.Name);
        public static bool CategoryContainsValue(AdapterEnum @enum, EnumItem item) => @enum.ValueTypes.ContainsKey(item.Name);
        public static bool EnumHasValues(AdapterEnum @enum) => @enum.ValueTypes.Any();
    }
    internal class Transpiler : CsharpTranspiler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectPath"></param>
        public Transpiler(string projectPath, ILogger<Transpiler> logger = default) : base(projectPath, logger) { }

        public override void Transpile(MTConnectModel model, CancellationToken cancellationToken = default)
        {
            _logger?.LogInformation("Received MTConnectModel, beginning transpilation");

            Model.SetValue("model", model, true);

            TemplateContext.PushGlobal(new CategoryFunctions());

            const string DataItemNamespace = "Mtconnect.AdapterInterface.DataItemTypes";
            const string DataItemValueNamespace = "Mtconnect.AdapterInterface.DataItemValues";

            // Process DataItem Types/Sub-Types
            var dataItemTypeEnums = new List<AdapterEnum>();
            var valueEnums = new List<AdapterEnum>();
            string[] categories = new string[] { "Sample", "Event", "Condition" };

            foreach (var category in categories)
            {
                // Get the UmlPackage for the category (ie. Samples, Events, Conditions).
                var typesPackage = model
                    ?.ObservationInformationModel
                    ?.ObservationTypes
                    ?.Elements
                    ?.Where(o => o.Name == $"{category} Types")
                    ?.FirstOrDefault() as UmlPackage;
                // Get all DataItem Type and SubType references
                var allTypes = typesPackage
                    ?.Elements
                    ?.Where(o => o is UmlClass)
                    ?.Select(o => o as UmlClass);
                // Filter to get just the Type references
                var types = allTypes
                    ?.Where(o => !o.Name.Contains("."));
                // Filter and group each SubType by the relevant Type reference
                var subTypes = allTypes
                    ?.Where(o => o.Name.Contains("."))
                    ?.GroupBy(o => o.Name.Substring(0, o.Name.IndexOf(".")), o => o)
                    ?.Where(o => o.Any())
                    ?.ToDictionary(o => o.Key, o => o?.ToList());

                var categoryEnum = new AdapterEnum(model, typesPackage, $"{category}Types") { Namespace = DataItemNamespace };

                foreach (var type in types)
                {
                    // Add type to CATEGORY enum
                    categoryEnum.AddItem(model, type);

                    // Find value
                    var typeResult = type?.Properties?.FirstOrDefault(o => o.Name == "result");
                    if (typeResult != null)
                    {
                        var typeValuesSysEnum = model
                            ?.Profile
                            ?.ProfileDataTypes
                            ?.Elements
                            ?.FirstOrDefault(o => o is UmlEnumeration && o.Id == typeResult.PropertyType);
                        if (typeValuesSysEnum != null)
                        {
                            var typeValuesEnum = new AdapterEnum(model, typeValuesSysEnum as UmlEnumeration) { Namespace = DataItemValueNamespace, Name = $"{type.Name}Values" };
                            foreach (var value in typeValuesEnum.Items)
                            {
                                value.Name = value.SysML_Name;
                            }
                            if (!categoryEnum.ValueTypes.ContainsKey(type.Name)) categoryEnum.ValueTypes.Add(ScribanHelperMethods.ToUpperSnakeCode(type.Name), $"{type.Name}Values");
                            valueEnums.Add(typeValuesEnum);
                        }
                    }

                    // Add subType as enum
                    if (subTypes.ContainsKey(type.Name))
                    {
                        // Register type as having a subType in the CATEGORY enum
                        if (!categoryEnum.SubTypes.ContainsKey(type.Name)) categoryEnum.SubTypes.Add(ScribanHelperMethods.ToUpperSnakeCode(type.Name), $"{type.Name}SubTypes");

                        var subTypeEnum = new AdapterEnum(model, type, $"{type.Name}SubTypes") { Namespace = DataItemNamespace };

                        var typeSubTypes = subTypes[type.Name];
                        subTypeEnum.AddItems(model, typeSubTypes);

                        // Cleanup Enum names
                        foreach (var item in subTypeEnum.Items)
                        {
                            if (!item.Name.Contains(".")) continue;
                            item.Name = ScribanHelperMethods.ToUpperSnakeCode(item.Name.Substring(item.Name.IndexOf(".") + 1));
                        }

                        // Register the DataItem SubType Enum
                        dataItemTypeEnums.Add(subTypeEnum);
                    }
                }

                // Cleanup Enum names
                foreach (var item in categoryEnum.Items)
                {
                    item.Name = ScribanHelperMethods.ToUpperSnakeCode(item.Name);
                }

                // Register the DataItem Category Enum (ie. Samples, Events, Conditions)
                dataItemTypeEnums.Add(categoryEnum);
            }

            _logger?.LogInformation($"Processing {dataItemTypeEnums.Count} DataItem types/subTypes");

            // Process the template into enum files
            processTemplate(dataItemTypeEnums, Path.Combine(ProjectPath, "Enums"), true);
            processTemplate(valueEnums, Path.Combine(ProjectPath, "Enums"), true);
        }
    }
}
