using Newtonsoft.Json;

namespace FirePortal.App.ApiClients.Wings.Requests;

public class ServerPower
{
    [JsonProperty("action")]
    public string Action { get; set; }
}