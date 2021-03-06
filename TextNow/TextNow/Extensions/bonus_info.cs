// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
using Newtonsoft.Json;
using System;

public class BonusInfo
{
    public string AccessoriesAttached { get; set; } = "No";
    [JsonProperty("ActiveMemory(Formatted)")]
    public string ActiveMemoryFormatted { get; set; } = "28.657532";
    [JsonProperty("ActiveMemory(NotFormatted)")]
    public string ActiveMemoryNotFormatted { get; set; } = "293.453125";
    public string ApplicationVersion { get; set; } = "21.8.0";
    public string BatteryLevel { get; set; } = "100.000000";
    public string CFUUID { get; set; } = Guid.NewGuid().ToString();
    public string CPUUsage { get; set; } = "3.500000";
    public string CarrierAllowsVOIP { get; set; } = "Yes";
    public string CarrierCountry { get; set; } = "US";
    public string CarrierISOCountryCode { get; set; } = "us";
    public string CarrierMobileCountryCode { get; set; } = "310";
    public string CarrierMobileNetworkCode { get; set; } = "120";
    public string CarrierName { get; set; } = "Sprint";
    public string CellBroadcastAddress { get; set; } = "Unknown";
    public string CellIPAddress { get; set; } = "Unknown";
    public string CellNetmaskAddress { get; set; } = "Unknown";
    public string Charging { get; set; } = "Yes";
    public string ConnectedToCellNetwork { get; set; } = "No";
    public string ConnectedToWiFi { get; set; } = "Yes";
    public string Country { get; set; } = "en_US";
    public string Currency { get; set; } = "$";
    public string CurrentIPAddress { get; set; } = "192.168.0.8";
    public string DebuggerAttached { get; set; } = "No";
    public string DeviceModel { get; set; } = "iPhone";
    public string DeviceName { get; set; } = "iPhone";
    public string DeviceOrientation { get; set; } = "-1";
    public string DiskSpace { get; set; } = "15.99 GB";
    public string DistanceAvailable { get; set; } = "Yes";
    public string ExternalIPAddress { get; set; } = "2001:41d0:1000:2e58:92:222:182:102";
    public string FloorCountingAvailable { get; set; } = "Yes";
    [JsonProperty("FreeDiskSpace(Formatted)")]
    public string FreeDiskSpaceFormatted { get; set; } = "53%";
    [JsonProperty("FreeDiskSpace(NotFormatted)")]
    public string FreeDiskSpaceNotFormatted { get; set; } = "8.52 GB";
    [JsonProperty("FreeMemory(Formatted)")]
    public string FreeMemoryFormatted { get; set; } = "5.529785";
    [JsonProperty("FreeMemory(NotFormatted)")]
    public string FreeMemoryNotFormatted { get; set; } = "56.625000";
    public string FullyCharged { get; set; } = "No";
    public string HeadphonesAttached { get; set; } = "No";
    [JsonProperty("InactiveMemory(Formatted)")]
    public string InactiveMemoryFormatted { get; set; } = "28.005219";
    [JsonProperty("InactiveMemory(NotFormatted)")]
    public string InactiveMemoryNotFormatted { get; set; } = "286.773438";
    public string Jailbroken { get; set; } = "3429542";
    public string Language { get; set; } = "en-US";
    public string LongDiskSpace { get; set; }
    public string LongFreeDiskSpace { get; set; }
    public string MultitaskingEnabled { get; set; }
    public string NameAttachedAccessories { get; set; }
    public string NumberActiveProcessors { get; set; }
    public string NumberAttachedAccessories { get; set; }
    public string NumberProcessors { get; set; }
    public string PluggedIn { get; set; }
    public string ProcessID { get; set; }
    public string ProcessorsUsage { get; set; }
    public string ProximitySensorEnabled { get; set; }
    [JsonProperty("PurgableMemory(Formatted)")]
    public string PurgableMemoryFormatted { get; set; }
    [JsonProperty("PurgableMemory(NotFormatted)")]
    public string PurgableMemoryNotFormatted { get; set; }
    public string ScreenBrightness { get; set; }
    public string ScreenHeight { get; set; }
    public string ScreenWidth { get; set; }
    public string StepCountingAvailable { get; set; }
    public string SystemDeviceType { get; set; }
    public string SystemDeviceTypeFormatted { get; set; }
    public string SystemName { get; set; }
    public string SystemVersion { get; set; }
    public string TimeZone { get; set; }
    public string TotalMemory { get; set; }
    [JsonProperty("Uptime(ddhhmm)")]
    public string UptimeDdhhmm { get; set; }
    [JsonProperty("UsedDiskSpace(Formatted)")]
    public string UsedDiskSpaceFormatted { get; set; }
    [JsonProperty("UsedDiskSpace(NotFormatted)")]
    public string UsedDiskSpaceNotFormatted { get; set; }
    [JsonProperty("UsedMemory(Formatted)")]
    public string UsedMemoryFormatted { get; set; }
    [JsonProperty("UsedMemory(NotFormatted)")]
    public string UsedMemoryNotFormatted { get; set; }
    public string WiFiBroadcastAddress { get; set; }
    public string WiFiIPAddress { get; set; }
    public string WiFiNetmaskAddress { get; set; }
    public string WiFiRouterAddress { get; set; }
    [JsonProperty("WiredMemory(Formatted)")]
    public string WiredMemoryFormatted { get; set; }
    [JsonProperty("WiredMemory(NotFormatted)")]
    public string WiredMemoryNotFormatted { get; set; }
}

public class Root
{
    public BonusInfo bonus_info { get; set; }
}

