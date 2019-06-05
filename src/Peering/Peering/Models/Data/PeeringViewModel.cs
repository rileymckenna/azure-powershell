
using Microsoft.Azure.PowerShell.Cmdlets.Peering.Models;
using System.Collections.Generic;

namespace TeamFoundationServerPowershell.Model.Data
{
    public class PeeringViewModel
    {
        public int AsnNumber { get; set; }

        public string PeerName { get; set; }

        public List<string> Emails { get; set; }

        public List<string> Phone { get; set; }

        public List<string> ExchangeName { get; set; }

        public List<int?> PeeringFacilityId { get; set; }

        public List<PSExchangeConnection> Connections {get; set;}

        public LocationMetadata LocationMetadata { get; set; }

        public PeeringViewModel(PSPeerAsn peerAsn, PSPeering peering, LocationMetadata locationMetadata)
        {
            this.LocationMetadata = locationMetadata;
            this.AsnNumber = (int)peerAsn.PeerAsnProperty;
            this.PeerName = peerAsn.PeerName;
            this.Emails = new List<string>();
            foreach(var email in peerAsn.PeerContactInfo.Emails)
            {
                this.Emails.Add(email);
            }
            
            this.Phone = new List<string>();
            foreach (var phone in peerAsn.PeerContactInfo.Phone)
            {
                this.Phone.Add(phone);
            }
            this.Connections = new List<PSExchangeConnection>();
            this.ExchangeName = new List<string>();
            this.PeeringFacilityId = new List<int?>();
            foreach (var connection in peering.Exchange.Connections)
            {
                this.Connections.Add(connection);
                this.PeeringFacilityId.Add(connection.PeeringDBFacilityId);
                this.ExchangeName.Add(TeamFoundationBase.ResolvePeeringFacility(peering.PeeringLocation, connection.BgpSession.PeerSessionIPv4Address, connection.BgpSession.PeerSessionIPv6Address).FacilityName);
            }
        }
    }
}
