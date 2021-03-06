// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
using System;

public class IosBonusDataV1
{
    public string idfa { get; set; } = Guid.NewGuid().ToString().ToUpper();
    public string os_version { get; set; } = "12.4.8";
}

public class Root2
{
    public IosBonusDataV1 ios_bonus_data_v1 { get; set; }
}

