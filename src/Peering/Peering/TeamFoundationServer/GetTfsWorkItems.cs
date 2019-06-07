using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Management.Automation;

namespace TeamFoundationServerPowershell
{
    [Cmdlet(VerbsCommon.Get, "TfsWorkItem")]
    [OutputType(typeof(WorkItem))]
    public class GetTfsWorkItems : TeamFoundationBase
    {
        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public int? WorkItemId { get; set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter UntouchedTickets { get; set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter FailedTickets { get; set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter CreatedUsingPeeringAutomation { get; set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter All { get; set; }

        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose("Logging into VSS");
            SetWorkItemClient();
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
            try
            {
                if (this.WorkItemId == null)
                {
                    WriteVerbose("Getting all open tickets. Long running...");
                    var output = GetAllTickets();
                    this.WriteObject(output);
                }
                else
                {
                    WriteVerbose($"Getting ticket {this.WorkItemId}");
                    this.WriteObject(this.workItemTrackingHttpClient.GetWorkItemAsync(ProjectName, this.WorkItemId ?? 0).Result);
                }
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

        private List<WorkItem> GetAllTickets()
        {
            string queryString = string.Empty;
            if (!this.All)
            {
                if (this.UntouchedTickets && !this.FailedTickets && !this.CreatedUsingPeeringAutomation)
                {
                    queryString = @"AND [gnsedge.quick_notes] NOT CONTAINS WORDS 'PeeringAutomation:Failed' AND [gnsedge.quick_notes] NOT CONTAINS WORDS 'PeeringAutomation:InProgress'";
                }
                if (this.FailedTickets && !this.UntouchedTickets && !this.CreatedUsingPeeringAutomation)
                {
                    queryString = @"AND [gnsedge.quick_notes] CONTAINS WORDS 'PeeringAutomation:Failed'";
                }
                if(!this.FailedTickets && !this.UntouchedTickets && this.CreatedUsingPeeringAutomation)
                {
                    queryString = @"AND [gnsedge.quick_notes] NOT CONTAINS WORDS 'PeeringAutomation:Failed' AND [gnsedge.quick_notes] CONTAINS WORDS 'PeeringAutomation:InProgress'";
                }
            }

            var wiql = new Wiql();
            wiql.Query =
                $"SELECT [System.Id],[System.WorkItemType],[System.Title],[System.AssignedTo],[System.State],[System.Tags] FROM WorkItems WHERE [System.TeamProject] = @project AND [gnsedge.Team] = 'Edge SRE DRI' AND [gnsedge.SubState] <> 'Blocked' AND [System.Title] CONTAINS 'PeerChange' AND [System.State] = 'Active' AND [System.Description] NOT CONTAINS WORDS 'backup' {queryString} ORDER BY [System.Id] DESC";
            var workItemReferences =
            this.workItemTrackingHttpClient.QueryByWiqlAsync(wiql, ProjectName).Result.WorkItems;
            var workItemList = new List<WorkItem>();
            foreach (var workItemReference in workItemReferences)
            {
                int workItemId = workItemReference.Id;
                var workItem = this.workItemTrackingHttpClient.GetWorkItemAsync(ProjectName, workItemId).Result;
                workItemList.Add(workItem);
            }

            return workItemList;
        }
    }
}
