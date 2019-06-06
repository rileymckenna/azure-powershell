using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.PowerShell.Cmdlets.Peering.Models;
using TeamFoundationServerPowershell.Model;

namespace TeamFoundationServerPowershell
{
    [Cmdlet(VerbsCommon.Set, "TfsWorkItem")]
    [OutputType(typeof(KeyValuePair<PSPeerAsn, PSPeering>))]
    public class UpdateTfsWorkItems : TeamFoundationBase
    {
        private WorkItem workItem;
        [Parameter(
            Mandatory = true,
            Position = 0, ValueFromPipeline = true)]
        public PSExchangePeeringModelView InputObject { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1)]
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
            if(this.WorkItemId == null)
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
                    var connection = this.InputObject.Connections.FirstOrDefault();
                    var changeRecordTime = DateTime.Now.ToString();
                    var node = this.GetFacilityInformation(connection, this.InputObject.PeeringLocation);
                    var side = node.Split('-')[0].ToUpperInvariant().Contains("96") ? "- Other" : node.Split('-')[0].ToUpperInvariant();
                    var state = this.UpdateWorkItemStateToResolved(
                        (int)this.workItem.Id, side, side, node, node, changeRecordTime);
                    var str = $"\n{DateTime.Now} -> PeeringAutomation:Resolved -> completed request" +
                        $"\n{DateTime.Now} -> PeeringAutomation:ConnectionState -> {connection.ConnectionState}";
                    this.UpdateQuickNotesForWorkItem(this.workItem, (int)this.workItem.Id, str);
                }
                if (InProgress)
                {
                    var str = $"\n{DateTime.Now} -> PeeringAutomation:InProgress -> completed request";
                    this.UpdateQuickNotesForWorkItem(this.workItem, (int)this.workItem.Id, str);
                }
                if (QuickNotes != null)
                {
                    this.UpdateQuickNotesForWorkItem(this.workItem, (int)this.workItem.Id, QuickNotes);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string GetFacilityInformation(PSExchangeConnection connection, string peeringLocation)
        {
            var exchangeFacilities = JsonConvert.DeserializeObject<List<EdgeLocation>>(File.ReadAllText(@".\Common\FacilityLocationMap.json"));
            foreach (var location in exchangeFacilities)
            {
                if (location.LocationName.Equals(peeringLocation, StringComparison.InvariantCultureIgnoreCase))
                {
                    if (location.PublicPeeringFacilityMap.ContainsKey((uint)connection.PeeringDBFacilityId))
                    {
                        return location.PublicPeeringFacilityMap[(uint)connection.PeeringDBFacilityId].Devices.FirstOrDefault().Key;
                    }
                }
            }
            throw new Exception($"{peeringLocation} can not find the proper facility in the map.");
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End!");
        }
    }
}
