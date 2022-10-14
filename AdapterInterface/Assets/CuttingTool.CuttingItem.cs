using System.Xml;
using System.Collections.Generic;


namespace Mtconnect.AdapterInterface.Assets
{

    public partial class CuttingTool
    {
        /// <summary>
        /// A cutting item
        /// </summary>
        public class CuttingItem
        {
            /// <summary>
            /// Collection of generic properties for the Cutting Item.
            /// </summary>
            protected HashSet<Property> Properties = new HashSet<Property>();

            /// <summary>
            /// Collection of measurement values for the Cutting Item.
            /// </summary>
            protected HashSet<Measurement> Measurements = new HashSet<Measurement>();

            /// <summary>
            /// The number(s) representing the individual Cutting Item(s) on the tool.
            /// </summary>
            public string Indices { set; get; }

            /// <summary>
            /// The manufacturer identifier of this Cutting Item.
            /// </summary>
            public string ItemId { set; get; }

            /// <summary>
            /// The material composition for this Cutting Item.
            /// </summary>
            public string Grade { set; get; }

            /// <summary>
            /// The manufacturer(s) of the Cutting Item or Tool.
            /// </summary>
            public string Manufacturers { set; get; }

            /// <summary>
            /// A free-form description of the Cutting Item.
            /// </summary>
            public string Description { set; get; }

            /// <summary>
            /// Create a cutting item with identity info
            /// </summary>
            /// <param name="indices"><inheritdoc cref="Indices" path="/summary"/></param>
            /// <param name="id"><inheritdoc cref="ItemId" path="/summary"/></param>
            /// <param name="grade"><inheritdoc cref="Grade" path="/summary"/></param>
            /// <param name="manufacturers"><inheritdoc cref="Manufacturers" path="/summary"/></param>
            public CuttingItem(string indices, string id = null, string grade = null, string manufacturers = null)
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
                Properties.Add(property);
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
                Properties.Add(property);
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
            public Measurement AddMeasurement(
                string name,
                string code,
                double value = CT_NULL,
                double nominal = CT_NULL,
                double min = CT_NULL,
                double max = CT_NULL,
                string native = null,
                string units = null)
            {
                Measurement meas = new Measurement(name, code, value, nominal, min, max, native, units);
                Measurements.Add(meas);
                return meas;
            }

            /// <summary>
            /// Add a life of the Cutting Item.
            /// </summary>
            /// <param name="type"><inheritdoc cref="LifeType" path="/summary"/></param>
            /// <param name="direction">Indicates if the tool life counts from zero to maximum or maximum to zero.</param>
            /// <param name="value">Current value for tool life</param>
            /// <param name="initial">The initial life of the tool when it is new.</param>
            /// <param name="limit">The end of life limit for this tool.</param>
            /// <param name="warning">The point at which a tool life warning will be raised.</param>
            /// <returns></returns>
            public Property AddLife(
                LifeType type,
                Direction direction,
                string value = null,
                string initial = null,
                string limit = null,
                string warning = null)
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
                Properties.Add(life);
                return life;
            }

            /// <inheritdoc cref="Asset.ToXml(XmlWriter)"/>
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

                    foreach (Property prop in Properties)
                        prop.ToXml(writer);

                    if (Measurements.Count > 0)
                    {
                        writer.WriteStartElement("Measurements");
                            foreach (Measurement meas in Measurements)
                                meas.ToXml(writer);
                        writer.WriteEndElement();
                    }
                writer.WriteEndElement();

                return writer;
            }
        }
    }
}
