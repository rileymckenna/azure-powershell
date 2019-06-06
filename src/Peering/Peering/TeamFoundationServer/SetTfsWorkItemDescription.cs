
using Microsoft.Azure.PowerShell.Cmdlets.Peering.Common;
using Microsoft.Azure.PowerShell.Cmdlets.Peering.Models;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net;
using TeamFoundationServerPowershell.Model;

namespace TeamFoundationServerPowershell
{
    [Cmdlet(VerbsCommon.Set, "TfsWorkItemDescription")]
    [OutputType(typeof(KeyValuePair<PSPeerAsn, PSPeering>))]
    public class SetTfsWorkItemDescription : TeamFoundationBase
    {
        private WorkItem workItem;

        private string description;

        [Parameter(
            Position = 0,
        Mandatory = true)]
        public int? WorkItemId { get; set; }

        /// <summary>
        ///     Gets or sets The InputObject name
        /// </summary>
        [Parameter(Position = 1, Mandatory = true, HelpMessage = Constants.PeeringNameHelp)]
        [ValidateNotNullOrEmpty]
        public string PeerName { get; set; }

        /// <summary>
        ///     Gets or sets Peer ASN
        /// </summary>
        [Parameter(Position = 2, Mandatory = true, HelpMessage = Constants.PeeringAsnHelp)]
        [ValidateNotNullOrEmpty]
        public int PeerAsn { get; set; }

        /// <summary>
        ///     Gets or sets the Email
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = Constants.EmailsHelp)]
        [ValidateNotNullOrEmpty]
        public string[] Email { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = Constants.PhoneHelp)]
        [ValidateNotNullOrEmpty]
        public string[] Phone { get; set; }

        /// <summary>
        /// Gets or sets the session i pv 4 prefix.
        /// </summary>
        [Parameter(
            Mandatory = true,
            HelpMessage = Constants.HelpPeerSessionIPv4Prefix)]
        [ValidateNotNullOrEmpty]
        public string[] PeerSessionIPv4Address { get; set; }

        /// <summary>
        /// Gets or sets the session i pv 6 prefix.
        /// </summary>
        [Parameter(
            Mandatory = false,
            HelpMessage = Constants.HelpPeerSessionIPv6Prefix)]
        [ValidateNotNullOrEmpty]
        public string[] PeerSessionIPv6Address { get; set; }

        /// <summary>
        /// Gets or sets the max prefixes advertised i pv 4.
        /// </summary>
        [Parameter(
            Mandatory = false,
            HelpMessage = Constants.HelpMaxAdvertisedIPv4)]
        public int? MaxPrefixesAdvertisedIPv4 { get; set; }

        /// <summary>
        /// Gets or sets the max prefixes advertised i pv 6.
        /// </summary>
        [Parameter(
            Mandatory = false,
            HelpMessage = Constants.HelpMaxAdvertisedIPv6)]
        public int? MaxPrefixesAdvertisedIPv6 { get; set; }

        [Parameter(
        Mandatory = false,
        HelpMessage = Constants.MD5AuthenticationKeyHelp)]
        public string Md5Authenication { get; set; }

        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose("Begin!");
            SetWorkItemClient();
            this.workItem = this.workItemTrackingHttpClient.GetWorkItemAsync(ProjectName, this.WorkItemId ?? 0).Result;
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
            try
            {
                var connectionDictionary = new Dictionary<LocationMetadata, string>();
                if (this.PeerSessionIPv4Address.Length == this.PeerSessionIPv6Address.Length)
                {
                    for (int i = 0; i < this.PeerSessionIPv4Address.Length; i++)
                    {
                        var ipv4 = this.PeerSessionIPv4Address[i];
                        var ipv6 = this.PeerSessionIPv6Address[i];
                        var facility = TeamFoundationBase.ResolvePeeringFacility(null, ipv4, ipv6);
                        connectionDictionary.Add(facility, string.Join(",", ipv4, ipv6));
                    }
                }
                if (this.PeerSessionIPv4Address.Length > this.PeerSessionIPv6Address.Length)
                {
                    LocationMetadata facility = null;
                    for (int i = 0; i < this.PeerSessionIPv4Address.Length; i++)
                    {
                        var ipv4 = this.PeerSessionIPv4Address[i];
                        string ipv6 = null;
                        try
                        {
                            ipv6 = this.PeerSessionIPv6Address[i];
                            facility = TeamFoundationBase.ResolvePeeringFacility(null, ipv4, ipv6);
                        }
                        catch
                        {
                            facility = TeamFoundationBase.ResolvePeeringFacility(null, ipv4, string.Empty);
                        }
                        var s = $"{ipv4}";
                        s += (ipv6 == null) ? null : $",{ipv6}";
                        connectionDictionary.Add(facility, s);
                    }
                }
                string exchanges = null;
                foreach (var keyValue in connectionDictionary)
                {
                    var ipAddresses = keyValue.Value.Split(',');
                    string v4 = string.Empty;
                    string v6 = string.Empty;
                    for (int i = 0; i < ipAddresses.Length; i++)
                    {
                        var parsedAddress = IPAddress.Parse(ipAddresses[i]).AddressFamily;
                        if (parsedAddress == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            v4 = ipAddresses[i];
                        }
                        else if (parsedAddress == System.Net.Sockets.AddressFamily.InterNetworkV6)
                        {
                            v6 = ipAddresses[i];
                        }
                    }
                    exchanges += $"Exchange Name:{keyValue.Key.FacilityName}<br>IPv4:{v4}<br>IPv6:{v6}<br>MD5:{this.Md5Authenication}<br>";
                }
                this.description = $"<body contenteditable='true'>Please find the following Peering Request information:<br><br>AS number:{this.PeerAsn}<br>Peer name:{this.PeerName}<br>PeeringDB Record:http://as{this.PeerAsn}.peeringdb.com/<br>Peering/NOC Email:{string.Join(",", this.Email)}<br>Peering/NOC phone:{string.Join(",", this.Phone)}<br>Max prefixes for IPv4:{this.MaxPrefixesAdvertisedIPv4 ?? 20000}<br>Max prefixes for IPv6:{this.MaxPrefixesAdvertisedIPv6 ?? 2000}<br><br>Exchange information:<br>{exchanges}</body>";
                this.WriteVerbose(this.description);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
           WriteVerbose(this.UpdateDescriptionForWorkItem(this.WorkItemId ?? 0, this.description));
        }
    }
}
