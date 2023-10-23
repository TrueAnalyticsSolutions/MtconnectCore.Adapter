namespace Mtconnect.AdapterSdk
{
    /// <summary>
    /// Represents the generic type for a Component data model. Used to breakdown <see cref="IAdapterDataModel"/> implementations into device-component structures.
    /// </summary>
    public interface IComponentModel
    {
        /// <summary>
        /// Sets all DataItems and Sub-Components to <c>UNAVAILABLE</c>
        /// </summary>
        void Unavailable();
    }
}
