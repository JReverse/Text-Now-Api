using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TextNow
{
    public static class Register
    {
        public static async Task RegisterAccount(this TextNowClient client, string username, string email, string password)
        {
            //TODO 
            // EXAMPLE

/*
 * 
 * {"email":"emailhere","password":"passwordhere","system_version":"12.4.8","bonus_info":{"ConnectedToWiFi":"Yes","StepCountingAvailable":"Yes","SystemName":"iOS","TimeZone":"America\/Chicago","FreeMemory (Formatted)":"11.065674","NumberAttachedAccessories":"0","DeviceOrientation":"-1","DeviceName":"Justin’s iPhone","Country":"en_US","UsedMemory (Not Formatted)":"794.722656","PurgableMemory (Formatted)":"1.759720","ProcessorsUsage":"(\n    \"0.2446778\",\n    \"0.2047929\"\n)","FloorCountingAvailable":"Yes","UsedDiskSpace (Formatted)":"41%","CPUUsage":"7.400000","CFUUID":"8DA5B698-8694-414D-B2F0-88A98C3E7B06","ScreenHeight":"667","Charging":"No","WiFiBroadcastAddress":"192.168.0.255","NameAttachedAccessories":"Unknown","WiFiNetmaskAddress":"255.255.255.0","Language":"en-US","CarrierISOCountryCode":"us","HeadphonesAttached":"No","ApplicationVersion":"20.10.0","FreeDiskSpace (Formatted)":"58%","CarrierCountry":"US","External IP Address":"IP_HERE","CurrentIPAddress":"192.168.0.18","FreeMemory (Not Formatted)":"113.312500","ScreenWidth":"375","CellIPAddress":"Unknown","ProcessID":"870","ClipboardContent":"148.251.80.205","FreeDiskSpace (Not Formatted)":"9.41 GB","CarrierName":"Sprint","FullyCharged":"No","InactiveMemory (Formatted)":"27.696609","BatteryLevel":"85.000000","SystemDeviceType":"iPhone7,2","SystemDeviceType Formatted":"iPhone 6","WiFiIPAddress":"192.168.0.18","CarrierMobileCountryCode":"310","NumberActiveProcessors":"2","UsedDiskSpace (Not Formatted)":"6.58 GB","LongFreeDiskSpace":"9409421312","Currency":"$","CarrierAllowsVOIP":"Yes","ConnectedToCellNetwork":"No","ActiveMemory (Not Formatted)":"303.644531","WiredMemory (Formatted)":"20.260239","PluggedIn":"No","PurgableMemory (Not Formatted)":"18.019531","ScreenBrightness":"35.035431","WiredMemory (Not Formatted)":"207.464844","AccessoriesAttached":"No","Uptime (dd hh mm)":"0 1 13","ActiveMemory (Formatted)":"29.652786","DiskSpace":"15.99 GB","CellBroadcastAddress":"Unknown","Jailbroken":"3429542","DeviceModel":"iPhone","TotalMemory":"1024.000000","SystemVersion":"12.4.8","DistanceAvailable":"Yes","InactiveMemory (Not Formatted)":"283.613281","MultitaskingEnabled":"Yes","LongDiskSpace":"15989485568","CellNetmaskAddress":"Unknown","UsedMemory (Formatted)":"77.539062","NumberProcessors":"2","ProximitySensorEnabled":"Yes","DebuggerAttached":"No","CarrierMobileNetworkCode":"120","WiFiRouterAddress":"192.168.0.1"}}
 */
await client.HttpClient.Send("/api2.0/users/" + username, "PUT");
}
}
}
