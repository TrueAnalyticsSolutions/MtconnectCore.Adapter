using Mtconnect.AdapterInterface.DeviceConfiguration;
using System;
using System.IO;
using System.Reflection;

namespace Mtconnect
{
    /// <summary>
    /// A collection of methods that return formatted commands to be issued to a MTConnect Agent. See <see href="https://github.com/mtconnect/cppagent#commands">C++ Reference Agent</see> on GitHub.
    /// </summary>
    public static class AgentCommands
    {
        /// <summary>
        /// Handles the "<c>* PONG &lt;heartbeat&gt;</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Sends the response to <c>* PING</c> with a reference to the heartbeat</returns>
        public static string Pong(double? heartbeat = null)
            => heartbeat.HasValue
                ? $"* PONG {heartbeat}"
                : "* PONG";

        /// <summary>
        /// Handles the "<c>* adapterVersion: &lt;version&gt;</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Specify the Adapter Software Version the adapter supports</returns>
        public static string AdapterVersion()
            => $"* adapterVersion: {Assembly.GetEntryAssembly()?.GetName()?.Version?.ToString()}";

        /// <summary>
        /// Handles the "<c>* calibration: XXX</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Set the calibration in the device component of the associated device</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string Calibration()
            => ThrowOrDebug("* calibration: XXX");

        /// <summary>
        /// Handles the "<c>* conversionRequired: &lt;yes|no&gt;</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Tell the agent that the data coming from this adapter requires conversion</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ConversionRequired()
            => ThrowOrDebug("* conversionRequired: no");

        /// <summary>
        /// Handles the "<c>* device: &lt;uuid|name&gt;</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Specify the default device for this adapter. The device can be specified as either the device name or UUID</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string Device()
            => ThrowOrDebug($"* device: {Guid.NewGuid()}");

        /// <summary>
        /// Handles the "<c>* description: XXX</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Set the description in the device header of the associated device</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string Description()
            => ThrowOrDebug("* description: \"TEST DESCRIPTION\"");

        /// <summary>
        /// Handles the "<c>* manufacturer: XXX</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Set the manufacturer in the device header of the associated device</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string Manufacturer()
            => ThrowOrDebug("* manufacturer: \"True Analytics Manufacturing Solutions, LLC\"");

        /// <summary>
        /// Handles the "<c>* mtconnectVersion: &lt;version&gt;</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Specify the MTConnect Version the adapter supports</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string MtconnectVersion()
            => ThrowOrDebug("* mtconnectVersion: 2.0");

        /// <summary>
        /// Handles the "<c>* nativeName: XXX</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Set the nativeName in the device component of the associated device</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string NativeName()
            => ThrowOrDebug("* nativeName: TEST");

        /// <summary>
        /// Handles the "<c>* realTime: &lt;yes|no&gt;</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Tell the agent that the data coming from this adapter would like real-time priority</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string RealTime()
            => ThrowOrDebug("* realTime: no");

        /// <summary>
        /// Handles the "<c>* relativeTime: &lt;yes|no&gt;</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Tell the agent that the data coming from this adapter is specified in relative time</returns>
        public static string RelativeTime()
            => $"* relativeTime: no";

        /// <summary>
        /// Handles the "<c>* serialNumber: XXX</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Set the serialNumber in the device header of the associated device</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string SerialNumber()
            => ThrowOrDebug($"* serialNumber: {Environment.MachineName}");

        /// <summary>
        /// Handles the "<c>* shdrVersion: &lt;version&gt;</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Specify the version of the SHDR protocol delivered by the adapter. See ShdrVersion</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ShdrVersion()
            => ThrowOrDebug("* shdrVersion: 1");

        /// <summary>
        /// Handles the "<c>* station: XXX</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Set the station in the device header of the associated device</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string Station()
            => ThrowOrDebug("* station: STATION01");

        public static string DeviceModel(Adapter adapter)
        {
            var dcf = new DeviceConfigurationFactory();
            var doc = dcf.Create(adapter);
            return ThrowOrDebug("* deviceModel: --multiline--AAAAA\r(" + doc.OuterXml + ")");
        }

        /// <summary>
        /// Formats an error message to be sent to the Agent.
        /// </summary>
        /// <param name="message">Error message to send.</param>
        /// <returns>Formatted message</returns>
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