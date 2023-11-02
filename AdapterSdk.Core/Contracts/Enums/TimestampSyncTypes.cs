namespace Mtconnect.AdapterSdk
{
    /// <summary>
    /// Indicates the methodology used for ensuring the DateTime is accurate to standards.
    /// </summary>
    public enum TimestampSyncTypes
    {
        /// <summary>
        /// The methodology for time synchronization is not known.
        /// </summary>
        Unknown = -1,
        /// <summary>
        /// Indicates that no time synchronization is used for a timestamp.
        /// </summary>
        None = 0,
        /// <summary>
        /// <see href="https://en.wikipedia.org/wiki/Network_Time_Protocol">Network Time Protocol</see>, uses a hierarchical architecture with a small number of highly accurate references clocks at the top and large number of less accurate clocks at the bottom. NTP clients use the NTP protocol to synchronize their clocks with the closest NTP server.
        /// </summary>
        NTP,
        /// <summary>
        /// <see href="https://en.wikipedia.org/wiki/Precision_Time_Protocol">Precision Time Protocol</see>, designed specifically for industrial and scientific application where high precision time synchronization is required. PTP operates over Ethernet networks and uses a master-slave architecture to synchronize clocks.
        /// </summary>
        PTP,
        /// <summary>
        /// <see href="https://en.wikipedia.org/wiki/Global_Positioning_System#Timekeeping">Global Positioning System</see> is a satellite-based navigation system that can be used for time synchronization in some situations. GPS receivers use the timing signals from GPS satellites to synchronize their clocks.
        /// </summary>
        GPS,
        /// <summary>
        /// <see href="https://en.wikipedia.org/wiki/DCF77">Deutsche Funkturm</see> is a longwave time signal service transmitted from a radio transmitter located in Frankfurt, Germany. DCF77 can be used for time synchronization in Europe.
        /// </summary>
        DCF77
    }
}
