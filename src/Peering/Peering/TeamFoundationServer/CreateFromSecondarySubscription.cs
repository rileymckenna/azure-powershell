using Microsoft.Azure.Commands.Peering.Properties;
using Microsoft.Azure.Management.Peering;
using Microsoft.Azure.Management.Peering.Models;
using Microsoft.Azure.Management.ResourceManager.Models;
using Microsoft.Azure.PowerShell.Cmdlets.Peering.Common;
using Microsoft.Azure.PowerShell.Cmdlets.Peering.Models;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Automation;
using System.Net.Http;
using System.Threading;
using System.Transactions;
using TeamFoundationServerPowershell.Model;
using TeamFoundationServerPowershell.Model.Data;

namespace TeamFoundationServerPowershell
{
    [Cmdlet(VerbsCommon.New, "TfsClientFromSecondarySubscription")]
    [OutputType(typeof(PSPeering))]
    public class CreateFromSecondarySubscription : TeamFoundationBase
    {
        private WorkItem workItem;
        private KeyValuePair<PSPeerAsn, PSPeering> PeerAsnAndPeering;
        private LocationMetadata locationMetadata;
        private string name;

        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true)]
        public int? WorkItemNumber { get; set; }

        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose("Begin!");
            SetWorkItemClient();
            try
            {
                this.workItem = this.workItemTrackingHttpClient.GetWorkItemAsync(ProjectName, this.WorkItemNumber ?? 0).Result;
                this.PeerAsnAndPeering = this.ParseWorkItemDescriptionForPeerAsnContactInformationAndPeeringInformation(this.workItem.Fields["System.Description"].ToString());
                this.locationMetadata = TeamFoundationBase.ResolvePeeringFacility(this.PeerAsnAndPeering.Value.PeeringLocation, this.PeerAsnAndPeering.Value.Exchange.Connections.FirstOrDefault().BgpSession.PeerSessionIPv4Address, this.PeerAsnAndPeering.Value.Exchange.Connections.FirstOrDefault().BgpSession.PeerSessionIPv6Address);
            }catch (Exception ex)
            {
                throw ex; 
            }
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {

            // Get Resource Group
            var isResourceGroup = this.ResourceManagementClient.ResourceGroups.CheckExistenceWithHttpMessagesAsync(this.locationMetadata.PeeringLocationWithOutSpace).GetAwaiter().GetResult();
            if (!isResourceGroup.Response.IsSuccessStatusCode)
            {
                // Create RG
                this.WriteVerbose($"Resource Group {this.locationMetadata.PeeringLocation} does not exist, creating a new RG");
                var rg = new ResourceGroup {
                    Location = this.locationMetadata.AzRegion,
                    Name = this.locationMetadata.PeeringLocationWithOutSpace
                };
                var resourceGroup = this.ResourceManagementClient.ResourceGroups.CreateOrUpdateWithHttpMessagesAsync(this.locationMetadata.PeeringLocationWithOutSpace, rg).GetAwaiter().GetResult();
            }
            // Check for PeerAsn
            var asnName = $"AS{this.PeerAsnAndPeering.Key.PeerAsnProperty}";
            var peeringName = $"{asnName}_{this.locationMetadata.PeeringLocationWithOutSpace}_Exchange";
            this.name = peeringName;
            PSPeerAsn asn;
            try
            {
                asn = (PSPeerAsn)this.ToPeeringAsnPs(this.PeeringManagementClient.PeerAsns.Get(asnName));
                this.WriteVerbose($"PeerAsn Exists: {asn?.Id}");
            }
            catch
            {
                    // Create Asn
                    this.WriteVerbose($"{asnName} does not exist creating a new PeerAsn");
                    asn = (PSPeerAsn)this.ToPeeringAsnPs(this.PeeringManagementClient.PeerAsns.CreateOrUpdate(asnName, this.ToPeeringAsn(PeerAsnAndPeering.Key)));
                    Thread.Sleep(1000);
                    asn.ValidationState = "Approved";
                    this.WriteObject(this.PeeringManagementClient.PeerAsns.CreateOrUpdate(asnName, this.ToPeeringAsn(asn)));
            }

            try
            {
                // check for Legacy
                this.WriteVerbose("Checking for Legacy");
                var allLegacyPeering = this.PeeringManagementClient.LegacyPeerings.List(this.locationMetadata.PeeringLocation, Constants.Exchange);
                PeeringModel legacyPeering = null;
                foreach (var legacy in allLegacyPeering)
                {
                    if (legacy.Exchange.PeerAsn.Id.Equals(asn.Id, StringComparison.InvariantCultureIgnoreCase))
                    {
                        legacyPeering = legacy;
                        break;
                    }
                }
                if (legacyPeering != null) {
                    this.WriteVerbose($"Converting Legacy at {this.locationMetadata.PeeringLocation} and adding connection to {peeringName}");
                    var newPeering = this.PeeringManagementClient.Peerings.CreateOrUpdate(this.locationMetadata.PeeringLocationWithOutSpace, peeringName, legacyPeering);
                    foreach (var connection in this.PeerAsnAndPeering.Value.Exchange.Connections)
                    {
                        newPeering.Exchange.Connections.Add(PeeringResourceManagerProfile.Mapper.Map<ExchangeConnection>(connection));
                    }
                    newPeering.Tags = new Dictionary<string, string>(); 
                    newPeering.Tags["tfs"] = this.WorkItemNumber.ToString();
                    this.WriteObject(this.PeeringManagementClient.Peerings.CreateOrUpdate(this.locationMetadata.PeeringLocationWithOutSpace, peeringName, newPeering));
                }
                else
                {
                    try
                    {
                        this.WriteVerbose($"No Legacy Checking Existing");
                        var existingPeering = this.PeeringManagementClient.Peerings.Get(this.locationMetadata.PeeringLocationWithOutSpace, peeringName);
                        if (existingPeering == null)
                        {
                            this.WriteVerbose($"Existing peering, add connection to {peeringName}");
                            foreach (var connection in this.PeerAsnAndPeering.Value.Exchange.Connections)
                            {
                                existingPeering.Exchange.Connections.Add(PeeringResourceManagerProfile.Mapper.Map<ExchangeConnection>(connection));
                            }
                            existingPeering.Tags = new Dictionary<string, string>();
                            existingPeering.Tags["tfs"] = this.workItem.Id.ToString();
                            this.WriteObject(this.ToPeeringPs(existingPeering));
                            this.PeeringManagementClient.Peerings.CreateOrUpdate(this.locationMetadata.PeeringLocationWithOutSpace, peeringName, existingPeering);
                        }
                    }
                    catch
                    {

                        this.WriteVerbose($"No existing peering, creating new {peeringName} with Asn {this.PeerAsnAndPeering.Key.PeerAsnProperty} at location {this.locationMetadata.PeeringLocation}");
                        var peer = this.PeerAsnAndPeering.Value;
                        peer.Location = this.locationMetadata.AzRegion;
                        peer.Exchange.PeerAsn = new PSSubResource { Id = asn.Id };
                        peer.Sku = new PSPeeringSku(Constants.BasicExchangeFree);
                        peer.Tags = new Dictionary<string, string>();
                        peer.Tags["tfs"] = this.WorkItemNumber.ToString();
                        this.PeeringManagementClient.Peerings.CreateOrUpdate(this.locationMetadata.PeeringLocationWithOutSpace, peeringName, this.ToPeering(peer));
                    }
                }
            }
            catch (Microsoft.Azure.Management.Peering.Models.ErrorResponseException ex)
            {
                var error = GetErrorCodeAndMessageFromArmOrErm(ex);
               this.WriteWarning($"{string.Format(Resources.Error_CloudError, error.Code, error.Message)} for Ticket:{this.workItem.Id} Link:{this.workItem.Url}");
            }
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End!");
            try
            {
                var sierra = new PeeringViewModel((PSPeerAsn)this.ToPeeringAsnPs(this.PeeringManagementClient.PeerAsns.Get(this.PeerAsnAndPeering.Key.Name)), this.ToPeeringPs(this.PeeringManagementClient.Peerings.Get(this.locationMetadata.PeeringLocationWithOutSpace, this.name)), this.locationMetadata);
                var str = $"\n{DateTime.Now} -> PeeringAutomation:InProgress -> completed request";
                this.WriteVerbose(this.UpdateQuickNotesForWorkItem(this.workItem, (int)this.workItem.Id, str));
                this.WriteObject(sierra);
            }
            catch (Microsoft.Azure.Management.Peering.Models.ErrorResponseException ex)
            {
                var error = GetErrorCodeAndMessageFromArmOrErm(ex);
                this.WriteWarning($"{string.Format(Resources.Error_CloudError, error.Code, error.Message)} for Ticket:{this.workItem.Id} Link:{this.workItem.Links}");
            }
        }
    }
}
