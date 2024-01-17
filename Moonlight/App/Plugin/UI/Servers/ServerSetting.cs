using Microsoft.AspNetCore.Components;

namespace FirePortal.App.Plugin.UI.Servers;

public class ServerSetting
{
    public string Name { get; set; }
    public RenderFragment Component { get; set; }
}