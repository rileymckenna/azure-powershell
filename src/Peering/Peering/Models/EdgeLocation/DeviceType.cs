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
    /// Peer Type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeviceType
    {
        // ReSharper disable InconsistentNaming
        None = 0,
        IER = 1,
        TER = 2,
        // ReSharper enable InconsistentNaming
    }
}