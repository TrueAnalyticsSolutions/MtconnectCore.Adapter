using Microsoft.Extensions.Logging;
using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DeviceConfiguration;
using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace Mtconnect
{
    /// <summary>
    /// A collection of methods that return formatted commands to be issued to a MTConnect Agent. See <see href="https://github.com/mtconnect/cppagent#commands">C++ Reference Agent</see> on GitHub.
    /// </summary>
    public static class AgentCommands
    {
        /// <summary>
        /// Creates the "<c>* PONG &lt;heartbeat&gt;</c>" MTConnect Agent command
        /// </summary>
        /// <param name="heartbeat">The expected timeout for connections</param>
        /// <returns>(<c>string</c>) MTConnect Agent Command</returns>
        public static string Pong(double? heartbeat = null)
            => heartbeat.HasValue
                ? $"* PONG {heartbeat}"
                : "* PONG";

        /// <summary>
        /// Creates the "<c>* adapterVersion: &lt;version&gt;</c>" MTConnect Agent command
        /// </summary>
        /// <remarks>
        /// Specify the Adapter Software Version the adapter supports.
        /// See <seealso href="https://mtcup.org/en/Protocol#commands">MTCup</seealso> site.
        /// </remarks>
        /// <returns>(<c>string</c>) MTConnect Agent Command</returns>
        public static string AdapterVersion()
            => $"* adapterVersion: {Assembly.GetEntryAssembly()?.GetName()?.Version?.ToString()}";

        /// <summary>
        /// Creates the "<c>* calibration: XXX</c>" MTConnect Agent command
        /// </summary>
        /// <remarks>
        /// Set the calibration in the device component of the associated device.
        /// See <seealso href="https://mtcup.org/en/Protocol#commands">MTCup</seealso> site.
        /// </remarks>
        /// <returns>(<c>string</c>) MTConnect Agent Command</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string Calibration()
            => ThrowOrDebug("* calibration: XXX");

        /// <summary>
        /// Creates the "<c>* conversionRequired: &lt;yes|no&gt;</c>" MTConnect Agent command
        /// </summary>
        /// <remarks>
        /// Tell the agent that the data coming from this adapter requires conversion.
        /// See <seealso href="https://mtcup.org/en/Protocol#commands">MTCup</seealso> site.
        /// </remarks>
        /// <returns>(<c>string</c>) MTConnect Agent Command</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ConversionRequired()
            => ThrowOrDebug("* conversionRequired: no");

        /// <summary>
        /// Creates the "<c>* device: &lt;uuid|name&gt;</c>" MTConnect Agent command
        /// </summary>
        /// <remarks>
        /// Specify the default device for this adapter. The device can be specified as either the device name or UUID.
        /// See <seealso href="https://mtcup.org/en/Protocol#commands">MTCup</seealso> site.
        /// </remarks>
        /// <param name="adapter">Reference to the adapter expected to send the command</param>
        /// <returns>(<c>string</c>) MTConnect Agent Command</returns>
        public static string DeviceUuid(IAdapter adapter)
        {
            return "* device: " + adapter?.DeviceUUID ?? Guid.NewGuid().ToString();
        }

        /// <inheritdoc cref="DeviceUuid(IAdapter)"/>
        public static string DeviceName(IAdapter adapter, string devicePrefix = null)
        {
            return "* device: " + devicePrefix ?? adapter?.DeviceName;
        }

        /// <summary>
        /// Creates the "<c>* deviceModel: &lt;Multiline XML&gt;</c>" MTConnect Agent command
        /// </summary>
        /// <remarks>
        /// 
        /// See <seealso href="https://mtcup.org/en/Protocol#commands">MTCup</seealso> site.
        /// </remarks>
        /// <param name="adapter">Reference to the adapter expected to send the command</param>
        /// <param name="devicePrefix">Optional scope for a specific device prefix, if different than <see cref="IAdapter.DeviceUUID"/></param>
        /// <returns>(<c>string</c>) MTConnect Agent Command</returns>
        public static string DeviceModel(IAdapter adapter, string devicePrefix = null)
        {
            if (adapter == null)
            {
                var nrException = new ArgumentNullException("Adapter cannot be null when trying to generate a device configuration");
                adapter?._logger?.LogError(nrException, nrException.ToString());
                return null;
            }

            // XPath = /MTConnectDevices/Devices/Device[1]
            string xml = DeviceModelFactory.ToString(adapter, devicePrefix, "//*[local-name()='Device']");
            if (!string.IsNullOrEmpty(xml))
            {
                return "* deviceModel: --multiline--AAAAA\n" + xml + "\n--multiline--AAAAA";
            }
            return null;
        }

        /// <summary>
        /// Creates the "<c>* description: XXX</c>" MTConnect Agent command
        /// </summary>
        /// <remarks>
        /// Set the description in the device header of the associated device.
        /// See <seealso href="https://mtcup.org/en/Protocol#commands">MTCup</seealso> site.
        /// </remarks>
        /// <returns>(<c>string</c>) MTConnect Agent Command</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string Description()
            => ThrowOrDebug("* description: \"TEST DESCRIPTION\"");

        /// <summary>
        /// Creates the "<c>* manufacturer: XXX</c>" MTConnect Agent command
        /// </summary>
        /// <remarks>
        /// Set the manufacturer in the device header of the associated device.
        /// See <seealso href="https://mtcup.org/en/Protocol#commands">MTCup</seealso> site.
        /// </remarks>
        /// <param name="adapter">Reference to the adapter expected to send the command</param>
        /// <returns>(<c>string</c>) MTConnect Agent Command</returns>
        public static string Manufacturer(IAdapter adapter)
            => !string.IsNullOrEmpty(adapter?.Manufacturer)
                ? "* manufacturer: " + adapter.Manufacturer
                : null;

        /// <summary>
        /// Creates the "<c>* mtconnectVersion: &lt;version&gt;</c>" MTConnect Agent command
        /// </summary>
        /// <remarks>
        /// Specify the MTConnect Version the adapter supports.
        /// See <seealso href="https://mtcup.org/en/Protocol#commands">MTCup</seealso> site.
        /// </remarks>
        /// <param name="adapter">Reference to the adapter expected to send the command</param>
        /// <param name="devicePrefix">Optional scope for a specific device prefix, if different than <see cref="Adapter.DeviceUUID"/></param>
        /// <returns>(<c>string</c>) MTConnect Agent Command</returns>
        public static string MtconnectVersion(IAdapter adapter, string devicePrefix = null)
        {
            if (adapter == null)
            {
                var nrException = new ArgumentNullException("Adapter cannot be null when trying to generate a device configuration");
                adapter?._logger?.LogError(nrException, nrException.ToString());
                return null;
            }

            string version = DeviceModelFactory.GetMaximumMtconnectVersion(adapter, devicePrefix);
            if (!string.IsNullOrEmpty(version))
            {
                return "* mtconnectVersion: " + version;
            }
            return null;
        }

        /// <summary>
        /// Creates the "<c>* nativeName: XXX</c>" MTConnect Agent command
        /// </summary>
        /// <remarks>
        /// Set the nativeName in the device component of the associated device.
        /// See <seealso href="https://mtcup.org/en/Protocol#commands">MTCup</seealso> site.
        /// </remarks>
        /// <returns>(<c>string</c>) MTConnect Agent Command</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string NativeName()
            => ThrowOrDebug("* nativeName: TEST");

        /// <summary>
        /// Creates the "<c>* realTime: &lt;yes|no&gt;</c>" MTConnect Agent command
        /// </summary>
        /// <remarks>
        /// Tell the agent that the data coming from this adapter would like real-time priority.
        /// See <seealso href="https://mtcup.org/en/Protocol#commands">MTCup</seealso> site.
        /// </remarks>
        /// <returns>(<c>string</c>) MTConnect Agent Command</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string RealTime()
            => ThrowOrDebug("* realTime: no");

        /// <summary>
        /// Creates the "<c>* relativeTime: &lt;yes|no&gt;</c>" MTConnect Agent command
        /// </summary>
        /// <remarks>
        /// Tell the agent that the data coming from this adapter is specified in relative time.
        /// See <seealso href="https://mtcup.org/en/Protocol#commands">MTCup</seealso> site.
        /// </remarks>
        /// <returns>(<c>string</c>) MTConnect Agent Command</returns>
        public static string RelativeTime()
            => $"* relativeTime: no";

        /// <summary>
        /// Creates the "<c>* serialNumber: XXX</c>" MTConnect Agent command
        /// </summary>
        /// <remarks>
        /// Set the serialNumber in the device header of the associated device.
        /// See <seealso href="https://mtcup.org/en/Protocol#commands">MTCup</seealso> site.
        /// </remarks>
        /// <param name="adapter">Reference to the adapter expected to send the command</param>
        /// <returns>(<c>string</c>) MTConnect Agent Command</returns>
        public static string SerialNumber(IAdapter adapter)
            => !string.IsNullOrEmpty(adapter?.SerialNumber)
                ? "* serialNumber: " + adapter.SerialNumber
                : null;

        /// <summary>
        /// Creates the "<c>* shdrVersion: &lt;version&gt;</c>" MTConnect Agent command
        /// </summary>
        /// <remarks>
        /// Specify the version of the SHDR protocol delivered by the adapter.
        /// See <seealso href="https://mtcup.org/en/Protocol#commands">MTCup</seealso> site.
        /// </remarks>
        /// <returns>(<c>string</c>) MTConnect Agent Command</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ShdrVersion()
            => ThrowOrDebug("* shdrVersion: 1");

        /// <summary>
        /// Creates the "<c>* station: XXX</c>" MTConnect Agent command
        /// </summary>
        /// <remarks>
        /// Set the station in the device header of the associated device.
        /// See <seealso href="https://mtcup.org/en/Protocol#commands">MTCup</seealso> site.
        /// </remarks>
        /// <param name="adapter">Reference to the adapter expected to send the command</param>
        /// <returns>(<c>string</c>) MTConnect Agent Command</returns>
        public static string Station(IAdapter adapter)
            => !string.IsNullOrEmpty(adapter?.StationId)
                ? "* station: " + adapter.StationId
                : null;

        /// <summary>
        /// Creates an error message to be sent to the Agent.
        /// </summary>
        /// <remarks>
        /// This command is not recognized by the Agent, but should be logged as a warning in the Agent's logs.
        /// </remarks>
        /// <param name="message">Error message to send.</param>
        /// <returns>(<c>string</c>) MTConnect Agent Command</returns>
        public static string Error(string message) => $"* error: {message}";

        private static string ThrowOrDebug(string message = null)
        {
#if !DEBUG
            throw new NotImplementedException();
#else
            return message;
#endif
        }
    }

}