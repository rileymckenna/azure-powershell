//------------------------------------------------------------------------------
// <copyright file="BgpSessionState.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The state of the BGP session.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BgpSessionState
    {
        /// <summary>
        /// Default state without session
        /// </summary>
        None = 0,

        /// <summary>
        /// ref https://en.wikipedia.org/wiki/Border_Gateway_Protocol 
        /// </summary>
        Idle = 1,

        /// <summary>
        /// ref https://en.wikipedia.org/wiki/Border_Gateway_Protocol 
        /// </summary>
        Connect = 2,

        /// <summary>
        /// ref https://en.wikipedia.org/wiki/Border_Gateway_Protocol 
        /// </summary>
        Active = 3,

        /// <summary>
        /// ref https://en.wikipedia.org/wiki/Border_Gateway_Protocol 
        /// </summary>
        OpenSent = 4,

        /// <summary>
        /// ref https://en.wikipedia.org/wiki/Border_Gateway_Protocol 
        /// </summary>
        OpenConfirm = 5,

        /// <summary>
        /// ref https://en.wikipedia.org/wiki/Border_Gateway_Protocol 
        /// </summary>
        Established = 6,

        /// <summary>
        /// Custom state indicating that the session is pending to be added.
        /// </summary>
        PendingAdd = 997,

        /// <summary>
        /// Custom state indicating that the session is pending to be updated.
        /// </summary>
        PendingUpdate = 998,

        /// <summary>
        /// Custom state indicating that the session is pending to be removed.
        /// </summary>
        PendingRemove = 999
    }
}