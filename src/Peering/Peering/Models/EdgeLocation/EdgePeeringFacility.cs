using System.Collections.Generic;

namespace TeamFoundationServerPowershell.Model
{
    public class EdgePeeringFacility
    {
        public string Kind { get; set; }
        public Properties Properties { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public EdgePeeringFacility()
        {
            this.Properties = new Properties();
        }
    }

    public class PeeringFacility
    {
        public string ExchangeName { get; set; }
        public int BandwidthInMbps { get; set; }
        public string MicrosoftIPv4Address { get; set; }
        public string MicrosoftIPv6Address { get; set; }
        public string FacilityIPv4Prefix { get; set; }
        public string FacilityIPv6Prefix { get; set; }
        public Dictionary<string, string> IpAddressToDeviceMap { get; set; }
        public int PeeringDBFacilityId { get; set; }
        public string PeeringDBFacilityLink { get; set; }

        public PeeringFacility()
        {
            this.IpAddressToDeviceMap = new Dictionary<string, string>();
        }
    }

    public class Exchange
    {
        public List<PeeringFacility> PeeringFacilities { get; set; }

        public Exchange()
        {
            this.PeeringFacilities = new List<PeeringFacility>();
        }
    }

    public class Properties
    {
        public Exchange Exchange { get; set; }
        public string PeeringLocation { get; set; }
        public string Country { get; set; }
        public string AzureRegion { get; set; }

        public Properties()
        {
            this.Exchange = new Exchange();
        }
    }
}
