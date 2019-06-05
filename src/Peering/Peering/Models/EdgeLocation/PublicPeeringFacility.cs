//------------------------------------------------------------------------------
// <copyright file="PublicPeeringFacility.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Public Peering Facility: Microsoft Azure facility used for exchange peering (and sometimes direct)
    /// </summary>
    public class PublicPeeringFacility
    {
        /// <summary>
        /// Gets or sets value for Edge Location Codes
        /// </summary>
        public HashSet<string> CodeList { get; set; }

        /// <summary>
        /// Gets or sets value for Country Name
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets value for Name 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets value for Location Type 
        /// </summary>
        public LocationType LocationType { get; set; }

        /// <summary>
        /// Gets or sets value for Facility Link.
        /// </summary>
        public string PeeringDBFacilityLink { get; set; }

        /// <summary>
        /// Gets or sets value for Ipv4 Prefix
        /// </summary>
        public HashSet<string> Ipv4PrefixList { get; set; }

        /// <summary>
        /// Gets or sets value for Ipv6 Prefix
        /// </summary>
        public HashSet<string> Ipv6PrefixList { get; set; }

        /// <summary>
        /// Gets or sets value for MicrosoftSessionIpv4AddressList
        /// </summary>
        public HashSet<string> MicrosoftSessionIpv4AddressList { get; set; }

        /// <summary>
        /// Gets or sets value for MicrosoftSessionIpv6AddressList
        /// </summary>
        public HashSet<string> MicrosoftSessionIpv6AddressList { get; set; }

        /// <summary>
        /// Gets or sets value for Bandwidth
        /// </summary>
        public uint Bandwidth { get; set; }

        /// <summary>
        /// List Of Devices, key is device name
        /// </summary>
        public Dictionary<string, EdgeDevice> Devices { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicPeeringFacility"/> class.
        /// </summary>
        public PublicPeeringFacility()
        {
            this.CodeList = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
            this.Ipv4PrefixList = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
            this.Ipv6PrefixList = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
            this.MicrosoftSessionIpv4AddressList = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
            this.MicrosoftSessionIpv6AddressList = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
            this.Devices = new Dictionary<string, EdgeDevice>(StringComparer.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// The clone.
        /// </summary>
        /// <returns>
        /// The <see cref="PublicPeeringFacility"/>.
        /// </returns>
        public PublicPeeringFacility Clone()
        {
            var publicPeeringFacility = new PublicPeeringFacility
            {
                Bandwidth = this.Bandwidth,
                Country = this.Country,
                PeeringDBFacilityLink = this.PeeringDBFacilityLink,
                LocationType = this.LocationType,
                Name = this.Name,
            };

            foreach (var code in this.CodeList)
            {
                publicPeeringFacility.CodeList.Add(code);
            }

            foreach (var prefix in this.Ipv4PrefixList)
            {
                publicPeeringFacility.Ipv4PrefixList.Add(prefix);
            }

            foreach (var prefix in this.Ipv6PrefixList)
            {
                publicPeeringFacility.Ipv6PrefixList.Add(prefix);
            }

            foreach (var address in this.MicrosoftSessionIpv4AddressList)
            {
                publicPeeringFacility.MicrosoftSessionIpv4AddressList.Add(address);
            }

            foreach (var address in this.MicrosoftSessionIpv6AddressList)
            {
                publicPeeringFacility.MicrosoftSessionIpv6AddressList.Add(address);
            }

            foreach (var edgeDevice in this.Devices)
            {
                publicPeeringFacility.Devices[edgeDevice.Key] = edgeDevice.Value.Clone();
            }

            return publicPeeringFacility;
        }
    }
}