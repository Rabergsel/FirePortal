using Microsoft.EntityFrameworkCore;
using FirePortal.App.Database;
using FirePortal.App.Database.Entities;

namespace FirePortal.App.Repositories;

public class ImageRepository : IDisposable
{
    private readonly DataContext DataContext;

    public ImageRepository(DataContext dataContext)
    {
        DataContext = dataContext;
    }

    public DbSet<Image> Get()
    {
        return DataContext.Images;
    }

    public Image Add(Image image)
    {
        var x = DataContext.Images.Add(image);
        DataContext.SaveChanges();
        return x.Entity;
    }

    public void Update(Image image)
    {
        DataContext.Images.Update(image);
        DataContext.SaveChanges();
    }

    public void Delete(Image image)
    {
        DataContext.Images.Remove(image);
        DataContext.SaveChanges();
    }

    public void Dispose()
    {
        DataContext.Dispose();
    }
}