//------------------------------------------------------------------------------
// <copyright file="EdgeLocation.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// Edge Location
    /// </summary>
    public class EdgeLocation
    {
        /// <summary>
        ///  Gets or sets the value for Location Name
        /// </summary>
        public string LocationName { get; set; }

        /// <summary>
        /// Gets or sets the azure region for the location.
        /// </summary>
        public string AzureRegion { get; set; }

        /// <summary>
        /// Gets or sets the serving endpoint.
        /// </summary>
        public string ServingEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the value for PrivatePeeringFacilityMap, used for direct peering
        /// </summary>
        public Dictionary<uint, PrivatePeeringFacility> PrivatePeeringFacilityMap { get; set; }

        /// <summary>
        /// Gets or sets the value for PublicPeeringFacilityMap, used for exchange peering
        /// </summary>
        public Dictionary<uint, PublicPeeringFacility> PublicPeeringFacilityMap { get; set; }

        /// <summary>
        /// Gets or sets the value for TransitPeeringFacilityMap, used for direct peering
        /// </summary>
        public Dictionary<uint, PrivatePeeringFacility> TransitPeeringFacilityMap { get; set; }

        /// <summary>
        /// Gets or sets the value for InternalPeeringFacilityMap, used for direct peering
        /// </summary>
        public Dictionary<uint, PrivatePeeringFacility> InternalPeeringFacilityMap { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeLocation"/> class. 
        /// </summary>
        public EdgeLocation()
        {
            this.PrivatePeeringFacilityMap = new Dictionary<uint, PrivatePeeringFacility>();
            this.PublicPeeringFacilityMap = new Dictionary<uint, PublicPeeringFacility>();
            this.TransitPeeringFacilityMap = new Dictionary<uint, PrivatePeeringFacility>();
            this.InternalPeeringFacilityMap = new Dictionary<uint, PrivatePeeringFacility>();
        }

        /// <summary>
        /// Clone method
        /// </summary>
        /// <returns></returns>
        public EdgeLocation Clone()
        {
            var edgeLocation = new EdgeLocation
            {
                AzureRegion = this.AzureRegion,
                LocationName = this.LocationName,
                ServingEndpoint = this.ServingEndpoint
            };

            foreach (var privatePeeringFacility in this.PrivatePeeringFacilityMap)
            {
                edgeLocation.PrivatePeeringFacilityMap[privatePeeringFacility.Key] =
                    privatePeeringFacility.Value.Clone();
            }

            foreach (var publicPeeringFacility in this.PublicPeeringFacilityMap)
            {
                edgeLocation.PublicPeeringFacilityMap[publicPeeringFacility.Key] =
                    publicPeeringFacility.Value.Clone();
            }

            foreach (var transitPeeringFacility in this.TransitPeeringFacilityMap)
            {
                edgeLocation.TransitPeeringFacilityMap[transitPeeringFacility.Key] =
                    transitPeeringFacility.Value.Clone();
            }

            foreach (var internalPeeringFacility in this.InternalPeeringFacilityMap)
            {
                edgeLocation.InternalPeeringFacilityMap[internalPeeringFacility.Key] =
                    internalPeeringFacility.Value.Clone();
            }

            return edgeLocation;
        }
    }
}
