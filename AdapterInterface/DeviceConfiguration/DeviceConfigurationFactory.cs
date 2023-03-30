using Mtconnect.AdapterInterface.DataItemTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Mtconnect.AdapterInterface.DeviceConfiguration
{
    /// <summary>
    /// A factory for generating <c>Devices.xml</c> configuration files for MTConnect Agent(s).
    /// </summary>
    public class DeviceConfigurationFactory
    {
        const string XmlNs_M = "urn:mtconnect.org:MTConnectDevices:{{ version }}";
        const string XmlNs_Xsi = "http://www.w3.org/2001/XMLSchema-instance";
        const string XmlNs = "urn:mtconnect.org:MTConnectDevices:{{ version }}";
        const string XsiSchemaLocation = "urn:mtconnect.org:MTConnectDevices:{{ version }} http://www.mtconnect.org/schemas/MTConnectDevices_{{ version }}.xsd";

        /// <summary>
        /// Creates a valid MTConnect <c>MTConnectDevices</c> Response Document based on the configuration of the Adapter.
        /// </summary>
        /// <param name="adapter">Reference to the adapter to build the XML from.</param>
        /// <param name="devicePrefix">Optional scope for a specific device.</param>
        /// <returns>Valid <c>MTConnectDevices</c> Response Document, aka <c>Devices.xml</c> or Device Configuration file.</returns>
        public XmlDocument Create(Adapter adapter, string devicePrefix = null)
        {
            // Get the Adapter Version, used to set namespaces
            string adapterVersion = GetMaximumMtconnectVersion(adapter);

            // Build namespaces
            XmlDocument xDoc = new XmlDocument();
            string xmlns_m = XmlNs_M.Replace("{{ version }}", adapterVersion);
            string xmlns_xsi = XmlNs_Xsi.Replace("{{ version }}", adapterVersion);
            string xmlns = XmlNs.Replace("{{ version }}", adapterVersion);
            string xsi_schemaLocation = XsiSchemaLocation.Replace("{{ version }}", adapterVersion);

            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xDoc.NameTable);
            nsmgr.AddNamespace("m", xmlns_m);
            nsmgr.AddNamespace("xsi", xmlns_xsi);

            // Build XML Declaration (<?xml ?>
            xDoc.AppendChild(xDoc.CreateXmlDeclaration("1.0", "UTF-8", "yes"));

            // Build MTConnectDevices element
            var root = xDoc.AppendChild(xDoc.CreateElement("MTConnectDevices"));
            root.Attributes.Append(xDoc.CreateAttribute("xmlns:m", XNamespace.Xmlns.ToString())).Value = xmlns_m;
            root.Attributes.Append(xDoc.CreateAttribute("xmlns:xsi", XNamespace.Xmlns.ToString())).Value = xmlns_xsi;
            root.Attributes.Append(xDoc.CreateAttribute("xmlns")).Value = xmlns;
            root.Attributes.Append(xDoc.CreateAttribute("xsi:schemaLocation", xmlns_xsi)).Value = xsi_schemaLocation;

            // Build Header element
            var header = root.AppendChild(xDoc.CreateElement("Header"));
            header.Attributes.Append(xDoc.CreateAttribute("creationTime")).Value = DateTime.UtcNow.ToString("");// TODO: Ensure this is in the proper format
            header.Attributes.Append(xDoc.CreateAttribute("sender")).Value = AppDomain.CurrentDomain.FriendlyName;
            header.Attributes.Append(xDoc.CreateAttribute("instanceId")).Value = "0"; // QUESTION: Should this be '1' to be valid?
            header.Attributes.Append(xDoc.CreateAttribute("bufferSize")).Value = "0"; // QUESTION: Should this be '1' to be valid?
            header.Attributes.Append(xDoc.CreateAttribute("version")).Value = adapterVersion;
            header.Attributes.Append(xDoc.CreateAttribute("assetBufferSize")).Value = "0"; // QUESTION: Should this be based on the memory allocation for the Adapter?
            header.Attributes.Append(xDoc.CreateAttribute("assetCount")).Value = "0"; // QUESTION: Should this be based on the memory allocation for the Adapter?

            // Build Devices element
            var devices = root.AppendChild(xDoc.CreateElement("Devices"));

            

            var dataItemsByDevice = adapter.DataItems.GroupBy(o => o.DevicePrefix).ToDictionary(g => g.Key, g => g.ToList());
            foreach (var deviceDataItems in dataItemsByDevice)
            {
                // If scoping by Device, then skip when the key doesn't match
                if (!string.IsNullOrEmpty(devicePrefix) && !devicePrefix.Equals(deviceDataItems.Key, StringComparison.OrdinalIgnoreCase))
                    continue;

                // Build Device element
                var device = devices.AppendChild(xDoc.CreateElement("Device"));
                device.Attributes.Append(xDoc.CreateAttribute("id")).Value = deviceDataItems.Key;
                // QUESTION: iso841Class was deprecated, but perhaps we should still include it in case a v1.0 Adapter is created?
                device.Attributes.Append(xDoc.CreateAttribute("iso841Class")).Value = "1";
                // TODO: Add sampleInterval as a property within the Adapter or IAdapterSource.
                device.Attributes.Append(xDoc.CreateAttribute("sampleInterval")).Value = "50";
                device.Attributes.Append(xDoc.CreateAttribute("uuid")).Value = Guid.NewGuid().ToString();
                device.Attributes.Append(xDoc.CreateAttribute("name")).Value = deviceDataItems.Key;
                
                // TODO: Source manufacturer information for the Description element

                // TODO: If IAdapterSource is used, then group DataItems by potential IAdapterDataModel implementations that represent Components.

                foreach (var deviceDataItem in deviceDataItems.Value)
                {
                    // Build DataItem element
                    var dataItem = device.AppendChild(xDoc.CreateElement("DataItem"));
                    dataItem.Attributes.Append(xDoc.CreateAttribute("id")).Value = deviceDataItem.Name;
                    dataItem.Attributes.Append(xDoc.CreateAttribute("category")).Value = deviceDataItem.Category;
                    dataItem.Attributes.Append(xDoc.CreateAttribute("type")).Value = deviceDataItem.ObservationalType;
                    if (!string.IsNullOrEmpty(deviceDataItem.ObservationalSubType))
                    {
                        dataItem.Attributes.Append(xDoc.CreateAttribute("subType")).Value = deviceDataItem.ObservationalSubType;
                    }
                    if (!string.IsNullOrEmpty(deviceDataItem.Units))
                    {
                        dataItem.Attributes.Append(xDoc.CreateAttribute("nativeUnits")).Value = deviceDataItem.Units;
                    }
                    // TODO: Determine units based on the DataItem.ObservationalType
                    // TODO: Add coordinateSystem to DataItem and/or consider adding a CoordinateSystemAttribute to be used on IAdapterDataModel
                }
            }

            return xDoc;
        }

        // TODO: Update DataItem to yield the enum of Type and SubType.
        // TODO: Update DataItem to internally manage the "Introduced" and "Deprecated" properties according to the Type/SubType
        private string GetMaximumMtconnectVersion(Adapter adapter)
        {
            return "2.2";
        }
    }

}
