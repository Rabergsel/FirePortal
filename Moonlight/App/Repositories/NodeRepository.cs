using Microsoft.EntityFrameworkCore;
using FirePortal.App.Database;
using FirePortal.App.Database.Entities;

namespace FirePortal.App.Repositories;

public class NodeRepository : IDisposable
{
    private readonly DataContext DataContext;

    public NodeRepository(DataContext dataContext)
    {
        DataContext = dataContext;
    }

    public DbSet<Node> Get()
    {
        return DataContext.Nodes;
    }

    public Node Add(Node node)
    {
        var x = DataContext.Nodes.Add(node);
        DataContext.SaveChanges();
        return x.Entity;
    }

    public void Update(Node node)
    {
        DataContext.Nodes.Update(node);
        DataContext.SaveChanges();
    }

    public void Delete(Node node)
    {
        DataContext.Nodes.Remove(node);
        DataContext.SaveChanges();
    }

    public void Dispose()
    {
        DataContext.Dispose();
    }
}