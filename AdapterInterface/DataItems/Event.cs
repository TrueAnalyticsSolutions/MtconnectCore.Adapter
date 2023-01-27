namespace Mtconnect.AdapterInterface.DataItems
{
    /// <summary>
    /// Event is just an alias for DataItem
    /// </summary>
    public class Event : DataItem 
    {
        /// <inheritdoc />
        public Event(string name, string description = null) : base(name, description) { }
    }
}
