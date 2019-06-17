using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.PowerShell.Cmdlets.Peering.Models;
using TeamFoundationServerPowershell.Model;
using Microsoft.Azure.Commands.Peering.Common;

namespace TeamFoundationServerPowershell
{
    [Cmdlet(VerbsCommon.Set, "TfsWorkItem", SupportsShouldProcess = true)]
    [OutputType(typeof(KeyValuePair<PSPeerAsn, PSPeering>))]
    public class UpdateTfsWorkItems : TeamFoundationBase
    {
        private WorkItem workItem;
        [Parameter(
            Mandatory = true,
            Position = 0, ValueFromPipeline = true)]
        [ValidateNotNullOrEmpty]
        public PSExchangePeeringModelView InputObject { get; set; }

        [Parameter(
            Mandatory = false)]
        public int? WorkItemId { get; set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter Resolve { get; set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter InProgress { get; set; }

        [Parameter(Mandatory = false)]
        public string QuickNotes { get; set; }

        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose("Logging into VSS");
            SetWorkItemClient();
            WriteVerbose("Getting WorkItem");
            if (this.WorkItemId == null)
            {
                this.WorkItemId = int.Parse(this.InputObject.Tags.Values.FirstOrDefault());
                WriteVerbose($"WorkItemId: {this.WorkItemId}");
            }
            this.workItem = this.workItemTrackingHttpClient.GetWorkItemAsync(ProjectName, this.WorkItemId ?? 0).Result;
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
            try
            {
                if (Resolve)
                {
                    if (this.InputObject != null)
                    {
                        var peering = this.ParseWorkItemDescriptionForPeerAsnContactInformationAndPeeringInformation(this.workItem.Fields["System.Description"].ToString());
                        if (this.VerifyTFSDataAndPeeringAreTheSame(peering, this.InputObject))
                        {
                            var connection = this.InputObject.Connections.FirstOrDefault();
                            var changeRecordTime = DateTime.Now.ToString();
                            var node = this.GetFacilityInformation(connection, this.InputObject.PeeringLocation);
                            var side = node.Split('-')[0].ToUpperInvariant().Contains("96") ? "- Other" : node.Split('-')[0].ToUpperInvariant();
                            var state = this.UpdateWorkItemStateToResolved(
                                (int)this.workItem.Id, side, side, node, node, changeRecordTime);
                            var str = $"\n{DateTime.Now} -> PeeringAutomation:Resolved -> completed request" +
                                $"\n{DateTime.Now} -> PeeringAutomation:ConnectionState -> {connection.ConnectionState}";
                            this.UpdateQuickNotesForWorkItem((int)this.workItem.Id, str);
                        }
                        else
                        {
                            throw new Exception("Mismatch data in the TFS Description and Peering Object Recieved. Check the Ticket and peering object.");
                        }
                    }
                    else
                    {
                        throw new Exception("Use the Get-AzPeering -ResourceGroup <resourceGroupName> -Name <name> | Set-TfsWorkItem -Resolve ");
                    }
                }
                if (InProgress)
                {
                    var str = $"\n{DateTime.Now} -> PeeringAutomation:InProgress -> completed request";
                    this.UpdateQuickNotesForWorkItem((int)this.workItem.Id, str);
                }
                if (QuickNotes != null)
                {
                    this.UpdateQuickNotesForWorkItem((int)this.workItem.Id, QuickNotes);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool VerifyTFSDataAndPeeringAreTheSame(KeyValuePair<PSPeerAsn, List<PSPeering>> keyValue, PSExchangePeeringModelView inputObject)
        {
            var peerings = keyValue.Value;
            int matchCount = 0;
            int peeringIpCount = 0;
            foreach (var peering in peerings)
            {
                if (inputObject.PeerAsn.Id.Contains($"AS{keyValue.Key.PeerAsnProperty}") && inputObject.PeeringLocation.Equals(peering.PeeringLocation, StringComparison.CurrentCultureIgnoreCase))
                {
                    if (peering.Exchange.Connections.Any())
                    {
                        foreach (var descConnection in peering.Exchange.Connections)
                        {
                            peeringIpCount++;
                            foreach (var inputConnection in inputObject.Connections)
                            {
                                if (inputConnection.PeeringDBFacilityId == descConnection.PeeringDBFacilityId)
                                {
                                    if (inputConnection.BgpSession.PeerSessionIPv4Address != null && descConnection.BgpSession.PeerSessionIPv4Address.Any())
                                    {
                                        if (inputConnection.ConnectionState == "Active")
                                        {
                                            if (inputConnection.BgpSession.PeerSessionIPv4Address == descConnection.BgpSession.PeerSessionIPv4Address && inputConnection.BgpSession.SessionStateV4 == "Established")
                                            {
                                                matchCount++;
                                            }
                                        }
                                    }
                                    if (inputConnection.BgpSession.PeerSessionIPv6Address != null && descConnection.BgpSession.PeerSessionIPv6Address.Any())
                                    {
                                        if (inputConnection.ConnectionState == "Active")
                                        {
                                            if (inputConnection.BgpSession.PeerSessionIPv6Address == descConnection.BgpSession.PeerSessionIPv6Address && inputConnection.BgpSession.SessionStateV6 == "Established")
                                            {
                                                matchCount++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (matchCount > 0 && matchCount >= peeringIpCount)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private string GetFacilityInformation(PSExchangeConnection connection, string peeringLocation)
        {
            var exchangeFacilities = JsonConvert.DeserializeObject<List<EdgePeeringFacility>>(StaticFile.GetDeviceMap());
            try
            {
                foreach (var location in exchangeFacilities)
                {
                    if (location.Name.Equals(peeringLocation, StringComparison.InvariantCultureIgnoreCase))
                    {
                        foreach (var publicPeeringFacility in location.Properties.Exchange.PeeringFacilities)
                        {
                            if (publicPeeringFacility.PeeringDBFacilityId.Equals((int)connection.PeeringDBFacilityId))
                            {
                                foreach (var device in publicPeeringFacility.IpAddressToDeviceMap)
                                {
                                    try
                                    {
                                        if (device.Key.Equals(connection.BgpSession.MicrosoftSessionIPv4Address, StringComparison.InvariantCultureIgnoreCase))
                                        {
                                            return device.Value;
                                        }
                                        if (device.Key.Equals(connection.BgpSession.MicrosoftSessionIPv6Address, StringComparison.InvariantCultureIgnoreCase))
                                        {
                                            return device.Value;
                                        }
                                    }
                                    catch
                                    {
                                        continue;
                                    }
                                }
                            }
                        }
                    }
                }
                return string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End!");
        }
    }
}
