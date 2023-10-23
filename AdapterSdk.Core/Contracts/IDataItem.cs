using Mtconnect.AdapterSdk.DataItems;
using System;
using System.Collections.Generic;

namespace Mtconnect.AdapterSdk
{
    /// <summary>
    /// Abstract definition for a DataItem type.
    /// </summary>
    public interface IDataItem
    {
        /// <summary>
        /// Occurrs when the value of a DataItem has changed.
        /// </summary>
        event DataItemChangedHandler OnDataItemChanged;

        /// <summary>
        /// Reference to the type of source model (see <see cref="IAdapterDataModel"/>) this DataItem was constructed from.
        /// </summary>
        string ModelPath { get; set; }

        /// <summary>
        /// Refers to the category for the MTConnect observational type.
        /// </summary>
        string Category { get; }

        /// <summary>
        /// A <see cref="System.Type"/> reference to the <see cref="Enum"/> according the MTConnect Standard. See EventTypes, SampleTypes, and ConditionTypes for examples.
        /// </summary>
        Enum TypeEnum { get; }
        /// <summary>
        /// A <see cref="System.Type"/> reference to the <see cref="Enum"/> according to the MTConnect Standard and the provided TypeEnum if it is decorated with ObservationalSubTypeAttribute.
        /// </summary>
        Enum SubTypeEnum { get; }

        /// <summary>
        /// A flag for whether or not the <see cref="ObservationalType"/> has been validated against the MTConnect Standard.
        /// </summary>
        bool TypeValidated { get; }

        /// <summary>
        /// The intended <c>type</c> for the Data Item. See Events, Samples, and Conditions. The <c>type</c> can also be extended according to the standard be adding the prefix <c>x:</c> to indicate an extended type.
        /// </summary>
        string ObservationalType { get; set; }

        /// <summary>
        /// The intended <c>subType</c> for the Data Item. Refer to the appropriate Events, Samples, and Conditions. The <c>subType</c> can also be extended according to the standard be adding the prefix <c>x:</c> to indicate an extended type.
        /// </summary>
        string ObservationalSubType { get; set; }

        /// <summary>
        /// Reference to the <c>nativeUnits</c> of the DataItem
        /// </summary>
        string Units { get; set; }

        /// <summary>
        /// The name of the data item.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// A description of the DataItem such as a trace of its source or the methodology for a composite data type.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Optional device prefix.
        /// </summary>
        string DevicePrefix { get; set; }
        /// <summary>
        /// Get and set the Value property. This will check if the value has changed and set the changed flag appropriately. Automatically boxes types so will work for any data.
        /// </summary>
        object Value { get; set; }

        /// <summary>
        /// Timestamp of when the <see cref="Value"/> was last Changed.
        /// </summary>
        DateTime? LastChanged { get; set; }
        /// <summary>
        /// A flag to indicate if the data item's value has changed since it 
        /// has last been set.
        /// </summary>
        bool HasChanged { get; }

        /// <summary>
        /// An indicator that this data item must be sent on a separate line.
        /// This is done for all data items that are more complex than simple 
        /// Key|Value pairs.
        /// </summary>
        bool HasNewLine { get; }

        /// <summary>
        /// Flag for whether or not this DataItem has a different source for the expected output Timestamp.
        /// </summary>
        bool HasTimestampOverride { get; set; }

        /// <summary>
        /// An expression that can be used to apply additional formatting or transformations to the DataItem value.
        /// </summary>
        Func<object, object> FormatValue { get; set; }

        /// <summary>
        /// Make this data item <c>UNAVAILABLE</c>.
        /// </summary>
        void Unavailable();

        /// <summary>
        /// Checks if the data item is unavailable.
        /// </summary>
        /// <returns>true if Unavailable</returns>
        bool IsUnavailable();

        /// <summary>
        /// Forces this <see cref="IDataItem"/> to indicate that the <see cref="Value"/> has changed.
        /// </summary>
        void ForceChanged();

        /// <summary>
        /// These methods are mainly for conditions. They allow for
        /// mark and sweep of the condition activations.
        /// </summary>
        void Begin();

        /// <summary>
        /// This is called before we send the actual changed data. It does the diff from the previous state and finds all the activations that need to be removed. This also check to see if all the activations have been removed because we only need to do a single normal with no native code to clear all. This is not required for simple conditions.
        /// </summary>
        void Prepare();

        /// <summary>
        /// Reset the Changed flag.
        /// </summary>
        void Cleanup();

        /// <summary>
        /// Get a list of all the changed data items. Since this is a 
        /// single value, just return a list with one item if it has 
        /// changed
        /// </summary>
        /// <param name="all">true means to return this data item regardless of the 
        /// changed flag. This is used to send initial data back to a new client.</param>
        /// <returns>The changed data item</returns>
        List<IDataItem> ItemList(bool all = false);

        /// <summary>
        /// Performs validation against the DataItem value based on the <see cref="ObservationalType"/> and <see cref="ObservationalSubType"/>.
        /// </summary>
        /// <returns>Flag of whether or not the result yields anything other than <see cref="ValidationLevel.VALID"/>.</returns>
        bool Validate(out ValidationResult result);

        /// <summary>
        /// Copies the current DataItem into a new object.
        /// </summary>
        /// <returns></returns>
        IDataItem Copy();
    }
}
