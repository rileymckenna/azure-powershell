using System;
using System.Collections.Generic;
using System.Text;

namespace TeamFoundationServerPowershell.Model
{

    public class LocationMetadata
    {
        public int FacilityId { get; set; }

        public string FacilityName { get; set; }

        public string PeeringLocation { get; set; }

        public string AzRegion { get; set; }

        public string PeeringLocationWithOutSpace { get; private set; }

        public LocationMetadata(int id, string name, string city, string region)
        {
            this.FacilityId = id;
            this.FacilityName = name;
            this.PeeringLocation = city;
            this.AzRegion = region;
            this.PeeringLocationWithOutSpace = city;
            if (PeeringLocationWithOutSpace.Contains(" "))
            {
                this.PeeringLocationWithOutSpace = this.PeeringLocationWithOutSpace.Replace(' ', '_');
            }
        }
    }

}
