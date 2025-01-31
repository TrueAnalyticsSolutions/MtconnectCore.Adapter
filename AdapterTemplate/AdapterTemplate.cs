﻿using System;
using System.Threading;
using Mtconnect.AdapterSdk;
using Mtconnect.AdapterSdk.DataItems;

namespace Mtconnect.AdapterTemplate
{
    /// <summary>
    /// TODO: Explain the method or protocol for which MTConnect data is published.
    /// </summary>
    public sealed class AdapterTemplate : Adapter
    {
        /// <summary>
        /// Constructs a new <see cref="AdapterTemplate"/>.
        /// </summary>
        /// <param name="options"><inheritdoc cref="AdapterOptionsTemplate" path="/summary"/></param>
        /// <param name="logger"><inheritdoc cref="IAdapterLogger" path="/summary"/></param>
        public AdapterTemplate(AdapterOptionsTemplate options, IAdapterLogger logger = default) : base(options, logger) { }

        /// <inheritdoc />
        protected override void Start(bool begin = true, CancellationToken token = default)
        {
            if (State <= AdapterStates.NotStarted)
            {
                _logger?.LogInformation("Starting Adapter");
                State = AdapterStates.Starting;

                // TODO: Initialize and begin any connections for publish

                // Start before the _listenerThread because it relies on state being Busy
                State = AdapterStates.Started;
            }

            if (begin) Begin();
        }

        /// <inheritdoc />
        public override void Stop(Exception ex = null)
        {
            base.Stop(ex);

            if (State > AdapterStates.NotStarted)
            {
                _logger?.LogInformation("Stopping Adapter");
                State = AdapterStates.Stopping;

                // TODO: Begin closing connections

                State = AdapterStates.Stopped;
            }
        }

        /// <inheritdoc />
        public override void Send(DataItemSendTypes sendType = DataItemSendTypes.Changed, string clientId = null)
        {
            if (HasBegun)
                foreach (var item in DataItems) item.Prepare();

            base.Send(sendType, clientId);

            // Cleanup
            foreach (DataItem di in DataItems) di.Cleanup();
            HasBegun = false;
        }

        /// <inheritdoc />
        protected override void Write(string message, string clientId = null)
        {
            _logger?.LogDebug("Sending message: {Message}", message);

            // TODO: Publish the pipe-delimitted message from the underlying Adapter thru your connection
        }
    }
}
