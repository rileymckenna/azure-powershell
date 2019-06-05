//------------------------------------------------------------------------------
// <copyright file="PeeringSku.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace TeamFoundationServerPowershell.Model
{

    using Newtonsoft.Json;

    /// <summary>
    /// The SKU that defines the tier and kind of the peering.
    /// </summary>
    public class PeeringSku
    {
        /// <summary>
        /// The peering SKU name.
        /// </summary>
        private PeeringSkuName name;

        /// <summary>
        /// Initializes a new instance of the <see cref="PeeringSku"/> class.
        /// </summary>
        public PeeringSku()
        {
            this.ShouldSerializeReadOnlyProperties = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeeringSku"/> class.
        /// </summary>
        /// <param name="peeringSkuName">The peering SKU name.</param>
        public PeeringSku(PeeringSkuName peeringSkuName)
            : this()
        {
            this.Name = peeringSkuName;
        }

        /// <summary>
        /// Gets or sets the peering SKU name.
        /// </summary>

        public PeeringSkuName Name
        {
            get => this.name;
            set
            {
                switch (value)
                {
                    case PeeringSkuName.Basic_Direct_Free:
                        this.SetTierFamilyAndSize(
                            PeeringSkuTier.Basic,
                            PeeringSkuFamily.Direct,
                            PeeringSkuSize.Free);
                        break;
                    case PeeringSkuName.Basic_Exchange_Free:
                        this.SetTierFamilyAndSize(
                            PeeringSkuTier.Basic,
                            PeeringSkuFamily.Exchange,
                            PeeringSkuSize.Free);
                        break;
                    case PeeringSkuName.Premium_Direct_Free:
                        this.SetTierFamilyAndSize(
                            PeeringSkuTier.Premium,
                            PeeringSkuFamily.Direct,
                            PeeringSkuSize.Free);
                        break;
                    case PeeringSkuName.Premium_Partner_Metered:
                        this.SetTierFamilyAndSize(
                            PeeringSkuTier.Premium,
                            PeeringSkuFamily.Partner,
                            PeeringSkuSize.Metered);
                        break;
                    case PeeringSkuName.Premium_Exchange_Metered:
                        this.SetTierFamilyAndSize(
                            PeeringSkuTier.Premium,
                            PeeringSkuFamily.Exchange,
                            PeeringSkuSize.Metered);
                        break;
                }

                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets the peering SKU tier.
        /// </summary>
        public PeeringSkuTier Tier { get; set; }

        /// <summary>
        /// Gets or sets the peering SKU family.
        /// </summary>
        public PeeringSkuFamily Family { get; set; }

        /// <summary>
        /// Gets or sets the peering SKU size.
        public PeeringSkuSize Size { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not to serialize read-only properties.
        /// </summary>
        [JsonIgnore]
        public bool ShouldSerializeReadOnlyProperties { get; set; }

        /// <summary>
        /// Gets the string representation of the object.
        /// </summary>
        /// <returns>The string.</returns>
        public override string ToString()
        {
            return $"Sku:Name={this.Name}|" +
                   $"Tier={this.Tier}|" +
                   $"Family={this.Family}|" +
                   $"Size={this.Size}";
        }

        /// <summary>
        /// Equals method for PeeringSku
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(PeeringSku other)
        {
            return other != null && this.Tier == other.Tier && this.Family == other.Family && this.Size == other.Size;
        }

        /// <summary>
        /// Determines if the property needs to be serialized.
        /// </summary>
        /// <returns>True if it is to be serialized.</returns>
        public bool ShouldSerializeTier()
        {
            return this.ShouldSerializeReadOnlyProperties;
        }

        /// <summary>
        /// Determines if the property needs to be serialized.
        /// </summary>
        /// <returns>True if it is to be serialized.</returns>
        public bool ShouldSerializeFamily()
        {
            return this.ShouldSerializeReadOnlyProperties;
        }

        /// <summary>
        /// Determines if the property needs to be serialized.
        /// </summary>
        /// <returns>True if it is to be serialized.</returns>
        public bool ShouldSerializeSize()
        {
            return this.ShouldSerializeReadOnlyProperties;
        }

        /// <summary>
        /// The clone.
        /// </summary>
        /// <returns>
        /// The <see cref="PeeringSku"/>.
        /// </returns>
        public PeeringSku Clone()
        {
            return new PeeringSku
            {
                Family = this.Family,
                Name = this.Name,
                Size = this.Size,
                ShouldSerializeReadOnlyProperties = this.ShouldSerializeReadOnlyProperties,
                Tier = this.Tier
            };
        }

        /// <summary>
        /// Sets the tier, family ans size of the SKU.
        /// </summary>
        /// <param name="tier">The tier.</param>
        /// <param name="family">The family.</param>
        /// <param name="size">The size.</param>
        private void SetTierFamilyAndSize(
            PeeringSkuTier tier,
            PeeringSkuFamily family,
            PeeringSkuSize size)
        {
            this.Tier = tier;
            this.Family = family;
            this.Size = size;
        }

    }
}