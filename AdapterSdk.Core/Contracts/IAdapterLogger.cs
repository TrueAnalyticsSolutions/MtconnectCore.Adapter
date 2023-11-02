using System;

namespace Mtconnect.AdapterSdk
{
    /// <summary>
    /// Custom logging interface for Adapters
    /// </summary>
    public interface IAdapterLogger
    {
        /// <summary>
        /// Logs information messages
        /// </summary>
        /// <param name="message">Message to log</param>
        /// <param name="args">Message formatting arguments</param>
        void LogInformation(string message, params object[] args);
        /// <summary>
        /// Logs warning-level messages
        /// </summary>
        /// <param name="message">Message to log</param>
        /// <param name="args">Message formatting arguments</param>
        void LogWarning(string message, params object[] args);
        /// <summary>
        /// Logs warning-level messages
        /// </summary>
        /// <param name="exception">Exception to log</param>
        /// <param name="message">Message to log</param>
        /// <param name="args">Message formatting arguments</param>
        void LogWarning(Exception exception, string message, params object[] args);
        /// <summary>
        /// Logs error-level messages
        /// </summary>
        /// <param name="message">Message to log</param>
        /// <param name="args">Message formatting arguments</param>
        void LogError(string message, params object[] args);
        /// <summary>
        /// Logs error-level messages
        /// </summary>
        /// <param name="exception">Exception to log</param>
        /// <param name="message">Message to log</param>
        /// <param name="args">Message formatting arguments</param>
        void LogError(Exception exception, string message, params object[] args);
        /// <summary>
        /// Logs debug-level messages
        /// </summary>
        /// <param name="message">Message to log</param>
        /// <param name="args">Message formatting arguments</param>
        void LogDebug(string message, params object[] args);
        /// <summary>
        /// Logs trace-level messages
        /// </summary>
        /// <param name="message">Message to log</param>
        /// <param name="args">Message formatting arguments</param>
        void LogTrace(string message, params object[] args);
    }
}
