﻿using System;

namespace Mtconnect.AdapterInterface.DataItems
{
    public partial class Condition
    {
        /// <summary>
        /// The Activation is itself a data item. This is so it can be cleared and treated like other data items when generating text.
        /// </summary>
        public class Active : DataItem
        {
            /// <summary>
            /// The pieces of the activation are only used by the <see cref="Condition"/>.
            /// </summary>
            public Level Level { get; set; }

            /// <summary>
            /// Contents of the Active Condition
            /// </summary>
            public string Text { get; set; }

            /// <summary>
            /// The native code (usually in alpha-numeric value) generated by the controller of a piece of equipment providing a reference identifier for a Condition.
            /// </summary>
            public string NativeCode { get; set; }

            /// <summary>
            /// If the piece of equipment designates a severity level to a fault, nativeSeverity reports that severity information to a client software application.
            /// </summary>
            public string NativeSeverity { get; set; }

            /// <summary>
            /// Qualifier provides additional information regarding a <c>FAULT</c> state associated with the measured value of a process variable.
            /// </summary>
            public string Qualifier { get; set; }

            /// <summary>
            /// The marked flag tells if this alarm has been reasserted.
            /// </summary>
            public bool mMarked = true;

            /// <summary>
            /// A placeholder activation is just a <c>NORMAL</c> or <c>UNAVAILABLE</c>.
            /// </summary>
            public bool mPlaceholder = false;

            /// <summary>
            /// Create a new activation
            /// </summary>
            /// <param name="name">The name of the condition, passed from the parent</param>
            /// <param name="level">The condition level</param>
            /// <param name="text">The descriptive text for the condition</param>
            /// <param name="code">The native code of the alarm or warning</param>
            /// <param name="qualifier">A high/low qualifier</param>
            /// <param name="severity">The native severity of the condition</param>
            public Active(string name, Level level, string text = "", string code = "", string qualifier = "", string severity = "") : base(name)
            {
                Level = level;
                Text = text;
                NativeCode = code;
                Qualifier = qualifier;
                NativeSeverity = severity;
                HasNewLine = true;

                if (NativeCode.Length == 0 && (Level == Level.NORMAL || Level == Level.UNAVAILABLE))
                    mPlaceholder = true;
            }

            /// <summary>
            /// Update the values of the activation. Also marks this activation.
            /// </summary>
            /// <param name="level">The condition level</param>
            /// <param name="text">The descriptive text for the condition</param>
            /// <param name="qualifier">A high/low qualifier</param>
            /// <param name="severity">The native severity of the condition</param>
            /// <returns><c>true</c> if the <see cref="Condition"/> has changed</returns>
            public bool Set(Level level, string text = "", string qualifier = "", string severity = "")
            {
                HasChanged = level != Level
                    || text != Text
                    || qualifier != Qualifier
                    || severity != NativeSeverity;
                if (HasChanged)
                {
                    Level = level;
                    Qualifier = qualifier;
                    Text = text;
                    NativeSeverity = severity;
                }

                mMarked = true;
                return HasChanged;
            }

            /// <inheritdoc />
            public override string ToString()
            {
                return $"{Name}|{Enum.GetName(Level.GetType(), Level)}|{NativeCode}|{NativeSeverity}|{Qualifier}|{Text}";
            }

            /// <summary>
            /// Resets the marked flag.
            /// </summary>
            public void Clear()
            {
                mMarked = false;
            }
        }
    }
}
