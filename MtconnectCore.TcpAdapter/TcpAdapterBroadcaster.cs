using Microsoft.Extensions.Logging;

namespace Mtconnect
{
    public sealed class TcpAdapterBroadcaster : Broadcaster<TcpAdapter>
    {
        public TcpAdapterBroadcaster(TcpAdapter adapter, double broadcastRate = DEFAULT_BROADCAST_RATE, string address = DEFAULT_BROADCAST_ADDRESS, int port = DEFAULT_BROADCAST_PORT, ILoggerFactory logFactory = default) : base(adapter, broadcastRate, address, port, logFactory) { }

        protected override BroadcastMessage ConstructMessage(TcpAdapter adapter)
        {
            var baseMessage = base.ConstructMessage(adapter);
            var message = new TcpBroadcastMessage()
            {
                Started = baseMessage.Started,
                Type = baseMessage.Type,
                Address = adapter.Address,
                Port = adapter.Port,
                MaxConnections = adapter.MaxConnections,
                CurrentConnections = adapter.CurrentConnections,
            };
            return message;
        }
    }
    public class TcpBroadcastMessage : BroadcastMessage
    {
        public string Address { get; set; }

        public int Port { get; set; }

        public int MaxConnections { get; set; }

        public int CurrentConnections { get; set; }
    }
}
