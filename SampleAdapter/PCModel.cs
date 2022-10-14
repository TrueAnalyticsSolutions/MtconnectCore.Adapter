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

        [Event("avail")]
        public string? Availability { get; set; }

        [Sample("xPos")]
        public int? XPosition { get; set; }

        [Sample("yPos")]
        public int? YPosition { get; set; }

        [Event("prog")]
        public string? WindowTitle { get; set; }

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
            Availability = "AVAILABLE";

            Point lpPoint;
            if (WindowHandles.GetCursorPos(out lpPoint))
            {
                XPosition = lpPoint.X;
                YPosition = lpPoint.Y;
            }
            else
            {
                XPosition = null;
                YPosition = null;
            }

            try
            {
                string activeWindowTitle = WindowHandles.GetActiveWindowTitle();
                if (!string.IsNullOrEmpty(activeWindowTitle))
                {
                    WindowTitle = activeWindowTitle;
                }
                else
                {
                    WindowTitle = null;
                }
            }
            catch (Exception ex)
            {
                WindowTitle = null;
            }

            if (OnDataReceived != null)
            {
                OnDataReceived(this, new DataReceivedEventArgs());
            }
        }

        public void Start()
        {
            Timer.Start();
        }

        public void Stop()
        {
            Timer.Stop();
        }
    }
}