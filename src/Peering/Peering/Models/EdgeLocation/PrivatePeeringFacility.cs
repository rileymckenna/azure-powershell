//------------------------------------------------------------------------------
// <copyright file="PrivatePeeringFacility.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Private Peering facility: Microsoft Azure facility that supports direct peering
    /// </summary>
    public class PrivatePeeringFacility
    {
        /// <summary>
        /// Gets or sets value for Edge Location Codes
        /// </summary>
        public HashSet<string> CodeList { get; set; }

        /// <summary>
        /// Gets or sets the value for  Country Name
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the value for  Address 
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the value for Latitude 
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the value for  Longitude 
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or sets the value for  PeeringLocation Type 
        /// </summary>
        public LocationType LocationType { get; set; }

        /// <summary>
        /// Gets or sets the value for Facility Link.
        /// </summary>
        public string PeeringDBFacilityLink { get; set; }

        /// <summary>
        /// List Of Devices, key is device name
        /// </summary>
        public Dictionary<string, EdgeDevice> Devices { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivatePeeringFacility"/> class.
        /// </summary>
        public PrivatePeeringFacility()
        {
            this.CodeList = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            this.Devices = new Dictionary<string, EdgeDevice>(StringComparer.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// The clone.
        /// </summary>
        /// <returns>
        /// The <see cref="PrivatePeeringFacility"/>.
        /// </returns>
        public PrivatePeeringFacility Clone()
        {
            var privatePeeringFacility = new PrivatePeeringFacility
            {
                Address = this.Address,
                Country = this.Country,
                PeeringDBFacilityLink = this.PeeringDBFacilityLink,
                Latitude = this.Latitude,
                Longitude = this.Longitude,
                LocationType = this.LocationType,
            };

            foreach (var code in this.CodeList)
            {
                privatePeeringFacility.CodeList.Add(code);
            }

            foreach (var edgeDevice in this.Devices)
            {
                privatePeeringFacility.Devices[edgeDevice.Key] = edgeDevice.Value.Clone();
            }

            return privatePeeringFacility;
        }
    }
}