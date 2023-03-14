namespace Mtconnect.AdapterInterface.Contracts
{
    /// <summary>
    /// Varying levels of validation message criticalities.
    /// </summary>
    public enum ValidationLevel
    {
        /// <summary>
        /// There is a clear violation against the standard.
        /// </summary>
        ERROR = -2,
        /// <summary>
        /// There is a slight violation against the standard that perhaps goes against recommendation.
        /// </summary>
        WARNING = -1,
        /// <summary>
        /// There is no violation against the standard.
        /// </summary>
        MESSAGE = 0,
        /// <summary>
        /// The implementation is indicated as valid.
        /// </summary>
        VALID  = 1
    }
}
