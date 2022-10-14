namespace Mtconnect.AdapterInterface.Assets
{

    public partial class CuttingTool
    {
        /// <summary>
        /// The cutting tool or cutting item life
        /// </summary>
        public enum LifeType
        {
            /// <summary>
            /// The tool life measured in minutes. All units for minimum, maximum, and nominal MUST be provided in minutes.
            /// </summary>
            MINUTES,
            /// <summary>
            /// The tool life measured in parts. All units for minimum, maximum, and nominal MUST be provided as the number of parts.
            /// </summary>
            PART_COUNT,
            /// <summary>
            /// The tool life measured in tool wear. Wear MUST be provided in millimeters as an offset to nominal. All units for minimum, maximum, and nominal MUST be given as millimeter offsets as well.
            /// </summary>
            WEAR
        };
    }
}
