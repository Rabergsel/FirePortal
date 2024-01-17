using Microsoft.EntityFrameworkCore;
using FirePortal.App.Database;
using FirePortal.App.Database.Entities;

namespace FirePortal.App.Repositories;

public class RevokeRepository : IDisposable
{
    private readonly DataContext DataContext;

    public RevokeRepository(DataContext dataContext)
    {
        DataContext = dataContext;
    }

    public Revoke Add(Revoke revoke)
    {
        var x = DataContext.Revokes.Add(revoke);
        DataContext.SaveChanges();
        return x.Entity;
    }

    public DbSet<Revoke> Get()
    {
        return DataContext.Revokes;
    }

    public void Dispose()
    {
        DataContext.Dispose();
    }
}