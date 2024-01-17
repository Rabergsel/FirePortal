using Newtonsoft.Json;

namespace FirePortal.App.ApiClients.Wings.Requests;

public class CreateDirectory
{
    [JsonProperty("name")]
    public string Name { get; set; }
    
    [JsonProperty("path")]
    public string Path { get; set; }
}