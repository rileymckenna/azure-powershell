//------------------------------------------------------------------------------
// <copyright file="PortChannel.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{
    using System;
    using System.Collections.Generic;

    using TeamFoundationServerPowershell.Model;

    /// <summary>
    /// Port channel class
    /// </summary>
    public class PortChannel
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
        /// List of ports
        /// </summary>
        public Dictionary<string, RemotePortInfo> PortChannelPorts { get; set; }

        /// <summary>
        /// Contact info for circuit provider
        /// </summary>
        public ContactInfo CircuitContactInfo { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortChannel"/> class.
        /// </summary>
        public PortChannel()
        {
            this.PortChannelPorts = new Dictionary<string, RemotePortInfo>(StringComparer.InvariantCultureIgnoreCase);
            this.SessionIpv4PrefixList = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
            this.SessionIpv6PrefixList = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
            this.PeerInfoMap = new Dictionary<uint, List<PeerSessionInfo>>();
        }

        /// <summary>
        /// Clone method
        /// </summary>
        /// <returns></returns>
        public PortChannel Clone()
        {
            var portChannel = new PortChannel
            {
                PortBandwidth = this.PortBandwidth,
                PortAllocationType = this.PortAllocationType,
                CircuitContactInfo = this.CircuitContactInfo?.Clone(),
            };

            foreach (var portChannelPort in this.PortChannelPorts)
            {
                portChannel.PortChannelPorts[portChannelPort.Key] = portChannelPort.Value.Clone();
            }

            foreach (var prefix in this.SessionIpv4PrefixList)
            {
                portChannel.SessionIpv4PrefixList.Add(prefix);
            }

            foreach (var prefix in this.SessionIpv6PrefixList)
            {
                portChannel.SessionIpv6PrefixList.Add(prefix);
            }

            foreach (var peerInfo in this.PeerInfoMap)
            {
                var sessionList = new List<PeerSessionInfo>();

                foreach (var peerSessionInfo in peerInfo.Value)
                {
                    sessionList.Add(peerSessionInfo.Clone());
                }

                portChannel.PeerInfoMap[peerInfo.Key] = sessionList;
            }

            return portChannel;
        }
    }
}