using Microsoft.EntityFrameworkCore;
using FirePortal.App.Database;
using FirePortal.App.Database.Entities;

namespace FirePortal.App.Repositories.Domains;

public class SharedDomainRepository : IDisposable
{
    private readonly DataContext DataContext;

    public SharedDomainRepository(DataContext dataContext)
    {
        DataContext = dataContext;
    }

    public DbSet<SharedDomain> Get()
    {
        return DataContext.SharedDomains;
    }

    public SharedDomain Add(SharedDomain sharedDomain)
    {
        var x = DataContext.SharedDomains.Add(sharedDomain);
        DataContext.SaveChanges();
        return x.Entity;
    }

    public void Update(SharedDomain sharedDomain)
    {
        DataContext.SharedDomains.Update(sharedDomain);
        DataContext.SaveChanges();
    }

    public void Delete(SharedDomain domain)
    {
        DataContext.SharedDomains.Remove(domain);
        DataContext.SaveChanges();
    }

    public void Dispose()
    {
        DataContext.Dispose();
    }
}