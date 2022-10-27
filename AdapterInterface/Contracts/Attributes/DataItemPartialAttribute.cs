namespace Mtconnect.AdapterInterface.Contracts.Attributes
{
    /// <summary>
    /// A decorative attribute for indicating a complex object with properties that are decorated as DataItems.
    /// </summary>
    public class DataItemPartialAttribute : DataItemAttribute
    {
        /// <summary>
        /// Constructs a new 
        /// </summary>
        /// <param name="name"></param>
        public DataItemPartialAttribute(string name) : base(name) { }
    }
}
