﻿using Mtconnect.AdapterSdk;
using Mtconnect.AdapterSourceTemplate.Models;
using System;
using System.Threading;

namespace Mtconnect.AdapterSourceTemplate
{
    /// <summary>
    /// Contains an internal timer that periodically gets the current mouse position and active window title then publishes the values to an Adapter.
    /// </summary>
    public class BasicAdapterDataModelSource : IAdapterSource, IDisposable
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
        public BasicAdapterDataModel Model { get; private set; } = new BasicAdapterDataModel();

        private System.Timers.Timer Timer = new System.Timers.Timer();
        private Random Rng = new Random();

        /// <summary>
        /// Constructs a new instance of the PC monitor.
        /// </summary>
        /// <param name="sampleRate">The frequency for which the current states of the PC are collected (in milliseconds).</param>
        public BasicAdapterDataModelSource(int sampleRate = 50)
        {
            // NOTE: You MUST have at least one constructor with a signature containing ONLY primitive types.

            Timer.Interval = sampleRate;
            Timer.Elapsed += Timer_Elapsed;
        }

        // NOTE: This could be tied to a custom egress event, an asynchronous loop, or a timer.
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            string[] executionStates = new string[] { "READY", "ACTIVE", "FEEDHOLD" };

            Model.Availability = "AVAILABLE";

            // TODO: Continue updating the Model with information.
            // NOTE: The underlying Adapter will determine whether a value has changed, so no need to check for updated information.

            Model.Execution = executionStates[Rng.Next(0, 2)];

            Model.Axes.X.ActualPosition = Rng.Next(0, 300);
            Model.Axes.X.CommandedPosition = (float)Model.Axes.X.ActualPosition;
            Model.Axes.X.Load = Rng.Next(0, 100);

            Model.Axes.Y.ActualPosition = Rng.Next(0, 300);
            Model.Axes.Y.CommandedPosition = (float)Model.Axes.Y.ActualPosition;
            Model.Axes.Y.Load = Rng.Next(0, 100);

            Model.Axes.Z.ActualPosition = Rng.Next(0, 300);
            Model.Axes.Z.CommandedPosition = (float)Model.Axes.Z.ActualPosition;
            Model.Axes.Z.Load = Rng.Next(0, 100);

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