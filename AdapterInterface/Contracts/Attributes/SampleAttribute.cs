namespace Mtconnect.AdapterInterface.Contracts.Attributes
{
    /// <summary>
    /// A decorative attribute for indicating a property intended to go thru an Adapter stream as an Sample.
    /// </summary>
    public class SampleAttribute : DataItemAttribute
    {
        /// <inheritdoc />
        public SampleAttribute(string name) : base(name) { }
    }
}
