namespace Mtconnect.AdapterInterface.Contracts.Attributes
{
    /// <summary>
    /// A decorative attribute for indicating a complex object with properties that are decorated as DataItems.
    /// </summary>
    public class DataItemPartialAttribute : DataItemAttribute
    {
        /// <inheritdoc />
        public DataItemPartialAttribute(string name, string description = null) : base(name, description) { }
    }
}
