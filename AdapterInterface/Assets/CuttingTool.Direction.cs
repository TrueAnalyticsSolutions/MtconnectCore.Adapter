namespace Mtconnect.AdapterInterface.Assets
{
    public partial class CuttingTool
    {
        /// <summary>
        /// The cutting tool direction.
        /// </summary>
        public enum Direction
        {
            /// <summary>
            /// The tool life counts up from zero to the maximum.
            /// </summary>
            UP,
            /// <summary>
            /// The tool life counts down from maximum to zero.
            /// </summary>
            DOWN
        };
    }
}
