using System;
using System.Xml;

namespace Mtconnect.AdapterInterface.Assets
{
    /// <summary>
    /// Abstract Asset class.
    /// </summary>
    public abstract class Asset
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

        public abstract string GetMTCType();
    }
}