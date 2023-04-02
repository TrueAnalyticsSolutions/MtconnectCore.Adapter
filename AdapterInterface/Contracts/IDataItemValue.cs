namespace Mtconnect.AdapterInterface.Contracts
{
    /// <summary>
    /// Represents the abstract type for a DataItem value model. Used to implement defined types/subtypes from the MTConnect standard into <see cref="IComponentModel"/> implementations.
    /// </summary>
    public interface IDataItemValue
    {
        /// <summary>
        /// Represents the <c>category</c> attribute
        /// </summary>
        string Category { get; }

        /// <summary>
        /// Represents the <c>type</c> attribute
        /// </summary>
        string ObservationalType { get; }

        /// <summary>
        /// Represents the <c>subType</c> attribute
        /// </summary>
        string ObservationalSubType { get; }
    }
}
