using System.Text;
using FirePortal.App.Helpers;
using FirePortal.App.Models.Misc;
using Octokit;

namespace FirePortal.App.Services.Plugins;

public class PluginStoreService
{
    private readonly GitHubClient Client;
    private readonly PluginService PluginService;

    public PluginStoreService(PluginService pluginService)
    {
        PluginService = pluginService;
        Client = new(new ProductHeaderValue("FirePortal-Panel"));
    }

    public async Task<OfficialFirePortalPlugin[]> GetPlugins()
    {
        var items = await Client.Repository.Content.GetAllContents("FirePortal-Panel", "OfficialPlugins");

        if (items == null)
        {
            Logger.Fatal("Unable to read plugin repo contents");
            return Array.Empty<OfficialFirePortalPlugin>();
        }

        return items
            .Where(x => x.Type == ContentType.Dir)
            .Select(x => new OfficialFirePortalPlugin()
            {
                Name = x.Name
            })
            .ToArray();
    }

    public async Task<string> GetPluginReadme(OfficialFirePortalPlugin plugin)
    {
        var rawReadme = await Client.Repository.Content
            .GetRawContent("FirePortal-Panel", "OfficialPlugins", $"{plugin.Name}/README.md");

        if (rawReadme == null)
            return "Error";

        return Encoding.UTF8.GetString(rawReadme);
    }

    public async Task InstallPlugin(OfficialFirePortalPlugin plugin, bool updating = false)
    {
        var rawPlugin = await Client.Repository.Content
            .GetRawContent("FirePortal-Panel", "OfficialPlugins", $"{plugin.Name}/{plugin.Name}.dll");

        if (updating)
        {
            await File.WriteAllBytesAsync(PathBuilder.File("storage", "plugins", $"{plugin.Name}.dll.cache"), rawPlugin);
            return;
        }
        
        await File.WriteAllBytesAsync(PathBuilder.File("storage", "plugins", $"{plugin.Name}.dll"), rawPlugin);
        await PluginService.ReloadPlugins();
    }
}