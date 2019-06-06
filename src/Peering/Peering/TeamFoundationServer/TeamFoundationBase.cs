using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Management.ResourceManager;
using Microsoft.Azure.PowerShell.Cmdlets.Peering.Common;
using Microsoft.Azure.PowerShell.Cmdlets.Peering.Models;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using Microsoft.VisualStudio.Services.WebApi.Patch.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using TeamFoundationServerPowershell.Model;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Microsoft.VisualStudio.Services.WebApi.Patch;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using System.Security.Cryptography;

namespace TeamFoundationServerPowershell
{

    public class TeamFoundationBase : PeeringBaseCmdlet
    {
        /// <summary>
        /// The project name.
        /// </summary>
        public const string ProjectName = "GNS-EDGE";

        private IResourceManagementClient managementClient;

        public IResourceManagementClient ResourceManagementClient
        {
            get =>
                this.managementClient ?? (this.managementClient =
                                           AzureSession.Instance.ClientFactory.CreateArmClient<ResourceManagementClient>(
                                               this.DefaultProfile.DefaultContext,
                                               AzureEnvironment.Endpoint.ResourceManager));

            set => this.managementClient = value;
        }

        /// <summary>
        /// The work item type name.
        /// </summary>
        private const string WorkItemTypeName = "Circuit LifeCycle Template";

        /// <summary>
        /// The project collection URI.
        /// </summary>
        private readonly Uri projectCollectionUri = new Uri("http://gfsvstf:8080/tfs/GFS%20Service%20Mgmt");

        /// <summary>
        /// The work item tracking client.
        /// </summary>
        public WorkItemTrackingHttpClient workItemTrackingHttpClient;

        public void SetWorkItemClient(ICredentials credentials = null)
        {
            var vssCredential = credentials == null ? new VssCredentials() : new VssCredentials(new WindowsCredential());

            var vssConnection = new VssConnection(this.projectCollectionUri, vssCredential);

            this.workItemTrackingHttpClient = vssConnection.GetClient<WorkItemTrackingHttpClient>();

            // Load Peering Facilities
            // var pp = @"..\..\..\src\ExternalDatabase\FacilityLocationMap.json";
            // this.exchangeFacilities = JsonConvert.DeserializeObject<List<PeeringLocation>>(File.ReadAllText(pp));
        }

        protected override void BeginProcessing()
        {
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
        }

        public static LocationMetadata ResolvePeeringFacility(string exchangeFacilityName, string ipv4, string ipv6)
        {
            List<EdgeLocation> exchangeFacilities = JsonConvert.DeserializeObject<List<EdgeLocation>>(File.ReadAllText(@".\Common\FacilityLocationMap.json"));
            RoutePrefix v4 = null;
            if (!ipv4.Equals(string.Empty, StringComparison.InvariantCultureIgnoreCase) && ipv4 != null)
            {
                v4 = new RoutePrefix(System.Net.IPAddress.Parse(ipv4.Trim()), 32);
            }
            RoutePrefix v6 = null;
            if (!ipv6.Equals(string.Empty, StringComparison.InvariantCultureIgnoreCase) && ipv6 != null)
            {
                v6 = new RoutePrefix(System.Net.IPAddress.Parse(ipv6.Trim()), 128);
            }
            foreach (var exchangeFacility in exchangeFacilities)
            {
                foreach (var publicPeeringFacility in exchangeFacility.PublicPeeringFacilityMap)
                {
                    if (v4 != null)
                    {
                        foreach (var ipvx in publicPeeringFacility.Value.Ipv4PrefixList)
                        {
                            if (v4.Overlap(new RoutePrefix(ipvx)))
                            {
                                return new LocationMetadata(
                                    (int)publicPeeringFacility.Key,
                                    publicPeeringFacility.Value.Name,
                                    exchangeFacility.LocationName, exchangeFacility.AzureRegion);
                            }
                        }

                    }
                    if (v6 != null)
                    {
                        foreach (var ipvx in publicPeeringFacility.Value.Ipv6PrefixList)
                        {
                            if (v6.Overlap(new RoutePrefix(ipvx)))
                            {
                                return new LocationMetadata(
                                    (int)publicPeeringFacility.Key,
                                    publicPeeringFacility.Value.Name,
                                    exchangeFacility.LocationName, exchangeFacility.AzureRegion);
                            }
                        }

                    }
                }
            }

            throw new Exception($"Peering Facility {exchangeFacilityName} not found in PeeringDb using ipv4 {ipv4} and ipv6 {ipv6}");
        }

        public KeyValuePair<PSPeerAsn, PSPeering> ParseWorkItemDescriptionForPeerAsnContactInformationAndPeeringInformation(
string descriptionFieldContents)
        {
            PSPeerAsn peerAsn = new PSPeerAsn();
            var peeringConfiguration = new PSPeering
            {
                Exchange = new PSPeeringPropertiesExchange
                {
                    Connections = new List<PSExchangeConnection>()
                }

            };
            var html = descriptionFieldContents;
            string[] strArr;
            if (html.ToString().Contains(@"&nbsp;"))
            {
                strArr = html.ToString().Replace(@"<p>", string.Empty).Replace(@"<strong>", string.Empty)
                    .Replace("\n", string.Empty).Replace(@"</strong>", string.Empty).Replace(@"&nbsp;", string.Empty)
                    .Split(new[] { "</p>" }, StringSplitOptions.RemoveEmptyEntries);
            }
            else if (html.ToString().Contains(@"<br>"))
            {
                strArr = html.ToString().Replace(@"<p>", string.Empty).Replace(@"</p>", string.Empty)
                    .Replace(@"<strong>", string.Empty).Replace(@"</strong>", string.Empty).Replace("\n", string.Empty)
                    .Split(new[] { "<br>" }, StringSplitOptions.RemoveEmptyEntries);
            }
            else
            {
                strArr = html.ToString().Replace(@"<p>", string.Empty).Replace(@"<strong>", string.Empty)
                    .Replace(@"</strong>", string.Empty).Replace("\n", string.Empty).Split(
                        new[] { @"</p>" },
                        StringSplitOptions.RemoveEmptyEntries);
            }

            var bgpSession = new PSBgpSession();
            var connectionStrings = new List<string>();
            for (int i = 0; i < strArr.Length; i++)
            {
                var subString = strArr[i].ToUpperInvariant();
                if (subString.Contains("AS") && subString.Contains("NUMBER"))
                {
                    var asn = int.Parse(strArr[i].Split(':')[1]);
                    peerAsn = new PSPeerAsn(name: $"AS{asn}") { PeerContactInfo = new PSContactInfo { Emails = new List<string>(), Phone = new List<string>() } };
                    peerAsn.PeerAsnProperty = asn;
                }

                if (subString.Contains("PEER") & subString.Contains("NAME"))
                {
                    peerAsn.PeerName = strArr[i].Split(':')[1];
                }

                if (subString.Contains("EMAIL"))
                {
                    var emails = strArr[i].Split(':')[1].Split(',');
                    Array.ForEach<string>(emails, x => peerAsn.PeerContactInfo.Emails.Add(x));
                }

                if (subString.Contains("PHONE"))
                {
                    var phones = strArr[i].Split(':')[1].Split(',');
                    Array.ForEach<string>(phones, x => peerAsn.PeerContactInfo.Phone.Add(x));
                }

                if (subString.Contains(("Max prefixes for IPv4").ToUpperInvariant()))
                {
                    bgpSession.MaxPrefixesAdvertisedV4 = int.Parse(subString.Split(':')[1]) > 20000 ? 20000 : int.Parse(subString.Split(':')[1]);
                }

                if (subString.Contains(("Max prefixes for IPv6").ToUpperInvariant()))
                {
                    bgpSession.MaxPrefixesAdvertisedV6 = int.Parse(subString.Split(':')[1]) > 2000 ? 2000 : int.Parse(subString.Split(':')[1]);
                }

                if (!subString.Contains(("exchange information").ToUpperInvariant())) continue;
                for (int j = i; j < strArr.Length; j++)
                {
                    connectionStrings.Add(strArr[j]);
                }

                break;
            }

            connectionStrings.Reverse();
            foreach (string subStr in connectionStrings)
            {
                var s = subStr.ToUpperInvariant();
                if (s.Contains(("IPv4").ToUpperInvariant()) && !s.Contains(("old").ToUpperInvariant()))
                {
                    bgpSession.PeerSessionIPv4Address = s.Split(':')[1];
                }

                if (s.Contains(("IPv6").ToUpperInvariant()) && !s.Contains(("old").ToUpperInvariant()))
                {
                    if (s.Contains(("new").ToUpperInvariant()))
                    {
                        bgpSession.PeerSessionIPv6Address = s.Substring(9).Trim();
                    }
                    else
                    {
                        bgpSession.PeerSessionIPv6Address = s.Substring(5);
                    }
                }

                if (s.Contains("--"))
                {
                    var peeringLocation = TeamFoundationBase.ResolvePeeringFacility(s.Replace("-", string.Empty).Trim(), bgpSession.PeerSessionIPv4Address, bgpSession.PeerSessionIPv6Address);
                    peeringConfiguration.PeeringLocation = peeringLocation.PeeringLocation;
                    peeringConfiguration.Exchange.Connections.Add(
                        new PSExchangeConnection
                        {
                            BgpSession = bgpSession,
                            PeeringDBFacilityId = peeringLocation.FacilityId
                        });
                    bgpSession = new PSBgpSession
                    {
                        MaxPrefixesAdvertisedV4 = bgpSession.MaxPrefixesAdvertisedV4,
                        MaxPrefixesAdvertisedV6 = bgpSession.MaxPrefixesAdvertisedV6
                    };
                }

                if (s.Contains(("Exchange Name").ToUpperInvariant()))
                {
                    try
                    {
                        var peeringLocation = TeamFoundationBase.ResolvePeeringFacility(s.Split(':')[1].Trim(), bgpSession.PeerSessionIPv4Address, bgpSession.PeerSessionIPv6Address);
                        peeringConfiguration.PeeringLocation = peeringLocation.PeeringLocation;
                        peeringConfiguration.Exchange.Connections.Add(
                            new PSExchangeConnection
                            {
                                BgpSession = bgpSession,
                                PeeringDBFacilityId = peeringLocation.FacilityId
                            });
                        bgpSession = new PSBgpSession
                        {
                            MaxPrefixesAdvertisedV4 = bgpSession.MaxPrefixesAdvertisedV4,
                            MaxPrefixesAdvertisedV6 = bgpSession.MaxPrefixesAdvertisedV6
                        };
                    }
                    catch (Exception ex)
                    {
                        this.WriteVerbose(ex.Message);
                        continue;
                    }
                }
            }

            peeringConfiguration.Kind = Constants.Exchange;
            peeringConfiguration.Sku = new PSPeeringSku(Constants.BasicExchangeFree);
            return new KeyValuePair<PSPeerAsn, PSPeering>(peerAsn, peeringConfiguration);
        }

        public string UpdateQuickNotesForWorkItem(WorkItem workItem, int workItemId, string completionDate)
        {
            var item = workItem;
            var s = item.Fields["gnsedge.quick_notes"].ToString();
            s += completionDate;
            var document = new JsonPatchDocument
                               {
                                   new JsonPatchOperation
                                       {
                                           Operation = Microsoft.VisualStudio.Services.WebApi.Patch.Operation.Replace,
                                           Path = "/fields/gnsedge.quick_notes",
                                           Value = s
                                       }
                               };

            var result = this.workItemTrackingHttpClient.UpdateWorkItemAsync(document, ProjectName, workItemId).Result;
            this.WriteVerbose(string.Format("Updated Ticket {0} {1}", workItemId, completionDate));
            if (result.Fields["System.State"].ToString() == "Resolved")
            {
                this.WriteVerbose(string.Format("Resolved Ticket {0} {1}", workItemId, completionDate));
            }

            return result.Fields["System.State"].ToString();
        }

        public string UpdateDescriptionForWorkItem(int workItemId, string description)
        {
            var document = new JsonPatchDocument
                               {
                                   new JsonPatchOperation
                                       {
                                           Operation = Microsoft.VisualStudio.Services.WebApi.Patch.Operation.Replace,
                                           Path = "/fields/System.Description",
                                           Value = description
                                       }
                               };

            var result = this.workItemTrackingHttpClient.UpdateWorkItemAsync(document, ProjectName, workItemId).Result;
            this.WriteVerbose(string.Format("Updated Description for Ticket {0} {1}", workItemId, description));

            return result.Fields["System.Description"].ToString();
        }

        public string UpdateWorkItemStateToResolved(
    int workItemId,
    string aSide,
    string zSide,
    string nodeA,
    string nodeZ,
    string completionDate)
        {
            if (aSide.Equals("wst", StringComparison.OrdinalIgnoreCase))
            {
                aSide = @"- Other";
                zSide = @"- Other";
            }
            var document = new JsonPatchDocument
                               {
                                   new JsonPatchOperation
                                       {
                                           Operation = Operation.Replace,
                                           Path = "/fields/System.State",
                                           Value = "Resolved"
                                       },
                                   new JsonPatchOperation
                                       {
                                           Operation = Operation.Add, Path = "/fields/custom.A_Side", Value = aSide
                                       },
                                   new JsonPatchOperation
                                       {
                                           Operation = Operation.Add,
                                           Path = "/fields/gnsedge.Actual_Finish",
                                           Value = completionDate
                                       },
                                   new JsonPatchOperation
                                       {
                                           Operation = Operation.Add, Path = "/fields/custom.Z_Side", Value = zSide
                                       },
                                   new JsonPatchOperation
                                       {
                                           Operation = Operation.Add, Path = "/fields/custom.Node_A", Value = nodeA
                                       },
                                   new JsonPatchOperation
                                       {
                                           Operation = Operation.Add, Path = "/fields/custom.Node_Z", Value = nodeZ
                                       }
                               };

            var result = this.workItemTrackingHttpClient.UpdateWorkItemAsync(document, ProjectName, workItemId)
                .Result;

            return result.Fields["System.State"].ToString();
        }
    }
}
