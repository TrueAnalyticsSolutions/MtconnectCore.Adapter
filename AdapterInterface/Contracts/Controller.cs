using Mtconnect.AdapterInterface.DataItemValues;

namespace Mtconnect.AdapterInterface.Contracts
{
    public interface IController : IAdapterDataModel
    {
        IPath Path { get; set; }
    }
    public interface IPath : IAdapterDataModel
    {
        Execution Execution { get; set; }
    }
}
