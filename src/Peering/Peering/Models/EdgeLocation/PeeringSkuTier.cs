//------------------------------------------------------------------------------
// <copyright file="PeeringSkuTier.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The peering SKU tier.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PeeringSkuTier
    {
        /// <summary>
        /// No SLA.
        /// </summary>
        Basic,

        /// <summary>
        /// With SLA.
        /// </summary>
        Premium
    }
}