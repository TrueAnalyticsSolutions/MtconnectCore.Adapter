using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DeviceConfiguration;
using System;
using System.Net.NetworkInformation;
using System.Reflection;

namespace Mtconnect
{
    /// <summary>
    /// A collection of methods that return formatted responses to commands issued from a MTConnect Agent.
    /// </summary>
    public static class AdapterCommands
    {
        /// <summary>
        /// Determines the appropriate response to the provided <paramref name="message"/>.
        /// </summary>
        /// <param name="adapter">Reference to the Adapter implementation.</param>
        /// <param name="message">Reference to the command issued from the MTConnect Agent.</param>
        /// <returns>Formatted response to the command issued by the MTConnect Agent. If the command was not recognized, then the response string is empty.</returns>
        public static string GetResponse(this IAdapter adapter, string message)
        {
            const string PING = "* PING";
            const string GET_DATAITEMS = "* dataItems";
            const string GET_DATAITEM_VALUE = "* dataItem: ";
            const string GET_DATAITEM_DESCRIPTION = "* dataItemDescription: ";
            const string GET_DEVICE_MODEL = "* deviceModel";

            message = message?.Trim();
            if (message.StartsWith(PING, StringComparison.OrdinalIgnoreCase))
            {
                return AdapterCommands.Ping(adapter);
            }
            else if (message.Equals(GET_DATAITEMS, StringComparison.OrdinalIgnoreCase))
            {
                return AdapterCommands.DataItems(adapter);
            }
            else if (message.StartsWith(GET_DATAITEM_DESCRIPTION, StringComparison.OrdinalIgnoreCase))
            {
                return AdapterCommands.DataItemDescription(adapter, message);
            }
            else if (message.StartsWith(GET_DATAITEM_VALUE, StringComparison.OrdinalIgnoreCase))
            {
                return AdapterCommands.DataItem(adapter, message);
            } else if (message.StartsWith(GET_DEVICE_MODEL, StringComparison.OrdinalIgnoreCase))
            {
                return AdapterCommands.DeviceModel(adapter, message);
            }

            return string.Empty;
        }

        /// <summary>
        /// Handles the "<c>* PONG &lt;heartbeat&gt;</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Informs the agent of all dataItems that can be published by the adapter</returns>
        public static string Ping(IAdapter adapter)
            => AgentCommands.Pong(adapter.Heartbeat);

        /// <summary>
        /// Handles the "<c>* dataItems: XXX</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Informs the agent of all dataItems that can be published by the adapter</returns>
        public static string DataItems(IAdapter adapter)
            => $"* dataItems: {string.Join("|", adapter.GetDataItemNames())}";

        /// <summary>
        /// Handles the "<c>* dataItemDescription: XXX</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Informs the agent of the DataItem description, if any, for the provided DataItem name</returns>
        public static string DataItemDescription(IAdapter adapter, string message)
        {
            string dataItemName = message.Remove(0, message.LastIndexOf(' ') + 1);
            if (!adapter.Contains(dataItemName))
            {
                return AgentCommands.Error($"Cannot find DataItem '{dataItemName}'");
            }

            if (string.IsNullOrEmpty(adapter[dataItemName].Description))
            {
                return AgentCommands.Error($"No description available for DataItem '{dataItemName}'");
            }

            return $"* dataItemDescription: {adapter[dataItemName].Description}";
        }

        /// <summary>
        /// Handles the "<c>* dataItem: XXX</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Informs the agent of the current value for the provided DataItem</returns>
        public static string DataItem(IAdapter adapter, string message)
        {
            string dataItemName = message.Remove(0, message.LastIndexOf(' ') + 1);
            if (!adapter.Contains(dataItemName))
            {
                return AgentCommands.Error($"Cannot find DataItem '{dataItemName}'");
            }
            return $"* dataItem: {adapter[dataItemName]}";
        }

        /// <summary>
        /// Handles the "<c>* configuration: XXX</c>" command from the MTConnect Agent
        /// </summary>
        /// <param name="adapter">Reference to the Adapter</param>
        /// <param name="message">Optional name of the device to scope the configuration to.</param>
        /// <returns>Provides the Agent with a <c>MTConnectDevices</c> Response Document for the DataItem defined in the Adapter.</returns>
        public static string DeviceModel(IAdapter adapter, string message)
        {
            string deviceName = null;
            if (message.Contains(":"))
                deviceName = message.Remove(0, message.LastIndexOf(':') + 1).Trim();

            return AgentCommands.DeviceModel(adapter);
        }
    }
}