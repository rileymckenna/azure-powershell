using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Microsoft.Azure.Commands.Peering.Common
{
    public static class StaticFile
    {

        public static string GetDeviceMap()
        {
            return @"[
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Equinix Ashburn',
                        'bandwidthInMbps': 100000,
                        'microsoftIPv4Address': '206.126.236.17',
                        'microsoftIPv6Address': '2001:504:0:2::8075:1',
                        'facilityIPv4Prefix': '206.126.236.0/22',
                        'facilityIPv6Prefix': '2001:504:0:2::/64',
                        'ipAddressToDeviceMap': {
                            '206.126.236.17': 'ash-96cbe-1a',
                            '2001:504:0:2::8075:1': 'ash-96cbe-1a',
                            '206.126.236.148': 'ash-96cbe-1b',
                            '2001:504:0:2::8075:2': 'ash-96cbe-1b'
                        },
                        'peeringDBFacilityId': 1,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1'
                    },
                    {
                        'exchangeName': 'MegaIX Ashburn',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.53.170.12',
                        'microsoftIPv6Address': '2606:a980:0:3::c',
                        'facilityIPv4Prefix': '206.53.170.0/24',
                        'facilityIPv6Prefix': '2606:a980:0:3::/64',
                        'ipAddressToDeviceMap': {
                            '206.53.170.12': 'ash-96cbe-1b',
                            '2606:a980:0:3::c': 'ash-96cbe-1b'
                        },
                        'peeringDBFacilityId': 1178,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1178'
                    }
                ]
            },
            'peeringLocation': 'Ashburn',
            'country': 'US',
            'azureRegion': 'East US'
        },
        'name': 'Ashburn',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Equinix Palo Alto',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '198.32.176.152',
                        'microsoftIPv6Address': '2001:504:d::98',
                        'facilityIPv4Prefix': '198.32.176.0/24',
                        'facilityIPv6Prefix': '2001:504:d::/64',
                        'ipAddressToDeviceMap': {
                            '198.32.176.152': 'pao-96cbe-1b',
                            '2001:504:d::98': 'pao-96cbe-1b'
                        },
                        'peeringDBFacilityId': 7,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/7'
                    }
                ]
            },
            'peeringLocation': 'Palo Alto',
            'country': 'US',
            'azureRegion': 'West US'
        },
        'name': 'Palo Alto',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Equinix San Jose',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.223.116.17',
                        'microsoftIPv6Address': '2001:504:0:1::8075:1',
                        'facilityIPv4Prefix': '206.223.116.0/23',
                        'facilityIPv6Prefix': '2001:504:0:1::/64',
                        'ipAddressToDeviceMap': {
                            '206.223.116.17': 'sjc-96cbe-1a',
                            '2001:504:0:1::8075:1': 'sjc-96cbe-1a'
                        },
                        'peeringDBFacilityId': 5,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/5'
                    },
                    {
                        'exchangeName': 'AMS-IX BA',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.41.106.72',
                        'microsoftIPv6Address': '2001:504:3d:1:0:a500:8075:1',
                        'facilityIPv4Prefix': '206.41.106.0/24',
                        'facilityIPv6Prefix': '2001:504:3d:1::/64',
                        'ipAddressToDeviceMap': {
                            '206.41.106.72': 'sjc-96cbe-1b',
                            '2001:504:3d:1:0:a500:8075:1': 'sjc-96cbe-1b'
                        },
                        'peeringDBFacilityId': 935,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/935'
                    }
                ]
            },
            'peeringLocation': 'San Jose',
            'country': 'US',
            'azureRegion': 'West US'
        },
        'name': 'San Jose',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Equinix Chicago',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '208.115.136.27,206.223.119.27,208.115.137.61',
                        'microsoftIPv6Address': '2001:504:0:4::8075:1,2001:504:0:4::8075:2',
                        'facilityIPv4Prefix': '208.115.136.0/23,206.223.119.0/24',
                        'facilityIPv6Prefix': '2001:504:0:4::/64',
                        'ipAddressToDeviceMap': {
                            '208.115.136.27': 'chg-96e-2',
                            '2001:504:0:4::8075:1': 'chg-96e-2',
                            '208.115.137.61': 'chg-96e-1',
                            '2001:504:0:4::8075:2': 'chg-96e-1'
                        },
                        'peeringDBFacilityId': 2,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/2'
                    },
                    {
                        'exchangeName': 'AMS-IX Chicago',
                        'bandwidthInMbps': 20000,
                        'microsoftIPv4Address': '206.108.115.47',
                        'microsoftIPv6Address': '2001:504:38:1:0:a500:8075:1',
                        'facilityIPv4Prefix': '206.108.115.0/24',
                        'facilityIPv6Prefix': '2001:504:38:1::/64',
                        'ipAddressToDeviceMap': {
                            '206.108.115.47': 'chg-96e-2',
                            '2001:504:38:1:0:a500:8075:1': 'chg-96e-2'
                        },
                        'peeringDBFacilityId': 944,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/944'
                    }
                ]
            },
            'peeringLocation': 'Chicago',
            'country': 'US',
            'azureRegion': 'North Central US'
        },
        'name': 'Chicago',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Equinix Los Angeles',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.223.123.17',
                        'microsoftIPv6Address': '2001:504:0:3::8075:1',
                        'facilityIPv4Prefix': '206.223.123.0/24',
                        'facilityIPv6Prefix': '2001:504:0:3::/64',
                        'ipAddressToDeviceMap': {
                            '206.223.123.17': 'lax-96cbe-1a',
                            '2001:504:0:3::8075:1': 'lax-96cbe-1a'
                        },
                        'peeringDBFacilityId': 4,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/4'
                    },
                    {
                        'exchangeName': 'MegaIX Los Angeles',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.53.172.12',
                        'microsoftIPv6Address': '2606:a980:0:5::c',
                        'facilityIPv4Prefix': '206.53.172.0/24',
                        'facilityIPv6Prefix': '2606:a980:0:5::/64',
                        'ipAddressToDeviceMap': {
                            '206.53.172.12': 'lax-96cbe-1b',
                            '2606:a980:0:5::c': 'lax-96cbe-1b'
                        },
                        'peeringDBFacilityId': 1175,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1175'
                    },
                    {
                        'exchangeName': 'CoreSite - Any2 California',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.72.210.143',
                        'microsoftIPv6Address': '2001:504:13::210:143',
                        'facilityIPv4Prefix': '206.72.210.0/23',
                        'facilityIPv6Prefix': '2001:504:13::/64',
                        'ipAddressToDeviceMap': {
                            '206.72.210.143': 'lax-96cbe-1b',
                            '2001:504:13::210:143': 'lax-96cbe-1b'
                        },
                        'peeringDBFacilityId': 142,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/142'
                    }
                ]
            },
            'peeringLocation': 'Los Angeles',
            'country': 'US',
            'azureRegion': 'West US'
        },
        'name': 'Los Angeles',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Equinix Atlanta',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '198.32.182.33,198.32.182.102',
                        'microsoftIPv6Address': '2001:504:10::8075:1,2001:504:10::8075:2',
                        'facilityIPv4Prefix': '198.32.182.0/24',
                        'facilityIPv6Prefix': '2001:504:10::/64',
                        'ipAddressToDeviceMap': {
                            '198.32.182.102': 'ata-96e-1',
                            '2001:504:10::8075:2': 'ata-96e-1',
                            '198.32.182.33': 'ata-96e-2',
                            '2001:504:10::8075:1': 'ata-96e-2'
                        },
                        'peeringDBFacilityId': 9,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/9'
                    },
                    {
                        'exchangeName': 'Digital Realty Atlanta',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '198.32.132.117',
                        'microsoftIPv6Address': '2001:478:132::117',
                        'facilityIPv4Prefix': '198.32.132.0/24',
                        'facilityIPv6Prefix': '2001:478:132::/64',
                        'ipAddressToDeviceMap': {
                            '198.32.132.117': 'ata-96e-1',
                            '2001:478:132::117': 'ata-96e-1'
                        },
                        'peeringDBFacilityId': 22,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/22'
                    }
                ]
            },
            'peeringLocation': 'Atlanta',
            'country': 'US',
            'azureRegion': 'East US 2'
        },
        'name': 'Atlanta',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Equinix Miami (formerly NOTA)',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '198.32.124.188,198.32.124.189',
                        'microsoftIPv6Address': '2001:478:124::188,2001:478:124::189',
                        'facilityIPv4Prefix': '198.32.124.0/23',
                        'facilityIPv6Prefix': '2001:478:124::/64',
                        'ipAddressToDeviceMap': {
                            '198.32.124.188': 'mia-96cbe-1a',
                            '2001:478:124::188': 'mia-96cbe-1a',
                            '198.32.124.189': 'mia-96cbe-1b',
                            '2001:478:124::189': 'mia-96cbe-1b'
                        },
                        'peeringDBFacilityId': 17,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/17'
                    },
                    {
                        'exchangeName': 'FL-IX',
                        'bandwidthInMbps': 100000,
                        'microsoftIPv4Address': '206.41.108.25',
                        'microsoftIPv6Address': '2001:504:40:108::1:25',
                        'facilityIPv4Prefix': '206.41.108.0/24',
                        'facilityIPv6Prefix': '2001:504:40:108::/64',
                        'ipAddressToDeviceMap': {
                            '206.41.108.25': 'mia-96cbe-1b',
                            '2001:504:40:108::1:25': 'mia-96cbe-1b'
                        },
                        'peeringDBFacilityId': 954,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/954'
                    }
                ]
            },
            'peeringLocation': 'Miami',
            'country': 'US',
            'azureRegion': 'East US 2'
        },
        'name': 'Miami',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'LINX LON1',
                        'bandwidthInMbps': 300000,
                        'microsoftIPv4Address': '195.66.224.140',
                        'microsoftIPv6Address': '2001:7f8:4::1f8b:1',
                        'facilityIPv4Prefix': '195.66.224.0/22',
                        'facilityIPv6Prefix': '2001:7f8:4::/64',
                        'ipAddressToDeviceMap': {
                            '195.66.224.140': 'lts-96cbe-1b',
                            '2001:7f8:4::1f8b:1': 'lts-96cbe-1b'
                        },
                        'peeringDBFacilityId': 18,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/18'
                    },
                    {
                        'exchangeName': 'LINX LON2',
                        'bandwidthInMbps': 200000,
                        'microsoftIPv4Address': '195.66.236.140',
                        'microsoftIPv6Address': '2001:7f8:4:1::1f8b:1',
                        'facilityIPv4Prefix': '195.66.236.0/22',
                        'facilityIPv6Prefix': '2001:7f8:4:1::/64',
                        'ipAddressToDeviceMap': {
                            '195.66.236.140': 'lon04-96cbe-1b',
                            '2001:7f8:4:1::1f8b:1': 'lon04-96cbe-1b'
                        },
                        'peeringDBFacilityId': 321,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/321'
                    },
                    {
                        'exchangeName': 'LONAP',
                        'bandwidthInMbps': 100000,
                        'microsoftIPv4Address': '5.57.81.17',
                        'microsoftIPv6Address': '2001:7f8:17::1f8b:1',
                        'facilityIPv4Prefix': '5.57.80.0/22',
                        'facilityIPv6Prefix': '2001:7f8:17::/64',
                        'ipAddressToDeviceMap': {
                            '5.57.81.17': 'lon04-96cbe-1b',
                            '2001:7f8:17::1f8b:1': 'lon04-96cbe-1b'
                        },
                        'peeringDBFacilityId': 53,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/53'
                    },
                    {
                        'exchangeName': 'Equinix London',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '185.1.104.57',
                        'microsoftIPv6Address': '2001:7f8:be::8075:1',
                        'facilityIPv4Prefix': '185.1.104.0/24',
                        'facilityIPv6Prefix': '2001:7f8:be::/64',
                        'ipAddressToDeviceMap': {
                            '185.1.104.57': 'lon04-96cbe-1a',
                            '2001:7f8:be::8075:1': 'lon04-96cbe-1a'
                        },
                        'peeringDBFacilityId': 1997,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1997'
                    }
                ]
            },
            'peeringLocation': 'London',
            'country': 'GB',
            'azureRegion': 'UK South'
        },
        'name': 'London',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Equinix New York',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '198.32.118.18',
                        'microsoftIPv6Address': '2001:504:f::12',
                        'facilityIPv4Prefix': '198.32.118.0/24',
                        'facilityIPv6Prefix': '2001:504:f::/64',
                        'ipAddressToDeviceMap': {
                            '198.32.118.18': 'nyc-96cbe-1a',
                            '2001:504:f::12': 'nyc-96cbe-1a'
                        },
                        'peeringDBFacilityId': 12,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/12'
                    },
                    {
                        'exchangeName': 'NYIIX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '198.32.160.199',
                        'microsoftIPv6Address': '2001:504:1::a500:8075:1',
                        'facilityIPv4Prefix': '198.32.160.0/24',
                        'facilityIPv6Prefix': '2001:504:1::/64',
                        'ipAddressToDeviceMap': {
                            '198.32.160.199': 'nyc-96cbe-1a',
                            '2001:504:1::a500:8075:1': 'nyc-96cbe-1a'
                        },
                        'peeringDBFacilityId': 14,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/14'
                    },
                    {
                        'exchangeName': 'DE-CIX New York',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.82.104.133,206.130.10.133',
                        'microsoftIPv6Address': '2001:504:36::1f8b:0:1',
                        'facilityIPv4Prefix': '206.82.104.0/22,206.130.10.0/24',
                        'facilityIPv6Prefix': '2001:504:36::/64',
                        'ipAddressToDeviceMap': {
                            '206.82.104.133': 'nyc-96cbe-1b',
                            '2001:504:36::1f8b:0:1': 'nyc-96cbe-1b'
                        },
                        'peeringDBFacilityId': 804,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/804'
                    },
                    {
                        'exchangeName': 'Digital Realty New York',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.126.115.23',
                        'microsoftIPv6Address': '2001:504:17:115::23',
                        'facilityIPv4Prefix': '206.126.115.0/24',
                        'facilityIPv6Prefix': '2001:504:17:115::/64',
                        'ipAddressToDeviceMap': {
                            '206.126.115.23': 'nyc-96cbe-1b',
                            '2001:504:17:115::23': 'nyc-96cbe-1b'
                        },
                        'peeringDBFacilityId': 325,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/325'
                    }
                ]
            },
            'peeringLocation': 'New York',
            'country': 'US',
            'azureRegion': 'East US'
        },
        'name': 'New York',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'France-IX Paris',
                        'bandwidthInMbps': 100000,
                        'microsoftIPv4Address': '37.49.236.5,37.49.237.119',
                        'microsoftIPv6Address': '2001:7f8:54::5,2001:7f8:54::1:119',
                        'facilityIPv4Prefix': '37.49.236.0/22',
                        'facilityIPv6Prefix': '2001:7f8:54::/64',
                        'ipAddressToDeviceMap': {
                            '37.49.237.119': 'par02-96cbe-1b',
                            '2001:7f8:54::1:119': 'par02-96cbe-1b',
                            '37.49.236.5': 'pra-96cbe-1b',
                            '2001:7f8:54::5': 'pra-96cbe-1b'
                        },
                        'peeringDBFacilityId': 359,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/359'
                    },
                    {
                        'exchangeName': 'Equinix Paris',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '195.42.145.28',
                        'microsoftIPv6Address': '2001:7f8:43::8075:1',
                        'facilityIPv4Prefix': '195.42.144.0/23',
                        'facilityIPv6Prefix': '2001:7f8:43::/64',
                        'ipAddressToDeviceMap': {
                            '195.42.145.28': 'par02-96cbe-1a',
                            '2001:7f8:43::8075:1': 'par02-96cbe-1a'
                        },
                        'peeringDBFacilityId': 255,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/255'
                    }
                ]
            },
            'peeringLocation': 'Paris',
            'country': 'FR',
            'azureRegion': 'France Central'
        },
        'name': 'Paris',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'DE-CIX Frankfurt',
                        'bandwidthInMbps': 100000,
                        'microsoftIPv4Address': '80.81.194.52,80.81.195.11',
                        'microsoftIPv6Address': '2001:7f8::1f8b:0:1,2001:7f8::1f8b:0:2',
                        'facilityIPv4Prefix': '80.81.192.0/21',
                        'facilityIPv6Prefix': '2001:7f8::/64',
                        'ipAddressToDeviceMap': {
                            '80.81.194.52': 'fra-96cbe-1a',
                            '2001:7f8::1f8b:0:1': 'fra-96cbe-1a',
                            '80.81.195.11': 'fra-96cbe-1b',
                            '2001:7f8::1f8b:0:2': 'fra-96cbe-1b'
                        },
                        'peeringDBFacilityId': 31,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/31'
                    },
                    {
                        'exchangeName': 'ECIX-FRA',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '62.69.146.70',
                        'microsoftIPv6Address': '2001:7f8:8:20:0:1f8b:0:1',
                        'facilityIPv4Prefix': '62.69.146.0/23',
                        'facilityIPv6Prefix': '2001:7f8:8:20::/64',
                        'ipAddressToDeviceMap': {
                            '62.69.146.70': 'fra-96cbe-1b',
                            '2001:7f8:8:20:0:1f8b:0:1': 'fra-96cbe-1b'
                        },
                        'peeringDBFacilityId': 676,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/676'
                    },
                    {
                        'exchangeName': 'NL-IX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '193.239.118.163',
                        'microsoftIPv6Address': '2001:7f8:13::a500:8075:2',
                        'facilityIPv4Prefix': '193.239.116.0/22',
                        'facilityIPv6Prefix': '2001:7f8:13::/64',
                        'ipAddressToDeviceMap': {
                            '193.239.118.163': 'fra-96cbe-1a',
                            '2001:7f8:13::a500:8075:2': 'fra-96cbe-1a'
                        },
                        'peeringDBFacilityId': 64,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/64'
                    }
                ]
            },
            'peeringLocation': 'Frankfurt',
            'country': 'DE',
            'azureRegion': 'West Europe'
        },
        'name': 'Frankfurt',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'NL-ix',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '193.239.117.16',
                        'microsoftIPv6Address': '2001:7f8:13::a500:8075:1',
                        'facilityIPv4Prefix': '193.239.116.0/22',
                        'facilityIPv6Prefix': '2001:7f8:13::/64',
                        'ipAddressToDeviceMap': {
                            '193.239.117.16': 'amb-96cbe-1a',
                            '2001:7f8:13::a500:8075:1': 'amb-96cbe-1a'
                        },
                        'peeringDBFacilityId': 64,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/64'
                    },
                    {
                        'exchangeName': 'AMS-IX',
                        'bandwidthInMbps': 200000,
                        'microsoftIPv4Address': '80.249.209.21,80.249.209.20',
                        'microsoftIPv6Address': '2001:7f8:1::a500:8075:2,2001:7f8:1::a500:8075:1',
                        'facilityIPv4Prefix': '80.249.208.0/21',
                        'facilityIPv6Prefix': '2001:7f8:1::/64',
                        'ipAddressToDeviceMap': {
                            '80.249.209.21': 'amb-96cbe-1b',
                            '2001:7f8:1::a500:8075:2': 'amb-96cbe-1b',
                            '80.249.209.20': 'ams-96c-1b',
                            '2001:7f8:1::a500:8075:1': 'ams-96c-1b'
                        },
                        'peeringDBFacilityId': 26,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/26'
                    },
                    {
                        'exchangeName': 'Equinix Amsterdam',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '185.1.112.37',
                        'microsoftIPv6Address': '2001:7f8:83::8075:1',
                        'facilityIPv4Prefix': '185.1.112.0/24',
                        'facilityIPv6Prefix': '2001:7f8:83::/64',
                        'ipAddressToDeviceMap': {},
                        'peeringDBFacilityId': 2031,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/2031'
                    }
                ]
            },
            'peeringLocation': 'Amsterdam',
            'country': 'NL',
            'azureRegion': 'West Europe'
        },
        'name': 'Amsterdam',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'VIX',
                        'bandwidthInMbps': 100000,
                        'microsoftIPv4Address': '193.203.0.165',
                        'microsoftIPv6Address': '2001:7f8:30:0:2:1:0:8075',
                        'facilityIPv4Prefix': '193.203.0.0/23',
                        'facilityIPv6Prefix': '2001:7f8:30::/64',
                        'ipAddressToDeviceMap': {
                            '193.203.0.165': 'vie-96cbe-1b',
                            '2001:7f8:30:0:2:1:0:8075': 'vie-96cbe-1b'
                        },
                        'peeringDBFacilityId': 50,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/50'
                    }
                ]
            },
            'peeringLocation': 'Vienna',
            'country': 'AT',
            'azureRegion': 'West Europe'
        },
        'name': 'Vienna',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'BNIX',
                        'bandwidthInMbps': 20000,
                        'microsoftIPv4Address': '194.53.172.34',
                        'microsoftIPv6Address': '2001:7f8:26::a500:8075:1',
                        'facilityIPv4Prefix': '194.53.172.0/25',
                        'facilityIPv6Prefix': '2001:7f8:26::/64',
                        'ipAddressToDeviceMap': {
                            '194.53.172.34': 'bru30-96cbe-1a',
                            '2001:7f8:26::a500:8075:1': 'bru30-96cbe-1a'
                        },
                        'peeringDBFacilityId': 59,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/59'
                    }
                ]
            },
            'peeringLocation': 'Brussels',
            'country': 'BE',
            'azureRegion': 'France Central'
        },
        'name': 'Brussels',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Equinix Dallas',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.223.118.17,206.223.118.65',
                        'microsoftIPv6Address': '2001:504:0:5::8075:1,2001:504:0:5::8075:2',
                        'facilityIPv4Prefix': '206.223.118.0/24',
                        'facilityIPv6Prefix': '2001:504:0:5::/64',
                        'ipAddressToDeviceMap': {
                            '206.223.118.17': 'dal-96cbe-1a',
                            '2001:504:0:5::8075:1': 'dal-96cbe-1a',
                            '206.223.118.65': 'dal-96cbe-1b',
                            '2001:504:0:5::8075:2': 'dal-96cbe-1b'
                        },
                        'peeringDBFacilityId': 3,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/3'
                    },
                    {
                        'exchangeName': 'MegaIX Dallas',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.53.174.12',
                        'microsoftIPv6Address': '2606:a980:0:7::c',
                        'facilityIPv4Prefix': '206.53.174.0/24',
                        'facilityIPv6Prefix': '2606:a980:0:7::/64',
                        'ipAddressToDeviceMap': {
                            '206.53.174.12': 'dal-96cbe-1b',
                            '2606:a980:0:7::c': 'dal-96cbe-1b'
                        },
                        'peeringDBFacilityId': 1180,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1180'
                    },
                    {
                        'exchangeName': 'CyrusOne IX Dallas',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '198.32.130.39,198.32.130.40',
                        'microsoftIPv6Address': '2001:478:130::39,2001:478:130::40',
                        'facilityIPv4Prefix': '198.32.130.0/24',
                        'facilityIPv6Prefix': '2001:478:130::/64',
                        'ipAddressToDeviceMap': {},
                        'peeringDBFacilityId': 672,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/672'
                    },
                    {
                        'exchangeName': 'DE-CIX Dallas',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.53.202.15',
                        'microsoftIPv6Address': '2001:504:61::1f8b:0:1',
                        'facilityIPv4Prefix': '206.53.202.0/24',
                        'facilityIPv6Prefix': '2001:504:61::/64',
                        'ipAddressToDeviceMap': {
                            '206.53.202.15': 'dal-96cbe-1b',
                            '2001:504:61::1f8b:0:1': 'dal-96cbe-1b'
                        },
                        'peeringDBFacilityId': 1249,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1249'
                    }
                ]
            },
            'peeringLocation': 'Dallas',
            'country': 'US',
            'azureRegion': 'South Central US'
        },
        'name': 'Dallas',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Columbia IX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '10.12.97.129',
                        'microsoftIPv6Address': '',
                        'facilityIPv4Prefix': '10.12.97.128/26',
                        'facilityIPv6Prefix': '',
                        'ipAddressToDeviceMap': {
                            '10.12.97.129': 'co1-96c-1a'
                        },
                        'peeringDBFacilityId': 99999,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/99999'
                    },
                    {
                        'exchangeName': 'Equinix Seattle',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '198.32.134.152',
                        'microsoftIPv6Address': '2001:504:12::15',
                        'facilityIPv4Prefix': '198.32.134.0/24',
                        'facilityIPv6Prefix': '2001:504:12::/64',
                        'ipAddressToDeviceMap': {
                            '198.32.134.152': 'wst-96cbe-1a',
                            '2001:504:12::15': 'wst-96cbe-1a'
                        },
                        'peeringDBFacilityId': 11,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/11'
                    },
                    {
                        'exchangeName': 'SIX Seattle',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.81.80.30,206.81.80.68',
                        'microsoftIPv6Address': '2001:504:16::1f8b,2001:504:16::68:0:1f8b',
                        'facilityIPv4Prefix': '206.81.80.0/23',
                        'facilityIPv6Prefix': '2001:504:16::/64',
                        'ipAddressToDeviceMap': {
                            '206.81.80.30': 'wst-96cbe-1a',
                            '2001:504:16::1f8b': 'wst-96cbe-1a',
                            '206.81.80.68': 'wst-96cbe-1b',
                            '2001:504:16::68:0:1f8b': 'wst-96cbe-1b'
                        },
                        'peeringDBFacilityId': 13,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/13'
                    },
                    {
                        'exchangeName': 'MegaIX Seattle',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.53.171.13',
                        'microsoftIPv6Address': '2606:a980:0:4::d',
                        'facilityIPv4Prefix': '206.53.171.0/24',
                        'facilityIPv6Prefix': '2606:a980:0:4::/64',
                        'ipAddressToDeviceMap': {
                            '206.53.171.13': 'wst-96cbe-1b',
                            '2606:a980:0:4::d': 'wst-96cbe-1b'
                        },
                        'peeringDBFacilityId': 1174,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1174'
                    },
                    {
                        'exchangeName': 'PacificWave',
                        'bandwidthInMbps': 100000,
                        'microsoftIPv4Address': '207.231.240.7,207.231.241.7,207.231.242.7,207.231.243.7,207.231.245.7,207.231.248.7',
                        'microsoftIPv6Address': '2001:504:b:10::7,2001:504:b:11::7,2001:504:b:80::7,2001:504:b:81::7,2001:504:b:88::7,2001:504:b:89::7',
                        'facilityIPv4Prefix': '207.231.240.0/25,207.231.241.0/24,207.231.242.0/25,207.231.243.0/24,207.231.245.0/24,207.231.248.0/24',
                        'facilityIPv6Prefix': '2001:504:b:10::/64,2001:504:b:11::/64,2001:504:b:80::/64,2001:504:b:81::/64,2001:504:b:88::/64,2001:504:b:89::/64',
                        'ipAddressToDeviceMap': {
                            '207.231.240.7': 'wst-96cbe-1b',
                            '2001:504:b:10::7': 'wst-96cbe-1b',
                            '207.231.242.7': 'wst-96cbe-1b',
                            '2001:504:b:11::7': 'wst-96cbe-1b',
                            '207.231.241.7': 'wst-96cbe-1b',
                            '2001:504:b:80::7': 'wst-96cbe-1b',
                            '207.231.245.7': 'wst-96cbe-1b',
                            '2001:504:b:88::7': 'wst-96cbe-1b',
                            '207.231.248.7': 'wst-96cbe-1b',
                            '2001:504:b:89::7': 'wst-96cbe-1b'
                        },
                        'peeringDBFacilityId': 82,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/82'
                    }
                ]
            },
            'peeringLocation': 'Seattle',
            'country': 'US',
            'azureRegion': 'West US 2'
        },
        'name': 'Seattle',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'LINX Manchester',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '195.66.244.82,195.66.244.116',
                        'microsoftIPv6Address': '2001:7f8:4:2::1f8b:1,2001:7f8:4:2::1f8b:2',
                        'facilityIPv4Prefix': '195.66.244.0/24',
                        'facilityIPv6Prefix': '2001:7f8:4:2::/64',
                        'ipAddressToDeviceMap': {
                            '195.66.244.82': 'man30-96cbe-1a',
                            '2001:7f8:4:2::1f8b:1': 'man30-96cbe-1a',
                            '195.66.244.116': 'man30-96cbe-1b',
                            '2001:7f8:4:2::1f8b:2': 'man30-96cbe-1b'
                        },
                        'peeringDBFacilityId': 583,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/583'
                    },
                    {
                        'exchangeName': 'Equinix Manchester',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '185.1.101.31',
                        'microsoftIPv6Address': '2001:7f8:bc::8075:1',
                        'facilityIPv4Prefix': '185.1.101.0/24',
                        'facilityIPv6Prefix': '2001:7f8:bc::/64',
                        'ipAddressToDeviceMap': {},
                        'peeringDBFacilityId': 1927,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1927'
                    }
                ]
            },
            'peeringLocation': 'Manchester',
            'country': 'GB',
            'azureRegion': 'UK West'
        },
        'name': 'Manchester',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Equinix Zurich',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '194.42.48.50',
                        'microsoftIPv6Address': '2001:7f8:c:8235:194:42:48:50',
                        'facilityIPv4Prefix': '194.42.48.0/25',
                        'facilityIPv6Prefix': '2001:7f8:c:8235:194:42:48:0/112',
                        'ipAddressToDeviceMap': {},
                        'peeringDBFacilityId': 29,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/29'
                    },
                    {
                        'exchangeName': 'SwissIX',
                        'bandwidthInMbps': 100000,
                        'microsoftIPv4Address': '91.206.52.152',
                        'microsoftIPv6Address': '2001:7f8:24::98',
                        'facilityIPv4Prefix': '91.206.52.0/23',
                        'facilityIPv6Prefix': '2001:7f8:24::/64',
                        'ipAddressToDeviceMap': {
                            '91.206.52.152': 'zrh-96cbe-1a',
                            '2001:7f8:24::98': 'zrh-96cbe-1a'
                        },
                        'peeringDBFacilityId': 60,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/60'
                    }
                ]
            },
            'peeringLocation': 'Zurich',
            'country': 'CH',
            'azureRegion': 'France Central'
        },
        'name': 'Zurich',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'CATNIX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '193.242.98.152',
                        'microsoftIPv6Address': '2001:7f8:2a:0:2:1:0:8075',
                        'facilityIPv4Prefix': '193.242.98.0/24',
                        'facilityIPv6Prefix': '2001:7f8:2a::/64',
                        'ipAddressToDeviceMap': {
                            '193.242.98.152': 'bcn30-96cbe-1a',
                            '2001:7f8:2a:0:2:1:0:8075': 'bcn30-96cbe-1a'
                        },
                        'peeringDBFacilityId': 62,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/62'
                    }
                ]
            },
            'peeringLocation': 'Barcelona',
            'country': 'ES',
            'azureRegion': 'France Central'
        },
        'name': 'Barcelona',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'GigaPIX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '193.136.250.60',
                        'microsoftIPv6Address': '2001:7f8:a:1::6',
                        'facilityIPv4Prefix': '193.136.250.0/24',
                        'facilityIPv6Prefix': '2001:7f8:a:1::/64',
                        'ipAddressToDeviceMap': {
                            '193.136.250.60': 'lis01-96cbe-1a',
                            '2001:7f8:a:1::6': 'lis01-96cbe-1a'
                        },
                        'peeringDBFacilityId': 72,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/72'
                    }
                ]
            },
            'peeringLocation': 'Lisbon',
            'country': 'PT',
            'azureRegion': 'France Central'
        },
        'name': 'Lisbon',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'ESPANIX Madrid Lower LAN',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '193.149.1.29',
                        'microsoftIPv6Address': '2001:7f8:f::70',
                        'facilityIPv4Prefix': '193.149.1.0/24',
                        'facilityIPv6Prefix': '2001:7f8:f::/64',
                        'ipAddressToDeviceMap': {
                            '193.149.1.29': 'mad30-96cbe-1a',
                            '2001:7f8:f::70': 'mad30-96cbe-1a'
                        },
                        'peeringDBFacilityId': 63,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/63'
                    },
                    {
                        'exchangeName': 'ESPANIX Madrid Upper LAN',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '185.79.175.184',
                        'microsoftIPv6Address': '2001:7f8:f:1::70',
                        'facilityIPv4Prefix': '185.79.175.0/24',
                        'facilityIPv6Prefix': '2001:7f8:f:1::/64',
                        'ipAddressToDeviceMap': {
                            '185.79.175.184': 'mad30-96cbe-1b',
                            '2001:7f8:f:1::70': 'mad30-96cbe-1b'
                        },
                        'peeringDBFacilityId': 1146,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1146'
                    },
                    {
                        'exchangeName': 'DE-CIX Madrid',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '185.1.68.16',
                        'microsoftIPv6Address': '2001:7f8:a0::1f8b:0:1',
                        'facilityIPv4Prefix': '185.1.68.0/24',
                        'facilityIPv6Prefix': '2001:7f8:a0::/64',
                        'ipAddressToDeviceMap': {
                            '185.1.68.16': 'mad30-96cbe-1b',
                            '2001:7f8:a0::1f8b:0:1': 'mad30-96cbe-1b'
                        },
                        'peeringDBFacilityId': 1277,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1277'
                    }
                ]
            },
            'peeringLocation': 'Madrid',
            'country': 'ES',
            'azureRegion': 'France Central'
        },
        'name': 'Madrid',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Equinix Sydney',
                        'bandwidthInMbps': 100000,
                        'microsoftIPv4Address': '45.127.172.36',
                        'microsoftIPv6Address': '2001:de8:6::1:2076:1',
                        'facilityIPv4Prefix': '45.127.172.0/22',
                        'facilityIPv6Prefix': '2001:de8:6::/64',
                        'ipAddressToDeviceMap': {
                            '45.127.172.36': 'syd-96cbe-1a',
                            '2001:de8:6::1:2076:1': 'syd-96cbe-1a'
                        },
                        'peeringDBFacilityId': 94,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/94'
                    },
                    {
                        'exchangeName': 'MegaIX Sydney',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '103.26.68.7',
                        'microsoftIPv6Address': '2001:dea:0:10::7',
                        'facilityIPv4Prefix': '103.26.68.0/23',
                        'facilityIPv6Prefix': '2001:dea:0:10::/64',
                        'ipAddressToDeviceMap': {
                            '103.26.68.7': 'syd-96cbe-1b',
                            '2001:dea:0:10::7': 'syd-96cbe-1b'
                        },
                        'peeringDBFacilityId': 780,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/780'
                    },
                    {
                        'exchangeName': 'New South Wales Internet Exchange',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '218.100.52.4',
                        'microsoftIPv6Address': '2001:7fa:11:4:0:2f2c:0:1',
                        'facilityIPv4Prefix': '218.100.52.0/23',
                        'facilityIPv6Prefix': '2001:7fa:11:4::/64',
                        'ipAddressToDeviceMap': {
                            '218.100.52.4': 'syd-96cbe-1b',
                            '2001:7fa:11:4:0:2f2c:0:1': 'syd-96cbe-1b'
                        },
                        'peeringDBFacilityId': 716,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/716'
                    },
                    {
                        'exchangeName': 'PIPE Networks Sydney',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '218.100.2.162',
                        'microsoftIPv6Address': '2001:7fa:b::162',
                        'facilityIPv4Prefix': '218.100.2.0/24',
                        'facilityIPv6Prefix': '2001:7fa:b::/64',
                        'ipAddressToDeviceMap': {
                            '218.100.2.162': 'syd-96cbe-1a',
                            '2001:7fa:b::162': 'syd-96cbe-1a'
                        },
                        'peeringDBFacilityId': 105,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/105'
                    }
                ]
            },
            'peeringLocation': 'Sydney',
            'country': 'AU',
            'azureRegion': 'Australia East'
        },
        'name': 'Sydney',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Equinix Tokyo',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '203.190.230.24',
                        'microsoftIPv6Address': '2001:de8:5::8075:1',
                        'facilityIPv4Prefix': '203.190.230.0/24',
                        'facilityIPv6Prefix': '2001:de8:5::/64',
                        'ipAddressToDeviceMap': {
                            '203.190.230.24': 'tyb-96cbe-1b',
                            '2001:de8:5::8075:1': 'tyb-96cbe-1b'
                        },
                        'peeringDBFacilityId': 167,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/167'
                    },
                    {
                        'exchangeName': 'JPIX TOKYO',
                        'bandwidthInMbps': 100000,
                        'microsoftIPv4Address': '210.171.224.116,210.171.224.110',
                        'microsoftIPv6Address': '2001:de8:8::8075:2,2001:de8:8::8075:1',
                        'facilityIPv4Prefix': '210.171.224.0/23',
                        'facilityIPv6Prefix': '2001:de8:8::/64',
                        'ipAddressToDeviceMap': {
                            '210.171.224.116': 'tya-96cbe-1a',
                            '2001:de8:8::8075:2': 'tya-96cbe-1a',
                            '210.171.224.110': 'tyb-96cbe-1a',
                            '2001:de8:8::8075:1': 'tyb-96cbe-1a'
                        },
                        'peeringDBFacilityId': 30,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/30'
                    },
                    {
                        'exchangeName': 'BBIX Tokyo',
                        'bandwidthInMbps': 100000,
                        'microsoftIPv4Address': '218.100.6.76',
                        'microsoftIPv6Address': '2001:de8:c::8075:1',
                        'facilityIPv4Prefix': '218.100.6.0/23',
                        'facilityIPv6Prefix': '2001:de8:c::/64',
                        'ipAddressToDeviceMap': {
                            '218.100.6.76': 'tyb-96cbe-1b',
                            '2001:de8:c::8075:1': 'tyb-96cbe-1b'
                        },
                        'peeringDBFacilityId': 126,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/126'
                    },
                    {
                        'exchangeName': 'JPNAP Tokyo',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '210.173.176.16',
                        'microsoftIPv6Address': '2001:7fa:7:1::8075:1',
                        'facilityIPv4Prefix': '210.173.176.0/24',
                        'facilityIPv6Prefix': '2001:7fa:7:1::/64',
                        'ipAddressToDeviceMap': {
                            '210.173.176.16': 'tyb-96cbe-1a',
                            '2001:7fa:7:1::8075:1': 'tyb-96cbe-1a'
                        },
                        'peeringDBFacilityId': 95,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/95'
                    }
                ]
            },
            'peeringLocation': 'Tokyo',
            'country': 'JP',
            'azureRegion': 'Japan East'
        },
        'name': 'Tokyo',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'KINX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '192.145.251.47,192.145.251.48',
                        'microsoftIPv6Address': '2001:7fa:8::13,2001:7fa:8::14',
                        'facilityIPv4Prefix': '192.145.251.0/24',
                        'facilityIPv6Prefix': '2001:7fa:8::/64',
                        'ipAddressToDeviceMap': {
                            '192.145.251.47': 'sla-96cbe-1a',
                            '2001:7fa:8::13': 'sla-96cbe-1a',
                            '192.145.251.48': 'sla-96cbe-1b',
                            '2001:7fa:8::14': 'sla-96cbe-1b'
                        },
                        'peeringDBFacilityId': 52,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/52'
                    }
                ]
            },
            'peeringLocation': 'Seoul',
            'country': 'KR',
            'azureRegion': 'Korea Central'
        },
        'name': 'Seoul',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'DIX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '192.38.7.76',
                        'microsoftIPv6Address': '2001:7f8:1f::8075:76:0',
                        'facilityIPv4Prefix': '192.38.7.0/24',
                        'facilityIPv6Prefix': '2001:7f8:1f::/64',
                        'ipAddressToDeviceMap': {
                            '192.38.7.76': 'cph30-96cbe-1a',
                            '2001:7f8:1f::8075:76:0': 'cph30-96cbe-1a'
                        },
                        'peeringDBFacilityId': 78,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/78'
                    },
                    {
                        'exchangeName': 'Netnod Copenhagen',
                        'bandwidthInMbps': 40000,
                        'microsoftIPv4Address': '212.237.192.181,212.237.193.181',
                        'microsoftIPv6Address': '2001:7f8:d:202::181,2001:7f8:d:203::181',
                        'facilityIPv4Prefix': '212.237.192.0/24,212.237.193.0/24',
                        'facilityIPv6Prefix': '2001:7f8:d:202::/64,2001:7f8:d:203::/64',
                        'ipAddressToDeviceMap': {
                            '212.237.192.181': 'cph30-96cbe-1b',
                            '2001:7f8:d:202::181': 'cph30-96cbe-1b',
                            '212.237.193.181': 'cph30-96cbe-1b',
                            '2001:7f8:d:203::181': 'cph30-96cbe-1b'
                        },
                        'peeringDBFacilityId': 193,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/193'
                    },
                    {
                        'exchangeName': 'NL-IX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '193.239.118.172',
                        'microsoftIPv6Address': '2001:7f8:13::a500:8075:4',
                        'facilityIPv4Prefix': '193.239.116.0/22',
                        'facilityIPv6Prefix': '2001:7f8:13::/64',
                        'ipAddressToDeviceMap': {
                            '193.239.118.172': 'cph30-96cbe-1a',
                            '2001:7f8:13::a500:8075:4': 'cph30-96cbe-1a'
                        },
                        'peeringDBFacilityId': 64,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/64'
                    }
                ]
            },
            'peeringLocation': 'Copenhagen',
            'country': 'DK',
            'azureRegion': 'West Europe'
        },
        'name': 'Copenhagen',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Netnod Stockholm',
                        'bandwidthInMbps': 100000,
                        'microsoftIPv4Address': '195.245.240.181,194.68.123.181,194.68.128.181,195.69.119.181',
                        'microsoftIPv6Address': '2001:7f8:d:fc::181,2001:7f8:d:fb::181,2001:7f8:d:fe::181,2001:7f8:d:ff::181',
                        'facilityIPv4Prefix': '195.245.240.0/24,194.68.123.0/24,194.68.128.0/24,195.69.119.0/24',
                        'facilityIPv6Prefix': '2001:7f8:d:fc::/64,2001:7f8:d:fb::/64,2001:7f8:d:fe::/64,2001:7f8:d:ff::/64',
                        'ipAddressToDeviceMap': {
                            '194.68.123.181': 'sto-96cbe-1a',
                            '2001:7f8:d:ff::181': 'sto-96cbe-1a',
                            '195.245.240.181': 'sto-96cbe-1a',
                            '2001:7f8:d:fc::181': 'sto-96cbe-1a',
                            '194.68.128.181': 'sto-96cbe-1b',
                            '2001:7f8:d:fe::181': 'sto-96cbe-1b',
                            '195.69.119.181': 'sto-96cbe-1b',
                            '2001:7f8:d:fb::181': 'sto-96cbe-1b'
                        },
                        'peeringDBFacilityId': 70,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/70'
                    },
                    {
                        'exchangeName': 'STHIX - Stockholm',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '192.121.80.59',
                        'microsoftIPv6Address': '2001:7f8:3e:0:a500:0:8075:1',
                        'facilityIPv4Prefix': '192.121.80.0/24',
                        'facilityIPv6Prefix': '2001:7f8:3e::/64',
                        'ipAddressToDeviceMap': {
                            '192.121.80.59': 'sto-96cbe-1a',
                            '2001:7f8:3e:0:a500:0:8075:1': 'sto-96cbe-1a'
                        },
                        'peeringDBFacilityId': 172,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/172'
                    },
                    {
                        'exchangeName': 'Equinix Stockholm',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '185.1.107.34',
                        'microsoftIPv6Address': '2001:7f8:c1::8075:1',
                        'facilityIPv4Prefix': '185.1.107.0/24',
                        'facilityIPv6Prefix': '2001:7f8:c1::/64',
                        'ipAddressToDeviceMap': {},
                        'peeringDBFacilityId': 1923,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1923'
                    }
                ]
            },
            'peeringLocation': 'Stockholm',
            'country': 'SE',
            'azureRegion': 'West Europe'
        },
        'name': 'Stockholm',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'INEX LAN1',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '185.6.36.28',
                        'microsoftIPv6Address': '2001:7f8:18::28',
                        'facilityIPv4Prefix': '185.6.36.0/23',
                        'facilityIPv6Prefix': '2001:7f8:18::/64',
                        'ipAddressToDeviceMap': {
                            '185.6.36.28': 'dub30-96cbe-1a',
                            '2001:7f8:18::28': 'dub30-96cbe-1a'
                        },
                        'peeringDBFacilityId': 48,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/48'
                    },
                    {
                        'exchangeName': 'Equinix Dublin',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '185.1.109.26',
                        'microsoftIPv6Address': '2001:7f8:c3::8075:1',
                        'facilityIPv4Prefix': '185.1.109.0/24',
                        'facilityIPv6Prefix': '2001:7f8:c3::/64',
                        'ipAddressToDeviceMap': {},
                        'peeringDBFacilityId': 1926,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1926'
                    }
                ]
            },
            'peeringLocation': 'Dublin',
            'country': 'IE',
            'azureRegion': 'North Europe'
        },
        'name': 'Dublin',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'IX.br (PTT.br) Campinas',
                        'bandwidthInMbps': 60000,
                        'microsoftIPv4Address': '200.192.108.42',
                        'microsoftIPv6Address': '2001:12f8:0:11::42',
                        'facilityIPv4Prefix': '200.192.108.0/24',
                        'facilityIPv6Prefix': '2001:12f8:0:11::/64',
                        'ipAddressToDeviceMap': {
                            '200.192.108.42': 'cpq01-96cbe-1a',
                            '2001:12f8:0:11::42': 'cpq01-96cbe-1a'
                        },
                        'peeringDBFacilityId': 415,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/415'
                    },
                    {
                        'exchangeName': 'Equinix Sao Paulo',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '198.32.122.57,198.32.122.60',
                        'microsoftIPv6Address': '2001:478:122::3c,2001:478:122::39',
                        'facilityIPv4Prefix': '198.32.122.0/24',
                        'facilityIPv6Prefix': '2001:478:122::/64',
                        'ipAddressToDeviceMap': {
                            '198.32.122.60': 'gru-96cbe-1a',
                            '2001:478:122::3c': 'gru-96cbe-1a',
                            '198.32.122.57': 'gru-96cbe-1b',
                            '2001:478:122::39': 'gru-96cbe-1b'
                        },
                        'peeringDBFacilityId': 119,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/119'
                    },
                    {
                        'exchangeName': 'IX.br (PTT.br) Sao Paulo',
                        'bandwidthInMbps': 200000,
                        'microsoftIPv4Address': '187.16.218.139,187.16.218.144',
                        'microsoftIPv6Address': '2001:12f8::218:139,2001:12f8::218:144',
                        'facilityIPv4Prefix': '187.16.216.0/21',
                        'facilityIPv6Prefix': '2001:12f8::/64',
                        'ipAddressToDeviceMap': {
                            '187.16.218.139': 'sao03-96cbe-1a',
                            '2001:12f8::218:139': 'sao03-96cbe-1a',
                            '187.16.218.144': 'sao03-96cbe-1b',
                            '2001:12f8::218:144': 'sao03-96cbe-1b'
                        },
                        'peeringDBFacilityId': 171,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/171'
                    }
                ]
            },
            'peeringLocation': 'Sao Paulo',
            'country': 'BR',
            'azureRegion': 'Brazil South'
        },
        'name': 'Sao Paulo',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Equinix Hong Kong',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '119.27.63.4,36.255.56.4',
                        'microsoftIPv6Address': '2001:de8:7::8075:1',
                        'facilityIPv4Prefix': '119.27.63.0/24,36.255.56.0/22',
                        'facilityIPv6Prefix': '2001:de8:7::/64',
                        'ipAddressToDeviceMap': {
                            '36.255.56.4': 'hkb-96cbe-1a',
                            '2001:de8:7::8075:1': 'hkb-96cbe-1a'
                        },
                        'peeringDBFacilityId': 125,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/125'
                    },
                    {
                        'exchangeName': 'AMS-IX Hong Kong',
                        'bandwidthInMbps': 20000,
                        'microsoftIPv4Address': '103.247.139.28',
                        'microsoftIPv6Address': '2001:df0:296::a500:8075:1',
                        'facilityIPv4Prefix': '103.247.139.0/25',
                        'facilityIPv6Prefix': '2001:df0:296::/64',
                        'ipAddressToDeviceMap': {
                            '103.247.139.28': 'hkg-96cbe-1a',
                            '2001:df0:296::a500:8075:1': 'hkg-96cbe-1a'
                        },
                        'peeringDBFacilityId': 577,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/577'
                    },
                    {
                        'exchangeName': 'HKIX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '123.255.91.120,123.255.90.222',
                        'microsoftIPv6Address': '2001:7fa:0:1::ca28:a178,2001:7fa:0:1::ca28:a0de',
                        'facilityIPv4Prefix': '123.255.88.0/21',
                        'facilityIPv6Prefix': '2001:7fa:0:1::/64',
                        'ipAddressToDeviceMap': {
                            '123.255.90.222': 'hkb-96cbe-1a',
                            '2001:7fa:0:1::ca28:a0de': 'hkb-96cbe-1a',
                            '123.255.91.120': 'hkb-96cbe-1b',
                            '2001:7fa:0:1::ca28:a178': 'hkb-96cbe-1b'
                        },
                        'peeringDBFacilityId': 42,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/42'
                    },
                    {
                        'exchangeName': 'BBIX Hong Kong',
                        'bandwidthInMbps': 30000,
                        'microsoftIPv4Address': '103.203.158.102',
                        'microsoftIPv6Address': '2403:c780:b800:bb00::8075:2',
                        'facilityIPv4Prefix': '103.203.158.0/23',
                        'facilityIPv6Prefix': '2403:c780:b800:bb00::/64',
                        'ipAddressToDeviceMap': {},
                        'peeringDBFacilityId': 1449,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1449'
                    }
                ]
            },
            'peeringLocation': 'Hong Kong',
            'country': 'HK',
            'azureRegion': 'East Asia'
        },
        'name': 'Hong Kong',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'NIX.CZ',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '91.210.16.115',
                        'microsoftIPv6Address': '2001:7f8:14::6b:1',
                        'facilityIPv4Prefix': '91.210.16.0/22',
                        'facilityIPv6Prefix': '2001:7f8:14::/64',
                        'ipAddressToDeviceMap': {
                            '91.210.16.115': 'prg01-96cbe-1a',
                            '2001:7f8:14::6b:1': 'prg01-96cbe-1a'
                        },
                        'peeringDBFacilityId': 71,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/71'
                    },
                    {
                        'exchangeName': 'Peering.cz',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '91.213.211.214',
                        'microsoftIPv6Address': '2001:7f8:7f::214',
                        'facilityIPv4Prefix': '91.213.211.0/24',
                        'facilityIPv6Prefix': '2001:7f8:7f::/64',
                        'ipAddressToDeviceMap': {
                            '91.213.211.214': 'prg01-96cbe-1b',
                            '2001:7f8:7f::214': 'prg01-96cbe-1b'
                        },
                        'peeringDBFacilityId': 713,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/713'
                    }
                ]
            },
            'peeringLocation': 'Prague',
            'country': 'CZ',
            'azureRegion': 'West Europe'
        },
        'name': 'Prague',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'France-IX Marseille',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '37.49.232.14',
                        'microsoftIPv6Address': '2001:7f8:54:5::14',
                        'facilityIPv4Prefix': '37.49.232.0/24',
                        'facilityIPv6Prefix': '2001:7f8:54:5::/64',
                        'ipAddressToDeviceMap': {
                            '37.49.232.14': 'mrs01-96cbe-1a',
                            '2001:7f8:54:5::14': 'mrs01-96cbe-1a'
                        },
                        'peeringDBFacilityId': 880,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/880'
                    },
                    {
                        'exchangeName': 'DE-CIX Marseille',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '185.1.47.13',
                        'microsoftIPv6Address': '2001:7f8:36::1f8b:0:1',
                        'facilityIPv4Prefix': '185.1.47.0/24',
                        'facilityIPv6Prefix': '2001:7f8:36::/64',
                        'ipAddressToDeviceMap': {
                            '185.1.47.13': 'mrs01-96cbe-1b',
                            '2001:7f8:36::1f8b:0:1': 'mrs01-96cbe-1b'
                        },
                        'peeringDBFacilityId': 1149,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1149'
                    }
                ]
            },
            'peeringLocation': 'Marseille',
            'country': 'FR',
            'azureRegion': 'France Central'
        },
        'name': 'Marseille',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'SOX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '198.32.141.141',
                        'microsoftIPv6Address': '2001:de8:d::8069:1',
                        'facilityIPv4Prefix': '198.32.141.0/24',
                        'facilityIPv6Prefix': '2001:de8:d::/64',
                        'ipAddressToDeviceMap': {
                            '198.32.141.141': 'ier02.sg1',
                            '2001:de8:d::8069:1': 'ier02.sg1'
                        },
                        'peeringDBFacilityId': 93,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/93'
                    },
                    {
                        'exchangeName': 'SGIX',
                        'bandwidthInMbps': 30000,
                        'microsoftIPv4Address': '103.16.102.23',
                        'microsoftIPv6Address': '2001:de8:12:100::23',
                        'facilityIPv4Prefix': '103.16.102.0/23',
                        'facilityIPv6Prefix': '2001:de8:12:100::/64',
                        'ipAddressToDeviceMap': {
                            '103.16.102.23': 'ier01.sg1',
                            '2001:de8:12:100::23': 'ier01.sg1'
                        },
                        'peeringDBFacilityId': 429,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/429'
                    },
                    {
                        'exchangeName': 'Equinix Singapore',
                        'bandwidthInMbps': 100000,
                        'microsoftIPv4Address': '27.111.228.57,27.111.229.172',
                        'microsoftIPv6Address': '2001:de8:4::8075:1,2001:de8:4::8075:2',
                        'facilityIPv4Prefix': '27.111.228.0/22',
                        'facilityIPv6Prefix': '2001:de8:4::/64',
                        'ipAddressToDeviceMap': {
                            '27.111.228.57': 'sge-96cbe-1a',
                            '2001:de8:4::8075:1': 'sge-96cbe-1a',
                            '27.111.229.172': 'sge-96cbe-1b',
                            '2001:de8:4::8075:2': 'sge-96cbe-1b'
                        },
                        'peeringDBFacilityId': 158,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/158'
                    },
                    {
                        'exchangeName': 'MegaIX Singapore',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '103.41.12.23',
                        'microsoftIPv6Address': '2001:ded::17',
                        'facilityIPv4Prefix': '103.41.12.0/22',
                        'facilityIPv6Prefix': '2001:ded::/48',
                        'ipAddressToDeviceMap': {
                            '103.41.12.23': 'sge-96cbe-1b',
                            '2001:ded::17': 'sge-96cbe-1b'
                        },
                        'peeringDBFacilityId': 965,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/965'
                    },
                    {
                        'exchangeName': 'BBIX Singapore',
                        'bandwidthInMbps': 30000,
                        'microsoftIPv4Address': '103.231.152.101',
                        'microsoftIPv6Address': '2001:df5:b800:bb00::8075:1',
                        'facilityIPv4Prefix': '103.231.152.0/22',
                        'facilityIPv6Prefix': '2001:df5:b800:bb00::/64',
                        'ipAddressToDeviceMap': {
                            '103.231.152.101': 'sge-96cbe-1a',
                            '2001:df5:b800:bb00::8075:1': 'sge-96cbe-1a'
                        },
                        'peeringDBFacilityId': 909,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/909'
                    }
                ]
            },
            'peeringLocation': 'Singapore',
            'country': 'SG',
            'azureRegion': 'Southeast Asia'
        },
        'name': 'Singapore',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'BiX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '193.188.137.21,193.188.137.51',
                        'microsoftIPv6Address': '2001:7f8:35::8075:1,2001:7f8:35::8075:2',
                        'facilityIPv4Prefix': '193.188.137.0/24',
                        'facilityIPv6Prefix': '2001:7f8:35::/64',
                        'ipAddressToDeviceMap': {
                            '193.188.137.21': 'bud01-96cbe-1a',
                            '2001:7f8:35::8075:1': 'bud01-96cbe-1a',
                            '193.188.137.51': 'bud01-96cbe-1b',
                            '2001:7f8:35::8075:2': 'bud01-96cbe-1b'
                        },
                        'peeringDBFacilityId': 55,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/55'
                    }
                ]
            },
            'peeringLocation': 'Budapest',
            'country': 'HU',
            'azureRegion': 'West Europe'
        },
        'name': 'Budapest',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'MSK-IX Moscow',
                        'bandwidthInMbps': 200000,
                        'microsoftIPv4Address': '195.208.208.137',
                        'microsoftIPv6Address': '2001:7f8:20:101::208:137',
                        'facilityIPv4Prefix': '195.208.208.0/21',
                        'facilityIPv6Prefix': '2001:7f8:20:101::/64',
                        'ipAddressToDeviceMap': {
                            '195.208.208.137': 'msa-96cbe-1a',
                            '2001:7f8:20:101::208:137': 'msa-96cbe-1a'
                        },
                        'peeringDBFacilityId': 100,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/100'
                    },
                    {
                        'exchangeName': 'DATAIX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '178.18.225.38',
                        'microsoftIPv6Address': '2a03:5f80:4::225:38',
                        'facilityIPv4Prefix': '178.18.224.0/22',
                        'facilityIPv6Prefix': '2a03:5f80:4::/64',
                        'ipAddressToDeviceMap': {
                            '178.18.225.38': 'msa-96cbe-1a',
                            '2a03:5f80:4::225:38': 'msa-96cbe-1a'
                        },
                        'peeringDBFacilityId': 358,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/358'
                    }
                ]
            },
            'peeringLocation': 'Moscow',
            'country': 'RU',
            'azureRegion': 'West Europe'
        },
        'name': 'Moscow',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'CoreSite - Any2 Denver ',
                        'bandwidthInMbps': 20000,
                        'microsoftIPv4Address': '206.51.46.72,206.51.46.100,198.32.216.72',
                        'microsoftIPv6Address': '2605:6c00:303:303::72,2605:6c00:303:303::100',
                        'facilityIPv4Prefix': '206.51.46.0/24,198.32.216.0/24',
                        'facilityIPv6Prefix': '2605:6c00:303:303::/64',
                        'ipAddressToDeviceMap': {
                            '206.51.46.72': 'den02-96cbe-1a',
                            '2605:6c00:303:303::72': 'den02-96cbe-1a',
                            '206.51.46.100': 'den02-96cbe-1b',
                            '2605:6c00:303:303::100': 'den02-96cbe-1b'
                        },
                        'peeringDBFacilityId': 254,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/254'
                    }
                ]
            },
            'peeringLocation': 'Denver',
            'country': 'US',
            'azureRegion': 'West Central US'
        },
        'name': 'Denver',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Balcan-IX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '80.97.248.52,80.97.248.76,86.104.125.130',
                        'microsoftIPv6Address': '2a02:d10:80::13,2a02:d10:80::32,2001:7f8:64:225::8075:1',
                        'facilityIPv4Prefix': '80.97.248.0/23,86.104.125.0/24',
                        'facilityIPv6Prefix': '2a02:d10:80::/64,2001:7f8:64:225::/64',
                        'ipAddressToDeviceMap': {
                            '86.104.125.130': 'buh01-96cbe-1a',
                            '2001:7f8:64:225::8075:1': 'buh01-96cbe-1a',
                            '80.97.248.76': 'buh01-96cbe-1a',
                            '2a02:d10:80::32': 'buh01-96cbe-1a',
                            '80.97.248.52': 'buh01-96cbe-1b',
                            '2a02:d10:80::13': 'buh01-96cbe-1b'
                        },
                        'peeringDBFacilityId': 372,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/372'
                    },
                    {
                        'exchangeName': 'RoNIX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '217.156.113.88',
                        'microsoftIPv6Address': '2001:7f8:49::88',
                        'facilityIPv4Prefix': '217.156.113.0/24',
                        'facilityIPv6Prefix': '2001:7f8:49::/64',
                        'ipAddressToDeviceMap': {
                            '217.156.113.88': 'buh01-96cbe-1b',
                            '2001:7f8:49::88': 'buh01-96cbe-1b'
                        },
                        'peeringDBFacilityId': 301,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/301'
                    }
                ]
            },
            'peeringLocation': 'Bucharest',
            'country': 'RO',
            'azureRegion': 'France Central'
        },
        'name': 'Bucharest',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'TPIX-TW',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '203.163.222.15,203.163.222.85',
                        'microsoftIPv6Address': '2406:d400:1:133:203:163:222:15,2406:d400:1:133:203:163:222:85',
                        'facilityIPv4Prefix': '203.163.222.0/24',
                        'facilityIPv6Prefix': '2406:d400:1:133:203:163:222:0/112',
                        'ipAddressToDeviceMap': {
                            '203.163.222.15': 'tpe31-96cbe-1a',
                            '2406:d400:1:133:203:163:222:15': 'tpe31-96cbe-1a',
                            '203.163.222.85': 'tpe31-96cbe-1b',
                            '2406:d400:1:133:203:163:222:85': 'tpe31-96cbe-1b'
                        },
                        'peeringDBFacilityId': 823,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/823'
                    }
                ]
            },
            'peeringLocation': 'Taipei',
            'country': 'TW',
            'azureRegion': 'East Asia'
        },
        'name': 'Taipei',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'MyIX',
                        'bandwidthInMbps': 20000,
                        'microsoftIPv4Address': '218.100.44.214,218.100.44.154',
                        'microsoftIPv6Address': '2001:de8:10::54,2001:de8:10::a9',
                        'facilityIPv4Prefix': '218.100.44.0/24',
                        'facilityIPv6Prefix': '2001:de8:10::/48',
                        'ipAddressToDeviceMap': {
                            '218.100.44.214': 'kul30-96cbe-1a',
                            '2001:de8:10::a9': 'kul30-96cbe-1a',
                            '218.100.44.154': 'kul30-96cbe-1b',
                            '2001:de8:10::54': 'kul30-96cbe-1b'
                        },
                        'peeringDBFacilityId': 250,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/250'
                    }
                ]
            },
            'peeringLocation': 'Kuala Lumpur',
            'country': 'MY',
            'azureRegion': 'Southeast Asia'
        },
        'name': 'Kuala Lumpur',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'BCIX',
                        'bandwidthInMbps': 50000,
                        'microsoftIPv4Address': '193.178.185.84,193.178.185.104',
                        'microsoftIPv6Address': '2001:7f8:19:1::1f8b:1,2001:7f8:19:1::1f8b:2',
                        'facilityIPv4Prefix': '193.178.185.0/24',
                        'facilityIPv6Prefix': '2001:7f8:19:1::/64',
                        'ipAddressToDeviceMap': {
                            '193.178.185.84': 'ber30-96cbe-1a',
                            '2001:7f8:19:1::1f8b:1': 'ber30-96cbe-1a',
                            '193.178.185.104': 'ber30-96cbe-1b',
                            '2001:7f8:19:1::1f8b:2': 'ber30-96cbe-1b'
                        },
                        'peeringDBFacilityId': 87,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/87'
                    },
                    {
                        'exchangeName': 'ECIX-BER',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '194.9.117.84',
                        'microsoftIPv6Address': '2001:7f8:8:5:0:1f8b:0:1',
                        'facilityIPv4Prefix': '194.9.117.0/24',
                        'facilityIPv6Prefix': '2001:7f8:8:5::/64',
                        'ipAddressToDeviceMap': {
                            '194.9.117.84': 'ber30-96cbe-1b',
                            '2001:7f8:8:5:0:1f8b:0:1': 'ber30-96cbe-1b'
                        },
                        'peeringDBFacilityId': 209,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/209'
                    }
                ]
            },
            'peeringLocation': 'Berlin',
            'country': 'DE',
            'azureRegion': 'West Europe'
        },
        'name': 'Berlin',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Equinix Warsaw (PLIX)',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '195.182.218.146,195.182.218.167',
                        'microsoftIPv6Address': '2001:7f8:42::a500:8075:1,2001:7f8:42::a500:8075:2',
                        'facilityIPv4Prefix': '195.182.218.0/23',
                        'facilityIPv6Prefix': '2001:7f8:42::/48',
                        'ipAddressToDeviceMap': {
                            '195.182.218.146': 'waw01-96cbe-1a',
                            '2001:7f8:42::a500:8075:1': 'waw01-96cbe-1a',
                            '195.182.218.167': 'waw01-96cbe-1b',
                            '2001:7f8:42::a500:8075:2': 'waw01-96cbe-1b'
                        },
                        'peeringDBFacilityId': 264,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/264'
                    },
                    {
                        'exchangeName': 'TPIX',
                        'bandwidthInMbps': 20000,
                        'microsoftIPv4Address': '195.149.232.50',
                        'microsoftIPv6Address': '2001:7f8:27::8075:1',
                        'facilityIPv4Prefix': '195.149.232.0/23',
                        'facilityIPv6Prefix': '2001:7f8:27::/48',
                        'ipAddressToDeviceMap': {
                            '195.149.232.50': 'waw01-96cbe-1a',
                            '2001:7f8:27::8075:1': 'waw01-96cbe-1a'
                        },
                        'peeringDBFacilityId': 482,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/482'
                    }
                ]
            },
            'peeringLocation': 'Warsaw',
            'country': 'PL',
            'azureRegion': 'West Europe'
        },
        'name': 'Warsaw',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Extreme IX Chennai',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '45.120.251.137',
                        'microsoftIPv6Address': '2001:df2:1900:3::137',
                        'facilityIPv4Prefix': '45.120.251.0/24',
                        'facilityIPv6Prefix': '2001:df2:1900:3::/64',
                        'ipAddressToDeviceMap': {
                            '45.120.251.137': 'maa02-96cbe-1b',
                            '2001:df2:1900:3::137': 'maa02-96cbe-1b'
                        },
                        'peeringDBFacilityId': 1786,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1786'
                    }
                ]
            },
            'peeringLocation': 'Chennai',
            'country': 'IN',
            'azureRegion': 'South India'
        },
        'name': 'Chennai',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'AMS-IX India',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '223.31.200.19',
                        'microsoftIPv6Address': '2001:e48:44:100b:0:a500:8075:1',
                        'facilityIPv4Prefix': '223.31.200.0/24',
                        'facilityIPv6Prefix': '2001:e48:44:100b::/64',
                        'ipAddressToDeviceMap': {
                            '223.31.200.19': 'bom02-96cbe-1a',
                            '2001:e48:44:100b:0:a500:8075:1': 'bom02-96cbe-1a'
                        },
                        'peeringDBFacilityId': 1623,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1623'
                    },
                    {
                        'exchangeName': 'Extreme IX Mumbai',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '103.77.108.128',
                        'microsoftIPv6Address': '2001:df2:1900:2::128',
                        'facilityIPv4Prefix': '103.77.108.0/24',
                        'facilityIPv6Prefix': '2001:df2:1900:2::/64',
                        'ipAddressToDeviceMap': {
                            '103.77.108.128': 'bom02-96cbe-1b',
                            '2001:df2:1900:2::128': 'bom02-96cbe-1b'
                        },
                        'peeringDBFacilityId': 1627,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1627'
                    }
                ]
            },
            'peeringLocation': 'Mumbai',
            'country': 'IN',
            'azureRegion': 'West India'
        },
        'name': 'Mumbai',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'MegaIX Perth',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '202.12.243.11',
                        'microsoftIPv6Address': '2001:dea:0:50::b',
                        'facilityIPv4Prefix': '202.12.243.0/24',
                        'facilityIPv6Prefix': '2001:dea:0:50::/64',
                        'ipAddressToDeviceMap': {
                            '202.12.243.11': 'per01-96cbe-1a',
                            '2001:dea:0:50::b': 'per01-96cbe-1a'
                        },
                        'peeringDBFacilityId': 1235,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1235'
                    },
                    {
                        'exchangeName': 'West Australian Internet Exchange (WAIX)',
                        'bandwidthInMbps': 30000,
                        'microsoftIPv4Address': '198.32.212.95',
                        'microsoftIPv6Address': '2001:7fa:11::2f2c:0:1',
                        'facilityIPv4Prefix': '198.32.212.0/24',
                        'facilityIPv6Prefix': '2001:7fa:11::/64',
                        'ipAddressToDeviceMap': {
                            '198.32.212.95': 'per01-96cbe-1a',
                            '2001:7fa:11::2f2c:0:1': 'per01-96cbe-1a'
                        },
                        'peeringDBFacilityId': 21,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/21'
                    }
                ]
            },
            'peeringLocation': 'Perth',
            'country': 'AU',
            'azureRegion': 'Australia Central'
        },
        'name': 'Perth',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Boston Internet Exchange',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.108.236.10',
                        'microsoftIPv6Address': '2001:504:24:1::1f8b:1',
                        'facilityIPv4Prefix': '206.108.236.0/24',
                        'facilityIPv6Prefix': '2001:504:24:1::/64',
                        'ipAddressToDeviceMap': {
                            '206.108.236.10': 'bos01-96e-1',
                            '2001:504:24:1::1f8b:1': 'bos01-96e-1'
                        },
                        'peeringDBFacilityId': 565,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/565'
                    },
                    {
                        'exchangeName': 'CoreSite - Any2 Boston',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.51.42.10',
                        'microsoftIPv6Address': '2001:504:13:7::10',
                        'facilityIPv4Prefix': '206.51.42.0/24',
                        'facilityIPv6Prefix': '2001:504:13:7::/64',
                        'ipAddressToDeviceMap': {},
                        'peeringDBFacilityId': 333,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/333'
                    },
                    {
                        'exchangeName': 'MASS-IX',
                        'bandwidthInMbps': 20000,
                        'microsoftIPv4Address': '206.53.143.7',
                        'microsoftIPv6Address': '2001:504:47::1f8b:0:1',
                        'facilityIPv4Prefix': '206.53.143.0/24',
                        'facilityIPv6Prefix': '2001:504:47::/64',
                        'ipAddressToDeviceMap': {
                            '206.53.143.7': 'bos01-96e-1',
                            '2001:504:47::1f8b:0:1': 'bos01-96e-1'
                        },
                        'peeringDBFacilityId': 1086,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1086'
                    }
                ]
            },
            'peeringLocation': 'Boston',
            'country': 'US',
            'azureRegion': 'East US'
        },
        'name': 'Boston',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'B-IX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '185.1.30.58',
                        'microsoftIPv6Address': '',
                        'facilityIPv4Prefix': '185.1.30.0/24',
                        'facilityIPv6Prefix': '',
                        'ipAddressToDeviceMap': {
                            '185.1.30.58': 'sof01-96cbe-1b'
                        },
                        'peeringDBFacilityId': 326,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/326'
                    },
                    {
                        'exchangeName': 'BIX.BG',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '193.169.198.74',
                        'microsoftIPv6Address': '2001:7f8:58::1f8b:0:1',
                        'facilityIPv4Prefix': '193.169.198.0/23',
                        'facilityIPv6Prefix': '2001:7f8:58::/48',
                        'ipAddressToDeviceMap': {
                            '193.169.198.74': 'sof01-96cbe-1a',
                            '2001:7f8:58::1f8b:0:1': 'sof01-96cbe-1a'
                        },
                        'peeringDBFacilityId': 331,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/331'
                    },
                    {
                        'exchangeName': 'NetIX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '193.218.0.150',
                        'microsoftIPv6Address': '2001:67c:29f0::8075:1',
                        'facilityIPv4Prefix': '193.218.0.0/24',
                        'facilityIPv6Prefix': '2001:67c:29f0::/64',
                        'ipAddressToDeviceMap': {
                            '193.218.0.150': 'sof01-96cbe-1b',
                            '2001:67c:29f0::8075:1': 'sof01-96cbe-1b'
                        },
                        'peeringDBFacilityId': 699,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/699'
                    },
                    {
                        'exchangeName': 'MegaIX Sofia',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '91.212.235.6',
                        'microsoftIPv6Address': '2001:7f8:9f::6',
                        'facilityIPv4Prefix': '91.212.235.0/24',
                        'facilityIPv6Prefix': '2001:7f8:9f::/64',
                        'ipAddressToDeviceMap': {},
                        'peeringDBFacilityId': 1056,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1056'
                    }
                ]
            },
            'peeringLocation': 'Sofia',
            'country': 'BG',
            'azureRegion': 'France Central'
        },
        'name': 'Sofia',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'MegaIX Las Vegas',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.53.205.6',
                        'microsoftIPv6Address': '2606:a980:0:9::6',
                        'facilityIPv4Prefix': '206.53.205.0/24',
                        'facilityIPv6Prefix': '2606:a980:0:9::/64',
                        'ipAddressToDeviceMap': {
                            '206.53.205.6': 'las01-96cbe-1a',
                            '2606:a980:0:9::6': 'las01-96cbe-1a'
                        },
                        'peeringDBFacilityId': 1628,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1628'
                    }
                ]
            },
            'peeringLocation': 'Las Vegas',
            'country': 'US',
            'azureRegion': 'West US'
        },
        'name': 'Las Vegas',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'TorIX',
                        'bandwidthInMbps': 100000,
                        'microsoftIPv4Address': '206.108.35.109,206.108.34.160',
                        'microsoftIPv6Address': '2001:504:1a::35:109,2001:504:1a::34:160',
                        'facilityIPv4Prefix': '206.108.34.0/23',
                        'facilityIPv6Prefix': '2001:504:1a::34:0/111',
                        'ipAddressToDeviceMap': {
                            '206.108.34.160': 'yto01-96cbe-1a',
                            '2001:504:1a::34:160': 'yto01-96cbe-1a',
                            '206.108.35.109': 'yto01-96cbe-1b',
                            '2001:504:1a::35:109': 'yto01-96cbe-1b'
                        },
                        'peeringDBFacilityId': 24,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/24'
                    },
                    {
                        'exchangeName': 'MegaIX Toronto',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.53.203.7',
                        'microsoftIPv6Address': '2606:a980:0:8::7',
                        'facilityIPv4Prefix': '206.53.203.0/24',
                        'facilityIPv6Prefix': '2606:a980:0:8::/64',
                        'ipAddressToDeviceMap': {
                            '206.53.203.7': 'yto01-96cbe-1b',
                            '2606:a980:0:8::7': 'yto01-96cbe-1b'
                        },
                        'peeringDBFacilityId': 1307,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1307'
                    }
                ]
            },
            'peeringLocation': 'Toronto',
            'country': 'CA',
            'azureRegion': 'Canada Central'
        },
        'name': 'Toronto',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'NAPAfrica IX Johannesburg',
                        'bandwidthInMbps': 40000,
                        'microsoftIPv4Address': '196.60.8.133,196.60.9.133',
                        'microsoftIPv6Address': '2001:43f8:6d0::133,2001:43f8:6d0::9:133',
                        'facilityIPv4Prefix': '196.60.8.0/23',
                        'facilityIPv6Prefix': '2001:43f8:6d0::/64',
                        'ipAddressToDeviceMap': {
                            '196.60.8.133': 'jnb02-96cbe-1a',
                            '2001:43f8:6d0::133': 'jnb02-96cbe-1a',
                            '196.60.9.133': 'jnb02-96cbe-1b',
                            '2001:43f8:6d0::9:133': 'jnb02-96cbe-1b'
                        },
                        'peeringDBFacilityId': 592,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/592'
                    }
                ]
            },
            'peeringLocation': 'Johannesburg',
            'country': 'ZA',
            'azureRegion': 'South Africa North'
        },
        'name': 'Johannesburg',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'JPIX OSAKA',
                        'bandwidthInMbps': 100000,
                        'microsoftIPv4Address': '103.246.232.116',
                        'microsoftIPv6Address': '2001:de8:8:6::8075:1',
                        'facilityIPv4Prefix': '103.246.232.0/24',
                        'facilityIPv6Prefix': '2001:de8:8:6::/64',
                        'ipAddressToDeviceMap': {
                            '103.246.232.116': 'osa02-96cbe-1a',
                            '2001:de8:8:6::8075:1': 'osa02-96cbe-1a'
                        },
                        'peeringDBFacilityId': 564,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/564'
                    },
                    {
                        'exchangeName': 'JPNAP Osaka',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '210.173.178.16,210.173.178.26',
                        'microsoftIPv6Address': '2001:7fa:7:2::8075:1,2001:7fa:7:2::8075:2,2001:7fa:7:2::8076:1',
                        'facilityIPv4Prefix': '210.173.178.0/25',
                        'facilityIPv6Prefix': '2001:7fa:7:2::/64',
                        'ipAddressToDeviceMap': {
                            '210.173.178.16': 'osa30-96cbe-1a',
                            '2001:7fa:7:2::8075:1': 'osa30-96cbe-1a',
                            '210.173.178.26': 'osa30-96cbe-1b',
                            '2001:7fa:7:2::8075:2': 'osa30-96cbe-1b'
                        },
                        'peeringDBFacilityId': 145,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/145'
                    },
                    {
                        'exchangeName': 'BBIX Osaka',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '218.100.9.28',
                        'microsoftIPv6Address': '2001:de8:c:2::8075:1',
                        'facilityIPv4Prefix': '218.100.9.0/24',
                        'facilityIPv6Prefix': '2001:de8:c:2::/64',
                        'ipAddressToDeviceMap': {
                            '218.100.9.28': 'osa30-96cbe-1a',
                            '2001:de8:c:2::8075:1': 'osa30-96cbe-1a'
                        },
                        'peeringDBFacilityId': 786,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/786'
                    }
                ]
            },
            'peeringLocation': 'Osaka',
            'country': 'JP',
            'azureRegion': 'Japan East'
        },
        'name': 'Osaka',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'NAPAfrica IX Cape Town',
                        'bandwidthInMbps': 40000,
                        'microsoftIPv4Address': '196.10.140.47,196.10.140.147',
                        'microsoftIPv6Address': '2001:43f8:6d1::47,2001:43f8:6d1::147',
                        'facilityIPv4Prefix': '196.10.140.0/24',
                        'facilityIPv6Prefix': '2001:43f8:6d1::/64',
                        'ipAddressToDeviceMap': {
                            '196.10.140.47': 'cpt02-96cbe-1a',
                            '2001:43f8:6d1::47': 'cpt02-96cbe-1a',
                            '196.10.140.147': 'cpt02-96cbe-1b',
                            '2001:43f8:6d1::147': 'cpt02-96cbe-1b'
                        },
                        'peeringDBFacilityId': 597,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/597'
                    }
                ]
            },
            'peeringLocation': 'Cape Town',
            'country': 'ZA',
            'azureRegion': 'South Africa North'
        },
        'name': 'Cape Town',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'VANIX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.41.104.41',
                        'microsoftIPv6Address': '2001:504:39::41',
                        'facilityIPv4Prefix': '206.41.104.0/24',
                        'facilityIPv6Prefix': '2001:504:39::/64',
                        'ipAddressToDeviceMap': {
                            '206.41.104.41': 'yvr01-96cbe-1a',
                            '2001:504:39::41': 'yvr01-96cbe-1a'
                        },
                        'peeringDBFacilityId': 863,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/863'
                    }
                ]
            },
            'peeringLocation': 'Vancouver',
            'country': 'CA',
            'azureRegion': 'West US 2'
        },
        'name': 'Vancouver',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'PIPE Networks Melbourne',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '218.100.13.80',
                        'microsoftIPv6Address': '2001:7fa:e::13',
                        'facilityIPv4Prefix': '218.100.13.0/24',
                        'facilityIPv6Prefix': '',
                        'ipAddressToDeviceMap': {},
                        'peeringDBFacilityId': 111,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/111'
                    },
                    {
                        'exchangeName': 'MegaIX Melbourne',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '103.26.71.35',
                        'microsoftIPv6Address': '2001:dea:0:30::23',
                        'facilityIPv4Prefix': '103.26.71.0/24',
                        'facilityIPv6Prefix': '2001:dea:0:30::/64',
                        'ipAddressToDeviceMap': {
                            '103.26.71.35': 'mel01-96cbe-1b',
                            '2001:dea:0:30::23': 'mel01-96cbe-1b'
                        },
                        'peeringDBFacilityId': 779,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/779'
                    },
                    {
                        'exchangeName': 'Equinix Melbourne',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '183.177.61.5',
                        'microsoftIPv6Address': '2001:de8:6:1::8075:1',
                        'facilityIPv4Prefix': '183.177.61.0/24',
                        'facilityIPv6Prefix': '2001:de8:6:1::/64',
                        'ipAddressToDeviceMap': {
                            '183.177.61.5': 'mel01-96cbe-1a',
                            '2001:de8:6:1::8075:1': 'mel01-96cbe-1a'
                        },
                        'peeringDBFacilityId': 1026,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1026'
                    },
                    {
                        'exchangeName': 'Victorian Internet Exchange',
                        'bandwidthInMbps': 40000,
                        'microsoftIPv4Address': '218.100.78.51',
                        'microsoftIPv6Address': '2001:7fa:11:1:0:2f2c:0:1',
                        'facilityIPv4Prefix': '218.100.78.0/24',
                        'facilityIPv6Prefix': '2001:7fa:11:1::/64',
                        'ipAddressToDeviceMap': {
                            '218.100.78.51': 'mel01-96cbe-1b',
                            '2001:7fa:11:1:0:2f2c:0:1': 'mel01-96cbe-1b'
                        },
                        'peeringDBFacilityId': 513,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/513'
                    }
                ]
            },
            'peeringLocation': 'Melbourne',
            'country': 'AU',
            'azureRegion': 'Australia Southeast'
        },
        'name': 'Melbourne',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'PIPE Networks Brisbane',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '218.100.0.73',
                        'microsoftIPv6Address': '2001:7fa:9::a',
                        'facilityIPv4Prefix': '218.100.0.0/24',
                        'facilityIPv6Prefix': '',
                        'ipAddressToDeviceMap': {},
                        'peeringDBFacilityId': 110,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/110'
                    },
                    {
                        'exchangeName': 'MegaIX Brisbane',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '103.26.70.20',
                        'microsoftIPv6Address': '2001:dea:0:20::14',
                        'facilityIPv4Prefix': '103.26.70.0/24',
                        'facilityIPv6Prefix': '2001:dea:0:20::/64',
                        'ipAddressToDeviceMap': {
                            '103.26.70.20': 'bne01-96cbe-1a',
                            '2001:dea:0:20::14': 'bne01-96cbe-1a'
                        },
                        'peeringDBFacilityId': 781,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/781'
                    },
                    {
                        'exchangeName': 'Queensland Internet Exchange',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '218.100.76.49',
                        'microsoftIPv6Address': '2001:7fa:11:2:0:2f2c:0:1',
                        'facilityIPv4Prefix': '218.100.76.0/24',
                        'facilityIPv6Prefix': '2001:7fa:11:2::/64',
                        'ipAddressToDeviceMap': {
                            '218.100.76.49': 'bne01-96cbe-1b',
                            '2001:7fa:11:2:0:2f2c:0:1': 'bne01-96cbe-1b'
                        },
                        'peeringDBFacilityId': 576,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/576'
                    }
                ]
            },
            'peeringLocation': 'Brisbane',
            'country': 'AU',
            'azureRegion': 'Australia East'
        },
        'name': 'Brisbane',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'APE',
                        'bandwidthInMbps': 20000,
                        'microsoftIPv4Address': '192.203.154.162',
                        'microsoftIPv6Address': '2001:7fa:4:c0cb::9aa2',
                        'facilityIPv4Prefix': '192.203.154.0/24',
                        'facilityIPv6Prefix': '2001:7fa:4:c0cb::/64',
                        'ipAddressToDeviceMap': {
                            '192.203.154.162': 'akl01-96cbe-1a',
                            '2001:7fa:4:c0cb::9aa2': 'akl01-96cbe-1a'
                        },
                        'peeringDBFacilityId': 97,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/97'
                    },
                    {
                        'exchangeName': 'AKL-IX',
                        'bandwidthInMbps': 20000,
                        'microsoftIPv4Address': '43.243.21.23',
                        'microsoftIPv6Address': '2001:7fa:11:6:0:1f8b:0:1',
                        'facilityIPv4Prefix': '43.243.21.0/24',
                        'facilityIPv6Prefix': '2001:7fa:11:6::/64',
                        'ipAddressToDeviceMap': {
                            '43.243.21.23': 'akl01-96cbe-1a',
                            '2001:7fa:11:6:0:1f8b:0:1': 'akl01-96cbe-1a'
                        },
                        'peeringDBFacilityId': 977,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/977'
                    },
                    {
                        'exchangeName': 'MegaIX Auckland',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '43.243.22.38',
                        'microsoftIPv6Address': '2001:dea:0:40::26',
                        'facilityIPv4Prefix': '43.243.22.0/23',
                        'facilityIPv6Prefix': '2001:dea:0:40::/64',
                        'ipAddressToDeviceMap': {
                            '43.243.22.38': 'akl01-96cbe-1a',
                            '2001:dea:0:40::26': 'akl01-96cbe-1a'
                        },
                        'peeringDBFacilityId': 984,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/984'
                    },
                    {
                        'exchangeName': 'WIX-NZ',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '202.7.0.220',
                        'microsoftIPv6Address': '2001:7fa:3:ca07::dc',
                        'facilityIPv4Prefix': '202.7.0.0/23',
                        'facilityIPv6Prefix': '2001:7fa:3:ca07::/64',
                        'ipAddressToDeviceMap': {
                            '202.7.0.220': 'akl01-96cbe-1a',
                            '2001:7fa:3:ca07::dc': 'akl01-96cbe-1a'
                        },
                        'peeringDBFacilityId': 348,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/348'
                    }
                ]
            },
            'peeringLocation': 'Auckland',
            'country': 'NZ',
            'azureRegion': 'Australia East'
        },
        'name': 'Auckland',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'CIX',
                        'bandwidthInMbps': 20000,
                        'microsoftIPv4Address': '185.1.87.110',
                        'microsoftIPv6Address': '2001:7f8:28::25:0',
                        'facilityIPv4Prefix': '185.1.87.0/24',
                        'facilityIPv6Prefix': '2001:7f8:28::/64',
                        'ipAddressToDeviceMap': {
                            '185.1.87.110': 'zag30-96cbe-1a',
                            '2001:7f8:28::25:0': 'zag30-96cbe-1a'
                        },
                        'peeringDBFacilityId': 303,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/303'
                    }
                ]
            },
            'peeringLocation': 'Zagreb',
            'country': 'HR',
            'azureRegion': 'West Europe'
        },
        'name': 'Zagreb',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'IX.br (PTT.br) Rio de Janeiro',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '45.6.52.73,45.6.52.72',
                        'microsoftIPv6Address': '2001:12f8:0:2::73,2001:12f8:0:2::72',
                        'facilityIPv4Prefix': '45.6.52.0/22',
                        'facilityIPv6Prefix': '2001:12f8:0:2::/64',
                        'ipAddressToDeviceMap': {
                            '45.6.52.73': 'rio02-96cbe-1a',
                            '2001:12f8:0:2::73': 'rio02-96cbe-1a',
                            '45.6.52.72': 'rio03-96cbe-1a',
                            '2001:12f8:0:2::72': 'rio03-96cbe-1a'
                        },
                        'peeringDBFacilityId': 177,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/177'
                    }
                ]
            },
            'peeringLocation': 'Rio de Janeiro',
            'country': 'BR',
            'azureRegion': 'Brazil South'
        },
        'name': 'Rio de Janeiro',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'FICIX 2 (Helsinki)',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '193.110.224.62',
                        'microsoftIPv6Address': '2001:7f8:7:b::8075:1,2001:7f8:7:a::8075:1',
                        'facilityIPv4Prefix': '193.110.224.0/24',
                        'facilityIPv6Prefix': '2001:7f8:7:b::/64',
                        'ipAddressToDeviceMap': {
                            '193.110.224.62': 'hel03-96cbe-1a',
                            '2001:7f8:7:b::8075:1': 'hel03-96cbe-1a'
                        },
                        'peeringDBFacilityId': 98,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/98'
                    },
                    {
                        'exchangeName': 'FICIX 1 (Espoo)',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '193.110.226.62',
                        'microsoftIPv6Address': '2001:7f8:7:a::8075:1,2001:7f8:7:b::8075:1',
                        'facilityIPv4Prefix': '193.110.226.0/24',
                        'facilityIPv6Prefix': '2001:7f8:7:a::/64',
                        'ipAddressToDeviceMap': {
                            '193.110.226.62': 'hel02-96cbe-1a',
                            '2001:7f8:7:a::8075:1': 'hel02-96cbe-1a'
                        },
                        'peeringDBFacilityId': 1332,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1332'
                    }
                ]
            },
            'peeringLocation': 'Helsinki',
            'country': 'FI',
            'azureRegion': 'West Europe'
        },
        'name': 'Helsinki',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'CyrusOne IX Houston',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '198.32.96.35,198.32.96.36',
                        'microsoftIPv6Address': '2001:478:96::35,2001:478:96::36',
                        'facilityIPv4Prefix': '198.32.96.0/23',
                        'facilityIPv6Prefix': '2001:478:96::/64',
                        'ipAddressToDeviceMap': {
                            '198.32.96.35': 'hou01-96cbe-1a',
                            '2001:478:96::35': 'hou01-96cbe-1a',
                            '198.32.96.36': 'hou01-96cbe-1b',
                            '2001:478:96::36': 'hou01-96cbe-1b'
                        },
                        'peeringDBFacilityId': 673,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/673'
                    }
                ]
            },
            'peeringLocation': 'Houston',
            'country': 'US',
            'azureRegion': 'South Central US'
        },
        'name': 'Houston',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'CyrusOne IX Phoenix',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '198.32.98.35,198.32.98.36',
                        'microsoftIPv6Address': '',
                        'facilityIPv4Prefix': '198.32.98.0/24',
                        'facilityIPv6Prefix': '',
                        'ipAddressToDeviceMap': {
                            '198.32.98.35': 'phx01-96cbe-1a',
                            '198.32.98.36': 'phx01-96cbe-1b'
                        },
                        'peeringDBFacilityId': 760,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/760'
                    },
                    {
                        'exchangeName': 'Phoenix IX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.41.105.44',
                        'microsoftIPv6Address': '2001:504:3b::44',
                        'facilityIPv4Prefix': '206.41.105.0/24',
                        'facilityIPv6Prefix': '2001:504:3b::/64',
                        'ipAddressToDeviceMap': {
                            '206.41.105.44': 'phx01-96cbe-1a',
                            '2001:504:3b::44': 'phx01-96cbe-1a'
                        },
                        'peeringDBFacilityId': 662,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/662'
                    }
                ]
            },
            'peeringLocation': 'Phoenix',
            'country': 'US',
            'azureRegion': 'West US'
        },
        'name': 'Phoenix',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'PIT Santiago - PIT Chile',
                        'bandwidthInMbps': 20000,
                        'microsoftIPv4Address': '200.23.206.210,200.23.206.211',
                        'microsoftIPv6Address': '2801:14:9000::8075:1,2801:14:9000::8075:2',
                        'facilityIPv4Prefix': '200.23.206.0/24',
                        'facilityIPv6Prefix': '2801:14:9000::/64',
                        'ipAddressToDeviceMap': {
                            '200.23.206.210': 'scl30-96cbe-1a',
                            '2801:14:9000::8075:1': 'scl30-96cbe-1a',
                            '200.23.206.211': 'scl30-96cbe-1b',
                            '2801:14:9000::8075:2': 'scl30-96cbe-1b'
                        },
                        'peeringDBFacilityId': 1514,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1514'
                    }
                ]
            },
            'peeringLocation': 'Santiago',
            'country': 'CL',
            'azureRegion': 'Brazil South'
        },
        'name': 'Santiago',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'QIX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '198.179.18.16',
                        'microsoftIPv6Address': '2001:504:2d::18:16',
                        'facilityIPv4Prefix': '198.179.18.0/24',
                        'facilityIPv6Prefix': '2001:504:2d::/48',
                        'ipAddressToDeviceMap': {
                            '198.179.18.16': 'ymq01-96cbe-1a',
                            '2001:504:2d::18:16': 'ymq01-96cbe-1a'
                        },
                        'peeringDBFacilityId': 355,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/355'
                    }
                ]
            },
            'peeringLocation': 'Montreal',
            'country': 'CA',
            'azureRegion': 'Canada East'
        },
        'name': 'Montreal',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'GR-IX::Athens',
                        'bandwidthInMbps': 40000,
                        'microsoftIPv4Address': '176.126.38.18,176.126.38.28',
                        'microsoftIPv6Address': '2001:7f8:6e::18,2001:7f8:6e::28',
                        'facilityIPv4Prefix': '176.126.38.0/25',
                        'facilityIPv6Prefix': '2001:7f8:6e::/64',
                        'ipAddressToDeviceMap': {
                            '176.126.38.18': 'ath01-96cbe-1a',
                            '2001:7f8:6e::18': 'ath01-96cbe-1a',
                            '176.126.38.28': 'ath01-96cbe-1b',
                            '2001:7f8:6e::28': 'ath01-96cbe-1b'
                        },
                        'peeringDBFacilityId': 347,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/347'
                    }
                ]
            },
            'peeringLocation': 'Athens',
            'country': 'GR',
            'azureRegion': 'France Central'
        },
        'name': 'Athens',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'MIX-IT',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '217.29.66.112,217.29.66.212',
                        'microsoftIPv6Address': '2001:7f8:b:100:1d1:a5d0:8075:112,2001:7f8:b:100:1d1:a5d0:8075:212',
                        'facilityIPv4Prefix': '217.29.66.0/23',
                        'facilityIPv6Prefix': '2001:7f8:b:100::/64',
                        'ipAddressToDeviceMap': {
                            '217.29.66.212': 'mil30-96cbe-1a',
                            '2001:7f8:b:100:1d1:a5d0:8075:212': 'mil30-96cbe-1a',
                            '217.29.66.112': 'mil30-96cbe-1b',
                            '2001:7f8:b:100:1d1:a5d0:8075:112': 'mil30-96cbe-1b'
                        },
                        'peeringDBFacilityId': 35,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/35'
                    },
                    {
                        'exchangeName': 'TOP-IX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '194.116.96.88',
                        'microsoftIPv6Address': '2001:7f8:23:ffff::88',
                        'facilityIPv4Prefix': '194.116.96.0/24',
                        'facilityIPv6Prefix': '2001:7f8:23:ffff::/64',
                        'ipAddressToDeviceMap': {
                            '194.116.96.88': 'mil30-96cbe-1b',
                            '2001:7f8:23:ffff::88': 'mil30-96cbe-1b'
                        },
                        'peeringDBFacilityId': 115,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/115'
                    }
                ]
            },
            'peeringLocation': 'Milan',
            'country': 'IT',
            'azureRegion': 'France Central'
        },
        'name': 'Milan',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'Extreme IX Delhi',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '45.120.248.13',
                        'microsoftIPv6Address': '2001:df2:1900:1::13',
                        'facilityIPv4Prefix': '45.120.248.0/24',
                        'facilityIPv6Prefix': '2001:df2:1900:1::/64',
                        'ipAddressToDeviceMap': {
                            '45.120.248.13': 'del01-96cbe-1b',
                            '2001:df2:1900:1::13': 'del01-96cbe-1b'
                        },
                        'peeringDBFacilityId': 1323,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1323'
                    }
                ]
            },
            'peeringLocation': 'New Delhi',
            'country': 'IN',
            'azureRegion': 'West India'
        },
        'name': 'New Delhi',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'DRF IX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '206.197.210.37',
                        'microsoftIPv6Address': '2606:7c80:3375:50::37',
                        'facilityIPv4Prefix': '206.197.210.0/24',
                        'facilityIPv6Prefix': '2606:7c80:3375:50::/64',
                        'ipAddressToDeviceMap': {
                            '206.197.210.37': 'hnl01-96cbe-1a',
                            '2606:7c80:3375:50::37': 'hnl01-96cbe-1a'
                        },
                        'peeringDBFacilityId': 267,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/267'
                    }
                ]
            },
            'peeringLocation': 'Honolulu',
            'country': 'US',
            'azureRegion': 'West US'
        },
        'name': 'Honolulu',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'SH-IX',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '185.1.15.14',
                        'microsoftIPv6Address': '2001:7f8:7a::8075:1',
                        'facilityIPv4Prefix': '185.1.15.0/24',
                        'facilityIPv6Prefix': '2001:7f8:7a::/64',
                        'ipAddressToDeviceMap': {
                            '185.1.15.14': 'ier02.dxb20',
                            '2001:7f8:7a::8075:1': 'ier02.dxb20'
                        },
                        'peeringDBFacilityId': 866,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/866'
                    }
                ]
            },
            'peeringLocation': 'Fujairah',
            'country': 'AE',
            'azureRegion': 'UK West'
        },
        'name': 'Fujairah',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'UAE-IX',
                        'bandwidthInMbps': 20000,
                        'microsoftIPv4Address': '185.1.8.22,185.1.8.32',
                        'microsoftIPv6Address': '2001:7f8:73::1f8b:0:1,2001:7f8:73::1f8b:0:2',
                        'facilityIPv4Prefix': '185.1.8.0/24',
                        'facilityIPv6Prefix': '2001:7f8:73::/64',
                        'ipAddressToDeviceMap': {
                            '185.1.8.32': 'ier01.dxb30',
                            '2001:7f8:73::1f8b:0:1': 'ier01.dxb30',
                            '185.1.8.22': 'ier02.dxb30',
                            '2001:7f8:73::1f8b:0:2': 'ier02.dxb30'
                        },
                        'peeringDBFacilityId': 587,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/587'
                    }
                ]
            },
            'peeringLocation': 'Dubai',
            'country': 'AE',
            'azureRegion': 'UK West'
        },
        'name': 'Dubai',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'DE-CIX Dusseldorf',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '185.1.58.94',
                        'microsoftIPv6Address': '2001:7f8:9e::1f8b:0:1',
                        'facilityIPv4Prefix': '185.1.58.0/24',
                        'facilityIPv6Prefix': '2001:7f8:9e::/64',
                        'ipAddressToDeviceMap': {},
                        'peeringDBFacilityId': 1214,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/1214'
                    }
                ]
            },
            'peeringLocation': 'Dusseldorf',
            'country': 'DE',
            'azureRegion': 'UK West'
        },
        'name': 'Dusseldorf',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'DE-CIX Munich',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '80.81.202.100',
                        'microsoftIPv6Address': '2001:7f8:44::1f8b:0:1',
                        'facilityIPv4Prefix': '80.81.202.0/24',
                        'facilityIPv6Prefix': '2001:7f8:44::/64',
                        'ipAddressToDeviceMap': {},
                        'peeringDBFacilityId': 248,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/248'
                    }
                ]
            },
            'peeringLocation': 'Munich',
            'country': 'DE',
            'azureRegion': 'UK West'
        },
        'name': 'Munich',
        'type': 'Microsoft.Peering/peeringLocations'
    },
    {
        'kind': 'Exchange',
        'properties': {
            'exchange': {
                'peeringFacilities': [
                    {
                        'exchangeName': 'DE-CIX Hamburg',
                        'bandwidthInMbps': 10000,
                        'microsoftIPv4Address': '80.81.203.105',
                        'microsoftIPv6Address': '2001:7f8:3d::1f8b:0:1',
                        'facilityIPv4Prefix': '80.81.203.0/24',
                        'facilityIPv6Prefix': '2001:7f8:3d::/64',
                        'ipAddressToDeviceMap': {},
                        'peeringDBFacilityId': 74,
                        'peeringDBFacilityLink': 'https://www.peeringdb.com/ix/74'
                    }
                ]
            },
            'peeringLocation': 'Hamburg',
            'country': 'DE',
            'azureRegion': 'UK West'
        },
        'name': 'Hamburg',
        'type': 'Microsoft.Peering/peeringLocations'
    }
]";
        }

        public static string GetFacilityLocationMap()
        {
            return @"[
  {
    'LocationName': 'Ashburn',
    'AzureRegion': 'East US',
    'PrivatePeeringFacilityMap': {
      '1': {
        'CodeList': [
          'ash'
        ],
        'Country': 'US',
        'Address': '21715 Filigree Ct',
        'Latitude': 39.016363,
        'Longitude': -77.459023,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '1': {
        'CodeList': [
          'ash'
        ],
        'Country': 'US',
        'Name': 'Equinix Ashburn',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1',
        'Ipv4PrefixList': [
          '206.126.236.0/22'
        ],
        'Ipv6PrefixList': [
          '2001:504:0:2::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.126.236.17'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:0:2::8075:1'
        ],
        'Bandwidth': 100000,
        'Devices': {
          'ash-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel9': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '1178': {
        'CodeList': [
          'ash'
        ],
        'Country': 'US',
        'Name': 'MegaIX Ashburn',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1178',
        'Ipv4PrefixList': [
          '206.53.170.0/24'
        ],
        'Ipv6PrefixList': [
          '2606:a980:0:3::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.53.170.12'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2606:a980:0:3::c'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'ash-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel8': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Palo Alto',
    'AzureRegion': 'West US',
    'PrivatePeeringFacilityMap': {
      '5': {
        'CodeList': [
          'pao'
        ],
        'Country': 'US',
        'Address': '529 Bryant St',
        'Latitude': 37.445896,
        'Longitude': -122.160775,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/5',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '7': {
        'CodeList': [
          'pao'
        ],
        'Country': 'US',
        'Name': 'Equinix Palo Alto',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/7',
        'Ipv4PrefixList': [
          '198.32.176.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:d::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '198.32.176.152'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:d::98'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'pao-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel1': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'San Jose',
    'AzureRegion': 'West US',
    'PrivatePeeringFacilityMap': {
      '6': {
        'CodeList': [
          'sjc'
        ],
        'Country': 'US',
        'Address': '11 Great Oaks Blvd',
        'Latitude': 37.241767,
        'Longitude': -121.782967,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/6',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '5': {
        'CodeList': [
          'sjc'
        ],
        'Country': 'US',
        'Name': 'Equinix San Jose',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/5',
        'Ipv4PrefixList': [
          '206.223.116.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:504:0:1::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.223.116.17'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:0:1::8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'sjc-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel0': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '935': {
        'CodeList': [
          'sjc'
        ],
        'Country': 'US',
        'Name': 'AMS-IX BA',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/935',
        'Ipv4PrefixList': [
          '206.41.106.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:3d:1::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.41.106.72'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:3d:1:0:a500:8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'sjc-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel7': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Chicago',
    'AzureRegion': 'North Central US',
    'PrivatePeeringFacilityMap': {
      '7': {
        'CodeList': [
          'chg'
        ],
        'Country': 'US',
        'Address': '350 E Cermak Rd',
        'Latitude': 41.85365,
        'Longitude': -87.618342,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/7',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '2': {
        'CodeList': [
          'chg'
        ],
        'Country': 'US',
        'Name': 'Equinix Chicago',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/2',
        'Ipv4PrefixList': [
          '208.115.136.0/23',
          '206.223.119.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:0:4::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '208.115.136.27',
          '206.223.119.27',
          '208.115.137.61'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:0:4::8075:1',
          '2001:504:0:4::8075:2'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'chg-96e-2': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel11': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'chg-96e-1': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel65': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '944': {
        'CodeList': [
          'chg'
        ],
        'Country': 'US',
        'Name': 'AMS-IX Chicago',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/944',
        'Ipv4PrefixList': [
          '206.108.115.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:38:1::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.108.115.47'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:38:1:0:a500:8075:1'
        ],
        'Bandwidth': 20000,
        'Devices': {
          'chg-96e-2': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel13': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Los Angeles',
    'AzureRegion': 'West US',
    'PrivatePeeringFacilityMap': {
      '8': {
        'CodeList': [
          'lax03'
        ],
        'Country': 'US',
        'Address': '600 W 7th St',
        'Latitude': 34.047322,
        'Longitude': -118.25745,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/8',
        'Devices': {}
      },
      '19': {
        'CodeList': [
          'lax'
        ],
        'Country': 'US',
        'Address': '624 S. Grand Ave.',
        'Latitude': 34.047942,
        'Longitude': -118.255564,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/19',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '4': {
        'CodeList': [
          'lax'
        ],
        'Country': 'US',
        'Name': 'Equinix Los Angeles',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/4',
        'Ipv4PrefixList': [
          '206.223.123.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:0:3::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.223.123.17'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:0:3::8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'lax-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel0': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '1175': {
        'CodeList': [
          'lax'
        ],
        'Country': 'US',
        'Name': 'MegaIX Los Angeles',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1175',
        'Ipv4PrefixList': [
          '206.53.172.0/24'
        ],
        'Ipv6PrefixList': [
          '2606:a980:0:5::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.53.172.12'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2606:a980:0:5::c'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'lax-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel25': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '142': {
        'CodeList': [
          'lax'
        ],
        'Country': 'US',
        'Name': 'CoreSite - Any2 California',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/142',
        'Ipv4PrefixList': [
          '206.72.210.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:504:13::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.72.210.143'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:13::210:143'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'lax-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel2': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Atlanta',
    'AzureRegion': 'East US 2',
    'PrivatePeeringFacilityMap': {
      '11': {
        'CodeList': [
          'ata'
        ],
        'Country': 'US',
        'Address': '56 Marietta St NW',
        'Latitude': 33.755456,
        'Longitude': -84.39153,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/11',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '9': {
        'CodeList': [
          'ata'
        ],
        'Country': 'US',
        'Name': 'Equinix Atlanta',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/9',
        'Ipv4PrefixList': [
          '198.32.182.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:10::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '198.32.182.33',
          '198.32.182.102'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:10::8075:1',
          '2001:504:10::8075:2'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'ata-96e-1': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel62': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'ata-96e-2': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel0': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '22': {
        'CodeList': [
          'ata'
        ],
        'Country': 'US',
        'Name': 'Digital Realty Atlanta',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/22',
        'Ipv4PrefixList': [
          '198.32.132.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:478:132::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '198.32.132.117'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:478:132::117'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'ata-96e-1': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel0': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Miami',
    'AzureRegion': 'East US 2',
    'PrivatePeeringFacilityMap': {
      '15': {
        'CodeList': [
          'mia'
        ],
        'Country': 'US',
        'Address': '50 NE 9th St',
        'Latitude': 25.782648,
        'Longitude': -80.193157,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/15',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '17': {
        'CodeList': [
          'mia'
        ],
        'Country': 'US',
        'Name': 'Equinix Miami (formerly NOTA)',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/17',
        'Ipv4PrefixList': [
          '198.32.124.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:478:124::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '198.32.124.188',
          '198.32.124.189'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:478:124::188',
          '2001:478:124::189'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'mia-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel1': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'mia-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel1': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '954': {
        'CodeList': [
          'mia'
        ],
        'Country': 'US',
        'Name': 'FL-IX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/954',
        'Ipv4PrefixList': [
          '206.41.108.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:40:108::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.41.108.25'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:40:108::1:25'
        ],
        'Bandwidth': 100000,
        'Devices': {
          'mia-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel6': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'London',
    'AzureRegion': 'UK South',
    'PrivatePeeringFacilityMap': {
      '34': {
        'CodeList': [
          'lts'
        ],
        'Country': 'GB',
        'Address': '14 Coriander Avenue',
        'Latitude': 51.511517,
        'Longitude': -0.001787,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/34',
        'Devices': {}
      },
      '39': {
        'CodeList': [
          'lts'
        ],
        'Country': 'GB',
        'Address': '14 Coriander Avenue',
        'Latitude': 51.511517,
        'Longitude': -0.001787,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/39',
        'Devices': {}
      },
      '40': {
        'CodeList': [
          'lts'
        ],
        'Country': 'GB',
        'Address': 'Sovereign House',
        'Latitude': 51.499819,
        'Longitude': -0.010775,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/40',
        'Devices': {}
      },
      '832': {
        'CodeList': [
          'lon04'
        ],
        'Country': 'GB',
        'Address': '8 Buckingham Avenue',
        'Latitude': 51.522463,
        'Longitude': -0.62905,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/832',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '18': {
        'CodeList': [
          'lts'
        ],
        'Country': 'GB',
        'Name': 'LINX LON1',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/18',
        'Ipv4PrefixList': [
          '195.66.224.0/22'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:4::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '195.66.224.140'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:4::1f8b:1'
        ],
        'Bandwidth': 300000,
        'Devices': {
          'lts-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel6': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '321': {
        'CodeList': [
          'lon04'
        ],
        'Country': 'GB',
        'Name': 'LINX LON2',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/321',
        'Ipv4PrefixList': [
          '195.66.236.0/22'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:4:1::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '195.66.236.140'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:4:1::1f8b:1'
        ],
        'Bandwidth': 200000,
        'Devices': {
          'lon04-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel1': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '53': {
        'CodeList': [
          'lon04'
        ],
        'Country': 'GB',
        'Name': 'LONAP',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/53',
        'Ipv4PrefixList': [
          '5.57.80.0/22'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:17::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '5.57.81.17'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:17::1f8b:1'
        ],
        'Bandwidth': 100000,
        'Devices': {
          'lon04-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel60': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '1997': {
        'CodeList': [
          'lon04'
        ],
        'Country': 'GB',
        'Name': 'Equinix London',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1997',
        'Ipv4PrefixList': [
          '185.1.104.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:be::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '185.1.104.57'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:be::8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'lon04-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel64': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [
                  '185.1.104.57/32'
                ],
                'SessionIpv6PrefixList': [
                  '2001:7f8:be::8075:1/128'
                ],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'New York',
    'AzureRegion': 'East US',
    'PrivatePeeringFacilityMap': {
      '38': {
        'CodeList': [
          'nyc'
        ],
        'Country': 'US',
        'Address': '111 8th Avenue',
        'Latitude': 40.753599,
        'Longitude': -73.99198,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/38',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '12': {
        'CodeList': [
          'nyc'
        ],
        'Country': 'US',
        'Name': 'Equinix New York',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/12',
        'Ipv4PrefixList': [
          '198.32.118.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:f::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '198.32.118.18'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:f::12'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'nyc-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel1': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '14': {
        'CodeList': [
          'nyc'
        ],
        'Country': 'US',
        'Name': 'NYIIX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/14',
        'Ipv4PrefixList': [
          '198.32.160.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:1::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '198.32.160.199'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:1::a500:8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'nyc-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel2': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '804': {
        'CodeList': [
          'nyc'
        ],
        'Country': 'US',
        'Name': 'DE-CIX New York',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/804',
        'Ipv4PrefixList': [
          '206.82.104.0/22',
          '206.130.10.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:36::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.82.104.133',
          '206.130.10.133'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:36::1f8b:0:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'nyc-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel15': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '325': {
        'CodeList': [
          'nyc'
        ],
        'Country': 'US',
        'Name': 'Digital Realty New York',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/325',
        'Ipv4PrefixList': [
          '206.126.115.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:17:115::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.126.115.23'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:17:115::23'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'nyc-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel1': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Paris',
    'AzureRegion': 'France Central',
    'PrivatePeeringFacilityMap': {
      '53': {
        'CodeList': [
          'pra'
        ],
        'Country': 'FR',
        'Address': '137 Boulevard Voltaire',
        'Latitude': 48.856032,
        'Longitude': 2.383369,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/53',
        'Devices': {}
      },
      '714': {
        'CodeList': [
          'par02'
        ],
        'Country': 'FR',
        'Address': '11-13 Avenue des Arts et Metiers',
        'Latitude': 48.914183,
        'Longitude': 2.362402,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/714',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '359': {
        'CodeList': [
          'pra',
          'par02'
        ],
        'Country': 'FR',
        'Name': 'France-IX Paris',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/359',
        'Ipv4PrefixList': [
          '37.49.236.0/22'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:54::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '37.49.236.5',
          '37.49.237.119'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:54::5',
          '2001:7f8:54::1:119'
        ],
        'Bandwidth': 100000,
        'Devices': {
          'par02-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel10.4': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'pra-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel11.4': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '255': {
        'CodeList': [
          'par02'
        ],
        'Country': 'FR',
        'Name': 'Equinix Paris',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/255',
        'Ipv4PrefixList': [
          '195.42.144.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:43::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '195.42.145.28'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:43::8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'par02-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel3': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Frankfurt',
    'AzureRegion': 'West Europe',
    'PrivatePeeringFacilityMap': {
      '58': {
        'CodeList': [
          'fra'
        ],
        'Country': 'DE',
        'Address': 'Hanauer Landstrasse 298',
        'Latitude': 50.11967,
        'Longitude': 8.73463,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/58',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '31': {
        'CodeList': [
          'fra'
        ],
        'Country': 'DE',
        'Name': 'DE-CIX Frankfurt',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/31',
        'Ipv4PrefixList': [
          '80.81.192.0/21'
        ],
        'Ipv6PrefixList': [
          '2001:7f8::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '80.81.194.52',
          '80.81.195.11'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8::1f8b:0:1',
          '2001:7f8::1f8b:0:2'
        ],
        'Bandwidth': 100000,
        'Devices': {
          'fra-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel67.10': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'fra-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel9': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '676': {
        'CodeList': [
          'fra'
        ],
        'Country': 'DE',
        'Name': 'ECIX-FRA',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/676',
        'Ipv4PrefixList': [
          '62.69.146.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:8:20::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '62.69.146.70'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:8:20:0:1f8b:0:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'fra-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel5': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '64': {
        'CodeList': [
          'fra'
        ],
        'Country': 'NL',
        'Name': 'NL-IX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/64',
        'Ipv4PrefixList': [
          '193.239.116.0/22'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:13::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '193.239.118.163'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:13::a500:8075:2'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'fra-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel66': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Amsterdam',
    'AzureRegion': 'West Europe',
    'PrivatePeeringFacilityMap': {
      '63': {
        'CodeList': [
          'ams'
        ],
        'Country': 'NL',
        'Address': 'Johan Huizingalaan 759',
        'Latitude': 52.343984,
        'Longitude': 4.828711,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/63',
        'Devices': {}
      },
      '64': {
        'CodeList': [
          'ams'
        ],
        'Country': 'NL',
        'Address': 'Cessnalaan 1',
        'Latitude': 52.28415,
        'Longitude': 4.770855,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/64',
        'Devices': {}
      },
      '1236': {
        'CodeList': [
          'amb'
        ],
        'Country': 'NL',
        'Address': 'Schepenbergweg 42',
        'Latitude': 52.293391,
        'Longitude': 4.944979,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1236',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '64': {
        'CodeList': [
          'amb'
        ],
        'Country': 'NL',
        'Name': 'NL-ix',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/64',
        'Ipv4PrefixList': [
          '193.239.116.0/22'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:13::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '193.239.117.16'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:13::a500:8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'amb-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel67.7': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '26': {
        'CodeList': [
          'amb',
          'ams'
        ],
        'Country': 'NL',
        'Name': 'AMS-IX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/26',
        'Ipv4PrefixList': [
          '80.249.208.0/21'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:1::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '80.249.209.21',
          '80.249.209.20'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:1::a500:8075:2',
          '2001:7f8:1::a500:8075:1'
        ],
        'Bandwidth': 200000,
        'Devices': {
          'amb-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel8': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'ams-96c-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel9': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '2031': {
        'CodeList': [
          'amb'
        ],
        'Country': 'NL',
        'Name': 'Equinix Amsterdam',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/2031',
        'Ipv4PrefixList': [
          '185.1.112.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:83::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '185.1.112.37'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:83::8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'amb-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel70': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Vienna',
    'AzureRegion': 'West Europe',
    'PrivatePeeringFacilityMap': {
      '67': {
        'CodeList': [
          'vie'
        ],
        'Country': 'AT',
        'Address': 'Louis-Haefliger-Gasse 10',
        'Latitude': 48.269027,
        'Longitude': 16.410613,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/67',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '50': {
        'CodeList': [
          'vie'
        ],
        'Country': 'AT',
        'Name': 'VIX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/50',
        'Ipv4PrefixList': [
          '193.203.0.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:30::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '193.203.0.165'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:30:0:2:1:0:8075'
        ],
        'Bandwidth': 100000,
        'Devices': {
          'vie-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel20': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Brussels',
    'AzureRegion': 'France Central',
    'PrivatePeeringFacilityMap': {
      '68': {
        'CodeList': [
          'bru30'
        ],
        'Country': 'BE',
        'Address': 'Wezenbeekstraat 2',
        'Latitude': 50.870502,
        'Longitude': 4.476941,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/68',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '59': {
        'CodeList': [
          'bru30'
        ],
        'Country': 'BE',
        'Name': 'BNIX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/59',
        'Ipv4PrefixList': [
          '194.53.172.0/25'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:26::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '194.53.172.34'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:26::a500:8075:1'
        ],
        'Bandwidth': 20000,
        'Devices': {
          'bru30-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel1': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Dallas',
    'AzureRegion': 'South Central US',
    'PrivatePeeringFacilityMap': {
      '69': {
        'CodeList': [
          'dal'
        ],
        'Country': 'US',
        'Address': '1950 N Stemmons Fwy',
        'Latitude': 32.800955,
        'Longitude': -96.81955,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/69',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '3': {
        'CodeList': [
          'dal'
        ],
        'Country': 'US',
        'Name': 'Equinix Dallas',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/3',
        'Ipv4PrefixList': [
          '206.223.118.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:0:5::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.223.118.17',
          '206.223.118.65'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:0:5::8075:1',
          '2001:504:0:5::8075:2'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'dal-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel35': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'dal-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel68': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '1180': {
        'CodeList': [
          'dal'
        ],
        'Country': 'US',
        'Name': 'MegaIX Dallas',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1180',
        'Ipv4PrefixList': [
          '206.53.174.0/24'
        ],
        'Ipv6PrefixList': [
          '2606:a980:0:7::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.53.174.12'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2606:a980:0:7::c'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'dal-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel5': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '672': {
        'CodeList': [
          'dal'
        ],
        'Country': 'US',
        'Name': 'CyrusOne IX Dallas',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/672',
        'Ipv4PrefixList': [
          '198.32.130.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:478:130::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '198.32.130.39',
          '198.32.130.40'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:478:130::39',
          '2001:478:130::40'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'dal-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel13': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'dal-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel14': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '1249': {
        'CodeList': [
          'dal'
        ],
        'Country': 'US',
        'Name': 'DE-CIX Dallas',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1249',
        'Ipv4PrefixList': [
          '206.53.202.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:61::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.53.202.15'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:61::1f8b:0:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'dal-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel71': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Seattle',
    'AzureRegion': 'West US 2',
    'PrivatePeeringFacilityMap': {
      '71': {
        'CodeList': [
          'wst'
        ],
        'Country': 'US',
        'Address': '2001 Sixth Avenue',
        'Latitude': 47.614347,
        'Longitude': -122.338883,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/71',
        'Devices': {}
      },
      '99999': {
        'CodeList': [
          'co1'
        ],
        'Country': 'US',
        'Address': 'One Microsoft Way, Redmond',
        'Latitude': 47.614347,
        'Longitude': -122.338883,
        'LocationType': 'Test',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/99999',
        'MicrosoftSessionIpv6AddressList': [],
        'Bandwidth': 10000,
        'Devices': {
          'co1-96c-1a': {
          },
          'co1-96c-1b': {
          }
        }
      }
    },
    'PublicPeeringFacilityMap': {
      '99999': {
        'CodeList': [
          'co1'
        ],
        'Country': 'US',
        'Name': 'Columbia IX',
        'LocationType': 'Test',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/99999',
        'Ipv4PrefixList': [
          '10.12.97.128/26'
        ],
        'Ipv6PrefixList': [],
        'MicrosoftSessionIpv4AddressList': [
          '10.12.97.129'
        ],
        'MicrosoftSessionIpv6AddressList': [],
        'Bandwidth': 10000,
        'Devices': {
          'co1-96c-1a': {
            'DeviceType': 'None',
            'PortChannels': {},
            'Ports': {
              'xe-9/3/2.0': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [
                  '10.12.97.129/32'
                ],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              },
              'xe-9/3/2': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              }
            }
          }
        }
      },
      '11': {
        'CodeList': [
          'wst'
        ],
        'Country': 'US',
        'Name': 'Equinix Seattle',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/11',
        'Ipv4PrefixList': [
          '198.32.134.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:12::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '198.32.134.152'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:12::15'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'wst-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel1': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '13': {
        'CodeList': [
          'wst'
        ],
        'Country': 'US',
        'Name': 'SIX Seattle',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/13',
        'Ipv4PrefixList': [
          '206.81.80.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:504:16::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.81.80.30',
          '206.81.80.68'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:16::1f8b',
          '2001:504:16::68:0:1f8b'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'wst-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel5': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'wst-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel1': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '1174': {
        'CodeList': [
          'wst'
        ],
        'Country': 'US',
        'Name': 'MegaIX Seattle',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1174',
        'Ipv4PrefixList': [
          '206.53.171.0/24'
        ],
        'Ipv6PrefixList': [
          '2606:a980:0:4::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.53.171.13'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2606:a980:0:4::d'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'wst-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel8': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '82': {
        'CodeList': [
          'wst'
        ],
        'Country': 'US',
        'Name': 'PacificWave',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/82',
        'Ipv4PrefixList': [
          '207.231.240.0/25',
          '207.231.241.0/24',
          '207.231.242.0/25',
          '207.231.243.0/24',
          '207.231.245.0/24',
          '207.231.248.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:b:10::/64',
          '2001:504:b:11::/64',
          '2001:504:b:80::/64',
          '2001:504:b:81::/64',
          '2001:504:b:88::/64',
          '2001:504:b:89::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '207.231.240.7',
          '207.231.241.7',
          '207.231.242.7',
          '207.231.243.7',
          '207.231.245.7',
          '207.231.248.7'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:b:10::7',
          '2001:504:b:11::7',
          '2001:504:b:80::7',
          '2001:504:b:81::7',
          '2001:504:b:88::7',
          '2001:504:b:89::7'
        ],
        'Bandwidth': 100000,
        'Devices': {
          'wst-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {},
            'Ports': {
              'et-7/0/2.706': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              },
              'et-7/0/2.707': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              },
              'et-7/0/2.776': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              },
              'et-7/0/2.777': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              },
              'et-7/0/2.778': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              },
              'et-7/0/2.779': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              }
            }
          }
        }
      }
    }
  },
  {
    'LocationName': 'Manchester',
    'AzureRegion': 'UK West',
    'PrivatePeeringFacilityMap': {
      '76': {
        'CodeList': [
          'man30'
        ],
        'Country': 'GB',
        'Address': 'Manchester Science Park',
        'Latitude': 53.463112,
        'Longitude': -2.236869,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/76',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '583': {
        'CodeList': [
          'man30'
        ],
        'Country': 'GB',
        'Name': 'LINX Manchester',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/583',
        'Ipv4PrefixList': [
          '195.66.244.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:4:2::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '195.66.244.82',
          '195.66.244.116'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:4:2::1f8b:1',
          '2001:7f8:4:2::1f8b:2'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'man30-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel3': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'man30-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel64': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '1927': {
        'CodeList': [
          'man30'
        ],
        'Country': 'GB',
        'Name': 'Equinix Manchester',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1927',
        'Ipv4PrefixList': [
          '185.1.101.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:bc::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '185.1.101.31'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:bc::8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'man30-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel63': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Zurich',
    'AzureRegion': 'France Central',
    'PrivatePeeringFacilityMap': {
      '81': {
        'CodeList': [
          'zrh'
        ],
        'Country': 'CH',
        'Address': 'Sagereistrasse 35',
        'Latitude': 47.433041,
        'Longitude': 8.557414,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/81',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '29': {
        'CodeList': [
          'zrh'
        ],
        'Country': 'CH',
        'Name': 'Equinix Zurich',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/29',
        'Ipv4PrefixList': [
          '194.42.48.0/25'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:c:8235:194:42:48:0/112'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '194.42.48.50'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:c:8235:194:42:48:50'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'zrh-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel62': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '60': {
        'CodeList': [
          'zrh'
        ],
        'Country': 'CH',
        'Name': 'SwissIX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/60',
        'Ipv4PrefixList': [
          '91.206.52.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:24::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '91.206.52.152'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:24::98'
        ],
        'Bandwidth': 100000,
        'Devices': {
          'zrh-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel60': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Barcelona',
    'AzureRegion': 'France Central',
    'PrivatePeeringFacilityMap': {
      '122': {
        'CodeList': [
          'bcn30'
        ],
        'Country': 'ES',
        'Address': 'Carrer de l`Acer 30-32',
        'Latitude': 41.351557,
        'Longitude': 2.137457,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/122',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '62': {
        'CodeList': [
          'bcn30'
        ],
        'Country': 'ES',
        'Name': 'CATNIX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/62',
        'Ipv4PrefixList': [
          '193.242.98.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:2a::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '193.242.98.152'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:2a:0:2:1:0:8075'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'bcn30-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel15': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Lisbon',
    'AzureRegion': 'France Central',
    'PrivatePeeringFacilityMap': {
      '126': {
        'CodeList': [
          'lis01'
        ],
        'Country': 'PT',
        'Address': 'Av. Severiano Falcao, 14',
        'Latitude': 38.787923,
        'Longitude': -9.12364,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/126',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '72': {
        'CodeList': [
          'lis01'
        ],
        'Country': 'PT',
        'Name': 'GigaPIX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/72',
        'Ipv4PrefixList': [
          '193.136.250.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:a:1::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '193.136.250.60'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:a:1::6'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'lis01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel3': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Madrid',
    'AzureRegion': 'France Central',
    'PrivatePeeringFacilityMap': {
      '130': {
        'CodeList': [
          'mad30'
        ],
        'Country': 'ES',
        'Address': 'C/ Albasanz 71',
        'Latitude': 40.439323,
        'Longitude': -3.621211,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/130',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '63': {
        'CodeList': [
          'mad30'
        ],
        'Country': 'ES',
        'Name': 'ESPANIX Madrid Lower LAN',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/63',
        'Ipv4PrefixList': [
          '193.149.1.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:f::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '193.149.1.29'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:f::70'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'mad30-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel20': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '1146': {
        'CodeList': [
          'mad30'
        ],
        'Country': 'ES',
        'Name': 'ESPANIX Madrid Upper LAN',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1146',
        'Ipv4PrefixList': [
          '185.79.175.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:f:1::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '185.79.175.184'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:f:1::70'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'mad30-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel10': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '1277': {
        'CodeList': [
          'mad30'
        ],
        'Country': 'ES',
        'Name': 'DE-CIX Madrid',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1277',
        'Ipv4PrefixList': [
          '185.1.68.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:a0::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '185.1.68.16'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:a0::1f8b:0:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'mad30-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel25': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Sydney',
    'AzureRegion': 'Australia East',
    'PrivatePeeringFacilityMap': {
      '131': {
        'CodeList': [
          'syd'
        ],
        'Country': 'AU',
        'Address': 'Unit B 639 Gardeners Road',
        'Latitude': -33.921391,
        'Longitude': 151.188147,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/131',
        'Devices': {}
      },
      '1660': {
        'CodeList': [
          'syd'
        ],
        'Country': 'AU',
        'Address': '4 Eden Park Drive',
        'Latitude': -33.785169,
        'Longitude': 151.131515,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1660',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '94': {
        'CodeList': [
          'syd'
        ],
        'Country': 'AU',
        'Name': 'Equinix Sydney',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/94',
        'Ipv4PrefixList': [
          '45.127.172.0/22'
        ],
        'Ipv6PrefixList': [
          '2001:de8:6::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '45.127.172.36'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:de8:6::1:2076:1'
        ],
        'Bandwidth': 100000,
        'Devices': {
          'syd-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel3.599': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '780': {
        'CodeList': [
          'syd'
        ],
        'Country': 'AU',
        'Name': 'MegaIX Sydney',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/780',
        'Ipv4PrefixList': [
          '103.26.68.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:dea:0:10::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '103.26.68.7'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:dea:0:10::7'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'syd-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel2': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '716': {
        'CodeList': [
          'syd'
        ],
        'Country': 'AU',
        'Name': 'New South Wales Internet Exchange',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/716',
        'Ipv4PrefixList': [
          '218.100.52.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:7fa:11:4::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '218.100.52.4'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7fa:11:4:0:2f2c:0:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'syd-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel0': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '105': {
        'CodeList': [
          'syd'
        ],
        'Country': 'AU',
        'Name': 'PIPE Networks Sydney',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/105',
        'Ipv4PrefixList': [
          '218.100.2.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7fa:b::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '218.100.2.162'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7fa:b::162'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'syd-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel0': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Tokyo',
    'AzureRegion': 'Japan East',
    'PrivatePeeringFacilityMap': {
      '142': {
        'CodeList': [
          'tya'
        ],
        'Country': 'JP',
        'Address': 'Otemachi Building',
        'Latitude': 35.687178,
        'Longitude': 139.765453,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/142',
        'Devices': {}
      },
      '599': {
        'CodeList': [
          'tyb'
        ],
        'Country': 'JP',
        'Address': 'ComSpace Bldg.',
        'Latitude': 35.687467,
        'Longitude': 139.779481,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/599',
        'Devices': {}
      },
      '1893': {
        'CodeList': [
          'tya'
        ],
        'Country': 'JP',
        'Address': 'Otemachi Finance City',
        'Latitude': 35.688288,
        'Longitude': 139.765927,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1893',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '167': {
        'CodeList': [
          'tyb'
        ],
        'Country': 'JP',
        'Name': 'Equinix Tokyo',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/167',
        'Ipv4PrefixList': [
          '203.190.230.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:de8:5::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '203.190.230.24'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:de8:5::8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'tyb-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel5.599': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '30': {
        'CodeList': [
          'tya',
          'tyb'
        ],
        'Country': 'JP',
        'Name': 'JPIX TOKYO',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/30',
        'Ipv4PrefixList': [
          '210.171.224.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:de8:8::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '210.171.224.116',
          '210.171.224.110'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:de8:8::8075:2',
          '2001:de8:8::8075:1'
        ],
        'Bandwidth': 100000,
        'Devices': {
          'tya-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel0': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'tyb-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel3': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '126': {
        'CodeList': [
          'tyb'
        ],
        'Country': 'JP',
        'Name': 'BBIX Tokyo',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/126',
        'Ipv4PrefixList': [
          '218.100.6.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:de8:c::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '218.100.6.76'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:de8:c::8075:1'
        ],
        'Bandwidth': 100000,
        'Devices': {
          'tyb-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel4': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '95': {
        'CodeList': [
          'tya'
        ],
        'Country': 'JP',
        'Name': 'JPNAP Tokyo',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/95',
        'Ipv4PrefixList': [
          '210.173.176.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7fa:7:1::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '210.173.176.16'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7fa:7:1::8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'tya-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel7': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Seoul',
    'AzureRegion': 'Korea Central',
    'PrivatePeeringFacilityMap': {
      '143': {
        'CodeList': [
          'sla'
        ],
        'Country': 'KR',
        'Address': '3F LG CNS Bldg',
        'Latitude': 37.482197,
        'Longitude': 126.87988,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/143',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '52': {
        'CodeList': [
          'sla'
        ],
        'Country': 'KR',
        'Name': 'KINX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/52',
        'Ipv4PrefixList': [
          '192.145.251.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7fa:8::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '192.145.251.47',
          '192.145.251.48'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7fa:8::13',
          '2001:7fa:8::14'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'sla-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel2': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'sla-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel63': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Copenhagen',
    'AzureRegion': 'West Europe',
    'PrivatePeeringFacilityMap': {
      '148': {
        'CodeList': [
          'cph30'
        ],
        'Country': 'DK',
        'Address': 'Industriparken 20A',
        'Latitude': 55.728092,
        'Longitude': 12.377482,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/148',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '78': {
        'CodeList': [
          'cph30'
        ],
        'Country': 'DK',
        'Name': 'DIX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/78',
        'Ipv4PrefixList': [
          '192.38.7.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:1f::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '192.38.7.76'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:1f::8075:76:0'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'cph30-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel20': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '193': {
        'CodeList': [
          'cph30'
        ],
        'Country': 'SE',
        'Name': 'Netnod Copenhagen',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/193',
        'Ipv4PrefixList': [
          '212.237.192.0/24',
          '212.237.193.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:d:202::/64',
          '2001:7f8:d:203::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '212.237.192.181',
          '212.237.193.181'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:d:202::181',
          '2001:7f8:d:203::181'
        ],
        'Bandwidth': 40000,
        'Devices': {
          'cph30-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel5.410': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              },
              'PortChannel5.420': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '64': {
        'CodeList': [
          'cph30'
        ],
        'Country': 'NL',
        'Name': 'NL-IX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/64',
        'Ipv4PrefixList': [
          '193.239.116.0/22'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:13::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '193.239.118.172'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:13::a500:8075:4'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'cph30-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel62.7': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Stockholm',
    'AzureRegion': 'West Europe',
    'PrivatePeeringFacilityMap': {
      '156': {
        'CodeList': [
          'sto'
        ],
        'Country': 'SE',
        'Address': 'Mariehällsvägen 36',
        'Latitude': 59.362574,
        'Longitude': 17.955657,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/156',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '70': {
        'CodeList': [
          'sto'
        ],
        'Country': 'SE',
        'Name': 'Netnod Stockholm',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/70',
        'Ipv4PrefixList': [
          '195.245.240.0/24',
          '194.68.123.0/24',
          '194.68.128.0/24',
          '195.69.119.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:d:fc::/64',
          '2001:7f8:d:fb::/64',
          '2001:7f8:d:fe::/64',
          '2001:7f8:d:ff::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '195.245.240.181',
          '194.68.123.181',
          '194.68.128.181',
          '195.69.119.181'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:d:fc::181',
          '2001:7f8:d:fb::181',
          '2001:7f8:d:fe::181',
          '2001:7f8:d:ff::181'
        ],
        'Bandwidth': 100000,
        'Devices': {
          'sto-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel12.15': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              },
              'PortChannel12.16': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'sto-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel3.15': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              },
              'PortChannel3.16': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '172': {
        'CodeList': [
          'sto'
        ],
        'Country': 'SE',
        'Name': 'STHIX - Stockholm',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/172',
        'Ipv4PrefixList': [
          '192.121.80.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:3e::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '192.121.80.59'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:3e:0:a500:0:8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'sto-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel8': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '1923': {
        'CodeList': [
          'sto'
        ],
        'Country': 'SE',
        'Name': 'Equinix Stockholm',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1923',
        'Ipv4PrefixList': [
          '185.1.107.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:c1::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '185.1.107.34'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:c1::8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'sto-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel64': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Dublin',
    'AzureRegion': 'North Europe',
    'PrivatePeeringFacilityMap': {
      '164': {
        'CodeList': [
          'db3'
        ],
        'Country': 'IE',
        'Address': 'Unit 4027, Kingswood Road',
        'Latitude': 53.296306,
        'Longitude': -6.41897,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/164',
        'Devices': {}
      },
      '177': {
        'CodeList': [
          'db3'
        ],
        'Country': 'IE',
        'Address': 'Unit 35 Lavery Avenue',
        'Latitude': 53.334251,
        'Longitude': -6.365538,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/177',
        'Devices': {}
      },
      '1065': {
        'CodeList': [
          'db3'
        ],
        'Country': 'IE',
        'Address': 'Unit 2, North West Business Park',
        'Latitude': 53.411166,
        'Longitude': -6.347409,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1065',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '48': {
        'CodeList': [
          'dub30'
        ],
        'Country': 'IE',
        'Name': 'INEX LAN1',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/48',
        'Ipv4PrefixList': [
          '185.6.36.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:18::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '185.6.36.28'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:18::28'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'dub30-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel15': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '1926': {
        'CodeList': [
          'dub30'
        ],
        'Country': 'IE',
        'Name': 'Equinix Dublin',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1926',
        'Ipv4PrefixList': [
          '185.1.109.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:c3::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '185.1.109.26'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:c3::8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'dub30-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel60': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Sao Paulo',
    'AzureRegion': 'Brazil South',
    'PrivatePeeringFacilityMap': {
      '165': {
        'CodeList': [
          'gru'
        ],
        'Country': 'BR',
        'Address': 'Ceci Avenue, 1900',
        'Latitude': -23.492585,
        'Longitude': -46.808371,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/165',
        'Devices': {}
      },
      '1283': {
        'CodeList': [
          'sao03'
        ],
        'Country': 'BR',
        'Address': 'Alameda Araguaia 3641',
        'Latitude': -23.502585,
        'Longitude': -46.827139,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1283',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '415': {
        'CodeList': [
          'cpq01'
        ],
        'Country': 'BR',
        'Name': 'IX.br (PTT.br) Campinas',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/415',
        'Ipv4PrefixList': [
          '200.192.108.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:12f8:0:11::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '200.192.108.42'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:12f8:0:11::42'
        ],
        'Bandwidth': 60000,
        'Devices': {
          'cpq01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel8.10': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              },
              'PortChannel8.20': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '119': {
        'CodeList': [
          'gru'
        ],
        'Country': 'BR',
        'Name': 'Equinix Sao Paulo',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/119',
        'Ipv4PrefixList': [
          '198.32.122.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:478:122::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '198.32.122.57',
          '198.32.122.60'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:478:122::3c',
          '2001:478:122::39'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'gru-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel2': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'gru-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel2': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '171': {
        'CodeList': [
          'sao03'
        ],
        'Country': 'BR',
        'Name': 'IX.br (PTT.br) Sao Paulo',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/171',
        'Ipv4PrefixList': [
          '187.16.216.0/21'
        ],
        'Ipv6PrefixList': [
          '2001:12f8::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '187.16.218.139',
          '187.16.218.144'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:12f8::218:139',
          '2001:12f8::218:144'
        ],
        'Bandwidth': 200000,
        'Devices': {
          'sao03-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel1.3543': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              },
              'PortChannel1.3544': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'sao03-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel13.3564': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              },
              'PortChannel13.3565': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Hong Kong',
    'AzureRegion': 'East Asia',
    'PrivatePeeringFacilityMap': {
      '170': {
        'CodeList': [
          'hkb'
        ],
        'Country': 'HK',
        'Address': '17/F Global Gateway',
        'Latitude': 22.365483,
        'Longitude': 114.119317,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/170',
        'Devices': {}
      },
      '225': {
        'CodeList': [
          'hkg'
        ],
        'Country': 'HK',
        'Address': '399 Chai Wan Road',
        'Latitude': 22.266098,
        'Longitude': 114.246512,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/225',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '125': {
        'CodeList': [
          'hkb'
        ],
        'Country': 'HK',
        'Name': 'Equinix Hong Kong',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/125',
        'Ipv4PrefixList': [
          '119.27.63.0/24',
          '36.255.56.0/22'
        ],
        'Ipv6PrefixList': [
          '2001:de8:7::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '119.27.63.4',
          '36.255.56.4'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:de8:7::8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'hkb-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel9.599': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '577': {
        'CodeList': [
          'hkg'
        ],
        'Country': 'HK',
        'Name': 'AMS-IX Hong Kong',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/577',
        'Ipv4PrefixList': [
          '103.247.139.0/25'
        ],
        'Ipv6PrefixList': [
          '2001:df0:296::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '103.247.139.28'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:df0:296::a500:8075:1'
        ],
        'Bandwidth': 20000,
        'Devices': {
          'hkg-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel60': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '42': {
        'CodeList': [
          'hkb'
        ],
        'Country': 'HK',
        'Name': 'HKIX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/42',
        'Ipv4PrefixList': [
          '123.255.88.0/21'
        ],
        'Ipv6PrefixList': [
          '2001:7fa:0:1::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '123.255.91.120',
          '123.255.90.222'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7fa:0:1::ca28:a178',
          '2001:7fa:0:1::ca28:a0de'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'hkb-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel62': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'hkb-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel64': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '1449': {
        'CodeList': [
          'hkg30'
        ],
        'Country': 'HK',
        'Name': 'BBIX Hong Kong',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1449',
        'Ipv4PrefixList': [
          '103.203.158.0/23'
        ],
        'Ipv6PrefixList': [
          '2403:c780:b800:bb00::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '103.203.158.102'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2403:c780:b800:bb00::8075:2'
        ],
        'Bandwidth': 30000,
        'Devices': {
          'ier02.hkg30': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel60': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Prague',
    'AzureRegion': 'West Europe',
    'PrivatePeeringFacilityMap': {
      '214': {
        'CodeList': [
          'prg01'
        ],
        'Country': 'CZ',
        'Address': 'Nad Elektrarnou 1428/47',
        'Latitude': 50.060164,
        'Longitude': 14.482978,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/214',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '71': {
        'CodeList': [
          'prg01'
        ],
        'Country': 'CZ',
        'Name': 'NIX.CZ',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/71',
        'Ipv4PrefixList': [
          '91.210.16.0/22'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:14::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '91.210.16.115'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:14::6b:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'prg01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {},
            'Ports': {
              'et-1/1/0.10': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              }
            }
          }
        }
      },
      '713': {
        'CodeList': [
          'prg01'
        ],
        'Country': 'CZ',
        'Name': 'Peering.cz',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/713',
        'Ipv4PrefixList': [
          '91.213.211.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:7f::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '91.213.211.214'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:7f::214'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'prg01-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel1': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Marseille',
    'AzureRegion': 'France Central',
    'PrivatePeeringFacilityMap': {
      '226': {
        'CodeList': [
          'mrs02'
        ],
        'Country': 'FR',
        'Address': '40 avenue Roger Salengro',
        'Latitude': 43.310381,
        'Longitude': 5.373342,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/226',
        'Devices': {}
      },
      '1879': {
        'CodeList': [
          'mrs01'
        ],
        'Country': 'FR',
        'Address': '71 Avenue André Roussin',
        'Latitude': 43.360546,
        'Longitude': 5.338242,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1879',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '880': {
        'CodeList': [
          'mrs01'
        ],
        'Country': 'FR',
        'Name': 'France-IX Marseille',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/880',
        'Ipv4PrefixList': [
          '37.49.232.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:54:5::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '37.49.232.14'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:54:5::14'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'mrs01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel6': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '1149': {
        'CodeList': [
          'mrs01'
        ],
        'Country': 'FR',
        'Name': 'DE-CIX Marseille',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1149',
        'Ipv4PrefixList': [
          '185.1.47.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:36::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '185.1.47.13'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:36::1f8b:0:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'mrs01-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel15': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Singapore',
    'AzureRegion': 'Southeast Asia',
    'PrivatePeeringFacilityMap': {
      '282': {
        'CodeList': [
          'sge'
        ],
        'Country': 'SG',
        'Address': '20 Ayer Rajah Crescent',
        'Latitude': 1.295229,
        'Longitude': 103.789842,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/282',
        'Devices': {}
      },
      '388': {
        'CodeList': [
          'sg1'
        ],
        'Country': 'SG',
        'Address': ' 2 TAI SENG AVENUE',
        'Latitude': 1.336441,
        'Longitude': 103.893491,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/388',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '93': {
        'CodeList': [
          'sg1'
        ],
        'Country': 'SG',
        'Name': 'SOX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/93',
        'Ipv4PrefixList': [
          '198.32.141.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:de8:d::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '198.32.141.141'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:de8:d::8069:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'sg1-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {},
            'Ports': {
              'xe-2/1/2:0': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              }
            }
          },
          'ier02.sg1': {
            'DeviceType': 'None',
            'PortChannels': {},
            'Ports': {
              'et-0/0/26:3': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              }
            }
          }
        }
      },
      '429': {
        'CodeList': [
          'sg1'
        ],
        'Country': 'SG',
        'Name': 'SGIX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/429',
        'Ipv4PrefixList': [
          '103.16.102.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:de8:12:100::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '103.16.102.23'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:de8:12:100::23'
        ],
        'Bandwidth': 30000,
        'Devices': {
          'ier01.sg1': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel62': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'sg1-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel60': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '158': {
        'CodeList': [
          'sge'
        ],
        'Country': 'SG',
        'Name': 'Equinix Singapore',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/158',
        'Ipv4PrefixList': [
          '27.111.228.0/22'
        ],
        'Ipv6PrefixList': [
          '2001:de8:4::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '27.111.228.57',
          '27.111.229.172'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:de8:4::8075:1',
          '2001:de8:4::8075:2'
        ],
        'Bandwidth': 100000,
        'Devices': {
          'sge-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel10.599': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'sge-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel61': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '965': {
        'CodeList': [
          'sge'
        ],
        'Country': 'SG',
        'Name': 'MegaIX Singapore',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/965',
        'Ipv4PrefixList': [
          '103.41.12.0/22'
        ],
        'Ipv6PrefixList': [
          '2001:ded::/48'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '103.41.12.23'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:ded::17'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'sge-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel12': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '909': {
        'CodeList': [
          'sge'
        ],
        'Country': 'SG',
        'Name': 'BBIX Singapore',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/909',
        'Ipv4PrefixList': [
          '103.231.152.0/22'
        ],
        'Ipv6PrefixList': [
          '2001:df5:b800:bb00::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '103.231.152.101'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:df5:b800:bb00::8075:1'
        ],
        'Bandwidth': 30000,
        'Devices': {
          'sge-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel3': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Budapest',
    'AzureRegion': 'West Europe',
    'PrivatePeeringFacilityMap': {
      '301': {
        'CodeList': [
          'bud01'
        ],
        'Country': 'HU',
        'Address': 'Asztalos Sandor u. 13.',
        'Latitude': 47.493244,
        'Longitude': 19.102328,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/301',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '55': {
        'CodeList': [
          'bud01'
        ],
        'Country': 'HU',
        'Name': 'BiX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/55',
        'Ipv4PrefixList': [
          '193.188.137.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:35::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '193.188.137.21',
          '193.188.137.51'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:35::8075:1',
          '2001:7f8:35::8075:2'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'bud01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel62.10': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              },
              'PortChannel62.11': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'bud01-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel63.10': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              },
              'PortChannel63.11': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Moscow',
    'AzureRegion': 'West Europe',
    'PrivatePeeringFacilityMap': {
      '349': {
        'CodeList': [
          'msa'
        ],
        'Country': 'RU',
        'Address': '8 Marta 14',
        'Latitude': 55.805323,
        'Longitude': 37.551781,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/349',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '100': {
        'CodeList': [
          'msa'
        ],
        'Country': 'RU',
        'Name': 'MSK-IX Moscow',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/100',
        'Ipv4PrefixList': [
          '195.208.208.0/21'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:20:101::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '195.208.208.137'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:20:101::208:137'
        ],
        'Bandwidth': 200000,
        'Devices': {
          'msa-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel4': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '358': {
        'CodeList': [
          'msa'
        ],
        'Country': 'RU',
        'Name': 'DATAIX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/358',
        'Ipv4PrefixList': [
          '178.18.224.0/22'
        ],
        'Ipv6PrefixList': [
          '2a03:5f80:4::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '178.18.225.38'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2a03:5f80:4::225:38'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'msa-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel2': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Denver',
    'AzureRegion': 'West Central US',
    'PrivatePeeringFacilityMap': {
      '389': {
        'CodeList': [
          'den02'
        ],
        'Country': 'US',
        'Address': '910 15th Street',
        'Latitude': 39.745636,
        'Longitude': -104.995636,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/389',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '254': {
        'CodeList': [
          'den02'
        ],
        'Country': 'US',
        'Name': 'CoreSite - Any2 Denver ',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/254',
        'Ipv4PrefixList': [
          '206.51.46.0/24',
          '198.32.216.0/24'
        ],
        'Ipv6PrefixList': [
          '2605:6c00:303:303::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.51.46.72',
          '206.51.46.100',
          '198.32.216.72'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2605:6c00:303:303::72',
          '2605:6c00:303:303::100'
        ],
        'Bandwidth': 20000,
        'Devices': {
          'den02-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel12': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'den02-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel2': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Bucharest',
    'AzureRegion': 'France Central',
    'PrivatePeeringFacilityMap': {
      '439': {
        'CodeList': [
          'buh01'
        ],
        'Country': 'RO',
        'Address': '8, Dimitrie Pompeiu Blvd., 3rd fl.',
        'Latitude': 44.48049,
        'Longitude': 26.117669,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/439',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '372': {
        'CodeList': [
          'buh01'
        ],
        'Country': 'RO',
        'Name': 'Balcan-IX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/372',
        'Ipv4PrefixList': [
          '80.97.248.0/23',
          '86.104.125.0/24'
        ],
        'Ipv6PrefixList': [
          '2a02:d10:80::/64',
          '2001:7f8:64:225::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '80.97.248.52',
          '80.97.248.76',
          '86.104.125.130'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2a02:d10:80::13',
          '2a02:d10:80::32',
          '2001:7f8:64:225::8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'buh01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel7': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              },
              'PortChannel60': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'buh01-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel61': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '301': {
        'CodeList': [
          'buh01'
        ],
        'Country': 'RO',
        'Name': 'RoNIX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/301',
        'Ipv4PrefixList': [
          '217.156.113.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:49::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '217.156.113.88'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:49::88'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'buh01-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {},
            'Ports': {
              'xe-0/0/0:2': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              }
            }
          }
        }
      }
    }
  },
  {
    'LocationName': 'Taipei',
    'AzureRegion': 'East Asia',
    'PrivatePeeringFacilityMap': {
      '456': {
        'CodeList': [
          'tpe31'
        ],
        'Country': 'TW',
        'Address': 'No. 250, Yang-Guang Street, Nei-hu District',
        'Latitude': 25.073467,
        'Longitude': 121.577519,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/456',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '823': {
        'CodeList': [
          'tpe31'
        ],
        'Country': 'TW',
        'Name': 'TPIX-TW',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/823',
        'Ipv4PrefixList': [
          '203.163.222.0/24'
        ],
        'Ipv6PrefixList': [
          '2406:d400:1:133:203:163:222:0/112'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '203.163.222.15',
          '203.163.222.85'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2406:d400:1:133:203:163:222:15',
          '2406:d400:1:133:203:163:222:85'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'tpe31-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel9': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'tpe31-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel60': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Kuala Lumpur',
    'AzureRegion': 'Southeast Asia',
    'PrivatePeeringFacilityMap': {
      '460': {
        'CodeList': [
          'kul30'
        ],
        'Country': 'MY',
        'Address': 'Ground Floor, Menara AIMS',
        'Latitude': 3.14969,
        'Longitude': 101.70634,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/460',
        'Devices': {}
      },
      '1279': {
        'CodeList': [
          'kul01'
        ],
        'Country': 'MY',
        'Address': 'CSF Building, Computer Exchange',
        'Latitude': 2.913224,
        'Longitude': 101.655646,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1279',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '250': {
        'CodeList': [
          'kul30'
        ],
        'Country': 'MY',
        'Name': 'MyIX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/250',
        'Ipv4PrefixList': [
          '218.100.44.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:de8:10::/48'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '218.100.44.214',
          '218.100.44.154'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:de8:10::54',
          '2001:de8:10::a9'
        ],
        'Bandwidth': 20000,
        'Devices': {
          'kul30-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel3.200': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'kul30-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel3': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Berlin',
    'AzureRegion': 'West Europe',
    'PrivatePeeringFacilityMap': {
      '478': {
        'CodeList': [
          'ber30'
        ],
        'Country': 'DE',
        'Address': 'Nonnendammallee 15',
        'Latitude': 52.538479,
        'Longitude': 13.237136,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/478',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '87': {
        'CodeList': [
          'ber30'
        ],
        'Country': 'DE',
        'Name': 'BCIX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/87',
        'Ipv4PrefixList': [
          '193.178.185.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:19:1::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '193.178.185.84',
          '193.178.185.104'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:19:1::1f8b:1',
          '2001:7f8:19:1::1f8b:2'
        ],
        'Bandwidth': 50000,
        'Devices': {
          'ber30-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel1': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'ber30-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel2': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '209': {
        'CodeList': [
          'ber30'
        ],
        'Country': 'DE',
        'Name': 'ECIX-BER',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/209',
        'Ipv4PrefixList': [
          '194.9.117.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:8:5::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '194.9.117.84'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:8:5:0:1f8b:0:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'ber30-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel10': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Warsaw',
    'AzureRegion': 'West Europe',
    'PrivatePeeringFacilityMap': {
      '509': {
        'CodeList': [
          'waw01'
        ],
        'Country': 'PL',
        'Address': 'Al. Jerozolimskie 65/79',
        'Latitude': 52.227765,
        'Longitude': 21.004906,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/509',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '264': {
        'CodeList': [
          'waw01'
        ],
        'Country': 'PL',
        'Name': 'Equinix Warsaw (PLIX)',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/264',
        'Ipv4PrefixList': [
          '195.182.218.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:42::/48'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '195.182.218.146',
          '195.182.218.167'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:42::a500:8075:1',
          '2001:7f8:42::a500:8075:2'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'waw01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel6': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'waw01-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel6': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '482': {
        'CodeList': [
          'waw01'
        ],
        'Country': 'PL',
        'Name': 'TPIX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/482',
        'Ipv4PrefixList': [
          '195.149.232.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:27::/48'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '195.149.232.50'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:27::8075:1'
        ],
        'Bandwidth': 20000,
        'Devices': {
          'waw01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel10': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Chennai',
    'AzureRegion': 'South India',
    'PrivatePeeringFacilityMap': {
      '552': {
        'CodeList': [
          'maa02'
        ],
        'Country': 'IN',
        'Address': '4th floor, 2nd block',
        'Latitude': 13.0839,
        'Longitude': 80.27,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/552',
        'Devices': {}
      },
      '2006': {
        'CodeList': [
          'maa30'
        ],
        'Country': 'IN',
        'Address': 'Bharti Towers',
        'Latitude': 13.026469,
        'Longitude': 80.27241,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/2006',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '1786': {
        'CodeList': [
          'maa02'
        ],
        'Country': 'IN',
        'Name': 'Extreme IX Chennai',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1786',
        'Ipv4PrefixList': [
          '45.120.251.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:df2:1900:3::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '45.120.251.137'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:df2:1900:3::137'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'maa02-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel61': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Mumbai',
    'AzureRegion': 'West India',
    'PrivatePeeringFacilityMap': {
      '554': {
        'CodeList': [
          'bom02'
        ],
        'Country': 'IN',
        'Address': 'Kashinath Dhuru Marg',
        'Latitude': 19.020332,
        'Longitude': 72.831549999999993,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/554',
        'Devices': {}
      },
      '2046': {
        'CodeList': [
          'bom30'
        ],
        'Country': 'IN',
        'Address': 'Plot No, TPS-2, 14/3, 2nd floor',
        'Latitude': 19.066874,
        'Longitude': 72.835432,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/2046',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '1623': {
        'CodeList': [
          'bom02'
        ],
        'Country': 'IN',
        'Name': 'AMS-IX India',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1623',
        'Ipv4PrefixList': [
          '223.31.200.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:e48:44:100b::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '223.31.200.19'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:e48:44:100b:0:a500:8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'bom02-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel61': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '1627': {
        'CodeList': [
          'bom02'
        ],
        'Country': 'IN',
        'Name': 'Extreme IX Mumbai',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1627',
        'Ipv4PrefixList': [
          '103.77.108.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:df2:1900:2::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '103.77.108.128'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:df2:1900:2::128'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'bom02-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel68': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Perth',
    'AzureRegion': 'Australia Central',
    'PrivatePeeringFacilityMap': {
      '568': {
        'CodeList': [
          'per01'
        ],
        'Country': 'AU',
        'Address': '1 William Street',
        'Latitude': -31.955629,
        'Longitude': 115.855519,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/568',
        'Devices': {}
      },
      '1940': {
        'CodeList': [
          'per01'
        ],
        'Country': 'AU',
        'Address': '4 Millrose Drive',
        'Latitude': -31.864402,
        'Longitude': 115.895935,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1940',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '1235': {
        'CodeList': [
          'per01'
        ],
        'Country': 'AU',
        'Name': 'MegaIX Perth',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1235',
        'Ipv4PrefixList': [
          '202.12.243.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:dea:0:50::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '202.12.243.11'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:dea:0:50::b'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'per01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel8': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '21': {
        'CodeList': [
          'per01'
        ],
        'Country': 'AU',
        'Name': 'West Australian Internet Exchange (WAIX)',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/21',
        'Ipv4PrefixList': [
          '198.32.212.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7fa:11::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '198.32.212.95'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7fa:11::2f2c:0:1'
        ],
        'Bandwidth': 30000,
        'Devices': {
          'per01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel4': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Boston',
    'AzureRegion': 'East US',
    'PrivatePeeringFacilityMap': {
      '584': {
        'CodeList': [
          'bos01'
        ],
        'Country': 'US',
        'Address': '70 Innerbelt Rd',
        'Latitude': 42.376703,
        'Longitude': -71.079763,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/584',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '565': {
        'CodeList': [
          'bos01'
        ],
        'Country': 'US',
        'Name': 'Boston Internet Exchange',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/565',
        'Ipv4PrefixList': [
          '206.108.236.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:24:1::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.108.236.10'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:24:1::1f8b:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'bos01-96e-1': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel13': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '333': {
        'CodeList': [
          'bos01'
        ],
        'Country': 'US',
        'Name': 'CoreSite - Any2 Boston',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/333',
        'Ipv4PrefixList': [
          '206.51.42.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:13:7::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.51.42.10'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:13:7::10'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'bos01-96e-1': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel2': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '1086': {
        'CodeList': [
          'bos01'
        ],
        'Country': 'US',
        'Name': 'MASS-IX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1086',
        'Ipv4PrefixList': [
          '206.53.143.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:47::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.53.143.7'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:47::1f8b:0:1'
        ],
        'Bandwidth': 20000,
        'Devices': {
          'bos01-96e-1': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel5': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Sofia',
    'AzureRegion': 'France Central',
    'PrivatePeeringFacilityMap': {
      '663': {
        'CodeList': [
          'sof01'
        ],
        'Country': 'BG',
        'Address': '122 Ovcho Pole str.',
        'Latitude': 42.702735,
        'Longitude': 23.306259,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/663',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '326': {
        'CodeList': [
          'sof01'
        ],
        'Country': 'BG',
        'Name': 'B-IX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/326',
        'Ipv4PrefixList': [
          '185.1.30.0/24'
        ],
        'Ipv6PrefixList': [],
        'MicrosoftSessionIpv4AddressList': [
          '185.1.30.58'
        ],
        'MicrosoftSessionIpv6AddressList': [],
        'Bandwidth': 10000,
        'Devices': {
          'sof01-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {},
            'Ports': {
              'xe-0/2/3': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              }
            }
          }
        }
      },
      '331': {
        'CodeList': [
          'sof01'
        ],
        'Country': 'BG',
        'Name': 'BIX.BG',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/331',
        'Ipv4PrefixList': [
          '193.169.198.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:58::/48'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '193.169.198.74'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:58::1f8b:0:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'sof01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel7': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '699': {
        'CodeList': [
          'sof01'
        ],
        'Country': 'BG',
        'Name': 'NetIX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/699',
        'Ipv4PrefixList': [
          '193.218.0.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:67c:29f0::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '193.218.0.150'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:67c:29f0::8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'sof01-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel60': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '1056': {
        'CodeList': [
          'sof01'
        ],
        'Country': 'BG',
        'Name': 'MegaIX Sofia',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1056',
        'Ipv4PrefixList': [
          '91.212.235.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:9f::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '91.212.235.6'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:9f::6'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'sof01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel64': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Las Vegas',
    'AzureRegion': 'West US',
    'PrivatePeeringFacilityMap': {
      '770': {
        'CodeList': [
          'las01'
        ],
        'Country': 'US',
        'Address': '7135 S Decatur Boulevard',
        'Latitude': 36.059914,
        'Longitude': -115.210194,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/770',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '1628': {
        'CodeList': [
          'las01'
        ],
        'Country': 'US',
        'Name': 'MegaIX Las Vegas',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1628',
        'Ipv4PrefixList': [
          '206.53.205.0/24'
        ],
        'Ipv6PrefixList': [
          '2606:a980:0:9::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.53.205.6'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2606:a980:0:9::6'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'las01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel5': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Toronto',
    'AzureRegion': 'Canada Central',
    'PrivatePeeringFacilityMap': {
      '775': {
        'CodeList': [
          'yto01'
        ],
        'Country': 'CA',
        'Address': '151 Front St W.',
        'Latitude': 43.644632,
        'Longitude': -79.384228,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/775',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '24': {
        'CodeList': [
          'yto01'
        ],
        'Country': 'CA',
        'Name': 'TorIX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/24',
        'Ipv4PrefixList': [
          '206.108.34.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:504:1a::34:0/111'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.108.35.109',
          '206.108.34.160'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:1a::35:109',
          '2001:504:1a::34:160'
        ],
        'Bandwidth': 100000,
        'Devices': {
          'yto01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel10': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'yto01-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel64': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '1307': {
        'CodeList': [
          'yto01'
        ],
        'Country': 'CA',
        'Name': 'MegaIX Toronto',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1307',
        'Ipv4PrefixList': [
          '206.53.203.0/24'
        ],
        'Ipv6PrefixList': [
          '2606:a980:0:8::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.53.203.7'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2606:a980:0:8::7'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'yto01-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel4': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Johannesburg',
    'AzureRegion': 'South Africa North',
    'PrivatePeeringFacilityMap': {
      '850': {
        'CodeList': [
          'jnb02'
        ],
        'Country': 'ZA',
        'Address': '5 Brewery Street',
        'Latitude': -26.13778,
        'Longitude': 28.19756,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/850',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '592': {
        'CodeList': [
          'jnb02'
        ],
        'Country': 'ZA',
        'Name': 'NAPAfrica IX Johannesburg',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/592',
        'Ipv4PrefixList': [
          '196.60.8.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:43f8:6d0::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '196.60.8.133',
          '196.60.9.133'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:43f8:6d0::133',
          '2001:43f8:6d0::9:133'
        ],
        'Bandwidth': 40000,
        'Devices': {
          'jnb02-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel60': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'jnb02-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel60': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Osaka',
    'AzureRegion': 'Japan East',
    'PrivatePeeringFacilityMap': {
      '1157': {
        'CodeList': [
          'osa02'
        ],
        'Country': 'JP',
        'Address': 'NTT DATA Dojima Bldg',
        'Latitude': 34.695781,
        'Longitude': 135.491091,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1157',
        'Devices': {}
      },
      '2072': {
        'CodeList': [
          'osa30'
        ],
        'Country': 'JP',
        'Address': '3-1-7 Dojima, Kita-ku, Osaka-shi',
        'Latitude': 34.677851,
        'Longitude': 135.523562,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/2072',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '564': {
        'CodeList': [
          'osa02'
        ],
        'Country': 'JP',
        'Name': 'JPIX OSAKA',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/564',
        'Ipv4PrefixList': [
          '103.246.232.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:de8:8:6::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '103.246.232.116'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:de8:8:6::8075:1'
        ],
        'Bandwidth': 100000,
        'Devices': {
          'osa02-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel6': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '145': {
        'CodeList': [
          'osa30'
        ],
        'Country': 'JP',
        'Name': 'JPNAP Osaka',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/145',
        'Ipv4PrefixList': [
          '210.173.178.0/25'
        ],
        'Ipv6PrefixList': [
          '2001:7fa:7:2::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '210.173.178.16',
          '210.173.178.26'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7fa:7:2::8075:1',
          '2001:7fa:7:2::8075:2',
          '2001:7fa:7:2::8076:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'osa30-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel5': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              },
              'PortChannel62': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'osa30-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel63': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              },
              'PortChannel64': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '786': {
        'CodeList': [
          'osa30'
        ],
        'Country': 'JP',
        'Name': 'BBIX Osaka',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/786',
        'Ipv4PrefixList': [
          '218.100.9.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:de8:c:2::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '218.100.9.28'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:de8:c:2::8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'osa30-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel3': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Cape Town',
    'AzureRegion': 'South Africa North',
    'PrivatePeeringFacilityMap': {
      '1225': {
        'CodeList': [
          'cpt02'
        ],
        'Country': 'ZA',
        'Address': 'Great Westerford Building, 240 Main Road',
        'Latitude': -33.970872,
        'Longitude': 18.465223,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1225',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '597': {
        'CodeList': [
          'cpt02'
        ],
        'Country': 'ZA',
        'Name': 'NAPAfrica IX Cape Town',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/597',
        'Ipv4PrefixList': [
          '196.10.140.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:43f8:6d1::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '196.10.140.47',
          '196.10.140.147'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:43f8:6d1::47',
          '2001:43f8:6d1::147'
        ],
        'Bandwidth': 40000,
        'Devices': {
          'cpt02-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel60': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'cpt02-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel60': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Vancouver',
    'AzureRegion': 'West US 2',
    'PrivatePeeringFacilityMap': {
      '1330': {
        'CodeList': [
          'yvr01'
        ],
        'Country': 'CA',
        'Address': '555 West Hastings St',
        'Latitude': 49.284697,
        'Longitude': -123.111935,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1330',
        'Devices': {}
      },
      '1881': {
        'CodeList': [
          'yvr01'
        ],
        'Country': 'CA',
        'Address': '1050 W Pender Street',
        'Latitude': 49.286981,
        'Longitude': -123.119579,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1881',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '863': {
        'CodeList': [
          'yvr01'
        ],
        'Country': 'CA',
        'Name': 'VANIX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/863',
        'Ipv4PrefixList': [
          '206.41.104.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:39::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.41.104.41'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:39::41'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'yvr01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {},
            'Ports': {
              'xe-7/1/2:1': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              }
            }
          }
        }
      }
    }
  },
  {
    'LocationName': 'Melbourne',
    'AzureRegion': 'Australia Southeast',
    'PrivatePeeringFacilityMap': {
      '1339': {
        'CodeList': [
          'mel01'
        ],
        'Country': 'AU',
        'Address': '820 Lorimer Street',
        'Latitude': -37.821705,
        'Longitude': 144.931061,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1339',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '111': {
        'CodeList': [
          'mel01'
        ],
        'Country': 'AU',
        'Name': 'PIPE Networks Melbourne',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/111',
        'Ipv4PrefixList': [
          '218.100.13.0/24'
        ],
        'Ipv6PrefixList': [],
        'MicrosoftSessionIpv4AddressList': [
          '218.100.13.80'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7fa:e::13'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'mel01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {},
            'Ports': {
              'xe-8/0/1': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              }
            }
          }
        }
      },
      '779': {
        'CodeList': [
          'mel01'
        ],
        'Country': 'AU',
        'Name': 'MegaIX Melbourne',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/779',
        'Ipv4PrefixList': [
          '103.26.71.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:dea:0:30::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '103.26.71.35'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:dea:0:30::23'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'mel01-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel6': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '1026': {
        'CodeList': [
          'mel01'
        ],
        'Country': 'AU',
        'Name': 'Equinix Melbourne',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1026',
        'Ipv4PrefixList': [
          '183.177.61.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:de8:6:1::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '183.177.61.5'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:de8:6:1::8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'mel01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel16': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '513': {
        'CodeList': [
          'mel01'
        ],
        'Country': 'AU',
        'Name': 'Victorian Internet Exchange',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/513',
        'Ipv4PrefixList': [
          '218.100.78.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7fa:11:1::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '218.100.78.51'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7fa:11:1:0:2f2c:0:1'
        ],
        'Bandwidth': 40000,
        'Devices': {
          'mel01-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel1': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Brisbane',
    'AzureRegion': 'Australia East',
    'PrivatePeeringFacilityMap': {
      '1340': {
        'CodeList': [
          'bne01'
        ],
        'Country': 'AU',
        'Address': '20 Wharf Street',
        'Latitude': -27.465523,
        'Longitude': 153.029645,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1340',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '110': {
        'CodeList': [
          'bne01'
        ],
        'Country': 'AU',
        'Name': 'PIPE Networks Brisbane',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/110',
        'Ipv4PrefixList': [
          '218.100.0.0/24'
        ],
        'Ipv6PrefixList': [],
        'MicrosoftSessionIpv4AddressList': [
          '218.100.0.73'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7fa:9::a'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'bne01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {},
            'Ports': {
              'xe-0/0/0:1': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              }
            }
          }
        }
      },
      '781': {
        'CodeList': [
          'bne01'
        ],
        'Country': 'AU',
        'Name': 'MegaIX Brisbane',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/781',
        'Ipv4PrefixList': [
          '103.26.70.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:dea:0:20::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '103.26.70.20'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:dea:0:20::14'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'bne01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel2': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '576': {
        'CodeList': [
          'bne01'
        ],
        'Country': 'AU',
        'Name': 'Queensland Internet Exchange',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/576',
        'Ipv4PrefixList': [
          '218.100.76.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7fa:11:2::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '218.100.76.49'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7fa:11:2:0:2f2c:0:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'bne01-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel5': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Auckland',
    'AzureRegion': 'Australia East',
    'PrivatePeeringFacilityMap': {
      '1353': {
        'CodeList': [
          'akl01'
        ],
        'Country': 'NZ',
        'Address': '7A Parkhead Place',
        'Latitude': -36.750234,
        'Longitude': 174.696364,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1353',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '97': {
        'CodeList': [
          'akl01'
        ],
        'Country': 'NZ',
        'Name': 'APE',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/97',
        'Ipv4PrefixList': [
          '192.203.154.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7fa:4:c0cb::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '192.203.154.162'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7fa:4:c0cb::9aa2'
        ],
        'Bandwidth': 20000,
        'Devices': {
          'akl01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel2': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '977': {
        'CodeList': [
          'akl01'
        ],
        'Country': 'NZ',
        'Name': 'AKL-IX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/977',
        'Ipv4PrefixList': [
          '43.243.21.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7fa:11:6::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '43.243.21.23'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7fa:11:6:0:1f8b:0:1'
        ],
        'Bandwidth': 20000,
        'Devices': {
          'akl01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel60': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '984': {
        'CodeList': [
          'akl01'
        ],
        'Country': 'NZ',
        'Name': 'MegaIX Auckland',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/984',
        'Ipv4PrefixList': [
          '43.243.22.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:dea:0:40::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '43.243.22.38'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:dea:0:40::26'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'akl01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel1': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '348': {
        'CodeList': [
          'akl01'
        ],
        'Country': 'NZ',
        'Name': 'WIX-NZ',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/348',
        'Ipv4PrefixList': [
          '202.7.0.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:7fa:3:ca07::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '202.7.0.220'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7fa:3:ca07::dc'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'akl01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {},
            'Ports': {
              'xe-0/1/0': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              }
            }
          }
        }
      }
    }
  },
  {
    'LocationName': 'Zagreb',
    'AzureRegion': 'West Europe',
    'PrivatePeeringFacilityMap': {
      '1368': {
        'CodeList': [
          'zag30'
        ],
        'Country': 'HR',
        'Address': 'Selska cesta 93',
        'Latitude': 45.803311,
        'Longitude': 15.943893,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1368',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '303': {
        'CodeList': [
          'zag30'
        ],
        'Country': 'HR',
        'Name': 'CIX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/303',
        'Ipv4PrefixList': [
          '185.1.87.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:28::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '185.1.87.110'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:28::25:0'
        ],
        'Bandwidth': 20000,
        'Devices': {
          'zag30-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel10': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Rio de Janeiro',
    'AzureRegion': 'Brazil South',
    'PrivatePeeringFacilityMap': {
      '1374': {
        'CodeList': [
          'rio03'
        ],
        'Country': 'BR',
        'Address': '329 - Sao Cristovao',
        'Latitude': -22.903151,
        'Longitude': -43.21426,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1374',
        'Devices': {}
      },
      '1899': {
        'CodeList': [
          'rio02'
        ],
        'Country': 'BR',
        'Address': 'Estrada Adhemar Bebiano, 1380',
        'Latitude': -22.871261,
        'Longitude': -43.272742,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1899',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '177': {
        'CodeList': [
          'rio02',
          'rio03'
        ],
        'Country': 'BR',
        'Name': 'IX.br (PTT.br) Rio de Janeiro',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/177',
        'Ipv4PrefixList': [
          '45.6.52.0/22'
        ],
        'Ipv6PrefixList': [
          '2001:12f8:0:2::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '45.6.52.73',
          '45.6.52.72'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:12f8:0:2::73',
          '2001:12f8:0:2::72'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'rio02-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel5.10': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              },
              'PortChannel5.20': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'rio03-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel5.10': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              },
              'PortChannel5.20': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Helsinki',
    'AzureRegion': 'West Europe',
    'PrivatePeeringFacilityMap': {
      '1457': {
        'CodeList': [
          'hel02'
        ],
        'Country': 'FI',
        'Address': 'Parrukatu 2',
        'Latitude': 60.185146,
        'Longitude': 24.970015,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1457',
        'Devices': {}
      },
      '1459': {
        'CodeList': [
          'hel03'
        ],
        'Country': 'FI',
        'Address': 'Sahamyllyntie 4',
        'Latitude': 60.220067,
        'Longitude': 24.985015,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1459',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '98': {
        'CodeList': [
          'hel03'
        ],
        'Country': 'FI',
        'Name': 'FICIX 2 (Helsinki)',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/98',
        'Ipv4PrefixList': [
          '193.110.224.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:7:b::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '193.110.224.62'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:7:b::8075:1',
          '2001:7f8:7:a::8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'hel03-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel4': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '1332': {
        'CodeList': [
          'hel02'
        ],
        'Country': 'FI',
        'Name': 'FICIX 1 (Espoo)',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1332',
        'Ipv4PrefixList': [
          '193.110.226.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:7:a::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '193.110.226.62'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:7:a::8075:1',
          '2001:7f8:7:b::8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'hel02-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel4': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Houston',
    'AzureRegion': 'South Central US',
    'PrivatePeeringFacilityMap': {
      '1476': {
        'CodeList': [
          'hou01'
        ],
        'Country': 'US',
        'Address': '5150 & 5170 Westway Park Blvd',
        'Latitude': 29.844182,
        'Longitude': -95.556656,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1476',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '673': {
        'CodeList': [
          'hou01'
        ],
        'Country': 'US',
        'Name': 'CyrusOne IX Houston',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/673',
        'Ipv4PrefixList': [
          '198.32.96.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:478:96::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '198.32.96.35',
          '198.32.96.36'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:478:96::35',
          '2001:478:96::36'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'hou01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel2': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'hou01-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel2': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'San Antonio',
    'AzureRegion': 'South Central US',
    'PrivatePeeringFacilityMap': {
      '1484': {
        'CodeList': [
          'sn1'
        ],
        'Country': 'US',
        'Address': '9999 Westover Hills Blvd',
        'Latitude': 29.46661,
        'Longitude': -98.688078,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1484',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {}
  },
  {
    'LocationName': 'Phoenix',
    'AzureRegion': 'West US',
    'PrivatePeeringFacilityMap': {
      '1488': {
        'CodeList': [
          'phx01'
        ],
        'Country': 'US',
        'Address': '2335 South Ellis Road',
        'Latitude': 33.270744,
        'Longitude': -111.882056,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1488',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '760': {
        'CodeList': [
          'phx01'
        ],
        'Country': 'US',
        'Name': 'CyrusOne IX Phoenix',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/760',
        'Ipv4PrefixList': [
          '198.32.98.0/24'
        ],
        'Ipv6PrefixList': [],
        'MicrosoftSessionIpv4AddressList': [
          '198.32.98.35',
          '198.32.98.36'
        ],
        'MicrosoftSessionIpv6AddressList': [],
        'Bandwidth': 10000,
        'Devices': {
          'phx01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel2': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'phx01-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel2': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      },
      '662': {
        'CodeList': [
          'phx01'
        ],
        'Country': 'US',
        'Name': 'Phoenix IX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/662',
        'Ipv4PrefixList': [
          '206.41.105.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:3b::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.41.105.44'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:3b::44'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'phx01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {},
            'Ports': {
              'xe-2/1/2': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              }
            }
          }
        }
      }
    }
  },
  {
    'LocationName': 'Mexico',
    'AzureRegion': 'South Central US',
    'PrivatePeeringFacilityMap': {
      '1778': {
        'CodeList': [
          'mex30'
        ],
        'Country': 'MX',
        'Address': 'Privada de la Princesa 4',
        'Latitude': 20.567915,
        'Longitude': -100.254141,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1778',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {}
  },
  {
    'LocationName': 'Santiago',
    'AzureRegion': 'Brazil South',
    'PrivatePeeringFacilityMap': {
      '1779': {
        'CodeList': [
          'scl30'
        ],
        'Country': 'CL',
        'Address': 'Santa Marta de Huechuraba 6951',
        'Latitude': -33.35869,
        'Longitude': -70.67602,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1779',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '1514': {
        'CodeList': [
          'scl30'
        ],
        'Country': 'CL',
        'Name': 'PIT Santiago - PIT Chile',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1514',
        'Ipv4PrefixList': [
          '200.23.206.0/24'
        ],
        'Ipv6PrefixList': [
          '2801:14:9000::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '200.23.206.210',
          '200.23.206.211'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2801:14:9000::8075:1',
          '2801:14:9000::8075:2'
        ],
        'Bandwidth': 20000,
        'Devices': {
          'scl30-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel10': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'scl30-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel10': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Montreal',
    'AzureRegion': 'Canada East',
    'PrivatePeeringFacilityMap': {
      '1944': {
        'CodeList': [
          'ymq01'
        ],
        'Country': 'CA',
        'Address': '1250 Rene Levesque West',
        'Latitude': 45.497188,
        'Longitude': -73.570471,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1944',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '355': {
        'CodeList': [
          'ymq01'
        ],
        'Country': 'CA',
        'Name': 'QIX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/355',
        'Ipv4PrefixList': [
          '198.179.18.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:504:2d::/48'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '198.179.18.16'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:504:2d::18:16'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'ymq01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel5': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Athens',
    'AzureRegion': 'France Central',
    'PrivatePeeringFacilityMap': {
      '1949': {
        'CodeList': [
          'ath01'
        ],
        'Country': 'GR',
        'Address': 'Ifestou 76',
        'Latitude': 37.876249,
        'Longitude': 23.873294,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1949',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '347': {
        'CodeList': [
          'ath01'
        ],
        'Country': 'GR',
        'Name': 'GR-IX::Athens',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/347',
        'Ipv4PrefixList': [
          '176.126.38.0/25'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:6e::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '176.126.38.18',
          '176.126.38.28'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:6e::18',
          '2001:7f8:6e::28'
        ],
        'Bandwidth': 40000,
        'Devices': {
          'ath01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel7': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'ath01-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel4': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Milan',
    'AzureRegion': 'France Central',
    'PrivatePeeringFacilityMap': {
      '1974': {
        'CodeList': [
          'mil30'
        ],
        'Country': 'IT',
        'Address': 'Via Caldera, 21',
        'Latitude': 45.476394,
        'Longitude': 9.103571,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1974',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '35': {
        'CodeList': [
          'mil30'
        ],
        'Country': 'IT',
        'Name': 'MIX-IT',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/35',
        'Ipv4PrefixList': [
          '217.29.66.0/23'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:b:100::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '217.29.66.112',
          '217.29.66.212'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:b:100:1d1:a5d0:8075:112',
          '2001:7f8:b:100:1d1:a5d0:8075:212'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'mil30-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {},
            'Ports': {
              'et-7/1/0': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              }
            }
          },
          'mil30-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {},
            'Ports': {
              'et-7/1/0': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              }
            }
          }
        }
      },
      '115': {
        'CodeList': [
          'mil30'
        ],
        'Country': 'IT',
        'Name': 'TOP-IX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/115',
        'Ipv4PrefixList': [
          '194.116.96.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:23:ffff::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '194.116.96.88'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:23:ffff::88'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'mil30-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel1': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'New Delhi',
    'AzureRegion': 'West India',
    'PrivatePeeringFacilityMap': {
      '1982': {
        'CodeList': [
          'del01'
        ],
        'Country': 'IN',
        'Address': 'VSNL Colony',
        'Latitude': 28.550072,
        'Longitude': 77.235537,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/1982',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '1323': {
        'CodeList': [
          'del01'
        ],
        'Country': 'IN',
        'Name': 'Extreme IX Delhi',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1323',
        'Ipv4PrefixList': [
          '45.120.248.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:df2:1900:1::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '45.120.248.13'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:df2:1900:1::13'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'del01-96cbe-1b': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel10': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Honolulu',
    'AzureRegion': 'West US',
    'PrivatePeeringFacilityMap': {
      '2526': {
        'CodeList': [
          'hnl01'
        ],
        'Country': 'US',
        'Address': '3375 Koapaka St',
        'Latitude': 21.335678,
        'Longitude': -157.917855,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/2526',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {
      '267': {
        'CodeList': [
          'hnl01'
        ],
        'Country': 'US',
        'Name': 'DRF IX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/267',
        'Ipv4PrefixList': [
          '206.197.210.0/24'
        ],
        'Ipv6PrefixList': [
          '2606:7c80:3375:50::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '206.197.210.37'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2606:7c80:3375:50::37'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'hnl01-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {},
            'Ports': {
              'xe-9/1/0': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {}
              }
            }
          }
        }
      }
    }
  },
  {
    'LocationName': 'Manila',
    'AzureRegion': 'East Asia',
    'PrivatePeeringFacilityMap': {
      '4810': {
        'CodeList': [
          'mnl30'
        ],
        'Country': 'PH',
        'Address': '3F PLDT Bldg. Danny Floro St. corner CP Garcia St.',
        'Latitude': 14.56764,
        'Longitude': 121.0661,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/4810',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {}
  },
  {
    'LocationName': 'Hyderabad',
    'AzureRegion': 'South India',
    'PrivatePeeringFacilityMap': {
      '5236': {
        'CodeList': [
          'hyd30'
        ],
        'Country': 'IN',
        'Address': 'HUDA Techno Enclave, HITEC City',
        'Latitude': 17.436275,
        'Longitude': 78.382347,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/5236',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {}
  },
  {
    'LocationName': 'Fujairah',
    'AzureRegion': 'UK West',
    'PrivatePeeringFacilityMap': {},
    'PublicPeeringFacilityMap': {
      '866': {
        'CodeList': [
          'dxb20'
        ],
        'Country': 'AE',
        'Name': 'SH-IX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/866',
        'Ipv4PrefixList': [
          '185.1.15.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:7a::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '185.1.15.14'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:7a::8075:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'ier02.dxb20': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel62': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [
                  '185.1.15.14/32'
                ],
                'SessionIpv6PrefixList': [
                  '2001:7f8:7a::8075:1/128'
                ],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Dubai',
    'AzureRegion': 'UK West',
    'PrivatePeeringFacilityMap': {},
    'PublicPeeringFacilityMap': {
      '587': {
        'CodeList': [
          'dxb30'
        ],
        'Country': 'AE',
        'Name': 'UAE-IX',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/587',
        'Ipv4PrefixList': [
          '185.1.8.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:73::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '185.1.8.22',
          '185.1.8.32'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:73::1f8b:0:1',
          '2001:7f8:73::1f8b:0:2'
        ],
        'Bandwidth': 20000,
        'Devices': {
          'ier01.dxb30': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel60': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          },
          'ier02.dxb30': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel60': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Dusseldorf',
    'AzureRegion': 'UK West',
    'PrivatePeeringFacilityMap': {},
    'PublicPeeringFacilityMap': {
      '1214': {
        'CodeList': [
          'fra'
        ],
        'Country': 'DE',
        'Name': 'DE-CIX Dusseldorf',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/1214',
        'Ipv4PrefixList': [
          '185.1.58.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:9e::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '185.1.58.94'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:9e::1f8b:0:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'fra-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel67.100': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Munich',
    'AzureRegion': 'UK West',
    'PrivatePeeringFacilityMap': {},
    'PublicPeeringFacilityMap': {
      '248': {
        'CodeList': [
          'fra'
        ],
        'Country': 'DE',
        'Name': 'DE-CIX Munich',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/248',
        'Ipv4PrefixList': [
          '80.81.202.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:44::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '80.81.202.100'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:44::1f8b:0:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'fra-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel67.101': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Hamburg',
    'AzureRegion': 'UK West',
    'PrivatePeeringFacilityMap': {},
    'PublicPeeringFacilityMap': {
      '74': {
        'CodeList': [
          'fra'
        ],
        'Country': 'DE',
        'Name': 'DE-CIX Hamburg',
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/ix/74',
        'Ipv4PrefixList': [
          '80.81.203.0/24'
        ],
        'Ipv6PrefixList': [
          '2001:7f8:3d::/64'
        ],
        'MicrosoftSessionIpv4AddressList': [
          '80.81.203.105'
        ],
        'MicrosoftSessionIpv6AddressList': [
          '2001:7f8:3d::1f8b:0:1'
        ],
        'Bandwidth': 10000,
        'Devices': {
          'fra-96cbe-1a': {
            'DeviceType': 'None',
            'PortChannels': {
              'PortChannel67.102': {
                'PortBandwidth': 0,
                'PortAllocationType': 'None',
                'SessionIpv4PrefixList': [],
                'SessionIpv6PrefixList': [],
                'PeerInfoMap': {},
                'PortChannelPorts': {}
              }
            },
            'Ports': {}
          }
        }
      }
    }
  },
  {
    'LocationName': 'Newark',
    'AzureRegion': 'US East',
    'PrivatePeeringFacilityMap': {
      '9': {
        'CodeList': [
          'ewr30'
        ],
        'Country': 'US',
        'Address': '165 Halsey St',
        'Latitude': 40.736844,
        'Longitude': -74.173402,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/9',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {}
  },
  {
    'LocationName': 'Reston',
    'AzureRegion': 'US East',
    'PrivatePeeringFacilityMap': {
      '668': {
        'CodeList': [
          'ash'
        ],
        'Country': 'US',
        'Address': '12100 Sunrise Valley Drive',
        'Latitude': 38.950631,
        'Longitude': -77.364541,
        'LocationType': 'Production',
        'PeeringDBFacilityLink': 'https://www.peeringdb.com/fac/668',
        'Devices': {}
      }
    },
    'PublicPeeringFacilityMap': {}
  }
]";
        }
    }
}
