//------------------------------------------------------------------------------
// <copyright file="PeeringSkuName.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

// ReSharper disable InconsistentNaming
namespace TeamFoundationServerPowershell.Model
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The peering SKU name.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PeeringSkuName
    {
        /// <summary>
        /// The default SKU name.
        /// </summary>
        Default,

        /// <summary>
        /// No SLA, thru exchange, free of charge.
        /// </summary>
        Basic_Exchange_Free,
        
        /// <summary>
        /// No SLA, thru direct, free of charge.
        /// </summary>
        Basic_Direct_Free,

        /// <summary>
        /// With SLA, thru direct, free of charge.
        /// For partners to support partner peering.
        /// </summary>
        Premium_Direct_Free,

        /// <summary>
        /// With SLA, thru partner, charged as per usage.
        /// </summary>
        Premium_Partner_Metered,

        /// <summary>
        /// With SLA, thru exchange, charged as per usage.
        /// </summary>
        Premium_Exchange_Metered,
    }
}