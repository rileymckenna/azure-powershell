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
using ErrorResponseException = Microsoft.Azure.Management.Peering.Models.ErrorResponseException;

namespace TeamFoundationServerPowershell
{
    [Cmdlet(VerbsCommon.New, "TfsClientDirectFromSecondarySubscription", SupportsShouldProcess = true)]
    [OutputType(typeof(PSPeering))]
    public class CreateFromDirectSecondarySubscription : TeamFoundationBase
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

        [Parameter(
        Mandatory = false)]
        public SwitchParameter Force { get; set; }

        /// <summary>
        ///     The AsJob parameter to run in the background.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = Constants.AsJobHelp)]
        public SwitchParameter AsJob { get; set; }

        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose($"Starting on new ticket {this.WorkItemNumber}");
            SetWorkItemClient();
            try
            {
                this.workItem = this.workItemTrackingHttpClient.GetWorkItemAsync(ProjectName, this.WorkItemNumber ?? 0).Result;
                this.PeerAsnAndPeering = this.ParseWorkItemDescriptionForPeerAsnContactInformationAndPeeringInformationDirect(this.workItem.Fields["System.Description"].ToString());
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
            // Check for PeerAsn
            var asnName = $"AS{this.PeerAsnAndPeering.Key.PeerAsnProperty}";
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
                this.ConfirmAction(this.Force,
                    string.Format(Resources.ContinueNewMessage, "create a new PeerAsn", $"Name: {asnName} PeerName: {PeerAsnAndPeering.Key.PeerName} Asn: {PeerAsnAndPeering.Key.PeerAsnProperty} Email: {string.Join(",", PeerAsnAndPeering.Key.PeerContactInfo.Emails)} Phone: {string.Join(",", PeerAsnAndPeering.Key.PeerContactInfo.Phone)}"),
                    string.Format(Resources.ContinueNewMessage, "create a new PeerAsn", $"Name: {asnName} PeerName: {PeerAsnAndPeering.Key.PeerName} Asn: {PeerAsnAndPeering.Key.PeerAsnProperty} Email: {string.Join(",", PeerAsnAndPeering.Key.PeerContactInfo.Emails)} Phone: {string.Join(",", PeerAsnAndPeering.Key.PeerContactInfo.Phone)}"),
                    $"Name: {asnName} PeerName: {PeerAsnAndPeering.Key.PeerName} Asn: {PeerAsnAndPeering.Key.PeerAsnProperty} Email: {string.Join(",", PeerAsnAndPeering.Key.PeerContactInfo.Emails)} Phone: {string.Join(",", PeerAsnAndPeering.Key.PeerContactInfo.Phone)}",
                    this.CreateNewPeerAsn(asnName, PeerAsnAndPeering.Key));
                asn = (PSPeerAsn)this.ToPeeringAsnPs(this.PeeringManagementClient.PeerAsns.Get(asnName));
                Thread.Sleep(1000);
                asn.ValidationState = "Approved";
                this.WriteObject(this.PeeringManagementClient.PeerAsns.CreateOrUpdate(asnName, this.ToPeeringAsn(asn)));
            }


            foreach (var descriptionPeering in this.PeerAsnAndPeering.Value)
            {
                // Get Resource Group
                AzureOperationResponse<ResourceGroup> resourceGroup = null;
                var peeringName = $"{asnName}_{descriptionPeering.Name}_Direct";
                try
                {
                    this.WriteVerbose($"Checking for Resource Group {descriptionPeering.Name}");
                    resourceGroup = this.ResourceManagementClient.ResourceGroups.GetWithHttpMessagesAsync(descriptionPeering.Name).GetAwaiter().GetResult();
                    this.WriteVerbose($"Resource Group {resourceGroup.Body.Name} found.");
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
                        if (this.ResourceManagementClient.SubscriptionId.Equals("3e919f9a-4e26-4736-aa8d-d596d9a49239"))
                        {
                            rg.Location = "centralus";
                        }
                        this.ConfirmAction(this.Force,
                            string.Format(Resources.ContinueNewMessage, "create a new resource group", $"ResourceGroupName: {rg.Name} Region: {rg.Location}"),
                            string.Format(Resources.ContinueNewMessage, "create a new resource group", $"ResourceGroupName: {rg.Name} Region: {rg.Location}"),
                            $"ResourceGroupName: {rg.Name} Region: {rg.Location}",
                            this.CreateNewResourceGroup(rg));
                        resourceGroup = this.ResourceManagementClient.ResourceGroups.GetWithHttpMessagesAsync(descriptionPeering.Name).GetAwaiter().GetResult();
                        if (!resourceGroup.Response.IsSuccessStatusCode)
                        {
                            throw new Exception("ResourceGroup Failed to create");
                        }
                    }
                }

                try
                {
                    // check for Legacy
                    this.WriteVerbose("Checking for Legacy");
                    var allLegacyPeering = this.PeeringManagementClient.LegacyPeerings.List(descriptionPeering.PeeringLocation, Constants.Direct);
                    PeeringModel legacyPeering = null;
                    foreach (var legacy in allLegacyPeering)
                    {
                        if (legacy.Direct.PeerAsn.Id.Equals(asn.PeerAsnProperty.ToString(), StringComparison.InvariantCultureIgnoreCase) && legacy.PeeringLocation.Equals(descriptionPeering.PeeringLocation, StringComparison.InvariantCultureIgnoreCase))
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
                        legacyPeering.Direct.PeerAsn.Id = asn.Id;
                        var viewModel = new PSDirectPeeringModelView(this.ToPeeringPs(legacyPeering));
                        this.WriteObject(viewModel, true);
                        foreach (var connection in viewModel.Connections)
                        {
                            this.WriteVerbose($"ARM tracked bandwidth: {connection.BandwidthInMbps}. Provisioned Bandwidth: {connection.ProvisionedBandwidthInMbps}");
                            this.WriteObject(connection.BgpSession);
                            // Update bandwidth when supported.
                            connection.BandwidthInMbps = connection.ProvisionedBandwidthInMbps;
                        }
                        this.ConfirmAction(this.Force,
                            string.Format(Resources.ContinueNewMessage, "convert a Legacy Peering", $"Name: {peeringName} ResourceGroup: {resourceGroup.Body.Name}"),
                            string.Format(Resources.ContinueNewMessage, "convert a Legacy Peering", $"Name: {peeringName} ResourceGroup: {resourceGroup.Body.Name}"),
                           peeringName,
                            this.CreateOrUpdatePeering(resourceGroup.Body.Name, peeringName, legacyPeering));
                        try
                        {
                            this.WriteVerbose($"Peering was converted at {descriptionPeering.PeeringLocation} and adding connection to {peeringName}");
                            var newPeering = this.PeeringManagementClient.Peerings.Get(resourceGroup.Body.Name, peeringName);
                            if (newPeering != null)
                            {
                                var deviceInformation = TeamFoundationBase.ResolveDirectPeeringFacility(this.workItem.Fields["custom.Node_A"].ToString());
                                if (newPeering.Tags?.Count > 0)
                                {

                                    foreach (var directPeeringConnection in newPeering.Direct.Connections)
                                    {
                                        // Get the device ID
                                        // Get the location
                                        var key = $"{directPeeringConnection.ConnectionIdentifier}_{deviceInformation.Name}_{this.workItem.Id}";
                                        newPeering.Tags[key] = "Active";
                                        this.WriteVerbose($"Existing tags associated with the Peering. Adding Keys: {string.Join(",", newPeering.Tags.Keys)}. Adding new tag.key {key}");
                                    }
                                }
                                else
                                {
                                    foreach (var directPeeringConnection in newPeering.Direct.Connections)
                                    {
                                        newPeering.Tags = new Dictionary<string, string>();
                                        var key = $"{directPeeringConnection.ConnectionIdentifier}_{deviceInformation.Name}_{this.workItem.Id}";
                                        newPeering.Tags[key] = "Active";
                                        this.WriteVerbose($"No tags associated with the Peering. Adding Keys: {string.Join(",", newPeering.Tags.Keys)}. Adding new tag.key {key}");
                                    }
                                }
                                foreach (var psConnection in descriptionPeering.Direct.Connections)
                                {
                                    // Add new connection DECOM other
                                    if (psConnection.BandwidthInMbps == 100000)
                                    {
                                        var connection = PeeringResourceManagerProfile.Mapper.Map<DirectConnection>(psConnection);
                                        this.WriteVerbose($"Add Connection");
                                        newPeering.Direct.Connections.Add(connection);
                                    }
                                    else
                                    {
                                        for (int i = 0; i < newPeering.Direct.Connections.Count - 1; i++)
                                        {
                                            if (newPeering.Direct.Connections[i].BandwidthInMbps < psConnection.BandwidthInMbps)
                                            {
                                                this.WriteVerbose($"Update Connection");
                                                newPeering.Direct.Connections[i].BandwidthInMbps = psConnection.BandwidthInMbps;
                                            }
                                        }
                                    }
                                    this.WriteObject(this.ToPeeringPs(newPeering));
                                    this.ConfirmAction(this.Force,
                                        string.Format(Resources.ContinueNewMessage, "Update a converted Legacy Peering", $"Name: {peeringName} ResourceGroup: {resourceGroup.Body.Name}"),
                                        string.Format(Resources.ContinueNewMessage, "Update a converted Legacy Peering", $"Name: {peeringName} ResourceGroup: {resourceGroup.Body.Name}"),
                                        "AddOrUpdating Connection",
                                        this.CreateOrUpdatePeering(resourceGroup.Body.Name, peeringName, newPeering));
                                    newPeering = this.PeeringManagementClient.Peerings.Get(resourceGroup.Body.Name, peeringName);
                                }
                                newPeeringStack.Push(this.ToPeeringPs(this.PeeringManagementClient.Peerings.Get(resourceGroup.Body.Name, peeringName)));
                                this.WriteObject(newPeeringStack.Peek());
                            }
                        }
                        catch (ErrorResponseException ex)
                        {
                            var error = GetErrorCodeAndMessageFromArmOrErm(ex);
                            var errorMessage = $"Ticket:{this.WorkItemNumber}. {string.Format(Resources.Error_CloudError, error.Code, error.Message)} Link:{this.workItem.Url}";
                            this.errorPeeringStack.Push(errorMessage);
                            this.WriteWarning(errorMessage);
                        }
                    }
                    else
                    {
                        try
                        {
                            this.WriteVerbose($"An existing peering at {descriptionPeering.PeeringLocation} and adding connection to {peeringName}");
                            var newPeering = this.PeeringManagementClient.Peerings.Get(resourceGroup.Body.Name, peeringName);
                            if (newPeering != null)
                            {
                                var deviceInformation = TeamFoundationBase.ResolveDirectPeeringFacility(this.workItem.Fields["custom.Node_A"].ToString());
                                if (newPeering.Tags?.Count > 0)
                                {

                                    foreach (var directPeeringConnection in newPeering.Direct.Connections)
                                    {
                                        // Get the device ID
                                        // Get the location
                                        var key = $"{directPeeringConnection.ConnectionIdentifier}_{deviceInformation.Name}_{this.workItem.Id}";
                                        newPeering.Tags[key] = "Active";
                                        this.WriteVerbose($"Existing tags associated with the Peering. Adding Keys: {string.Join(",", newPeering.Tags.Keys)}. Adding new tag.key {key}");
                                    }
                                }
                                else
                                {
                                    foreach (var directPeeringConnection in newPeering.Direct.Connections)
                                    {
                                        newPeering.Tags = new Dictionary<string, string>();
                                        var key = $"{directPeeringConnection.ConnectionIdentifier}_{deviceInformation.Name}_{this.workItem.Id}";
                                        newPeering.Tags[key] = "Active";
                                        this.WriteVerbose($"No tags associated with the Peering. Adding Keys: {string.Join(",", newPeering.Tags.Keys)}. Adding new tag.key {key}");
                                    }
                                }
                                foreach (var psConnection in descriptionPeering.Direct.Connections)
                                {
                                    // Add new connection DECOM other
                                    if (psConnection.BandwidthInMbps == 100000)
                                    {
                                        var connection = PeeringResourceManagerProfile.Mapper.Map<DirectConnection>(psConnection);
                                        this.WriteVerbose($"Add Connection");
                                        newPeering.Direct.Connections.Add(connection);
                                    }
                                    else
                                    {
                                        for (int i = 0; i < newPeering.Direct.Connections.Count - 1; i++)
                                        {
                                            if (newPeering.Direct.Connections[i].BandwidthInMbps < psConnection.BandwidthInMbps)
                                            {
                                                this.WriteVerbose($"Update Connection");
                                                newPeering.Direct.Connections[i].BandwidthInMbps = psConnection.BandwidthInMbps;
                                            }
                                        }
                                    }
                                    try
                                    {
                                        this.WriteObject(this.ToPeeringPs(newPeering));
                                        this.ConfirmAction(this.Force,
                                            string.Format(Resources.ContinueNewMessage, "Update an exisiting Peering", $"Name: {peeringName} ResourceGroup: {resourceGroup.Body.Name}"),
                                            string.Format(Resources.ContinueNewMessage, "Update an exisiting Peering", $"Name: {peeringName} ResourceGroup: {resourceGroup.Body.Name}"),
                                            "AddOrUpdating Connection",
                                            this.CreateOrUpdatePeering(resourceGroup.Body.Name, peeringName, newPeering));
                                        newPeering = this.PeeringManagementClient.Peerings.Get(resourceGroup.Body.Name, peeringName);
                                    }
                                    catch (Microsoft.Azure.Management.Peering.Models.ErrorResponseException ex)
                                    {
                                        var error = GetErrorCodeAndMessageFromArmOrErm(ex);
                                        var errorMessage = $"Ticket:{this.WorkItemNumber}. {string.Format(Resources.Error_CloudError, error.Code, error.Message)} Link:{this.workItem.Url}";
                                        this.errorPeeringStack.Push(errorMessage);
                                        this.WriteWarning(errorMessage);
                                    }
                                }
                                newPeeringStack.Push(this.ToPeeringPs(this.PeeringManagementClient.Peerings.Get(resourceGroup.Body.Name, peeringName)));
                                this.WriteObject(newPeeringStack.Peek());
                            }
                        }
                        catch
                        {
                            this.WriteVerbose($"No existing peering, creating new {peeringName} with Asn {this.PeerAsnAndPeering.Key.PeerAsnProperty} at location {descriptionPeering.PeeringLocation}");
                            var peer = descriptionPeering;
                            var deviceInformation = TeamFoundationBase.ResolveDirectPeeringFacility(this.workItem.Fields["custom.Node_A"].ToString());
                            peer.Tags = new Dictionary<string, string>();
                            foreach (var directPeeringConnection in peer.Direct.Connections)
                            {
                                var key = $"{directPeeringConnection.ConnectionIdentifier}_{deviceInformation.Name}_{this.workItem.Id}";
                                peer.Tags[key] = "Active";
                            }
                            peer.Direct.PeerAsn.Id = asn.Id;
                            // TODO: Dogfood only
                            if (this.ResourceManagementClient.SubscriptionId.Equals("3e919f9a-4e26-4736-aa8d-d596d9a49239"))
                            {
                                peer.Location = "centralus";
                            }
                            this.WriteObject(peer);
                            this.ConfirmAction(this.Force,
                                string.Format(Resources.ContinueNewMessage, "Add a new Peering", $"Name: {peeringName} ResourceGroup: {resourceGroup.Body.Name}"),
                                string.Format(Resources.ContinueNewMessage, "Add a new Peering", $"Name: {peeringName} ResourceGroup: {resourceGroup.Body.Name}"),
                                string.Join("|", peer.Direct.Connections),
                                this.CreateOrUpdatePeering(resourceGroup.Body.Name, peeringName, this.ToPeering(peer)));
                            newPeeringStack.Push(this.ToPeeringPs(this.PeeringManagementClient.Peerings.Get(resourceGroup.Body.Name, peeringName)));
                            this.WriteObject(newPeeringStack.Peek());
                        }
                    }

                }
                catch (Microsoft.Azure.Management.Peering.Models.ErrorResponseException ex)
                {
                    var error = GetErrorCodeAndMessageFromArmOrErm(ex);
                    var errorMessage = $"Ticket:{this.WorkItemNumber}. {string.Format(Resources.Error_CloudError, error.Code, error.Message)} on {peeringName}";
                    this.errorPeeringStack.Push(errorMessage);
                    this.WriteWarning(errorMessage);
                }
            }
        }

        private Action CreateOrUpdatePeering(string resourceGroupName, string peeringName, PeeringModel peeringObject)
        {
            try
            {
                //this.WriteVerbose(string.Format($"Creating Name:{0} ResourceGroup: {1} Info: {2}", peeringName, resourceGroupName, peeringObject));
                return new Action(() => this.PeeringManagementClient.Peerings.CreateOrUpdate(resourceGroupName, peeringName, peeringObject));
            }
            catch (Exception ex)
            {
                return new Action(() => this.WriteExceptionError(ex));
            }
        }

        private Action CreateNewPeerAsn(string asnName, PSPeerAsn key)
        {
            try
            {
                //this.WriteVerbose(string.Format($"Creating Name:{0} Info: {1}", asnName, key));
                var action = new Action(() => this.PeeringManagementClient.PeerAsns.CreateOrUpdate(asnName, this.ToPeeringAsn(key)));
                //this.WriteVerbose($"Created PeerAsn: {asnName}");
                return action;
            }
            catch (Exception ex)
            {
                return new Action(() => this.WriteExceptionError(ex));
            }
        }

        private Action CreateNewResourceGroup(ResourceGroup rg)
        {
            try
            {
                // this.WriteVerbose($"Creating new ResourceGroup: {rg.Name} Region: {rg.Location}");
                var action = new Action(() => this.ResourceManagementClient.ResourceGroups.CreateOrUpdateWithHttpMessagesAsync(rg.Name, rg).GetAwaiter().GetResult());
                // this.WriteVerbose($"Created ResourceGroup: {rg.Name}");
                return action;
            }
            catch (Exception ex)
            {
                return new Action(() => this.WriteExceptionError(ex));
            }
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose($"Verifying all resources were created properly for {this.WorkItemNumber}");
            try
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
                        var str = $"\n{DateTime.Now} -> PeeringAutomation:InProgress -> completed request; Devices have been configured - ProvisioningCompleted" +
                            $"\n{DateTime.Now} -> PeeringAutomation:ViewResource -> $peering = Get-AzPeering -ResourceGroupName {resourceGroup.Body.Name} -Name {stackPeering.Name}";
                        this.WriteVerbose(this.UpdateQuickNotesForWorkItem((int)this.workItem.Id, str));
                        Thread.Sleep(3000);
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
                if (errorPeeringStack.Count != 0)
                {
                    foreach (var error in this.errorPeeringStack)
                    {
                        if (!this.ResourceManagementClient.SubscriptionId.Equals("3e919f9a-4e26-4736-aa8d-d596d9a49239"))
                        {
                            var str = $"\n{DateTime.Now} -> PeeringAutomation:Failed -> {error}";
                            this.WriteVerbose(this.UpdateQuickNotesForWorkItem((int)this.workItem.Id, str));
                        }
                        else
                        {
                            var str = $"\n{DateTime.Now} -> PeeringAutomation:Failed -> {error}";
                            this.WriteVerbose($"Mock updated ticket with: {str}");
                        }
                    }
                }
            }
            catch (Microsoft.Azure.Management.Peering.Models.ErrorResponseException ex)
            {
                var error = GetErrorCodeAndMessageFromArmOrErm(ex);
                this.WriteWarning($"Ticket:{this.WorkItemNumber}. {string.Format(Resources.Error_CloudError, error.Code, error.Message)}");
            }
        }
    }
}
