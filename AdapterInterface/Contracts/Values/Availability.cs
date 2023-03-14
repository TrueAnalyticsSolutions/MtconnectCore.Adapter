namespace Mtconnect.AdapterInterface.Contracts.Values
{
    public class Availability : EventValue
    {
        public Availability(string value) : base(value) { }

        public static Availability Available => new Availability("AVAILABLE");
        public static Availability Unavailable => new Availability("UNAVAILABLE");

        public static implicit operator Availability(string value)
        {
            return new Availability(value.ToUpperInvariant());
        }
    }
}
