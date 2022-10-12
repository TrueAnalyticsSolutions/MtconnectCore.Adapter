using System;
using System.Xml;
using System.Collections;
using System.Collections.Generic;


namespace MtconnectCore.AdapterInterface.Assets
{

    /// <summary>
    /// An abstraction around an XML Generator for a cutting tool asset
    /// </summary>
    public partial class CuttingTool : Asset
    {
        public const double CT_NULL = Double.NaN;

        public string SerialNumber { set; get; }
        public string ToolId { set; get; }
        public string Description { set; get; }
        public string Manufacturers { set; get; }

        protected HashSet<Property> mProperties = new HashSet<Property>();
        protected HashSet<Measurement> mMeasurements = new HashSet<Measurement>();
        protected ArrayList mItems = new ArrayList();

        /// <summary>
        /// Creates a new cutting tool asset
        /// </summary>
        /// <param name="assetId">The asset id</param>
        /// <param name="toolId">The tool id</param>
        /// <param name="serialNumber">The serial number of the tool</param>
        public CuttingTool(string assetId, string toolId, string serialNumber)
            : base(assetId)
        {
            ToolId = toolId;
            SerialNumber = serialNumber;
        }

        /// <summary>
        /// The MTConnect Asset Type.
        /// </summary>
        /// <returns>CuttingTool</returns>
        public override string GetMTCType()
        {
            return "CuttingTool";
        }

        /// <summary>
        /// Create a simple attribute
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static Property.Attribute CreateAttribute(string name, string value)
        {
            return new Property.Attribute(name, value);
        }

        /// <summary>
        /// Add a property to the cutting tool
        /// </summary>
        /// <param name="property">The property</param>
        public void AddProperty(Property property)
        {
            mProperties.Add(property);
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
        /// Add the list of current status to the cutting tool
        /// </summary>
        /// <param name="status">A string array of status</param>
        /// <returns></returns>
        public CutterStatus AddStatus(string[] status)
        {
            CutterStatus cs = new CutterStatus(status);
            mProperties.Add(cs);
            return cs;
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

        /// <summary>
        /// Add the tool life
        /// </summary>
        /// <param name="type">MINUTES, PART_COUNT, or WEAR</param>
        /// <param name="direction">UP or DOWN</param>
        /// <param name="value">The current value</param>
        /// <param name="initial">The initial value for the range</param>
        /// <param name="limit">The limit</param>
        /// <param name="warning">A point where there will be a warning</param>
        /// <returns>The life property</returns>
        public Property AddLife(LifeType type, Direction direction, string value = null,
                                string initial = null,
                                string limit = null, string warning = null)
        {
            Property life = new Property("ToolLife");
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

        /// <summary>
        /// Adds a cutting item
        /// </summary>
        /// <param name="item">The cutting item</param>
        public void AddItem(CuttingItem item)
        {
            mItems.Add(item);
        }

        /// <summary>
        /// Generate XML
        /// </summary>
        /// <param name="writer">The XML writer used to generate</param>
        /// <returns>The writer</returns>
        public override XmlWriter ToXml(XmlWriter writer)
        {
            writer.WriteStartElement("CuttingTool");
                writer.WriteAttributeString("toolId", ToolId);
                writer.WriteAttributeString("serialNumber", SerialNumber);
                if (Manufacturers != null)
                    writer.WriteAttributeString("manufactures", Manufacturers);
                base.ToXml(writer);

                writer.WriteElementString("Description", Description);

                writer.WriteStartElement("CuttingToolLifeCycle");
                    foreach (Property prop in mProperties)
                        prop.ToXml(writer);
                    if (mMeasurements.Count > 0)
                    {
                        writer.WriteStartElement("Measurements");
                            foreach (Measurement meas in mMeasurements)
                                meas.ToXml(writer);
                        writer.WriteEndElement();
                    }

                    if (mItems.Count > 0)
                    {
                        writer.WriteStartElement("CuttingItems");
                            foreach (CuttingItem item in mItems)
                                item.ToXml(writer);
                        writer.WriteEndElement();
                    }
                writer.WriteEndElement();
            writer.WriteEndElement();

            return writer;
        }
    }
}
