using FirePortal.App.Models.Misc;
using FirePortal.App.Plugin.UI.Servers;
using FirePortal.App.Plugin.UI.Webspaces;

namespace FirePortal.App.Plugin;

public abstract class FirePortalPlugin
{
    public string Name { get; set; } = "N/A";
    public string Author { get; set; } = "N/A";
    public string Version { get; set; } = "N/A";
    
    public Func<ServerPageContext, Task>? OnBuildServerPage { get; set; }
    public Func<WebspacePageContext, Task>? OnBuildWebspacePage { get; set; }
    public Func<IServiceCollection, Task>? OnBuildServices { get; set; }
    public Func<List<MalwareScan>, Task<List<MalwareScan>>>? OnBuildMalwareScans { get; set; }
}