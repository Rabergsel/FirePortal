using Newtonsoft.Json;

namespace FirePortal.App.Models.Notifications;

public class Login : BasicWSModel
{
    [JsonProperty("token")] public string Token { get; set; } = "";
}