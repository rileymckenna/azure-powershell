//------------------------------------------------------------------------------
// <copyright file="DevicePort.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{
    using System;
    using System.Collections.Generic;

    using TeamFoundationServerPowershell.Model;

    /// <summary>
    /// Device Port class
    /// </summary>
    public class DevicePort
    {
        /// <summary>
        /// Port bandwidth
        /// </summary>
        public uint PortBandwidth { get; set; }

        /// <summary>
        /// Port allocation Type
        /// </summary>
        public PortAllocationType PortAllocationType { get; set; }

        /// <summary>
        /// Remote Rack location
        /// </summary>
        public string RemoteRackLocation { get; set; }

        /// <summary>
        /// Remote Colo Id
        /// </summary>
        public string RemoteColoId { get; set; }

        /// <summary>
        /// Remote Port Id
        /// </summary>
        public string RemotePortId { get; set; }

        /// <summary>
        /// Session Ipv4 Prefix
        /// </summary>
        public HashSet<string> SessionIpv4PrefixList { get; set; }

        /// <summary>
        /// Session Ipv6 Prefix
        /// </summary>
        public HashSet<string> SessionIpv6PrefixList { get; set; }

        /// <summary>
        /// Map of peers, key is Peer ASN
        /// </summary>
        public IDictionary<uint, List<PeerSessionInfo>> PeerInfoMap { get; set; }

        /// <summary>
        /// Contact info for circuit provider
        /// </summary>
        public ContactInfo CircuitContactInfo { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DevicePort"/> class.
        /// </summary>
        public DevicePort()
        {
            this.SessionIpv4PrefixList = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
            this.SessionIpv6PrefixList = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
            this.PeerInfoMap = new Dictionary<uint, List<PeerSessionInfo>>();
        }

        /// <summary>
        /// Clone method
        /// </summary>
        /// <returns></returns>
        public DevicePort Clone()
        {
            var devicePort = new DevicePort
            {
                PortBandwidth = this.PortBandwidth,
                PortAllocationType = this.PortAllocationType,
                CircuitContactInfo = this.CircuitContactInfo?.Clone(),
                RemoteRackLocation = this.RemoteRackLocation,
                RemotePortId = this.RemotePortId,
                RemoteColoId = this.RemoteColoId
            };

            foreach (var prefix in this.SessionIpv4PrefixList)
            {
                devicePort.SessionIpv4PrefixList.Add(prefix);
            }

            foreach (var prefix in this.SessionIpv6PrefixList)
            {
                devicePort.SessionIpv6PrefixList.Add(prefix);
            }

            foreach (var peerInfo in this.PeerInfoMap)
            {
                var sessionList = new List<PeerSessionInfo>();

                foreach (var peerSessionInfo in peerInfo.Value)
                {
                    sessionList.Add(peerSessionInfo.Clone());
                }

                devicePort.PeerInfoMap[peerInfo.Key] = sessionList;
            }

            return devicePort;
        }
    }
}