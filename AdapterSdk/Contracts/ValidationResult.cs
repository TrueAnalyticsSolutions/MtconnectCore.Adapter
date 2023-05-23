using System;

namespace Mtconnect.AdapterSdk.Contracts
{
    /// <summary>
    /// A structure for containing a message when validation DataItems.
    /// </summary>
    public struct ValidationResult
    {
        /// <summary>
        /// The criticality of the message.
        /// </summary>
        public ValidationLevel Level { get; set; }

        /// <summary>
        /// The details of the message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// An exception that may have triggered the validation message.
        /// </summary>
        public Exception Exception { get; set; }
    }
}
