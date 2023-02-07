using Mtconnect.AdapterInterface.DataItems;
using System;

namespace Mtconnect.AdapterInterface.Contracts.Attributes
{
    /// <summary>
    /// Indicates that a <see cref="DateTime"/> property can be the source for <see cref="DataItem.LastChanged"/>.
    /// <b>Important:</b> the <see cref="DateTime"/> property must be within the same entity as the <see cref="DataItem"/> property (or a property decorated with <see cref="DataItemAttribute"/>).
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class TimestampAttribute : Attribute
    {
        /// <summary>
        /// Reference to the DataItem for which this timestamp relates.
        /// </summary>
        public string DataItemName { get; }

        /// <summary>
        /// Indicates the methodology for how the timestamp was originally synchronized. This is particularly useful when the timestamp originates from another known system.
        /// </summary>
        public TimestampSyncTypes SynchronizationType { get; } = TimestampSyncTypes.Unknown;

        /// <summary>
        /// Indicates the accuracy of the timestamp.
        /// </summary>
        public TimestampResolutionTypes ResolutionType { get; } = TimestampResolutionTypes.Unknown;

        /// <summary>
        /// Indicates any potential causes for timestamp drift that can affect the resolution.
        /// </summary>
        public TimestampDriftCauses DriftCauses { get; } = TimestampDriftCauses.None;

        /// <summary>
        /// <inheritdoc cref="TimestampAttribute"/>
        /// </summary>
        /// <param name="dataItemName"><inheritdoc cref="DataItemName" path="/summary"/></param>
        /// <param name="syncType"><inheritdoc cref="SynchronizationType" path="/summary"/></param>
        /// <param name="resolutionType"><inheritdoc cref="ResolutionType" path="/summary"/></param>
        /// <param name="driftCauses"><inheritdoc cref="DriftCauses" path="/summary"/></param>
        public TimestampAttribute(string dataItemName, TimestampSyncTypes syncType = TimestampSyncTypes.Unknown, TimestampResolutionTypes resolutionType = TimestampResolutionTypes.Unknown, TimestampDriftCauses driftCauses = TimestampDriftCauses.None)
        {
            DataItemName = dataItemName;
            SynchronizationType = syncType;
            ResolutionType = resolutionType;
            DriftCauses = driftCauses;
        }
    }
}
