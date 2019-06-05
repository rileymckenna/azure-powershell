//------------------------------------------------------------------------------
// <copyright file="PortAllocationType.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Port Allocation Type Enum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PortAllocationType
    {
        None = 0,
        Free = 1,
        Direct = 2, 
        Exchange = 3, 
        Datacenter = 4
    }
}