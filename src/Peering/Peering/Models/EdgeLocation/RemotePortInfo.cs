//------------------------------------------------------------------------------
// <copyright file="RemotePortInfo.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{
    /// <summary>
    /// Remote Port Info
    /// </summary>
    public class RemotePortInfo
    { 
        /// <summary>
        /// Remote Rack location
        /// </summary>
        public string RemoteRackLocation { get; set; }

        /// <summary>
        /// Remote Colo Id
        /// </summary>
        public string RemoteColoId { get; set; }

        /// <summary>
        /// Remote Port Id
        /// </summary>
        public string RemotePortId { get; set; }

        /// <summary>
        /// Clone object
        /// </summary>
        /// <returns></returns>
        public RemotePortInfo Clone()
        {
            return new RemotePortInfo
            {
                RemoteRackLocation = this.RemoteRackLocation,
                RemoteColoId = this.RemoteColoId,
                RemotePortId = this.RemotePortId
            };
        }
    }
}