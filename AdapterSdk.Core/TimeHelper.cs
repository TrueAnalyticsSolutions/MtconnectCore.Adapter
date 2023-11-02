using System;

namespace Mtconnect.AdapterSdk
{
    /// <summary>
    /// Helper class for dealing with Time.
    /// </summary>
    public static class TimeHelper
    {
        /// <summary>
        /// Gets the current UTC time.
        /// </summary>
        /// <returns></returns>
        public static DateTime GetNow() => DateTime.UtcNow;
    }
}