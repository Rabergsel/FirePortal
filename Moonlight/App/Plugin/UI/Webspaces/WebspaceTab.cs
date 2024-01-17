using Microsoft.AspNetCore.Components;

namespace FirePortal.App.Plugin.UI.Webspaces;

public class WebspaceTab
{
    public string Name { get; set; } = "N/A";
    public string Route { get; set; } = "/";
    public RenderFragment Component { get; set; }
}