using Newtonsoft.Json;

namespace FirePortal.App.ApiClients.CloudPanel.Requests;

public class InstallLetsEncrypt
{
    [JsonProperty("domainName")]
    public string DomainName { get; set; }
}