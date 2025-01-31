﻿using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.DataItemTypes;
using System;

namespace Mtconnect.AdapterSdk.Attributes
{
    /// <summary>
    /// A decorative attribute for indicating a property intended to go thru an Adapter stream as an Event.
    /// </summary>
    public class EventAttribute : DataItemAttribute
    {
        /// <inheritdoc />
        public EventAttribute(string name, string description = null) : base(name, description) { }
    }
}
