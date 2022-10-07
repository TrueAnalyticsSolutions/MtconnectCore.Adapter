using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SampleAdapter.PC
{
    public static partial class WindowHandles
    {
        public class GlobalKeyboardHook : IDisposable
        {
            private IntPtr _windowsHookHandle;
            private IntPtr _user32LibraryHandle;
            private WindowHandles.GlobalKeyboardHook.HookProc _hookProc;
            public const int WH_KEYBOARD_LL = 13;
            public const int VkSnapshot = 44;
            private const int KfAltdown = 8192;
            public const int LlkhfAltdown = 32;

            public event EventHandler<WindowHandles.GlobalKeyboardHookEventArgs> KeyboardPressed;

            public GlobalKeyboardHook()
            {
                this._windowsHookHandle = IntPtr.Zero;
                this._user32LibraryHandle = IntPtr.Zero;
                this._hookProc = new WindowHandles.GlobalKeyboardHook.HookProc(this.LowLevelKeyboardProc);
                this._user32LibraryHandle = WindowHandles.GlobalKeyboardHook.LoadLibrary("User32");
                if (this._user32LibraryHandle == IntPtr.Zero)
                {
                    int lastWin32Error = Marshal.GetLastWin32Error();
                    throw new Win32Exception(lastWin32Error, string.Format("Failed to load library 'User32.dll'. Error {0}: {1}.", (object)lastWin32Error, (object)new Win32Exception(Marshal.GetLastWin32Error()).Message));
                }
                this._windowsHookHandle = WindowHandles.GlobalKeyboardHook.SetWindowsHookEx(13, this._hookProc, this._user32LibraryHandle, 0);
                if (this._windowsHookHandle == IntPtr.Zero)
                {
                    int lastWin32Error = Marshal.GetLastWin32Error();
                    throw new Win32Exception(lastWin32Error, string.Format("Failed to adjust keyboard hooks for '{0}'. Error {1}: {2}.", (object)Process.GetCurrentProcess().ProcessName, (object)lastWin32Error, (object)new Win32Exception(Marshal.GetLastWin32Error()).Message));
                }
            }

            protected virtual void Dispose(bool disposing)
            {
                if (disposing && this._windowsHookHandle != IntPtr.Zero)
                {
                    if (!WindowHandles.GlobalKeyboardHook.UnhookWindowsHookEx(this._windowsHookHandle))
                    {
                        int lastWin32Error = Marshal.GetLastWin32Error();
                        throw new Win32Exception(lastWin32Error, string.Format("Failed to remove keyboard hooks for '{0}'. Error {1}: {2}.", (object)Process.GetCurrentProcess().ProcessName, (object)lastWin32Error, (object)new Win32Exception(Marshal.GetLastWin32Error()).Message));
                    }
                    this._windowsHookHandle = IntPtr.Zero;
                    this._hookProc -= new WindowHandles.GlobalKeyboardHook.HookProc(this.LowLevelKeyboardProc);
                }
                if (!(this._user32LibraryHandle != IntPtr.Zero))
                    return;
                if (!WindowHandles.GlobalKeyboardHook.FreeLibrary(this._user32LibraryHandle))
                {
                    int lastWin32Error = Marshal.GetLastWin32Error();
                    throw new Win32Exception(lastWin32Error, string.Format("Failed to unload library 'User32.dll'. Error {0}: {1}.", (object)lastWin32Error, (object)new Win32Exception(Marshal.GetLastWin32Error()).Message));
                }
                this._user32LibraryHandle = IntPtr.Zero;
            }

            ~GlobalKeyboardHook() => this.Dispose(false);

            public void Dispose()
            {
                this.Dispose(true);
                GC.SuppressFinalize((object)this);
            }

            [DllImport("kernel32.dll")]
            private static extern IntPtr LoadLibrary(string lpFileName);

            [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
            private static extern bool FreeLibrary(IntPtr hModule);

            [DllImport("USER32", SetLastError = true)]
            private static extern IntPtr SetWindowsHookEx(
              int idHook,
              WindowHandles.GlobalKeyboardHook.HookProc lpfn,
              IntPtr hMod,
              int dwThreadId);

            [DllImport("USER32", SetLastError = true)]
            public static extern bool UnhookWindowsHookEx(IntPtr hHook);

            [DllImport("USER32", SetLastError = true)]
            private static extern IntPtr CallNextHookEx(
              IntPtr hHook,
              int code,
              IntPtr wParam,
              IntPtr lParam);

            public IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam)
            {
                bool flag = false;
                int int32 = wParam.ToInt32();
                if (Enum.IsDefined(typeof(WindowHandles.GlobalKeyboardHook.KeyboardState), (object)int32))
                {
                    WindowHandles.GlobalKeyboardHookEventArgs e = new WindowHandles.GlobalKeyboardHookEventArgs((WindowHandles.GlobalKeyboardHook.LowLevelKeyboardInputEvent)Marshal.PtrToStructure(lParam, typeof(WindowHandles.GlobalKeyboardHook.LowLevelKeyboardInputEvent)), (WindowHandles.GlobalKeyboardHook.KeyboardState)int32);
                    EventHandler<WindowHandles.GlobalKeyboardHookEventArgs> keyboardPressed = this.KeyboardPressed;
                    if (keyboardPressed != null)
                        keyboardPressed((object)this, e);
                    flag = e.Handled;
                }
                return flag ? (IntPtr)1 : WindowHandles.GlobalKeyboardHook.CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
            }

            private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

            public struct LowLevelKeyboardInputEvent
            {
                public int VirtualCode;
                public int HardwareScanCode;
                public int Flags;
                public int TimeStamp;
                public IntPtr AdditionalInformation;
            }

            public enum KeyboardState
            {
                KeyDown = 256, // 0x00000100
                KeyUp = 257, // 0x00000101
                SysKeyDown = 260, // 0x00000104
                SysKeyUp = 261, // 0x00000105
            }
        }
    }
}
