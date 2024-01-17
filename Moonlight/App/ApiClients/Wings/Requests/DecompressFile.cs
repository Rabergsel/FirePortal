using Newtonsoft.Json;

namespace FirePortal.App.ApiClients.Wings.Requests;

public class DecompressFile
{
    [JsonProperty("root")]
    public string Root { get; set; }

    [JsonProperty("file")]
    public string File { get; set; }
}