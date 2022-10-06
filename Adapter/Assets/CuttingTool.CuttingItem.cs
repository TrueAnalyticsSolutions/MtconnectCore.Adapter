using System.Xml;
using System.Collections.Generic;


namespace MtconnectCore.Adapter.Assets
{

    public partial class CuttingTool
    {
        /// <summary>
        /// A cutting item
        /// </summary>
        public class CuttingItem
        {
            protected HashSet<Property> mProperties = new HashSet<Property>();
            protected HashSet<Measurement> mMeasurements = new HashSet<Measurement>();

            public string Indices { set; get; }
            public string ItemId { set; get; }
            public string Grade { set; get; }
            public string Manufacturers { set; get; }
            public string Description { set; get; }
            
            /// <summary>
            /// Create a cutting item with identity info
            /// </summary>
            /// <param name="indices">The index range</param>
            /// <param name="id">The id (if indices are not used)</param>
            /// <param name="grade">The cutting item material grade</param>
            /// <param name="manufacturers">The manufacturers of this item</param>
            public CuttingItem(string indices, string id = null, string grade = null,
                string manufacturers = null)
            {
                Indices = indices;
                ItemId = id;
                Grade = grade;
                Manufacturers = manufacturers;
            }

            /// <summary>
            /// Add a property to the cutting tool
            /// </summary>
            /// <param name="name">Name of the property</param>
            /// <param name="arguments">Attributes</param>
            /// <param name="value">The CData value</param>
            /// <returns></returns>
            public Property AddProperty(string name, string[] arguments, string value = null)
            {
                Property property = new Property(name, arguments, value);
                mProperties.Add(property);
                return property;
            }

            /// <summary>
            /// Add a simple property to the item
            /// </summary>
            /// <param name="name">The name of the property</param>
            /// <param name="value">The value</param>
            /// <returns></returns>
            public Property AddProperty(string name, string value)
            {
                Property property = new Property(name,  value);
                mProperties.Add(property);
                return property;
            }

            /// <summary>
            /// Add a measurement to the cutting item
            /// </summary>
            /// <param name="name">The name of the measurement</param>
            /// <param name="code">The ISO 13399 code</param>
            /// <param name="value">The value for the measurement</param>
            /// <param name="nominal">The nominal value</param>
            /// <param name="min">The minimum constraint</param>
            /// <param name="max">The maximum constraint</param>
            /// <param name="native">The native units</param>
            /// <param name="units">Must be the standard units</param>
            /// <returns>The measurement</returns>
            public Measurement AddMeasurement(string name, string code,
                    double value = CT_NULL, double nominal = CT_NULL,
                    double min = CT_NULL, double max = CT_NULL,
                    string native = null, string units = null)
            {
                Measurement meas = new Measurement(name, code, value, nominal, min, max, native, units);
                mMeasurements.Add(meas);
                return meas;
            }

            public Property AddLife(LifeType type, Direction direction, string value = null,
                                    string initial = null,
                                    string limit = null, string warning = null)
            {
                Property life = new Property("ItemLife");
                life.Value = value;
                life.AddAttribute(new Property.Attribute("type", type.ToString()));
                life.AddAttribute(new Property.Attribute("countDirection", direction.ToString()));
                if (initial != null)
                    life.AddAttribute(new Property.Attribute("initial", initial));
                if (limit != null)
                    life.AddAttribute(new Property.Attribute("limit", limit));
                if (warning != null)
                    life.AddAttribute(new Property.Attribute("warning", warning));
                mProperties.Add(life);
                return life;
            }

            public XmlWriter ToXml(XmlWriter writer)
            {
                writer.WriteStartElement("CuttingItem");
                    writer.WriteAttributeString("indices", Indices);
                    if (ItemId != null)
                        writer.WriteAttributeString("itemId", ItemId);
                    if (Grade != null)
                        writer.WriteAttributeString("grade", Grade);
                    if (Manufacturers != null)
                        writer.WriteAttributeString("manufacturers", Manufacturers);
                    
                    if (Description != null)
                        writer.WriteElementString("Description", Description);

                    foreach (Property prop in mProperties)
                        prop.ToXml(writer);

                    if (mMeasurements.Count > 0)
                    {
                        writer.WriteStartElement("Measurements");
                            foreach (Measurement meas in mMeasurements)
                                meas.ToXml(writer);
                        writer.WriteEndElement();
                    }
                writer.WriteEndElement();

                return writer;
            }
        }
    }
}
