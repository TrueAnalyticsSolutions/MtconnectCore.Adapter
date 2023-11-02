using Mtconnect.AdapterSdk;
using Mtconnect.AdapterSdk.DataItemValues;
using Mtconnect.AdapterSourceTemplate.Models;
using System;
using System.Threading;

namespace Mtconnect.AdapterSourceTemplate
{
    /// <summary>
    /// Contains an internal timer that periodically gets the current mouse position and active window title then publishes the values to an Adapter.
    /// </summary>
    public class AdvancedAdapterDataModelSource : IAdapterSource, IDisposable
    {
        public string DeviceUuid => throw new NotImplementedException();

        public string DeviceName => throw new NotImplementedException();

        public string StationId => throw new NotImplementedException();

        public string SerialNumber => throw new NotImplementedException();

        public string Manufacturer => throw new NotImplementedException();

        /// <inheritdoc />
        public event DataReceivedHandler OnDataReceived;
        /// <inheritdoc />
        public event AdapterSourceStartedHandler OnAdapterSourceStarted;
        /// <inheritdoc />
        public event AdapterSourceStoppedHandler OnAdapterSourceStopped;

        /// TODO: Change the type to your data model or implement some other form of managing a IAdapterDataModel
        public AdvancedAdapterDataModel Model { get; private set; } = new AdvancedAdapterDataModel();


        private System.Timers.Timer Timer = new System.Timers.Timer();

        /// <summary>
        /// Constructs a new instance of the PC monitor.
        /// </summary>
        /// <param name="sampleRate">The frequency for which the current states of the PC are collected (in milliseconds).</param>
        public AdvancedAdapterDataModelSource(int sampleRate = 50)
        {
            // NOTE: You MUST have at least one constructor with a signature containing ONLY primitive types.

            Timer.Interval = sampleRate;
            Timer.Elapsed += Timer_Elapsed;
        }

        // NOTE: This could be tied to a custom egress event, an asynchronous loop, or a timer.
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Model.Availability = Availability.AVAILABLE;
            var rnd = new Random();
            string[] axes = new string[] { "x", "y", "z" };
            foreach (var axis in axes)
            {
                if (!Model.Axes.LinearAxes.ContainsKey(axis))
                    Model.Axes.LinearAxes.Add(axis, new AdvancedLinearAxis());
                Model.Axes.LinearAxes[axis].Load = rnd.Next(100);
                float pos = rnd.Next(1000);
                Model.Axes.LinearAxes[axis].ActualPosition = new float?[] { pos, pos, pos };
                Model.Axes.LinearAxes[axis].CommandedPosition = new float?[] { pos, pos, pos };
                Model.Axes.LinearAxes[axis].Motor.Load = rnd.Next(100);
                Model.Axes.LinearAxes[axis].Motor.Amperage = rnd.Next(120);
                Model.Axes.LinearAxes[axis].Motor.Torque = rnd.Next(120);
            }

            // TODO: Continue updating the Model with information.
            if (!Model.Controller.Paths.ContainsKey("primary"))
                Model.Controller.Paths.Add("primary", new MyPath());
            Model.Controller.Paths["primary"].Execution = Execution.READY;
            Model.Controller.Paths["primary"].ActiveProgram = "#1";

            if (!Model.Controller.Paths.ContainsKey("secondary"))
                Model.Controller.Paths.Add("secondary", new MyPath());
            Model.Controller.Paths["secondary"].Execution = Execution.READY;
            Model.Controller.Paths["secondary"].ActiveProgram = "#2";
            // NOTE: The underlying Adapter will determine whether a value has changed, so no need to check for updated information.

            OnDataReceived?.Invoke(this, new DataReceivedEventArgs(Model));
        }

        /// <inheritdoc />
        public void Start(CancellationToken token = default)
        {
            // NOTE: Start any timers, loops, or attach to any egress events from here.
            Timer.Start();

            OnAdapterSourceStarted?.Invoke(this, new AdapterSourceStartedEventArgs());
        }

        /// <inheritdoc />
        public void Stop(Exception ex = null)
        {
            // NOTE: Stop any timers or loops, or detatch from any egress events from here.
            Timer.Stop();

            OnAdapterSourceStopped?.Invoke(this, new AdapterSourceStoppedEventArgs(ex));
        }

        public void Dispose()
        {
            Timer.Dispose();
        }
    }
}