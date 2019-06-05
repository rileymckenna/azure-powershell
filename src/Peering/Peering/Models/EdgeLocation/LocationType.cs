//------------------------------------------------------------------------------
// <copyright file="LocationType.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Location Type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LocationType
    {
        None = 0,
        Production = 1,
        Test = 2
    }
}