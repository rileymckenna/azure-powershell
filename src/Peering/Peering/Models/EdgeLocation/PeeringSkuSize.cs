//------------------------------------------------------------------------------
// <copyright file="PeeringSkuSize.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The peering SKU size.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PeeringSkuSize
    {
        /// <summary>
        /// Free of charge.
        /// </summary>
        Free,

        /// <summary>
        /// Charged as per usage.
        /// </summary>
        Metered,

        /// <summary>
        /// Charged for port with reserved capacity.
        /// </summary>
        Unlimited
    }
}