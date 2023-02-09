using System;
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
            => _throwOrDebug("* calibration: XXX");

        /// <summary>
        /// Handles the "<c>* conversionRequired: &lt;yes|no&gt;</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Tell the agent that the data coming from this adapter requires conversion</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ConversionRequired()
            => _throwOrDebug("* conversionRequired: no");

        /// <summary>
        /// Handles the "<c>* device: &lt;uuid|name&gt;</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Specify the default device for this adapter. The device can be specified as either the device name or UUID</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string Device()
            => _throwOrDebug($"* device: {Guid.NewGuid()}");

        /// <summary>
        /// Handles the "<c>* description: XXX</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Set the description in the device header of the associated device</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string Description()
            => _throwOrDebug("* description: \"TEST DESCRIPTION\"");

        /// <summary>
        /// Handles the "<c>* manufacturer: XXX</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Set the manufacturer in the device header of the associated device</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string Manufacturer()
            => _throwOrDebug("* manufacturer: \"True Analytics Manufacturing Solutions, LLC\"");

        /// <summary>
        /// Handles the "<c>* mtconnectVersion: &lt;version&gt;</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Specify the MTConnect Version the adapter supports</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string MtconnectVersion()
            => _throwOrDebug("* mtconnectVersion: 2.0");

        /// <summary>
        /// Handles the "<c>* nativeName: XXX</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Set the nativeName in the device component of the associated device</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string NativeName()
            => _throwOrDebug("* nativeName: TEST");

        /// <summary>
        /// Handles the "<c>* realTime: &lt;yes|no&gt;</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Tell the agent that the data coming from this adapter would like real-time priority</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string RealTime()
            => _throwOrDebug("* realTime: no");

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
            => _throwOrDebug($"* serialNumber: {Environment.MachineName}");

        /// <summary>
        /// Handles the "<c>* shdrVersion: &lt;version&gt;</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Specify the version of the SHDR protocol delivered by the adapter. See <see cref="">ShdrVersion</see></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ShdrVersion()
            => _throwOrDebug("* shdrVersion: 1");

        /// <summary>
        /// Handles the "<c>* station: XXX</c>" command to the MTConnect Agent
        /// </summary>
        /// <returns>Set the station in the device header of the associated device</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string Station()
            => _throwOrDebug("* station: STATION01");


        public static string Error(string message) => $"* error: {message}";

        private static string _throwOrDebug(string message = null)
        {
#if !DEBUG
            throw new NotImplementedException();
#else
            return message;
#endif
        }
    }
}