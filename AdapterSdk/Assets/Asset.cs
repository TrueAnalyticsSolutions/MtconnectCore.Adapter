using System.Xml;

namespace Mtconnect.AdapterSdk.Assets
{
    /// <summary>
    /// Abstract Asset class.
    /// </summary>
    public abstract class Asset : IAsset
    {
        /// <summary>
        /// Unique identifier of an MTConnect Asset.
        /// </summary>
        public string AssetId { set; get; }

        /// <summary>
        /// Constructs a new MTConncet Asset.
        /// </summary>
        /// <param name="id"><inheritdoc cref="AssetId" path="/summary"/></param>
        public Asset(string id)
        {
            AssetId = id;
        }

        /// <summary>
        /// Writes XML to the provided <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">Method uses this to write XML.</param>
        /// <returns>Pass-thru reference to <paramref name="writer"/>.</returns>
        public virtual XmlWriter ToXml(XmlWriter writer)
        {
            writer.WriteAttributeString("assetId", AssetId);
            return writer;
        }

        /// <summary>
        /// Generic method for getting the type of Asset.
        /// </summary>
        /// <returns>Reference to the type of MTConnect Asset type.</returns>
        public abstract string GetMTCType();
    }
}