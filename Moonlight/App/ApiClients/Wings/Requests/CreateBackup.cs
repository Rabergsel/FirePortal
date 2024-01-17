using Newtonsoft.Json;

namespace FirePortal.App.ApiClients.Wings.Requests;

public class CreateBackup
{
    [JsonProperty("adapter")]
    public string Adapter { get; set; }
    
    [JsonProperty("uuid")]
    public Guid Uuid { get; set; }
    
    [JsonProperty("ignore")]
    public string Ignore { get; set; }
}