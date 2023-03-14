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
            if (model == null)
                throw new ArgumentNullException(nameof(model), "MTConnect model cannot be null");

            _logger?.LogInformation("Received MTConnectModel, beginning transpilation");

            Model.SetValue("model", model, true);

            TemplateContext.PushGlobal(new CategoryFunctions());

            const string DataItemNamespace = "Mtconnect.AdapterInterface.DataItemTypes";
            const string DataItemValueNamespace = "Mtconnect.AdapterInterface.DataItemValues";

            // Process DataItem Types/Sub-Types
            var dataItemTypeEnums = new List<AdapterEnum>();
            var valueEnums = new List<AdapterEnum>();
            string[] categories = new string[] { "Sample", "Event", "Condition" };

            foreach (string category in categories)
            {
                // Get the UmlPackage for the category (ie. Samples, Events, Conditions).
                var typesPackage = model
                    ?.ObservationInformationModel
                    ?.ObservationTypes
                    ?.Elements
                    ?.Where(o => o.Name == $"{category} Types")
                    ?.FirstOrDefault() as UmlPackage
                    ?? throw new NullReferenceException($"Cannot find {category} package type");

                // Get all DataItem Type and SubType references
                var allTypes = typesPackage
                    ?.Elements
                    ?.Where(o => o is UmlClass)
                    ?.Select(o => o as UmlClass)
                    ?.Where(o => o != null)
                    ?? Enumerable.Empty<UmlClass>();
                // Filter to get just the Type references
                var types = (allTypes
                    ?.Where(o => !o!.Name.Contains('.')))
                    ?? throw new NullReferenceException($"Cannot find {category} root types");

                // Filter and group each SubType by the relevant Type reference
                var subTypes = (allTypes
                    ?.Where(o => o!.Name.Contains('.'))
                    ?.GroupBy(o => o!.Name[..o.Name.IndexOf(".")], o => o)
                    ?.Where(o => o.Any())
                    ?.ToDictionary(o => o.Key, o => o.ToList()))
                    ?? throw new NullReferenceException($"Cannot find {category} sub types");

                var categoryEnum = new AdapterEnum(model!, typesPackage!, $"{category}Types") { Namespace = DataItemNamespace };

                foreach (UmlClass type in types)
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
                            ?.FirstOrDefault(o => o is UmlEnumeration && o.Id == typeResult.PropertyType) as UmlEnumeration;
                        if (typeValuesSysEnum != null)
                        {
                            var typeValuesEnum = new AdapterEnum(model!, typeValuesSysEnum) { Namespace = DataItemValueNamespace, Name = $"{type!.Name}Values" };
                            foreach (EnumItem value in typeValuesEnum.Items)
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

                        AdapterEnum subTypeEnum = new(model!, type, $"{type.Name}SubTypes") { Namespace = DataItemNamespace };

                        List<UmlClass?>? typeSubTypes = subTypes[type.Name];
                        subTypeEnum.AddItems(model, typeSubTypes);

                        // Cleanup Enum names
                        foreach (EnumItem item in subTypeEnum.Items)
                        {
                            if (!item.Name.Contains('.')) continue;
                            item.Name = ScribanHelperMethods.ToUpperSnakeCode(item.Name[(item.Name.IndexOf(".") + 1)..]);
                        }

                        // Register the DataItem SubType Enum
                        dataItemTypeEnums.Add(subTypeEnum);
                    }
                }

                // Cleanup Enum names
                foreach (EnumItem item in categoryEnum.Items)
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
