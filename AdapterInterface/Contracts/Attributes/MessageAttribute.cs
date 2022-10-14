namespace Mtconnect.AdapterInterface.Contracts.Attributes
{
    /// <summary>
    /// A decorative attribute for indicating a property intended to go thru an Adapter stream as an Message.
    /// </summary>
    public class MessageAttribute : DataItemAttribute
    {
        /// <inheritdoc />
        public MessageAttribute(string name) : base(name) { }
    }
}
