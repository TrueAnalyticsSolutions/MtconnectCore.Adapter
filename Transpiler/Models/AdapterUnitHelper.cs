using CSharpModels = MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Contracts;
using MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Sinks.ScribanTemplates;
using ScribanHelperMethods = MtconnectTranspiler.Sinks.CSharp.Models.ScribanHelperMethods;

namespace AdapterTranspiler.Models
{
    [ScribanTemplate("Adapter.UnitStaticHelper.scriban")]
    public class AdapterUnitHelper : CsharpType, IFileSource
    {
        const string UnitNamespace = "Mtconnect.AdapterSdk.Units";

        /// <summary>
        /// Internal reference to the class filename.
        /// </summary>
        protected string _filename { get; set; } = string.Empty;
        public string Filename
        {
            get
            {
                if (string.IsNullOrEmpty(_filename))
                    _filename = $"{Name}.cs";
                return _filename;
            }
            set { _filename = value; }
        }

        public AdapterEnum UnitsEnum { get; }

        public Dictionary<string, string?> TypeLookup { get; set; } = new Dictionary<string, string?>();

        public AdapterUnitHelper(XmiDocument model) : base(model, MTConnectHelper
                .JumpToPackage(model!, MTConnectHelper.PackageNavigationTree.Profile.DataTypes)!
                .Enumerations
                .GetByName("UnitEnum"))
        {
            Namespace = UnitNamespace;
            UnitsEnum = new AdapterEnum(model!, MTConnectHelper
                .JumpToPackage(model!, MTConnectHelper.PackageNavigationTree.Profile.DataTypes)!
                .Enumerations
                .GetByName("UnitEnum"))
            {
                Name = "MtconnectUnit",
                Namespace = UnitNamespace
            };

            foreach (var item in UnitsEnum.Items)
                item.Name = ToEnumSafe(item.SysML_Name);
        }

        public static string ToEnumSafe(string input)
            => ScribanHelperMethods.ToCodeSafe(input.Replace("/", "_PER_").Replace("^2", "_SQUARED").Replace("^3", "_CUBED"));
    }
}
