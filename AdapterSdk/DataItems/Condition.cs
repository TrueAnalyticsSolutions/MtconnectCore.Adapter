using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.DataItemTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mtconnect.AdapterSdk.DataItems
{
    /// <summary>
    /// A condition handles the fact that a single condition can have multiple 
    /// activations and needs to check when the are present and are cleared.
    /// </summary>
    public partial class Condition : DataItem
    {
        /// <inheritdoc />
        public override string Category => "CONDITION";

        /// <summary>
        /// A flag to indicate that the mark and sweep has begun.
        /// </summary>
        public bool HasBegun { get; private set; } = false;

        public override bool HasNewLine { get; protected set; } = true;

        /// <summary>
        /// A flag indicating the second phase of the mark and sweep has completed.
        /// </summary>
        public bool HasPrepared { get; private set; } = false;

        /// <summary>
        /// true means this is a simple condition and does not require mark and sweep processing.
        /// </summary>
        public bool IsSimple { get; private set; }

        private Dictionary<string, Active> _activeList { get; set; } = new Dictionary<string, Active>();

        /// <summary>
        /// Create a new CONDITION DataItem.
        /// </summary>
        /// <param name="name"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='name']"/></param>
        /// <param name="description"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='description']"/></param>
        /// <param name="simple">If this is a simple condition or if it uses mark and sweep</param>
        /// <param name="type"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='type']"/></param>
        /// <param name="subType"><inheritdoc cref="DataItem.DataItem(string, string, string, string)" path="/param[@name='subType']"/></param>
        public Condition(string name, string description = null, bool simple = false) : base(name, description)
        {
            IsSimple = simple;
        }

        public Condition(string name, string type, string subtype = null, string description = null, bool simple = false) : base(name, type, subtype, description)
        {
            IsSimple = simple;
        }

        public Condition(string name, EventTypes type, string subtype = null, string description = null, bool simple = false) : this(name, type.ToString(), subtype, description, simple) { }

        public Condition(string name, SampleTypes type, string subtype = null, string description = null, bool simple = false) : this(name, type.ToString(), subtype, description, simple) { }

        public Condition(string name, ConditionTypes type, string subtype = null, string description = null, bool simple = false) : this(name, type.ToString(), subtype, description, simple) { }

        /// <inheritdoc />
        public override void Unavailable()
        {
            Add(Level.UNAVAILABLE);
        }

        /// <inheritdoc />
        public override void Begin()
        {
            if (!IsSimple)
            {
                foreach (var kvp in _activeList)
                {
                    kvp.Value.Clear();
                }
                HasBegun = true;
            }

            HasPrepared = HasChanged = false;
        }

        /// <inheritdoc />
        public override void Prepare()
        {
            if (!HasBegun) return;

            // Check to see if we have any active marked conditions
            bool marked = _activeList.Any(o => o.Value.mPlaceholder || o.Value.mMarked);

            // If they've all been cleared, then go back to normal.
            if (!marked) Normal();

            // Sweep the old conditions and if they are not marked
            // set them to normal.
            foreach (var kvp in _activeList)
            {
                if (!kvp.Value.mPlaceholder && !kvp.Value.mMarked)
                {
                    kvp.Value.Set(Level.NORMAL, string.Empty);
                    kvp.Value.mMarked = false;
                }
                if (kvp.Value.HasChanged)
                    HasChanged = true;
            }

            HasPrepared = true;
        }

        /// <summary>
        /// This is the sweep phase where we removed the changed flags and remove all the stale activations.
        /// </summary>
        public override void Cleanup()
        {
            base.Cleanup();

            HasBegun = HasPrepared = false;
            foreach (var kvp in _activeList)
            {
                // It is assumed that if the activations are no longer needed, they will
                // be removed here after they are returned.
                if (!kvp.Value.mPlaceholder && !kvp.Value.mMarked)
                    _activeList.Remove(kvp.Key);

                kvp.Value.Cleanup();
            }

            // Remvoe stale items from the active list that are not marked                      
        }

        /// <summary>
        /// Add a new activation.
        /// </summary>
        /// <param name="active"></param>
        private void Add(Active active) => _activeList.Add(active.NativeCode, active);

        /// <summary>
        /// Adds a new activation to the condition or if <c>NORMAL</c> or <c>UNAVAILABLE</c>, removes the activation.
        /// </summary>
        /// <param name="level">The level</param>
        /// <param name="text">The descriptive text for the condition</param>
        /// <param name="code">The native code</param>
        /// <param name="qualifier">The qualifier</param>
        /// <param name="severity">The native severity</param>
        /// <returns><c>true</c> if the activation is modified</returns>
        public bool Add(Level level, string text = "", string code = "", string qualifier = "", string severity = "")
        {
            bool result = false;

            // Get the first activation
            Active previousActivation = null;
            Active newActivation = null;
            Func<Level, bool> isFirstActivation = (o) => o == Level.NORMAL || o == Level.UNAVAILABLE;
            if (string.IsNullOrEmpty(code) && isFirstActivation(level))
            {
                _activeList.Clear();
                newActivation = new Active(Name, level, Description, text, code, qualifier, severity);
                _activeList.Add(string.Empty, newActivation);
                result = HasChanged = true;
            } else if (!_activeList.TryGetValue(code, out newActivation))
            {
                if (_activeList.Count == 1 && isFirstActivation(_activeList.Values.FirstOrDefault().Level))
                {
                    _activeList.Clear();
                }

                newActivation = new Active(Name, level, Description, text, code, qualifier, severity);
                _activeList.Add(code, newActivation);

                result = HasChanged = true;
            }

            if (_activeList.ContainsKey(code))
            {
                if (newActivation != null)
                {
                    previousActivation = newActivation; // Before we set the values for a potentially old Activation
                    if (!result)
                    {
                        result = newActivation.Set(level, text, qualifier, severity);
                        if (result)
                        {
                            _activeList[code] = newActivation;
                        }
                        HasChanged = HasChanged || result;
                    }
                } else
                {
                    _activeList.Remove(code);
                }
            }

            if (result
                && IsReadyToUpdate(newActivation.Value)
                && ((previousActivation?.Value == null && newActivation.Value != null)
                || (previousActivation?.Value != null && newActivation.Value == null)
                || (previousActivation?.Value.Equals(newActivation.Value) == false)))
            {
                var e = new DataItemChangedEventArgs(previousActivation?.Value, newActivation.Value, LastChanged, TimeHelper.GetNow());

                LastChanged = newActivation.LastChanged;

                TriggerDataChangedEvent(e);
            }

            return result;
        }

        /// <summary>
        /// Clear a condition from the active list - Used only for simple Conditions.
        /// </summary>
        /// <param name="code">The native code</param>
        /// <returns><c>true</c> if the activation is found</returns>
        public bool Clear(string code)
        {
            Active found = null;
            // Find the activation.
            if (_activeList?.TryGetValue(code, out found) == false || found == null) return false;

            // If we've removed the last activation, go back to normal.
            if (_activeList.Count() == 1)
            {
                Normal();
            }
            else
            {
                // Otherwise, just clear this one.
                found.Set(Level.NORMAL);
                // Clear makes the activation be removed next sweep.
                found.Clear();
                LastChanged = found.LastChanged;
            }
            HasChanged = true;
            return true;
        }

        /// <summary>
        /// Cover to set everything to <c>NORMAL</c>.
        /// </summary>
        /// <returns><c>true</c> if the activation is modified</returns>
        public bool Normal() => Add(Level.NORMAL);

        /// <summary>
        /// Used to get a list of the active conditions for writing out to
        /// the clients.
        /// </summary>
        /// <param name="all">This flag is used to get all activations, regardless 
        /// of their changed state. This is used to deliver initial state to the client</param>
        /// <returns>A list of activations (also DataItems)</returns>
        public override List<DataItem> ItemList(bool all = false)
        {
            // Just grab all the activations.
            List<DataItem> list = _activeList.Values.ToList<DataItem>();// new List<DataItem>();
            if (IsSimple || (HasBegun && HasPrepared && HasChanged))
            {
                // For a simple condition, we are only looking for the changed set.
                // Since we don't care about the mark and sweep, this is similar to 
                // all other data items.
                list = list.Where(o => o.HasChanged).ToList();
            }

            return list;
        }

        /// <inheritdoc />
        public override bool Validate(out ValidationResult result)
        {
            var baseResponse = base.Validate(out result);
            if (!baseResponse) return baseResponse;

            // Validate the CONDITION value(s)
            if (_activeList.Any(o => o.Value.Validate(out _) == false)) {
                result = new ValidationResult
                {
                    Level = ValidationLevel.ERROR,
                    Message = $"{Category} DataItem has invalid ACTIVE states"
                };
                return false;
            }

            result = new ValidationResult
            {
                Level = ValidationLevel.VALID
            };
            return true;
        }
    }
}
