// See https://aka.ms/new-console-template for more information
using Mtconnect;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using SampleAdapter.PC;
using System.Drawing;

namespace SampleAdapter
{
    /// <summary>
    /// Contains an internal timer that periodically gets the current mouse position and active window title then publishes the values to an Adapter.
    /// </summary>
    public class PCStatusMonitor : IAdapterSource
    {
        /// <summary>
        /// Fires when the <see cref="IAdapterSource"/> changes any of its properties.
        /// </summary>
        public event DataReceivedHandler? OnDataReceived;

        public PCStatus Model { get; private set; } = new PCStatus();

        private System.Timers.Timer Timer = new System.Timers.Timer();

        /// <summary>
        /// Constructs a new instance of the PC monitor.
        /// </summary>
        /// <param name="sampleRate">The frequency for which the current states of the PC are collected (in milliseconds).</param>
        public PCStatusMonitor(int sampleRate = 50)
        {
            Timer.Interval = sampleRate;
            Timer.Elapsed += Timer_Elapsed; ;
        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Model.Availability = "AVAILABLE";

            Point lpPoint;
            if (WindowHandles.GetCursorPos(out lpPoint))
            {
                Model.XPosition = lpPoint.X;
                Model.YPosition = lpPoint.Y;
            }
            else
            {
                Model.XPosition = null;
                Model.YPosition = null;
            }

            try
            {
                string activeWindowTitle = WindowHandles.GetActiveWindowTitle();
                if (!string.IsNullOrEmpty(activeWindowTitle))
                {
                    Model.WindowTitle = activeWindowTitle;
                }
                else
                {
                    Model.WindowTitle = null;
                }
            }
            catch (Exception ex)
            {
                Model.WindowTitle = null;
            }

            if (OnDataReceived != null)
            {
                OnDataReceived(Model, new DataReceivedEventArgs());
            }
        }

        public void Start(CancellationToken token = default)
        {
            Timer.Start();
        }

        public void Stop()
        {
            Timer.Stop();
        }
    }
    public class PCStatus : IAdapterDataModel
    {
        [Event("avail")]
        public string? Availability { get; set; }

        [Sample("xPos", "user32.dll#GetCursorPos().X")]
        public int? XPosition { get; set; }

        [Sample("yPos", "user32.dll#GetCursorPos().Y")]
        public int? YPosition { get; set; }

        [Event("prog", "user32.dll#GetWindowText(user32.dll#GetForegroundWindow(), StringBuilder(256), 256)")]
        public string? WindowTitle { get; set; }
    }
}