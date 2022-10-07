using System.ComponentModel;

namespace SampleAdapter.PC
{
    public static partial class WindowHandles
    {
        public class GlobalKeyboardHookEventArgs : HandledEventArgs
        {
            public WindowHandles.GlobalKeyboardHook.KeyboardState KeyboardState { get; private set; }

            public WindowHandles.GlobalKeyboardHook.LowLevelKeyboardInputEvent KeyboardData { get; private set; }

            public GlobalKeyboardHookEventArgs(
              WindowHandles.GlobalKeyboardHook.LowLevelKeyboardInputEvent keyboardData,
              WindowHandles.GlobalKeyboardHook.KeyboardState keyboardState)
            {
                this.KeyboardData = keyboardData;
                this.KeyboardState = keyboardState;
            }
        }
    }
}
