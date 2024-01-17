using Newtonsoft.Json;

namespace FirePortal.App.Models.Notifications;

public class NotificationById : BasicWSModel
{
    [JsonProperty("notification")]
    public int Notification { get; set; }
}