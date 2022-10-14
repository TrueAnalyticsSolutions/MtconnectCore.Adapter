using System.Xml;
using System.Collections;


namespace Mtconnect.AdapterInterface.Assets
{

    public partial class CuttingTool
    {
        /// <summary>
        /// A cutting tool or cutting item property.
        /// </summary>
        public partial class Property
        {
            /// <summary>
            /// Key for the Property.
            /// </summary>
            public string Name { set; get; }

            /// <summary>
            /// Value for the Property.
            /// </summary>
            public string Value { set; get; }

            /// <summary>
            /// Collection of generic attributes for the Property.
            /// </summary>
            public ArrayList Attributes;

            /// <summary>
            /// Constructs a new Cutting Tool Property.
            /// </summary>
            /// <param name="name"><inheritdoc cref="Name" path="/summary"/></param>
            /// <param name="arguments"><inheritdoc cref="Attributes" path="/summary"/></param>
            /// <param name="value"><inheritdoc cref="Value" path="/summary"/></param>
            public Property(string name, Attribute[] arguments = null, string value = null)
            {
                Name = name;
                Value = value;
                if (arguments != null)
                {
                    Attributes = new ArrayList();
                    Attributes = new ArrayList(arguments);
                }
            }

            /// <summary>
            /// Constructs a new Cutting Tool Property.
            /// </summary>
            /// <param name="name"><inheritdoc cref="Name" path="/summary"/></param>
            /// <param name="arguments"><inheritdoc cref="Attributes" path="/summary"/></param>
            /// <param name="value"><inheritdoc cref="Value" path="/summary"/></param>
            public Property(string name, string[] arguments, string value = "")
            {
                Name = name;
                if (arguments != null)
                {
                    Attributes = new ArrayList();
                    for (int i = 0; i < arguments.Length; i += 2)
                        Attributes.Add(new Attribute(arguments[i], arguments[i + 1]));
                }
                Value = value;
            }

            /// <summary>
            /// Constructs a new Cutting Tool Property.
            /// </summary>
            /// <param name="name"><inheritdoc cref="Name" path="/summary"/></param>
            /// <param name="value"><inheritdoc cref="Value" path="/summary"/></param>
            public Property(string name, string value)
            {
                Name = name;
                Value = value;
            }

            /// <summary>
            /// Add a argument to this property
            /// </summary>
            /// <param name="argument">The argumnet</param>
            public void AddAttribute(Attribute argument)
            {
                if (Attributes == null) Attributes = new ArrayList();
                Attributes.Add(argument);
            }

            /// <inheritdoc />
            public override bool Equals(object obj)
            {
                if (obj is Property)
                    return Name.Equals(((Property)obj).Name);
                else
                    return Name.Equals(obj);
            }

            /// <inheritdoc />
            public override int GetHashCode()
            {
                return Name.GetHashCode();
            }

            /// <inheritdoc cref="CuttingTool.ToXml(XmlWriter)" />
            public virtual XmlWriter ToXml(XmlWriter writer)
            {
                writer.WriteStartElement(Name);

                if (Attributes != null)
                {
                    foreach (Attribute arg in Attributes)
                    {
                        writer.WriteAttributeString(arg.Name, arg.Value);
                    }
                }

                if (Value != null)
                    writer.WriteValue(Value);

                writer.WriteEndElement();

                return writer;
            }
        }
    }
}
