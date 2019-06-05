//------------------------------------------------------------------------------
// <copyright file="PeerSessionInfo.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{
    using System;
    using System.ComponentModel;
    using System.Net;

    using Newtonsoft.Json;

    /// <summary>
    /// Peer Session Info class
    /// </summary>
    public class PeerSessionInfo : IEquatable<PeerSessionInfo>
    { 
        /// <summary>
        /// Peer V4 State
        /// </summary>
        public BgpSessionState PeerV4State { get; set; }

        /// <summary>
        /// Peer Session V4 Address
        /// </summary>


        public IPAddress PeerSessionV4Address { get; set; }

        /// <summary>
        /// Microsoft Session V6 Address
        /// </summary>


        public IPAddress MicrosoftSessionV4Address { get; set; }

        /// <summary>
        /// Peer V6 State
        /// </summary>
        public BgpSessionState PeerV6State { get; set; }

        /// <summary>
        /// Peer Session V6 Address
        /// </summary>


        public IPAddress PeerSessionV6Address { get; set; }

        /// <summary>
        /// Microsoft Session V6 Address
        /// </summary>


        public IPAddress MicrosoftSessionV6Address { get; set; }

        /// <summary>
        /// Last Updated time
        /// </summary>
        public DateTime LastUpdatedTime { get; set; }

        /// <summary>
        /// Connection Identifier
        /// </summary>
        public string ConnectionIdentifier { get; set; }

        #region Overrides

        /// <summary>
        /// IEquatable
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(PeerSessionInfo other)
        {
            if (other == null)
            {
                return false;
            }

            return (((this.MicrosoftSessionV4Address != null &&
                      this.MicrosoftSessionV4Address.Equals(other.MicrosoftSessionV4Address))
                     || (this.MicrosoftSessionV4Address == null && other.MicrosoftSessionV4Address == null)) &&

                    ((this.PeerSessionV4Address != null && this.PeerSessionV4Address.Equals(other.PeerSessionV4Address))
                     || (this.PeerSessionV4Address == null && other.PeerSessionV4Address == null)) &&

                    ((this.MicrosoftSessionV6Address != null &&
                      this.MicrosoftSessionV6Address.Equals(other.MicrosoftSessionV6Address))
                     || (this.MicrosoftSessionV6Address == null && other.MicrosoftSessionV6Address == null)) &&

                    ((this.PeerSessionV6Address != null && this.PeerSessionV6Address.Equals(other.PeerSessionV6Address))
                     || (this.PeerSessionV6Address == null && other.PeerSessionV6Address == null)));
        }

        /// <summary>
        /// Returns true if two objects are equal.
        /// </summary>
        /// <param name="obj">The object</param>
        /// <returns>True if two objects are equal</returns>
        public override bool Equals(object obj)
        {
            return obj is PeerSessionInfo peerSessionInfo && this.Equals(peerSessionInfo);
        }

        /// <summary>
        /// Returns the hash code.
        /// </summary>
        /// <returns>The hash code</returns>
        public override int GetHashCode()
        {
            var hash = 17;
            hash = (hash * 31) + this.MicrosoftSessionV4Address.GetHashCode();
            hash = (hash * 31) + this.PeerSessionV4Address.GetHashCode();
            hash = (hash * 31) + this.MicrosoftSessionV6Address.GetHashCode();
            hash = (hash * 31) + this.PeerSessionV6Address.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Returns the string representation of the object.
        /// </summary>
        /// <returns>The string representation of the object</returns>
        public override string ToString()
        {
            return $"MicrosoftSessionV4Address={this.MicrosoftSessionV4Address}|"
                   + $"PeerSessionV4Address={this.PeerSessionV4Address}|"
                   + $"MicrosoftSessionV6Address={this.MicrosoftSessionV6Address}|"
                   + $"PeerSessionV6Address={this.PeerSessionV6Address}|"
                   + $"PeerV4State={this.PeerV4State.ToString()}|" 
                   + $"PeerV6State={this.PeerV6State.ToString()}|" 
                   + $"LastUpdatedTime={this.LastUpdatedTime:o}|"
                   + $"ConnectionIdentifier={this.ConnectionIdentifier}";
        }

        /// <summary>
        /// Clone method
        /// </summary>
        /// <returns></returns>
        public PeerSessionInfo Clone()
        {
            return new PeerSessionInfo
            {
                MicrosoftSessionV4Address = this.MicrosoftSessionV4Address,
                MicrosoftSessionV6Address = this.MicrosoftSessionV6Address,
                PeerSessionV4Address = this.PeerSessionV4Address,
                PeerSessionV6Address = this.PeerSessionV6Address,
                PeerV4State = this.PeerV4State,
                PeerV6State = this.PeerV6State,
                LastUpdatedTime = this.LastUpdatedTime,
                ConnectionIdentifier = this.ConnectionIdentifier
            };
        }

        /// <summary>
        /// Any session equal
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool AnySessionEqual(PeerSessionInfo other)
        {
            if (other == null)
            {
                return false;
            }

            return (((this.MicrosoftSessionV4Address != null &&
                      this.MicrosoftSessionV4Address.Equals(other.MicrosoftSessionV4Address)) &&
                     (this.PeerSessionV4Address != null &&
                      this.PeerSessionV4Address.Equals(other.PeerSessionV4Address))) ||
                    ((this.MicrosoftSessionV6Address != null &&
                      this.MicrosoftSessionV6Address.Equals(other.MicrosoftSessionV6Address)) &&
                     (this.PeerSessionV6Address != null &&
                      this.PeerSessionV6Address.Equals(other.PeerSessionV6Address))));
        }

        #endregion
    }
}