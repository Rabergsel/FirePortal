using FirePortal.App.ApiClients.Daemon.Resources;
using FirePortal.App.Database.Entities;

namespace FirePortal.App.Models.Misc;

public class RunningServer
{
    public Server Server { get; set; }
    public Container Container { get; set; }
}