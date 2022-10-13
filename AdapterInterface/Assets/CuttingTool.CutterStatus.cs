using System.Xml;
using System.Collections.Generic;


namespace Mtconnect.AdapterInterface.Assets
{

    public partial class CuttingTool
    {
        /// <summary>
        /// A property representing the cutter status
        /// </summary>
        public class CutterStatus : Property
        {
            public HashSet<string> mStatus;

            public CutterStatus(string[] status) : base("CutterStatus")
            {
                mStatus = new HashSet<string>();
                foreach (string s in status)
                    mStatus.Add(s);
            }

            /// <summary>
            /// Add a status
            /// </summary>
            /// <param name="s">The status to add</param>
            public void Add(string s)
            {
                mStatus.Add(s);
            }

            /// <summary>
            /// Remove a status
            /// </summary>
            /// <param name="s">The status to remove</param>
            public void Remove(string s)
            {
                mStatus.Remove(s);
            }

            /// <summary>
            /// Generate the xml for the status
            /// </summary>
            /// <param name="writer">The generator</param>
            /// <returns>The writer</returns>
            public override XmlWriter ToXml(XmlWriter writer)
            {
                writer.WriteStartElement(Name);

                foreach (string s in mStatus)
                    writer.WriteElementString("Status", s);

                writer.WriteEndElement();

                return writer;
            }
        }
    }
}
