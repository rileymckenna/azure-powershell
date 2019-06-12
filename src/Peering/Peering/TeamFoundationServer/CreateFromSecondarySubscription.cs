using Microsoft.Azure.Commands.Peering.Properties;
using Microsoft.Azure.Management.Internal.Network.Version2017_03_01.Models;
using Microsoft.Azure.Management.Peering;
using Microsoft.Azure.Management.Peering.Models;
using Microsoft.Azure.Management.ResourceManager.Models;
using Microsoft.Azure.PowerShell.Cmdlets.Peering.Common;
using Microsoft.Azure.PowerShell.Cmdlets.Peering.Models;
using Microsoft.Rest.Azure;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Threading;
using TeamFoundationServerPowershell.Model;
using TeamFoundationServerPowershell.Model.Data;

namespace TeamFoundationServerPowershell
{
    [Cmdlet(VerbsCommon.New, "TfsClientFromSecondarySubscription")]
    [OutputType(typeof(PSPeering))]
    public class CreateFromSecondarySubscription : TeamFoundationBase
    {
        private WorkItem workItem;
        private KeyValuePair<PSPeerAsn, List<PSPeering>> PeerAsnAndPeering;
        private Stack<PSPeering> newPeeringStack = new Stack<PSPeering>();
        private Stack<string> errorPeeringStack = new Stack<string>();

        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true)]
        public int? WorkItemNumber { get; set; }

        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose($"Starting on new ticket {this.WorkItemNumber}");
            SetWorkItemClient();
            try
            {
                this.workItem = this.workItemTrackingHttpClient.GetWorkItemAsync(ProjectName, this.WorkItemNumber ?? 0).Result;
                this.PeerAsnAndPeering = this.ParseWorkItemDescriptionForPeerAsnContactInformationAndPeeringInformation(this.workItem.Fields["System.Description"].ToString());
                // Determine how many peerings are contained within the work item
                if (this.PeerAsnAndPeering.Key == null || this.PeerAsnAndPeering.Value == null)
                {
                    this.WriteWarning($"Description context is not auto-parsable on ticket {this.WorkItemNumber} Link: {this.workItem.Url}");
                    throw new Exception($"Description context is not auto-parsable on ticket {this.WorkItemNumber} Link: {this.workItem.Url}");
                }
            }
            catch (Exception ex)
            {
                this.WriteWarning($"Ticket:{this.WorkItemNumber}. {ex.Message}.");
                throw;
            }
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
            foreach (var descriptionPeering in this.PeerAsnAndPeering.Value)
            {
                // Get Resource Group
                AzureOperationResponse<ResourceGroup> resourceGroup = null;
                try
                {
                    resourceGroup = this.ResourceManagementClient.ResourceGroups.GetWithHttpMessagesAsync(descriptionPeering.Name).GetAwaiter().GetResult();
                }
                catch
                {
                    if (resourceGroup == null)
                    {
                        // Create RG
                        this.WriteVerbose($"Resource Group {descriptionPeering.Name} does not exist, creating a new RG");
                        var rg = new ResourceGroup
                        {
                            Location = descriptionPeering.Location,
                            Name = descriptionPeering.Name
                        };
                        this.ResourceManagementClient.ResourceGroups.CreateOrUpdateWithHttpMessagesAsync(descriptionPeering.Name, rg).GetAwaiter().GetResult();
                        resourceGroup = this.ResourceManagementClient.ResourceGroups.GetWithHttpMessagesAsync(descriptionPeering.Name).GetAwaiter().GetResult();
                        if (!resourceGroup.Response.IsSuccessStatusCode)
                        {
                            throw new Exception("ResourceGroup Failed to create");
                        }
                    }
                }

                // Check for PeerAsn
                var asnName = $"AS{this.PeerAsnAndPeering.Key.PeerAsnProperty}";
                var peeringName = $"{asnName}_{descriptionPeering.Name}_Exchange";
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
                    var allLegacyPeering = this.PeeringManagementClient.LegacyPeerings.List(descriptionPeering.PeeringLocation, Constants.Exchange);
                    PeeringModel legacyPeering = null;
                    foreach (var legacy in allLegacyPeering)
                    {
                        if (legacy.Exchange.PeerAsn.Id.Equals(asn.PeerAsnProperty.ToString(), StringComparison.InvariantCultureIgnoreCase) && legacy.PeeringLocation.Equals(descriptionPeering.PeeringLocation, StringComparison.InvariantCultureIgnoreCase))
                        {
                            legacyPeering = legacy;
                            break;
                        }
                    }
                    if (legacyPeering != null)
                    {
                        this.WriteVerbose($"Converting Legacy at {descriptionPeering.PeeringLocation} and adding connection to {peeringName}");
                        // TODO Dogfood 
                        if (this.ResourceManagementClient.SubscriptionId.Equals("3e919f9a-4e26-4736-aa8d-d596d9a49239"))
                        {
                            legacyPeering.Location = "centralus";
                        }
                        else
                        {
                            legacyPeering.Location = descriptionPeering.Location;
                        }
                        legacyPeering.Exchange.PeerAsn.Id = asn.Id;
                        var newPeering = this.PeeringManagementClient.Peerings.CreateOrUpdate(resourceGroup.Body.Name, peeringName, legacyPeering);
                        foreach (var connection in descriptionPeering.Exchange.Connections)
                        {
                            newPeering.Exchange.Connections.Add(PeeringResourceManagerProfile.Mapper.Map<ExchangeConnection>(connection));
                        }
                        newPeering.Tags = new Dictionary<string, string>();
                        newPeering.Tags[$"tfs_{this.workItem.Id}"] = "Active";
                        newPeeringStack.Push(this.ToPeeringPs(this.PeeringManagementClient.Peerings.CreateOrUpdate(resourceGroup.Body.Name, peeringName, newPeering)));
                        this.WriteObject(newPeeringStack.Peek());
                    }
                    else
                    {
                        try
                        {
                            this.WriteVerbose($"No legacy peering, checking existing peerings at {descriptionPeering.PeeringLocation}");
                            var existingPeering = this.PeeringManagementClient.Peerings.Get(resourceGroup.Body.Name, peeringName);
                            if (existingPeering != null && existingPeering.PeeringLocation.Equals(descriptionPeering.PeeringLocation, StringComparison.InvariantCultureIgnoreCase))
                            {
                                this.WriteVerbose($"Existing peering, adding connection to {peeringName}");
                                foreach (var connection in descriptionPeering.Exchange.Connections)
                                {
                                    existingPeering.Exchange.Connections.Add(PeeringResourceManagerProfile.Mapper.Map<ExchangeConnection>(connection));
                                }
                                existingPeering.Tags = new Dictionary<string, string>();
                                existingPeering.Tags[$"tfs_{this.workItem.Id}"] = "Active";
                                // TODO Dogfood
                                if (this.ResourceManagementClient.SubscriptionId.Equals("3e919f9a-4e26-4736-aa8d-d596d9a49239"))
                                {
                                    existingPeering.Location = "centralus";
                                }
                                newPeeringStack.Push(this.ToPeeringPs(this.PeeringManagementClient.Peerings.CreateOrUpdate(resourceGroup.Body.Name, peeringName, existingPeering)));
                                this.WriteObject(newPeeringStack.Peek());
                            }
                        }
                        catch
                        {

                            this.WriteVerbose($"No existing peering, creating new {peeringName} with Asn {this.PeerAsnAndPeering.Key.PeerAsnProperty} at location {descriptionPeering.PeeringLocation}");
                            var peer = descriptionPeering;
                            peer.Tags = new Dictionary<string, string>();
                            peer.Tags[$"tfs_{this.workItem.Id}"] = "Active";
                            peer.Exchange.PeerAsn.Id = asn.Id;
                            // TODO: Dogfood only
                            if (this.ResourceManagementClient.SubscriptionId.Equals("3e919f9a-4e26-4736-aa8d-d596d9a49239"))
                            {
                                peer.Location = "centralus";
                            }
                            newPeeringStack.Push(this.ToPeeringPs(this.PeeringManagementClient.Peerings.CreateOrUpdate(resourceGroup.Body.Name, peeringName, this.ToPeering(peer))));
                            this.WriteObject(newPeeringStack.Peek());
                        }
                    }

                }
                catch (Microsoft.Azure.Management.Peering.Models.ErrorResponseException ex)
                {
                    var error = GetErrorCodeAndMessageFromArmOrErm(ex);
                    var errorMessage = $"Ticket:{this.WorkItemNumber}. {string.Format(Resources.Error_CloudError, error.Code, error.Message)} Link:{this.workItem.Url}";
                    this.errorPeeringStack.Push(errorMessage);
                    this.WriteWarning(errorMessage);
                }
            }
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose($"Verifying all resources were created properly for {this.WorkItemNumber}");
            try
            {
                if (errorPeeringStack.Count == 0)
                {
                    foreach (var stackPeering in this.newPeeringStack)
                    {
                        AzureOperationResponse<ResourceGroup> resourceGroup = null;
                        var xResourceGroup = stackPeering.PeeringLocation.TrimStart(' ').TrimEnd(' ').Replace(" ", "_");
                        resourceGroup = this.ResourceManagementClient.ResourceGroups.GetWithHttpMessagesAsync(xResourceGroup).GetAwaiter().GetResult();
                        this.WriteVerbose($"Found ResourceGroup: {resourceGroup.Body.Name}");
                        if (stackPeering.PeeringLocation != null && resourceGroup.Response.IsSuccessStatusCode && !this.ResourceManagementClient.SubscriptionId.Equals("3e919f9a-4e26-4736-aa8d-d596d9a49239"))
                        {
                            var peering = this.ToPeeringPs(this.PeeringManagementClient.Peerings.Get(resourceGroup.Body.Name, stackPeering.Name));
                            var peerAsn = (PSPeerAsn)this.ToPeeringAsnPs(this.PeeringManagementClient.PeerAsns.Get(this.PeerAsnAndPeering.Key.Name));
                            var sierra = new PeeringViewModel(peerAsn, peering, this.WorkItemNumber.Value);
                            var str = $"\n{DateTime.Now} -> PeeringAutomation:InProgress -> completed request" +
                                $"\n{DateTime.Now} -> PeeringAutomation:ViewResource -> $peering = Get-AzPeering -ResourceGroupName {resourceGroup.Body.Name} -Name {stackPeering.Name}";
                            this.WriteVerbose(this.UpdateQuickNotesForWorkItem(this.workItem, (int)this.workItem.Id, str));
                            this.WriteObject(sierra);
                        }
                        else if (this.ResourceManagementClient.SubscriptionId.Equals("3e919f9a-4e26-4736-aa8d-d596d9a49239") && resourceGroup.Response.IsSuccessStatusCode)
                        {
                            var peering = this.ToPeeringPs(this.PeeringManagementClient.Peerings.Get(resourceGroup.Body.Name, stackPeering.Name));
                            var peerAsn = (PSPeerAsn)this.ToPeeringAsnPs(this.PeeringManagementClient.PeerAsns.Get(this.PeerAsnAndPeering.Key.Name));
                            var sierra = new PeeringViewModel(peerAsn, peering, this.WorkItemNumber.Value);
                            var str = $"\n{DateTime.Now} -> PeeringAutomation:InProgress -> completed request" +
                                $"\n{DateTime.Now} -> PeeringAutomation:ViewResource -> $peering = Get-AzPeering -ResourceGroupName {resourceGroup.Body.Name} -Name {stackPeering.Name}";
                            this.WriteVerbose(str);
                            this.WriteObject(sierra);
                        }
                        else
                        {
                            this.WriteVerbose($"Ticket {this.WorkItemNumber} did not process properly");
                        }
                        if (this.newPeeringStack.Last() == stackPeering)
                        {
                            WriteVerbose($"Ticket: {this.WorkItemNumber} now complete.");
                        }
                    }
                }
                else
                {
                    foreach (var error in this.errorPeeringStack)
                    {
                        this.WriteWarning(error);
                    }
                    var str = $"\n{DateTime.Now} -> PeeringAutomation:Failed";
                    this.WriteVerbose(this.UpdateQuickNotesForWorkItem(this.workItem, (int)this.workItem.Id, str));
                }
            }
            catch (Microsoft.Azure.Management.Peering.Models.ErrorResponseException ex)
            {
                var error = GetErrorCodeAndMessageFromArmOrErm(ex);
                this.WriteWarning($"Ticket:{this.WorkItemNumber}. {string.Format(Resources.Error_CloudError, error.Code, error.Message)} Link:{this.workItem.Url}");
            }
        }
    }
}
