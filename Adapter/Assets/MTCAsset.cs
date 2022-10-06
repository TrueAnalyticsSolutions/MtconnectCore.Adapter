using System;
using System.Xml;

namespace MtconnectCore.Adapter.Assets
{
    /// <summary>
    /// Abstract Asset class.
    /// </summary>
    abstract public class Asset
    {
        public string AssetId { set; get; }

        public Asset(string id)
        {
            AssetId = id;
        }

        public virtual XmlWriter ToXml(XmlWriter writer)
        {
            writer.WriteAttributeString("assetId", AssetId);
            return writer;
        }

        abstract public string GetMTCType();
    }
}