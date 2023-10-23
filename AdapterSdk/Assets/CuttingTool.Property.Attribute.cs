namespace Mtconnect.AdapterSdk.Assets
{
    public partial class CuttingTool
    {
        public partial class Property
        {
            /// <summary>
            /// Represents a generic attribute of a Cutting Tool property.
            /// </summary>
            public class Attribute
            {
                /// <summary>
                /// Key for the attribute.
                /// </summary>
                public string Name { set; get; }

                /// <summary>
                /// Value for the attribute.
                /// </summary>
                public string Value { set; get; }

                /// <summary>
                /// Constructs a new Property Attribute.
                /// </summary>
                /// <param name="name"><inheritdoc cref="Name" path="/summary"/></param>
                /// <param name="value"><inheritdoc cref="Value" path="/summary"/></param>
                public Attribute(string name, string value)
                {
                    Name = name; Value = value;
                }
            }
        }
    }
}
