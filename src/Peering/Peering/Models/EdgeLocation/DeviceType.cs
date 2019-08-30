//------------------------------------------------------------------------------
// <copyright file="DeviceType.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Device Type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeviceType
    {
        None = 0,

        /// <summary>
        /// IERs and 96cbe
        /// </summary>
        InternetEdgeRouter = 1,

        /// <summary>
        /// TER devices
        /// </summary>
        TransitEdgeRouter = 2,

        /// <summary>
        /// CAR devices
        /// </summary>
        CorpAggRouter = 3,
    }
}