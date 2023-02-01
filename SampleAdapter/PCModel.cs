// See https://aka.ms/new-console-template for more information
using Mtconnect;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.DataItems;
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

        private long _loopCount { get; set; } = 0;

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
                Model.XPosition.Value = lpPoint.X;
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

            try
            {
                WindowHandles.SystemPower.SystemPowerStatus sps = new WindowHandles.SystemPower.SystemPowerStatus();
                WindowHandles.SystemPower.GetSystemPowerStatus(out sps);
                if (sps.flgBattery == WindowHandles.SystemPower.BatteryFlag.Unknown || sps.flgBattery == WindowHandles.SystemPower.BatteryFlag.NoSystemBattery)
                {
                    Model.BatteryCondition.Add(Condition.Level.WARNING, sps.flgBattery.ToString(), ((int)sps.flgBattery).ToString(), string.Empty, string.Empty);
                    Model.BatteryRemaining = null;
                } else
                {
                    Model.BatteryCondition.Normal();
                    Model.BatteryRemaining = (int)sps.BatteryLifePercent;
                }


                if (sps.LineStatus == WindowHandles.SystemPower.ACLineStatus.Unknown)
                {
                    Model.ACCondition.Add(Condition.Level.WARNING, sps.LineStatus.ToString(), ((int)sps.LineStatus).ToString(), string.Empty, string.Empty);
                    Model.ACConnected = null;
                } else
                {
                    Model.ACCondition.Normal();
                    Model.ACConnected = sps.LineStatus == WindowHandles.SystemPower.ACLineStatus.Online;
                }
            }
            catch (Exception ex)
            {
                Model.BatteryCondition.Add(Condition.Level.FAULT, ex.Message, ex.TargetSite.Name, string.Empty, string.Empty);
                Model.ACCondition.Add(Condition.Level.FAULT, ex.Message, ex.TargetSite.Name, string.Empty, string.Empty);
            }

            // Comment out for testing * DATAITEM_VALUE foobar
            if (_loopCount > 5000 / Timer.Interval)
            {
                Model.FooBar = "foobar";
            }

            if (OnDataReceived != null)
            {
                OnDataReceived(Model, new DataReceivedEventArgs());
            }
            _loopCount++;
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
        public Sample? XPosition { get; set; } = new Sample("xPos");

        [Sample("yPos", "user32.dll#GetCursorPos().Y")]
        public int? YPosition { get; set; }

        [Event("prog", "user32.dll#GetWindowText(user32.dll#GetForegroundWindow(), StringBuilder(256), 256)")]
        public string? WindowTitle { get; set; }

        [Event("foobar")]
        public string? FooBar { get; set; } = null;

        [Event("ac")]
        public bool? ACConnected { get; set; } = null;
        [Condition("acState")]
        public Condition ACCondition { get; set; } = new Condition("acState");

        [Sample("battery")]
        public int? BatteryRemaining { get; set; } = null;
        [Condition("batteryState")]
        public Condition BatteryCondition { get; set; } = new Condition("batteryState");
    }
}