using Newtonsoft.Json;

namespace FirePortal.App.Models.Notifications;

public class BasicWSModel
{
    [JsonProperty("action")]
    public string Action { get; set; }
}