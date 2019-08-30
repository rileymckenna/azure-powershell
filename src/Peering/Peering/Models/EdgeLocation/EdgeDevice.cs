﻿//------------------------------------------------------------------------------
// <copyright file="EdgeDevice.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Edge Device
    /// </summary>
    public class EdgeDevice
    {
        /// <summary>
        /// Rack Location
        /// </summary>
        public string RackLocation { get; set; }

        /// <summary>
        /// Colo Id
        /// </summary>
        public string ColoId { get; set; }

        /// <summary>
        /// Device Type
        /// </summary>
        public DeviceType DeviceType { get; set; }

        /// <summary>
        /// Port Channels map, Key is name of port channel
        /// </summary>
        public Dictionary<string, PortChannel> PortChannels { get; set; }

        /// <summary>
        ///  Ports Map
        /// </summary>
        public Dictionary<string, DevicePort> Ports { get; set; }

        /// <summary>
        /// If device can Take Connections
        /// </summary>
        public bool IsTakingNewConnection { get; set; }

        /// <summary>
        /// Device Id of the paired device at the edge location
        /// </summary>
        public List<string> PairDevices { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeDevice"/> class.
        /// </summary>
        public EdgeDevice()
        {
            this.PortChannels = new Dictionary<string, PortChannel>(StringComparer.InvariantCultureIgnoreCase);
            this.Ports = new Dictionary<string, DevicePort>(StringComparer.InvariantCultureIgnoreCase);
            this.PairDevices = new List<string>();
        }

        /// <summary>
        /// Clone method
        /// </summary>
        /// <returns></returns>
        public EdgeDevice Clone()
        {
            var edgeDevice = new EdgeDevice
            {
                DeviceType = this.DeviceType,
                ColoId = this.ColoId,
                RackLocation = this.RackLocation,
                IsTakingNewConnection = this.IsTakingNewConnection
            };

            foreach (var portChannel in this.PortChannels)
            {
                edgeDevice.PortChannels[portChannel.Key] = portChannel.Value.Clone();
            }

            foreach (var port in this.Ports)
            {
                edgeDevice.Ports[port.Key] = port.Value.Clone();
            }

            foreach (var pair in this.PairDevices)
            {
                edgeDevice.PairDevices.Add(pair);
            }
            return edgeDevice;
        }
    }
}