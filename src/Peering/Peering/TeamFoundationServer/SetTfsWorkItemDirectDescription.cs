
using Microsoft.Azure.PowerShell.Cmdlets.Peering.Common;
using Microsoft.Azure.PowerShell.Cmdlets.Peering.Models;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net;
using TeamFoundationServerPowershell.Model;
using Microsoft.Azure.Management.Peering;
using Microsoft.Azure.Management.Peering.Models;
using Microsoft.WindowsAzure.Commands.Common;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;

namespace TeamFoundationServerPowershell
{
    [Cmdlet(VerbsCommon.Set, "TfsWorkItemDirectDescription", DefaultParameterSetName = Constants.ParameterSetNameDefault)]
    [OutputType(typeof(KeyValuePair<PSPeerAsn, PSPeering>))]
    public class SetTfsWorkItemDirectDescription : TeamFoundationBase
    {
        private WorkItem workItem;

        private string description;

        [Parameter(
            Position = 0,
            Mandatory = true,
            ParameterSetName = Constants.ParameterSetNameByName)]
        [Parameter(
            Position = 0,
            Mandatory = true,
            ParameterSetName = Constants.ParameterSetNameDefault)]
        public int? WorkItemId { get; set; }

        /// <summary>
        ///     Gets or sets The InputObject name
        /// </summary>
        [Parameter(Position = 1,
            Mandatory = true,
            HelpMessage = Constants.PeeringNameHelp,
            ParameterSetName = Constants.ParameterSetNameByName)]
        [ValidateNotNullOrEmpty]
        public string PeerName { get; set; }

        /// <summary>
        ///     Gets or sets the Email
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = Constants.EmailsHelp,
            ParameterSetName = Constants.ParameterSetNameByName)]
        [ValidateNotNullOrEmpty]
        public string[] Email { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = Constants.PhoneHelp,
            ParameterSetName = Constants.ParameterSetNameByName)]
        public string[] Phone { get; set; }

        /// <summary>
        /// Gets or sets the session i pv 4 prefix.
        /// </summary>
        [Parameter(
            Mandatory = false,
            HelpMessage = Constants.HelpPeerSessionIPv4Prefix,
            ParameterSetName = Constants.ParameterSetNameByName)]
        [Parameter(
            Mandatory = false,
            HelpMessage = Constants.HelpPeerSessionIPv4Prefix,
            ParameterSetName = Constants.ParameterSetNameDefault)]
        [ValidateNotNullOrEmpty]
        public string PeerSessionIPv4Address { get; set; }

        /// <summary>
        /// Gets or sets the session i pv 6 prefix.
        /// </summary>
        [Parameter(
            Mandatory = false,
            HelpMessage = Constants.HelpPeerSessionIPv6Prefix,
            ParameterSetName = Constants.ParameterSetNameByName)]
        [Parameter(
            Mandatory = false,
            HelpMessage = Constants.HelpPeerSessionIPv6Prefix,
            ParameterSetName = Constants.ParameterSetNameDefault)]
        public string PeerSessionIPv6Address { get; set; }

        /// <summary>
        /// Gets or sets the session i pv 6 prefix.
        /// </summary>
        [Parameter(
            Mandatory = true,
            HelpMessage = Constants.HelpPeerSessionIPv6Prefix,
            ParameterSetName = Constants.ParameterSetNameByName)]
        [Parameter(
            Mandatory = true,
            HelpMessage = Constants.HelpPeerSessionIPv6Prefix,
            ParameterSetName = Constants.ParameterSetNameDefault)]
        [PSArgumentCompleter("10000", "20000", "30000", "40000", "50000", "60000", "70000", "80000", "90000", "100000")]
         [ValidateRange(Constants.MinRange, Constants.MaxRange), ValidateNotNullOrEmpty]
        public int BandwidthInMbps { get; set; }

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
            string asnName = string.Empty;
            string deviceInputInformation = string.Empty;
            try
            {
                var deviceName = this.workItem.Fields["custom.Node_A"].ToString();
                // Get the device ID
                // Get the location
                var deviceInformation = TeamFoundationBase.ResolveDirectPeeringFacility(deviceName);
                if (deviceInformation == null)
                    throw new Exception($"Device {deviceName} not found in peering map.");


                // Get the bandwidth

                if (this.PeerSessionIPv6Address == null)
                {
                    this.PeerSessionIPv6Address = string.Empty;
                }
                if(this.PeerSessionIPv4Address == null)
                {
                    this.PeerSessionIPv4Address = string.Empty;
                }
                deviceInputInformation += $"Device Name:{deviceInformation.Name}<br>IPv4:{this.PeerSessionIPv4Address}<br>IPv6:{this.PeerSessionIPv6Address}<br>BandwidthInMbps:{this.BandwidthInMbps}";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                var peerAsn = int.Parse(this.workItem.Fields["GFS.ASN"].ToString());
                if (this.ParameterSetName.Equals(Constants.ParameterSetNameByName, StringComparison.OrdinalIgnoreCase))
                {
                    this.description = $"<body contenteditable='true'>Please find the following Peering Request information:<br><br>AS number:{peerAsn}<br>Peer name:{this.PeerName}<br>PeeringDB Record:http://as{peerAsn}.peeringdb.com/<br>Peering/NOC Email:{string.Join(",", this.Email)}<br>Peering/NOC phone:{string.Join(",", this.Phone)}<br>Max prefixes for IPv4:20000<br>Max prefixes for IPv6:2000<br><br>Direct PNI information:<br>{deviceInputInformation}</body>";
                    this.WriteVerbose(this.description);
                }
                else
                {
                    asnName = $"AS{peerAsn}";
                    var asn = (PSPeerAsn)this.ToPeeringAsnPs(this.PeeringManagementClient.PeerAsns.Get(asnName));
                    this.WriteVerbose($"PeerAsn Exists: {asn?.Id}");
                    this.description = $"<body contenteditable='true'>Please find the following Peering Request information:<br><br>AS number:{asn.PeerAsnProperty}<br>Peer name:{asn.PeerName}<br>PeeringDB Record:http://as{asn.PeerAsnProperty}.peeringdb.com/<br>Peering/NOC Email:{string.Join(",", asn.PeerContactInfo.Emails)}<br>Peering/NOC phone:{string.Join(",", asn.PeerContactInfo.Phone)}<br>Max prefixes for IPv4:20000<br>Max prefixes for IPv6:2000<br><br>Direct PNI information:<br>{deviceInputInformation}</body>";
                    this.WriteVerbose(this.description);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Peer ASN {asnName} does not exist and requires creation");
            }
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            // Get Current Description and add to quicknotes.
            this.UpdateQuickNotesForWorkItem((int)this.workItem.Id, this.workItem.Fields["System.Description"].ToString());
            WriteVerbose(this.UpdateDescriptionForWorkItem(this.WorkItemId ?? 0, this.description));
        }
    }
}
