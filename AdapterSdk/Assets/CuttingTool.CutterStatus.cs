using System.Xml;
using System.Collections.Generic;


namespace Mtconnect.AdapterSdk.Assets
{

    public partial class CuttingTool
    {
        /// <summary>
        /// A property representing the cutter status
        /// </summary>
        public class CutterStatus : Property
        {
            /// <summary>
            /// The status of the Cutting Tool.
            /// </summary>
            public HashSet<string> Status;

            /// <summary>
            /// Constructs a new CutterStatus reference.
            /// </summary>
            /// <param name="status"><inheritdoc cref="Status" path="/summary"/></param>
            public CutterStatus(string[] status) : base("CutterStatus")
            {
                Status = new HashSet<string>();
                foreach (string s in status)
                    Status.Add(s);
            }

            /// <summary>
            /// Add a status
            /// </summary>
            /// <param name="s">The status to add</param>
            public void Add(string s)
            {
                Status.Add(s);
            }

            /// <summary>
            /// Remove a status
            /// </summary>
            /// <param name="s">The status to remove</param>
            public void Remove(string s)
            {
                Status.Remove(s);
            }

            /// <summary>
            /// Generate the xml for the status
            /// </summary>
            /// <param name="writer">The generator</param>
            /// <returns>The writer</returns>
            public override XmlWriter ToXml(XmlWriter writer)
            {
                writer.WriteStartElement(Name);

                foreach (string s in Status)
                    writer.WriteElementString("Status", s);

                writer.WriteEndElement();

                return writer;
            }
        }
    }
}
