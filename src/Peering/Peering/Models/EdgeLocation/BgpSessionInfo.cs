//------------------------------------------------------------------------------
// <copyright file="BgpSessionInfo.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Net;
    using Newtonsoft.Json;

    /// <summary>
    /// Bgp Session Info class
    /// </summary>
    public class BgpSessionInfo
    {
        /// <summary>
        /// Remote Address
        /// </summary>


        public IPAddress RemoteAddress { get; set; }

        /// <summary>
        /// Remote As
        /// </summary>
        public uint RemoteAs { get; set; }

        /// <summary>
        /// Peer State
        /// </summary>
        public BgpSessionState BgpSessionState { get; set; }

        /// <summary>
        /// Local Address
        /// </summary>


        public IPAddress LocalAddress { get; set; }

        /// <summary>
        /// Local If Name
        /// </summary>
        public string LocalIfName { get; set; }

        /// <summary>
        /// Local If capacity
        /// </summary>
        public uint LocalIfCapacityMbps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="remoteAddress"></param>
        /// <param name="remoteAs"></param>
        /// <param name="peerState"></param>
        /// <param name="localAddress"></param>
        /// <param name="localIfCapacityMbps"></param>
        /// <param name="interfaceIpMap"></param>
        public BgpSessionInfo(string remoteAddress,
            string remoteAs,
            string peerState,
            string localAddress,
            string localIfCapacityMbps,
            Dictionary<IPAddress, string> interfaceIpMap)
        {
            this.RemoteAddress = IPAddress.Parse(remoteAddress);
            this.LocalAddress = IPAddress.Parse(localAddress);
            this.RemoteAs = string.IsNullOrEmpty(remoteAs) ? 0 : UInt32.Parse(remoteAs);
            this.LocalIfCapacityMbps = UInt32.Parse(localIfCapacityMbps);
            this.BgpSessionState = Enum.TryParse<BgpSessionState>(peerState, out var bgpSessionState)
                                       ? bgpSessionState
                                       : BgpSessionState.None;
            this.LocalIfName = interfaceIpMap.ContainsKey(this.LocalAddress) ? interfaceIpMap[this.LocalAddress] : null;
        }

        /// <summary>
        /// To string override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"RemoteAddress={this.RemoteAddress}|" +
                   $"LocalAddress={this.LocalAddress}|" +
                   $"RemoteAs={this.RemoteAs}|" +
                   $"LocalIfCapacityMbps={this.LocalIfCapacityMbps}|" +
                   $"BgpSessionState={this.BgpSessionState}|" +
                   $"LocalIfName={this.LocalIfName}";
        }
    }
}