using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SampleAdapter.PC
{
    public static partial class WindowHandles
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindow(IntPtr hWnd, WindowHandles.GetWindowType uCmd);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, out WindowHandles.Rect lpRect);

        public static string GetActiveWindowTitle()
        {
            StringBuilder text = new StringBuilder(256);
            return WindowHandles.GetWindowText(WindowHandles.GetForegroundWindow(), text, 256) > 0 ? text.ToString() : (string)null;
        }

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll")]
        public static extern bool GetAsyncKeyState(ushort virtualKeyCode);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);
    }
}
