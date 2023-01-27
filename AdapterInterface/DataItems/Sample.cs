namespace Mtconnect.AdapterInterface.DataItems
{
    /// <summary>
    /// A sample is a data item with a floating point value
    /// </summary>
    public class Sample : DataItem
    {
        /// <inheritdoc />
        public Sample(string name, string description = null) : base(name, description) { }
    }
}
