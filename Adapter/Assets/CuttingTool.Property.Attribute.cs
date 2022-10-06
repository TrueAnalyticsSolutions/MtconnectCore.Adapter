namespace MtconnectCore.Adapter.Assets
{

    public partial class CuttingTool
    {
        public partial class Property
        {
            public class Attribute
            {
                public string Name { set; get; }
                public string Value { set; get; }

                public Attribute(string name, string value)
                {
                    Name = name; Value = value;
                }
            }
        }
    }
}
