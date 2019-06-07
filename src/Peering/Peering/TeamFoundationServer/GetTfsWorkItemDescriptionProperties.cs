using Microsoft.Azure.PowerShell.Cmdlets.Peering.Models;
using Microsoft.TeamFoundation.Work.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using TeamFoundationServerPowershell.Model.Data;

namespace TeamFoundationServerPowershell
{
    [Cmdlet(VerbsCommon.Get, "TfsWorkItemDescriptionProperties")]
    [OutputType(typeof(KeyValuePair<PSPeerAsn, PSPeering>))]
    public class TfsWorkItemDescriptionProperties : TeamFoundationBase
    {
        private WorkItem workItem;

        [Parameter(
        Mandatory = true,
        ValueFromPipeline = true)]
        public int? WorkItemId { get; set; }

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
                var keyValue = this.ParseWorkItemDescriptionForPeerAsnContactInformationAndPeeringInformation(this.workItem.Fields["System.Description"].ToString());
                foreach (var peering in keyValue.Value)
                {
                    this.WriteObject(new PeeringViewModel(keyValue.Key, peering));
                }
            }
            catch(Exception ex)
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
