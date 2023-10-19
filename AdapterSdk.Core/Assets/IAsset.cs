using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Mtconnect.AdapterSdk.Assets
{
    /// <summary>
    /// Abstract Asset class.
    /// </summary>
    public interface IAsset
    {
        /// <summary>
        /// Unique identifier of an MTConnect Asset.
        /// </summary>
        string AssetId { set; get; }

        /// <summary>
        /// Writes XML to the provided <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">Method uses this to write XML.</param>
        /// <returns>Pass-thru reference to <paramref name="writer"/>.</returns>
        XmlWriter ToXml(XmlWriter writer);

        /// <summary>
        /// Generic method for getting the type of Asset.
        /// </summary>
        /// <returns>Reference to the type of MTConnect Asset type.</returns>
        string GetMTCType();
    }
}
