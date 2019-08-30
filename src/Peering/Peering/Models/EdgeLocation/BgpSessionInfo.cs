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
        /// <param name="interfaceBandwidth"></param>
        /// <param name="addressPortChannelMap"></param>
        public BgpSessionInfo(
            string remoteAddress,
            string remoteAs,
            string peerState,
            string localAddress,
            Dictionary<string, uint> interfaceBandwidth,
            Dictionary<IPAddress, string> addressPortChannelMap)
        {
            this.RemoteAddress = IPAddress.Parse(remoteAddress);
            this.LocalAddress = IPAddress.Parse(localAddress);
            this.RemoteAs = string.IsNullOrEmpty(remoteAs) ? 0 : uint.Parse(remoteAs);

            this.BgpSessionState = Enum.TryParse<BgpSessionState>(peerState, true, out var bgpSessionState) ? bgpSessionState : BgpSessionState.None;
            this.LocalIfName = addressPortChannelMap.ContainsKey(this.LocalAddress) ? addressPortChannelMap[this.LocalAddress] : null;

            if (this.LocalIfName != null && interfaceBandwidth != null)
            {
                if (interfaceBandwidth.ContainsKey(this.LocalIfName))
                {
                    this.LocalIfCapacityMbps = interfaceBandwidth[this.LocalIfName];
                }
            }
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

        /// <summary>
        /// Gets the hash code.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            var hash = 17;
            hash = (hash * 31) + this.RemoteAddress.GetHashCode();
            hash = (hash * 31) + this.RemoteAs.GetHashCode();
            hash = (hash * 31) + this.LocalAddress.GetHashCode();
            hash = (hash * 31) + this.LocalIfName.GetHashCode();
            hash = (hash * 31) + this.BgpSessionState.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Checks if two objects are equal.
        /// </summary>
        /// <param name="other">The other object.</param>
        /// <returns>True if they are equal.</returns>
        public bool Equals(BgpSessionInfo other)
        {
            return other != null && this.RemoteAddress.Equals(other.RemoteAddress) && this.RemoteAs == other.RemoteAs
                   && this.BgpSessionState == other.BgpSessionState && this.LocalAddress.Equals(other.LocalAddress) &&
                   string.Equals(this.LocalIfName, other.LocalIfName, StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// Equals override method.
        /// </summary>
        /// <param name="obj">The other object.</param>
        /// <returns>True if they are equal.</returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as BgpSessionInfo);
        }
    }
}