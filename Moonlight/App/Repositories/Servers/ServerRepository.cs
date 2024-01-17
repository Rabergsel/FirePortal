using Microsoft.EntityFrameworkCore;
using FirePortal.App.Database;
using FirePortal.App.Database.Entities;

namespace FirePortal.App.Repositories.Servers;

public class ServerRepository : IDisposable
{
    private readonly DataContext DataContext;

    public ServerRepository(DataContext dataContext)
    {
        DataContext = dataContext;
    }

    public DbSet<Server> Get()
    {
        return DataContext.Servers;
    }

    public Server Add(Server server)
    {
        var x = DataContext.Servers.Add(server);
        DataContext.SaveChanges();
        return x.Entity;
    }

    public void Update(Server server)
    {
        DataContext.Servers.Update(server);
        DataContext.SaveChanges();
    }

    public void Delete(Server server)
    {
        DataContext.Servers.Remove(server);
        DataContext.SaveChanges();
    }

    public void Dispose()
    {
        DataContext.Dispose();
    }
}