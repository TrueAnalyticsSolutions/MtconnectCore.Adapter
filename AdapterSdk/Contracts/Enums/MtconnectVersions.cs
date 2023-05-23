namespace Mtconnect.AdapterSdk.Contracts
{
    /// <summary>
    /// Options for supported MTConnect Standard versions.
    /// </summary>
    public enum MtconnectVersions
    {
        /// <summary>
        /// Version 1.0.1
        /// </summary>
        /// <remarks>Prepared on: October 2, 2009</remarks>
        V_1_0_1 = 1 << 0,
        /// <summary>
        /// Version 1.1.0
        /// </summary>
        /// <remarks>Prepared on: April 30, 2010</remarks>
        V_1_1_0 = 1 << 1,
        /// <summary>
        /// Version 1.2.0
        /// </summary>
        /// <remarks>Prepared on: February 17, 2012</remarks>
        V_1_2_0 = 1 << 2,
        /// <summary>
        /// Version 1.3.0
        /// </summary>
        /// <remarks>Prepared on: September 30, 2014</remarks>
        V_1_3_0 = 1 << 3,
        /// <summary>
        /// Version 1.3.1
        /// </summary>
        /// <remarks>Prepared on: June 11, 2015</remarks>
        V_1_3_1 = 1 << 4,
        /// <summary>
        /// Version 1.4.0
        /// </summary>
        /// <remarks>Prepared on: March 31, 2018</remarks>
        V_1_4_0 = 1 << 5,
        /// <inheritdoc cref="V_1_4_0"/>
        V_1_4_1 = 1 << 6,
        /// <summary>
        /// Version 1.5.0
        /// </summary>
        V_1_5_0 = 1 << 7,
        /// <inheritdoc cref="V_1_5_0"/>
        V_1_5_1 = 1 << 8,
        /// <summary>
        /// Version 1.6.0
        /// </summary>
        /// <remarks>Prepared on: July 15, 2020</remarks>
        V_1_6_0 = 1 << 9,
        /// <inheritdoc cref="V_1_6_0"/>
        V_1_6_1 = 1 << 10,
        /// <summary>
        /// Version 1.7.0
        /// </summary>
        /// <remarks>Prepared on: February 25, 2021</remarks>
        V_1_7_0 = 1 << 11,
        /// <inheritdoc cref="V_1_7_0"/>
        V_1_7_1 = 1 << 12,
        /// <summary>
        /// Version 1.8.0
        /// </summary>
        /// <remarks>Prepared on: September 6, 2021</remarks>
        V_1_8_0 = 1 << 13,
        /// <inheritdoc cref="V_1_8_0"/>
        V_1_8_1 = 1 << 14,
        /// <summary>
        /// Version 2.0.0
        /// </summary>
        /// <remarks>Prepared on: May 24, 2022</remarks>
        V_2_0_0 = 1 << 15,
        /// <inheritdoc cref="V_2_0_0"/>
        V_2_0_1 = 1 << 16,
        /// <summary>
        /// Version 2.1.0
        /// </summary>
        /// <remarks>Prepared on: January 14, 2023</remarks>
        V_2_1_0 = 1 << 17,
        /// <inheritdoc cref="V_2_1_0"/>
        V_2_1_1 = 1 << 18,
        /// <summary>
        /// Version 2.2.0
        /// </summary>
        /// <remarks>Pre-Release</remarks>
        V_2_2_0 = 1 << 19,
    }
}
