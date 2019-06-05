//------------------------------------------------------------------------------
// <copyright file="PeeringSkuFamily.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The peering SKU family.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PeeringSkuFamily
    {
        /// <summary>
        /// Default family.
        /// </summary>
        Default,

        /// <summary>
        /// Peering thru direct.
        /// </summary>
        Direct,

        /// <summary>
        /// Peering thru exchange.
        /// </summary>
        Exchange,

        /// <summary>
        /// Peering thru partner.
        /// </summary>
        Partner
    }
}