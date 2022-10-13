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

            public string Name { set; get; }
            public string Value { set; get; }
            public ArrayList mAttributes;

            public Property(string name, Attribute[] arguments = null, string value = null)
            {
                Name = name;
                Value = value;
                if (arguments != null)
                {
                    mAttributes = new ArrayList();
                    mAttributes = new ArrayList(arguments);
                }
            }

            public Property(string name, string[] arguments, string value = "")
            {
                Name = name;
                if (arguments != null)
                {
                    mAttributes = new ArrayList();
                    for (int i = 0; i < arguments.Length; i += 2)
                        mAttributes.Add(new Attribute(arguments[i], arguments[i + 1]));
                }
                Value = value;
            }

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
                if (mAttributes == null) mAttributes = new ArrayList();
                mAttributes.Add(argument);
            }

            public override bool Equals(object obj)
            {
                if (obj is Property)
                    return Name.Equals(((Property)obj).Name);
                else
                    return Name.Equals(obj);
            }

            public override int GetHashCode()
            {
                return Name.GetHashCode();
            }

            public virtual XmlWriter ToXml(XmlWriter writer)
            {
                writer.WriteStartElement(Name);

                if (mAttributes != null)
                {
                    foreach (Attribute arg in mAttributes)
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
