using FirePortal.App.Database.Entities;

namespace FirePortal.App.Services.Files;

public class ResourceService
{
    private readonly string AppUrl;
    
    public ResourceService(ConfigService configService)
    {
        AppUrl = configService.Get().FirePortal.AppUrl;
    }

    public string Image(string name)
    {
        return $"{AppUrl}/api/FirePortal/resources/images/{name}";
    }
    
    public string BackgroundImage(string name)
    {
        return $"{AppUrl}/api/FirePortal/resources/background/{name}";
    }

    public string Avatar(User user)
    {
        return $"{AppUrl}/api/FirePortal/avatar/{user.Id}";
    }

    public string BucketItem(string bucket, string name)
    {
        return $"{AppUrl}/api/FirePortal/resources/bucket/{bucket}/{name}";
    }
}