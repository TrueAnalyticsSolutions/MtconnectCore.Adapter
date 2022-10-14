using System;
using System.Collections.Generic;
using System.Text;

namespace Mtconnect.AdapterInterface.Contracts.Attributes
{
    /// <summary>
    /// A decorative attribute for indicating a property intended to go thru an Adapter stream.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public abstract class DataItemAttribute : Attribute
    {
        /// <summary>
        /// The key for the MTConnect DataItem.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Constructs a new DataItem attribute.
        /// </summary>
        /// <param name="name">Key for the MTConnect DataItem.</param>
        public DataItemAttribute(string name)
        {
            Name = name;
        }
    }

    /// <summary>
    /// A decorative attribute for indicating a property intended to go thru an Adapter stream as an Event.
    /// </summary>
    public class EventAttribute : DataItemAttribute
    {
        /// <inheritdoc />
        public EventAttribute(string name) : base(name) { }
    }

    /// <summary>
    /// A decorative attribute for indicating a property intended to go thru an Adapter stream as an Sample.
    /// </summary>
    public class SampleAttribute : DataItemAttribute
    {
        /// <inheritdoc />
        public SampleAttribute(string name) : base(name) { }
    }

    /// <summary>
    /// A decorative attribute for indicating a property intended to go thru an Adapter stream as an Condition.
    /// </summary>
    public class ConditionAttribute : DataItemAttribute
    {
        /// <inheritdoc />
        public ConditionAttribute(string name) : base(name) { }
    }

    /// <summary>
    /// A decorative attribute for indicating a property intended to go thru an Adapter stream as an Message.
    /// </summary>
    public class MessageAttribute : DataItemAttribute
    {
        /// <inheritdoc />
        public MessageAttribute(string name) : base(name) { }
    }

    /// <summary>
    /// A decorative attribute for indicating a property intended to go thru an Adapter stream as an Time Series.
    /// </summary>
    public class TimeSeriesAttribute : DataItemAttribute
    {
        /// <inheritdoc />
        public TimeSeriesAttribute(string name) : base(name) { }
    }
}
