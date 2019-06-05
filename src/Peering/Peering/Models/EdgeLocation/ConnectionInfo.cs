//------------------------------------------------------------------------------
// <copyright file="ConnectionInfo.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{
    /// <summary>
    /// Connection Info
    /// </summary>
    public class ConnectionInfo
    {
        /// <summary>
        /// Gets or sets the connection IP v4 address, formatted as PeerV4_MicrosoftV4
        /// </summary>
        public string ConnectionIPv4Address { get; set; }

        /// <summary>
        /// Gets or sets the connection IP v6 address, formatted as PeerV6_MicrosoftV6
        /// </summary>
        public string ConnectionIPv6Address { get; set; }

        /// <summary>
        /// Gets or sets the SKU family.
        /// </summary>
        public PeeringSkuFamily PeeringSkuFamily { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the connection is removed.
        /// </summary>
        public bool ConnectionRemoved { get; set; }

        /// <summary>
        /// Gets a clone of the object.
        /// </summary>
        /// <returns>The clone of the object.</returns>
        public ConnectionInfo Clone()
        {
            return new ConnectionInfo
            {
                ConnectionIPv4Address = this.ConnectionIPv4Address,
                ConnectionIPv6Address = this.ConnectionIPv6Address,
                PeeringSkuFamily = this.PeeringSkuFamily,
                ConnectionRemoved = this.ConnectionRemoved
            };
        }

        /// <summary>
        /// Gets the string representation of the object.
        /// </summary>
        /// <returns>The string representation of the object.</returns>
        public override string ToString()
        {
            return $"ConnectionIPv4Address={this.ConnectionIPv4Address}|" +
                   $"ConnectionIPv6Address={this.ConnectionIPv6Address}|" +
                   $"PeeringSkuFamily={this.PeeringSkuFamily}|" +
                   $"ConnectionRemoved={this.ConnectionRemoved}";
        }

        /// <summary>
        /// Checks if the other object is equal to this.
        /// </summary>
        /// <param name="obj">The other object.</param>
        /// <returns>True if both are equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj is ConnectionInfo connectionInfo)
            {
                return connectionInfo.ConnectionIPv4Address.Equals(this.ConnectionIPv4Address)
                       && connectionInfo.ConnectionIPv6Address.Equals(this.ConnectionIPv6Address)
                       && connectionInfo.PeeringSkuFamily == this.PeeringSkuFamily
                       && connectionInfo.ConnectionRemoved == this.ConnectionRemoved;
            }

            return false;
        }

        /// <summary>
        /// Gets the hash code.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (this.ConnectionIPv4Address != null ? this.ConnectionIPv4Address.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (this.ConnectionIPv6Address != null
                                                   ? this.ConnectionIPv6Address.GetHashCode()
                                                   : 0);
                hashCode = (hashCode * 397) ^ (int)this.PeeringSkuFamily;
                hashCode = (hashCode * 397) ^ this.ConnectionRemoved.GetHashCode();
                return hashCode;
            }
        }
    }
}