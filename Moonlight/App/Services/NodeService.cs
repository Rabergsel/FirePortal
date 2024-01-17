using FirePortal.App.ApiClients.Daemon;
using FirePortal.App.ApiClients.Daemon.Requests;
using FirePortal.App.ApiClients.Daemon.Resources;
using FirePortal.App.ApiClients.Wings;
using FirePortal.App.ApiClients.Wings.Resources;
using FirePortal.App.Database.Entities;
using FirePortal.App.Helpers;
using FirePortal.App.Repositories;

namespace FirePortal.App.Services;

public class NodeService
{
    private readonly WingsApiHelper WingsApiHelper;
    private readonly DaemonApiHelper DaemonApiHelper;
    
    public NodeService(WingsApiHelper wingsApiHelper, DaemonApiHelper daemonApiHelper)
    {
        WingsApiHelper = wingsApiHelper;
        DaemonApiHelper = daemonApiHelper;
    }

    public async Task<SystemStatus> GetStatus(Node node)
    {
        return await WingsApiHelper.Get<SystemStatus>(node, "api/system");
    }

    public async Task<CpuMetrics> GetCpuMetrics(Node node)
    {
        return await DaemonApiHelper.Get<CpuMetrics>(node, "metrics/cpu");
    }
    
    public async Task<MemoryMetrics> GetMemoryMetrics(Node node)
    {
        return await DaemonApiHelper.Get<MemoryMetrics>(node, "metrics/memory");
    }
    
    public async Task<DiskMetrics> GetDiskMetrics(Node node)
    {
        return await DaemonApiHelper.Get<DiskMetrics>(node, "metrics/disk");
    }
    
    public async Task<SystemMetrics> GetSystemMetrics(Node node)
    {
        return await DaemonApiHelper.Get<SystemMetrics>(node, "metrics/system");
    }
    
    public async Task<DockerMetrics> GetDockerMetrics(Node node)
    {
        return await DaemonApiHelper.Get<DockerMetrics>(node, "metrics/docker");
    }

    public async Task RebuildFirewall(Node node, string[] ips)
    {
        await DaemonApiHelper.Post(node, "firewall/rebuild", ips);
    }

    public async Task Mount(Node node, string server, string serverPath, string path)
    {
        await DaemonApiHelper.Post(node, "mount", new Mount()
        {
            Server = server,
            ServerPath = serverPath,
            Path = path
        });
    }

    public async Task Unmount(Node node, string path)
    {
        await DaemonApiHelper.Delete(node, "mount", new Unmount()
        {
            Path = path
        });
    }

    public async Task<bool> IsHostUp(Node node)
    {
        try
        {
            await GetStatus(node);

            return true;
        }
        catch (Exception)
        {
            // ignored
        }

        return false;
    }
}