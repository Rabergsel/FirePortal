namespace FirePortal.App.Events;

public class Subscriber
{
    public string Id { get; set; }
    public object Action { get; set; }
    public object Handle { get; set; }
}