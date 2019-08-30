//------------------------------------------------------------------------------
// <copyright file="DeviceMetadata.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Facility device info for holding data from devicemetadata.xml
    /// </summary>
    public class DeviceMetadata : IEquatable<DeviceMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceMetadata"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="deviceType">
        /// The device type.
        /// </param>
        /// <param name="cloudType">
        /// The cloud type.
        /// </param>
        /// <param name="isExternalPeeringEnabled">
        /// The is external peering enabled.
        /// </param>
        /// <param name="siteCode">
        /// The site code.
        /// </param>
        /// <param name="lat">
        /// The lat.
        /// </param>
        /// <param name="lon">
        /// The lon.
        /// </param>
        public DeviceMetadata(
            string name,
            DeviceType deviceType,
            string cloudType,
            bool isExternalPeeringEnabled,
            string siteCode,
            double lat,
            double lon)
        {
            this.Name = name;
            this.DeviceType = deviceType;
            this.CloudType = cloudType;
            this.IsExternalPeeringEnabled = isExternalPeeringEnabled;
            this.SiteCode = siteCode;
            this.Latitude = lat;
            this.Longitude = lon;
            this.PairDevices = new HashSet<string>();
        }

        /// <summary>
        /// Gets or sets value for device name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ngs device type.
        /// </summary>
        public string NgsDeviceType { get; set; }

        /// <summary>
        /// Gets or sets the device type.
        /// </summary>
        public DeviceType DeviceType { get; set; }

        /// <summary>
        /// Gets or sets the cloud type.
        /// </summary>
        public string CloudType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is external peering enabled.
        /// </summary>
        public bool IsExternalPeeringEnabled { get; set; }

        /// <summary>
        /// Gets or sets the site code.
        /// </summary>
        public string SiteCode { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or sets the pair devices.
        /// </summary>
        public HashSet<string> PairDevices { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// The equals.
        /// </summary>
        /// <param name="other">
        /// The other.
        /// </param>
        /// <returns>
        /// The <see cref="T:System.Boolean" />.
        /// </returns>
        public bool Equals(DeviceMetadata other)
        {
            return this.Name.Equals(other?.Name, StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// The equals.
        /// </summary>
        /// <param name="obj">
        /// The obj.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public override bool Equals(object obj)
        {
            return obj is DeviceMetadata device && this.Equals(device);
        }

        /// <summary>
        /// The get hash code.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}
