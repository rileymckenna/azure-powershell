using System;
using System.Collections.Generic;
using System.Text;

namespace TeamFoundationServerPowershell.Model
{

    public class LocationMetadata
    {
        public int FacilityId { get; set; }

        // Get or sets the device or facility Name 
        public string Name { get; set; }

        public string PeeringLocation { get; set; }

        public string AzRegion { get; set; }
        public LocationType LocationType { get; private set; }
        public string PeeringLocationWithOutSpace { get; private set; }

        public LocationMetadata(int id, string name, string city, string region, LocationType locationType = LocationType.None)
        {
            this.FacilityId = id;
            this.Name = name;
            this.PeeringLocation = city;
            this.AzRegion = region;
            this.LocationType = locationType;
            this.PeeringLocationWithOutSpace = city;
            if (PeeringLocationWithOutSpace.Contains(" "))
            {
                this.PeeringLocationWithOutSpace = this.PeeringLocationWithOutSpace.Replace(' ', '_');
            }
        }
    }

}
