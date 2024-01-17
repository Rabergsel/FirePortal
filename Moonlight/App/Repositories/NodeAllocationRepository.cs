using Microsoft.EntityFrameworkCore;
using FirePortal.App.Database;
using FirePortal.App.Database.Entities;

namespace FirePortal.App.Repositories;

public class NodeAllocationRepository : IDisposable
{
    // This repository is ONLY for the server creation service, so allocations can be found
    // using raw sql. DO NOT use this in any other component
    
    private readonly DataContext DataContext;

    public NodeAllocationRepository(DataContext dataContext)
    {
        DataContext = dataContext;
    }

    public DbSet<NodeAllocation> Get()
    {
        return DataContext.NodeAllocations;
    }

    public void Dispose()
    {
        DataContext.Dispose();
    }
}