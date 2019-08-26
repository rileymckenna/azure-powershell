﻿using Microsoft.Azure.Commands.Common.Authentication;
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
using System.Net;
using TeamFoundationServerPowershell.Model;
using Microsoft.VisualStudio.Services.WebApi.Patch;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.Azure.Commands.Peering.Common;
using Microsoft.Azure.Management.Peering.Models;
using Operation = Microsoft.VisualStudio.Services.WebApi.Patch.Operation;

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
            ipv6 = ipv6 ?? string.Empty;
            ipv4 = ipv4 ?? string.Empty;
            var json = StaticFile.GetFacilityLocationMap().ToString();
            List<EdgeLocation> exchangeFacilities = JsonConvert.DeserializeObject<List<EdgeLocation>>(json);
            RoutePrefix v4 = null;
            if (!ipv4.Equals(string.Empty, StringComparison.InvariantCultureIgnoreCase) && ipv4 != string.Empty)
            {
                v4 = new RoutePrefix(System.Net.IPAddress.Parse(ipv4.Trim()), 32);
            }
            RoutePrefix v6 = null;
            if (!ipv6.Equals(string.Empty, StringComparison.InvariantCultureIgnoreCase) && ipv6 != string.Empty)
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

        public static LocationMetadata ResolveDirectPeeringFacility(string deviceName)
        {
            var json = StaticFile.GetFacilityLocationMap().ToString();
            List<EdgeLocation> directPeeringfacilities = JsonConvert.DeserializeObject<List<EdgeLocation>>(json);
            foreach (var facility in directPeeringfacilities)
            {
                foreach (var keyValuePair in facility.PrivatePeeringFacilityMap)
                {
                    if (keyValuePair.Value.Devices.ContainsKey(deviceName))
                    {
                        return new LocationMetadata((int)keyValuePair.Key, deviceName, facility.LocationName, facility.AzureRegion, keyValuePair.Value.LocationType);
                    }
                }
            }

            return null;
        }

        public KeyValuePair<PSPeerAsn, List<PSPeering>> ParseWorkItemDescriptionForPeerAsnContactInformationAndPeeringInformation(
string descriptionFieldContents)
        {
            List<PSPeering> listPeering = new List<PSPeering>();
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
            else if (html.ToString().Contains(@"<div>") && html.ToString().Contains(@"<br>"))
            {
                strArr = html.ToString().Replace(@"<div>", string.Empty).Replace(@"<br>", string.Empty).Replace("\n", string.Empty)
    .Split(new[] { "</div>" }, StringSplitOptions.RemoveEmptyEntries);
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
                var subString = strArr[i].ToLowerInvariant();
                if (subString.Contains("as") && subString.Contains("number"))
                {
                    var asn = int.Parse(strArr[i].Split(':')[1]);
                    peerAsn = new PSPeerAsn(name: $"AS{asn}") { PeerContactInfo = new PSContactInfo { Emails = new List<string>(), Phone = new List<string>() } };
                    peerAsn.PeerAsnProperty = asn;
                }

                if (subString.Contains("peer") & subString.Contains("name"))
                {
                    peerAsn.PeerName = strArr[i].Split(':')[1].Trim();
                }

                if (subString.Contains("email"))
                {
                    var emails = strArr[i].Split(':')[1].Trim().Split(',');
                    Array.ForEach<string>(emails, x => peerAsn.PeerContactInfo.Emails.Add(x));
                }

                if (subString.Contains("phone"))
                {
                    var phones = strArr[i].Split(':')[1].Trim().Split(',');
                    Array.ForEach<string>(phones, x => peerAsn.PeerContactInfo.Phone.Add(x));
                }

                if (subString.Contains(("Max prefixes for IPv4").ToLowerInvariant()))
                {
                    bgpSession.MaxPrefixesAdvertisedV4 = int.Parse(subString.Split(':')[1]) > 20000 ? 20000 : int.Parse(subString.Split(':')[1]);
                }

                if (subString.Contains(("Max prefixes for IPv6").ToLowerInvariant()))
                {
                    bgpSession.MaxPrefixesAdvertisedV6 = int.Parse(subString.Split(':')[1]) > 2000 ? 2000 : int.Parse(subString.Split(':')[1]);
                }

                if (!subString.Contains(("exchange information"))) continue;
                for (int j = i; j < strArr.Length; j++)
                {
                    connectionStrings.Add(strArr[j]);
                }

                break;
            }

            connectionStrings.Reverse();
            LocationMetadata prevLocation = null;
            foreach (string subStr in connectionStrings)
            {
                var s = subStr.ToLowerInvariant();
                if (s.Contains(("IPv4").ToLowerInvariant()) && !s.Contains(("old").ToLowerInvariant()))
                {
                    bgpSession.PeerSessionIPv4Address = s.Split(':')[1].Trim();
                    continue;
                }

                if (s.Contains(("MD5").ToLowerInvariant()))
                {
                    bgpSession.Md5AuthenticationKey = subStr.Split(':')[1].Trim();
                    continue;
                }

                if (s.Contains(("IPv6").ToLowerInvariant()) && !s.Contains(("old").ToLowerInvariant()))
                {
                    bgpSession.PeerSessionIPv6Address = s.Substring(5).Trim();
                    continue;
                }
                if (s.Contains(("Exchange Name").ToLowerInvariant()))
                {
                    try
                    {
                        var peeringLocation = TeamFoundationBase.ResolvePeeringFacility(s.Split(':')[1].Trim(), bgpSession.PeerSessionIPv4Address, bgpSession.PeerSessionIPv6Address);
                        if (peeringLocation.PeeringLocation.Equals(prevLocation?.PeeringLocation))
                        {
                            prevLocation = peeringLocation;
                            listPeering.Find(x => x.PeeringLocation == peeringLocation.PeeringLocation).Exchange.Connections.Add(
                                new PSExchangeConnection
                                {
                                    ConnectionIdentifier = Guid.NewGuid().ToString(),
                                    BgpSession = bgpSession,
                                    PeeringDBFacilityId = peeringLocation.FacilityId
                                });
                            bgpSession = new PSBgpSession
                            {
                                MaxPrefixesAdvertisedV4 = bgpSession.MaxPrefixesAdvertisedV4 ?? 20000,
                                MaxPrefixesAdvertisedV6 = bgpSession.MaxPrefixesAdvertisedV6 ?? 2000
                            };
                        }
                        else
                        {
                            prevLocation = peeringLocation;
                            peeringConfiguration.Exchange.Connections = new List<PSExchangeConnection>();
                            peeringConfiguration.Exchange.Connections.Add(new PSExchangeConnection
                            {
                                PeeringDBFacilityId = peeringLocation.FacilityId,
                                ConnectionIdentifier = Guid.NewGuid().ToString(),
                                BgpSession = new PSBgpSession
                                {
                                    MaxPrefixesAdvertisedV4 = bgpSession.MaxPrefixesAdvertisedV4 ?? 20000,
                                    MaxPrefixesAdvertisedV6 = bgpSession.MaxPrefixesAdvertisedV6 ?? 2000,
                                    PeerSessionIPv4Address = bgpSession.PeerSessionIPv4Address,
                                    PeerSessionIPv6Address = bgpSession.PeerSessionIPv6Address,
                                    Md5AuthenticationKey = bgpSession.Md5AuthenticationKey
                                }
                            });
                            var xPeering = new PSPeering(new PSPeeringSku(Constants.BasicExchangeFree), Constants.Exchange, peeringLocation.AzRegion, peeringLocation.PeeringLocationWithOutSpace, exchange: new PSPeeringPropertiesExchange
                            {
                                PeerAsn = new PSSubResource(peerAsn.Name),
                                Connections = peeringConfiguration.Exchange.Connections
                            }, peeringLocation: peeringLocation.PeeringLocation);
                            listPeering.Add(xPeering);
                        }
                    }
                    catch (Exception ex)
                    {
                        this.WriteVerbose(ex.Message);
                        throw new Exception(ex.Message);
                    }
                }
            }
            return new KeyValuePair<PSPeerAsn, List<PSPeering>>(peerAsn, listPeering);
        }

        public KeyValuePair<PSPeerAsn, List<PSPeering>> ParseWorkItemDescriptionForPeerAsnContactInformationAndPeeringInformationDirect(
string descriptionFieldContents)
        {
            List<PSPeering> listPeering = new List<PSPeering>();
            PSPeerAsn peerAsn = new PSPeerAsn();
            var peeringConfiguration = new PSPeering
            {
                Direct = new PSPeeringPropertiesDirect
                {
                    Connections = new List<PSDirectConnection>()
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
            else if (html.ToString().Contains(@"<div>") && html.ToString().Contains(@"<br>"))
            {
                strArr = html.ToString().Replace(@"<div>", string.Empty).Replace(@"<br>", string.Empty).Replace("\n", string.Empty)
    .Split(new[] { "</div>" }, StringSplitOptions.RemoveEmptyEntries);
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
                var subString = strArr[i].ToLowerInvariant();
                if (subString.Contains("as") && subString.Contains("number"))
                {
                    var asn = int.Parse(strArr[i].Split(':')[1]);
                    peerAsn = new PSPeerAsn(name: $"AS{asn}") { PeerContactInfo = new PSContactInfo { Emails = new List<string>(), Phone = new List<string>() } };
                    peerAsn.PeerAsnProperty = asn;
                }

                if (subString.Contains("peer") & subString.Contains("name"))
                {
                    peerAsn.PeerName = strArr[i].Split(':')[1].Trim();
                }

                if (subString.Contains("email"))
                {
                    var emails = strArr[i].Split(':')[1].Trim().Split(',');
                    Array.ForEach<string>(emails, x => peerAsn.PeerContactInfo.Emails.Add(x));
                }

                if (subString.Contains("phone"))
                {
                    var phones = strArr[i].Split(':')[1].Trim().Split(',');
                    Array.ForEach<string>(phones, x => peerAsn.PeerContactInfo.Phone.Add(x));
                }

                if (subString.Contains(("Max prefixes for IPv4").ToLowerInvariant()))
                {
                    bgpSession.MaxPrefixesAdvertisedV4 = int.Parse(subString.Split(':')[1]) > 20000 ? 20000 : int.Parse(subString.Split(':')[1]);
                }

                if (subString.Contains(("Max prefixes for IPv6").ToLowerInvariant()))
                {
                    bgpSession.MaxPrefixesAdvertisedV6 = int.Parse(subString.Split(':')[1]) > 2000 ? 2000 : int.Parse(subString.Split(':')[1]);
                }

                if (!subString.Contains(("direct pni information"))) continue;
                for (int j = i; j < strArr.Length; j++)
                {
                    connectionStrings.Add(strArr[j]);
                }

                break;
            }

            connectionStrings.Reverse();
            LocationMetadata prevLocation = null;
            var bandwidth = 10000;
            foreach (string subStr in connectionStrings)
            {
                var s = subStr.ToLowerInvariant();
                if (s.Contains(("IPv4").ToLowerInvariant()))
                {
                    bgpSession.SessionPrefixV6 = s.Split(':')[1].Trim();
                    continue;
                }

                if (s.Contains(("BandwidthInMbps").ToLowerInvariant()))
                {
                    bandwidth = int.Parse(subStr.Split(':')[1].Trim());
                    continue;
                }

                if (s.Contains(("IPv6").ToLowerInvariant()))
                {
                    bgpSession.SessionPrefixV6 = s.Substring(5).Trim();
                    continue;
                }
                if (s.Contains(("Device Name").ToLowerInvariant()))
                {
                    try
                    {
                        var peeringLocation = TeamFoundationBase.ResolveDirectPeeringFacility(s.Split(':')[1].Trim());
                        if(bgpSession.SessionPrefixV6 == string.Empty && bgpSession.SessionPrefixV6 == string.Empty)
                        {
                            bgpSession = null;
                        }
                        if (peeringLocation.PeeringLocation.Equals(prevLocation?.PeeringLocation))
                        {
                            prevLocation = peeringLocation;
                            listPeering.Find(x => x.PeeringLocation == peeringLocation.PeeringLocation).Direct.Connections.Add(
                                new PSDirectConnection
                                {
                                    ConnectionIdentifier = Guid.NewGuid().ToString(),
                                    BgpSession = bgpSession,
                                    BandwidthInMbps = bandwidth,
                                    PeeringDBFacilityId = peeringLocation.FacilityId
                                });
                            bgpSession = new PSBgpSession
                            {
                                MaxPrefixesAdvertisedV4 = bgpSession.MaxPrefixesAdvertisedV4 ?? 20000,
                                MaxPrefixesAdvertisedV6 = bgpSession.MaxPrefixesAdvertisedV6 ?? 2000
                            };
                        }
                        else
                        {
                            prevLocation = peeringLocation;
                            peeringConfiguration.Direct.Connections = new List<PSDirectConnection>();
                            if (bgpSession == null) {
                                peeringConfiguration.Direct.Connections.Add(new PSDirectConnection
                                {
                                    PeeringDBFacilityId = peeringLocation.FacilityId,
                                    ConnectionIdentifier = Guid.NewGuid().ToString(),
                                    BgpSession = bgpSession,
                                    BandwidthInMbps = bandwidth
                                });
                            }
                            else
                            {
                                peeringConfiguration.Direct.Connections.Add(new PSDirectConnection
                                {
                                    PeeringDBFacilityId = peeringLocation.FacilityId,
                                    ConnectionIdentifier = Guid.NewGuid().ToString(),
                                    BgpSession = new PSBgpSession
                                    {
                                        MaxPrefixesAdvertisedV4 = bgpSession.MaxPrefixesAdvertisedV4 ?? 20000,
                                        MaxPrefixesAdvertisedV6 = bgpSession.MaxPrefixesAdvertisedV6 ?? 2000,
                                        SessionPrefixV4 = bgpSession.SessionPrefixV4,
                                        SessionPrefixV6 = bgpSession.SessionPrefixV6,
                                    },
                                    BandwidthInMbps = bandwidth
                                });
                            }
                            var xPeering = new PSPeering(new PSPeeringSku(Constants.BasicDirectFree), Constants.Direct, peeringLocation.AzRegion, peeringLocation.PeeringLocationWithOutSpace, direct: new PSPeeringPropertiesDirect
                            {
                                PeerAsn = new PSSubResource(peerAsn.Name),
                                Connections = peeringConfiguration.Direct.Connections
                            }, peeringLocation: peeringLocation.PeeringLocation);
                            listPeering.Add(xPeering);
                        }
                    }
                    catch (Exception ex)
                    {
                        this.WriteVerbose(ex.Message);
                        throw new Exception(ex.Message);
                    }
                }
            }
            return new KeyValuePair<PSPeerAsn, List<PSPeering>>(peerAsn, listPeering);
        }

        public string UpdateQuickNotesForWorkItem(int workItemId, string notes)
        {
            var item = this.workItemTrackingHttpClient.GetWorkItemAsync(ProjectName, workItemId).Result;
            JsonPatchDocument document;
            try
            {
                var s = item.Fields["gnsedge.quick_notes"].ToString();
                s += notes;
                document = new JsonPatchDocument
                               {
                                   new JsonPatchOperation
                                       {
                                           Operation = Microsoft.VisualStudio.Services.WebApi.Patch.Operation.Replace,
                                           Path = "/fields/gnsedge.quick_notes",
                                           Value = s
                                       }
                               };
            }
            catch
            {
                this.WriteVerbose($"Quick Notes were null, creating quicknotes from scratch.");
                document = new JsonPatchDocument
                               {
                                   new JsonPatchOperation
                                       {
                                           Operation = Microsoft.VisualStudio.Services.WebApi.Patch.Operation.Add,
                                           Path = "/fields/gnsedge.quick_notes",
                                           Value = notes
                                       }
                               };
            }

            var result = this.workItemTrackingHttpClient.UpdateWorkItemAsync(document, ProjectName, workItemId).Result;
            this.WriteVerbose(string.Format("Updated Ticket {0} {1}", workItemId, notes));
            if (result.Fields["System.State"].ToString() == "Resolved")
            {
                this.WriteVerbose(string.Format("Resolved Ticket {0} {1}", workItemId, notes));
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
