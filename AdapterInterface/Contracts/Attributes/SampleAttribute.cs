﻿using Mtconnect.AdapterInterface.DataItemTypes;
using System;

namespace Mtconnect.AdapterInterface.Contracts.Attributes
{
    /// <summary>
    /// A decorative attribute for indicating a property intended to go thru an Adapter stream as an Sample.
    /// </summary>
    public class SampleAttribute : DataItemAttribute
    {
        /// <inheritdoc />
        public SampleAttribute(string name, string description = null, string type = null, string subtype = null) : base(name, description, type, subtype) { }

        /// <summary>
        /// Constructs a new <see cref="SampleAttribute"/> with more precise reference to the MTConnect Standard model.
        /// </summary>
        /// <param name="name"><inheritdoc cref="DataItemAttribute(string, string, string, string)" path="/param[@name='name']"/></param>
        /// <param name="description"><inheritdoc cref="DataItemAttribute(string, string, string, string)" path="/param[@name='description']"/></param>
        /// <param name="type">Reference to the MTConnect Standard defined types for SAMPLE.</param>
        /// <param name="subtype">Reference to the MTConnect Standard defined subType.</param>
        public SampleAttribute(string name, string description = null, SampleTypes? type = null, Enum subtype = null) : this(name, description, type.ToString(), subtype.ToString()) { }
    }
}
