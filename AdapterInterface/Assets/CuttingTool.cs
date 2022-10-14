using System;
using System.Xml;
using System.Collections;
using System.Collections.Generic;


namespace Mtconnect.AdapterInterface.Assets
{

    /// <summary>
    /// An abstraction around an XML Generator for a cutting tool asset
    /// </summary>
    public partial class CuttingTool : Asset
    {
        internal const double CT_NULL = Double.NaN;

        /// <summary>
        /// Unique identifier of the instance of this tool.
        /// </summary>
        public string SerialNumber { set; get; }

        /// <summary>
        /// Identifier for a class of Cutting Tools.
        /// </summary>
        public string ToolId { set; get; }

        /// <summary>
        /// This can contain configuration information and manufacturer specific details.
        /// </summary>
        public string Description { set; get; }

        /// <summary>
        /// Referring to the manufacturer(s) of this Cutting Tool.
        /// </summary>
        public string Manufacturers { set; get; }

        /// <summary>
        /// Collection of generic properties for the Cutting Tool.
        /// </summary>
        protected HashSet<Property> Properties = new HashSet<Property>();

        /// <summary>
        /// Collection of measurement values for the Cutting Tool.
        /// </summary>
        protected HashSet<Measurement> Measurements = new HashSet<Measurement>();

        /// <summary>
        /// Collection of Cutting Items that make up the Cutting Tool.
        /// </summary>
        protected ArrayList Items = new ArrayList();

        /// <summary>
        /// Creates a new cutting tool asset
        /// </summary>
        /// <param name="assetId"><inheritdoc cref="Asset.AssetId" path="/summary"/></param>
        /// <param name="toolId"><inheritdoc cref="ToolId" path="/summary"/></param>
        /// <param name="serialNumber"><inheritdoc cref="SerialNumber" path="/summary"/></param>
        public CuttingTool(string assetId, string toolId, string serialNumber) : base(assetId)
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
            Properties.Add(property);
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
        /// Add the list of current status to the cutting tool
        /// </summary>
        /// <param name="status">A string array of status</param>
        /// <returns></returns>
        public CutterStatus AddStatus(string[] status)
        {
            CutterStatus cs = new CutterStatus(status);
            Properties.Add(cs);
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
            Measurements.Add(meas);
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
            Properties.Add(life);
            return life;
        }

        /// <summary>
        /// Adds a cutting item
        /// </summary>
        /// <param name="item">The cutting item</param>
        public void AddItem(CuttingItem item)
        {
            Items.Add(item);
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
                    foreach (Property prop in Properties)
                        prop.ToXml(writer);
                    if (Measurements.Count > 0)
                    {
                        writer.WriteStartElement("Measurements");
                            foreach (Measurement meas in Measurements)
                                meas.ToXml(writer);
                        writer.WriteEndElement();
                    }

                    if (Items.Count > 0)
                    {
                        writer.WriteStartElement("CuttingItems");
                            foreach (CuttingItem item in Items)
                                item.ToXml(writer);
                        writer.WriteEndElement();
                    }
                writer.WriteEndElement();
            writer.WriteEndElement();

            return writer;
        }
    }
}
