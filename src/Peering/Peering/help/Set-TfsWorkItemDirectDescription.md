---
external help file: Microsoft.Azure.PowerShell.Cmdlets.Peering.dll-Help.xml
Module Name: Az.Peering
online version:
schema: 2.0.0
---

# Set-TfsWorkItemDirectDescription

## SYNOPSIS
{{ Fill in the Synopsis }}

## SYNTAX

### Default (Default)
```
Set-TfsWorkItemDirectDescription [-WorkItemId] <Int32> [-PeerSessionIPv4Address <String>]
 [-PeerSessionIPv6Address <String>] -BandwidthInMbps <Int32> [-DefaultProfile <IAzureContextContainer>]
 [<CommonParameters>]
```

### ByName
```
Set-TfsWorkItemDirectDescription [-WorkItemId] <Int32> [-PeerName] <String> -Email <String[]>
 [-Phone <String[]>] [-PeerSessionIPv4Address <String>] [-PeerSessionIPv6Address <String>]
 -BandwidthInMbps <Int32> [-DefaultProfile <IAzureContextContainer>] [<CommonParameters>]
```

## DESCRIPTION
{{ Fill in the Description }}

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -BandwidthInMbps
The peer session IPv6 address

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: IAzureContextContainer
Parameter Sets: (All)
Aliases: AzContext, AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Email
Email Addresses used to contact if issues arrise typically a Network Operations Center

```yaml
Type: String[]
Parameter Sets: ByName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PeerName
The unique name of the PSPeering.

```yaml
Type: String
Parameter Sets: ByName
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PeerSessionIPv4Address
The peer session IPv4 address

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PeerSessionIPv6Address
The peer session IPv6 address

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Phone
Phone used to contact if issues arrise typically a Network Operations Center

```yaml
Type: String[]
Parameter Sets: ByName
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkItemId
{{ Fill WorkItemId Description }}

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### System.Collections.Generic.KeyValuePair`2[[Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.PSPeerAsn, Microsoft.Azure.PowerShell.Cmdlets.Peering, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null],[Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.PSPeering, Microsoft.Azure.PowerShell.Cmdlets.Peering, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]]

## NOTES

## RELATED LINKS
