using System;

namespace Mtconnect.AdapterInterface.Contracts.Attributes
{
    /// <summary>
    /// An attribute used to flag the applicability of an object based on the version of the standard the MTConnect Response Document should be compared against.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public class MtconnectVersionAttribute : Attribute
    {
        /// <summary>
        /// Reference to the version of the MTConnect Standard that this object applies to.
        /// </summary>
        public MtconnectVersions MinimumVersion { get; set; }

        public MtconnectVersions? MaximumVersion { get; set; }

        /// <summary>
        /// A reference to the part and section of the MTConnect Standard that the applicability of this object is mentioned. This reference should be relevant to the <see cref="MinimumVersion"/> supplied.
        /// </summary>
        /// <example>Part 1 Section 1.0.0</example>
        public string StandardReference { get; set; }

        /// <summary>
        /// Initializes a <see cref="MtconnectVersionAttribute"/> for automatic processing of a MTConnect node's XML validation.
        /// </summary>
        /// <param name="version">Reference to the MTConnect Standard version that this validation is in reference to.</param>
        /// <param name="standardReference">Reference to the part and section of the MTConnect Standard that this validation method comes from.</param>
        public MtconnectVersionAttribute(MtconnectVersions version, string standardReference)
        {
            MinimumVersion = version;
            StandardReference = standardReference;
        }

        /// <inheritdoc cref="MtconnectVersionAttribute.MtconnectVersionAttribute(MtconnectVersions, string)"/>
        /// <param name="version">Reference to the MTConnect Standard version that this validation is in reference to.</param>
        /// <param name="standardReference">Reference to the part and section of the MTConnect Standard that this validation method comes from.</param>
        /// <param name="maximumVersion"></param>
        public MtconnectVersionAttribute(MtconnectVersions version, string standardReference, MtconnectVersions maximumVersion) : this(version, standardReference)
        {
            MaximumVersion = maximumVersion;
        }

        /// <summary>
        /// Compares the Response Document version against the version specified in the attribute based on the comparison method provided.
        /// </summary>
        /// <param name="documentVersion">Reference to the version of MTConnect implemented in the Response Document.</param>
        /// <returns>Flag for whether the MTConnect Response Document version matches with the specified <see cref="MinimumVersion"/> according to the <see cref="ComparisonType"/>.</returns>
        public bool Compare(MtconnectVersions documentVersion)
        {
            return documentVersion >= MinimumVersion && (MaximumVersion.HasValue ? documentVersion <= MaximumVersion.Value : true);
        }
    }
}
