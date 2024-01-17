using FirePortal.App.Database.Entities;
using FirePortal.App.Events;
using FirePortal.App.Repositories;

namespace FirePortal.App.Services.Sessions;

public class IpBanService
{
    private readonly IdentityService IdentityService;
    private readonly Repository<IpBan> IpBanRepository;
    
    public IpBanService(
        IdentityService identityService,
        Repository<IpBan> ipBanRepository)
    {
        IdentityService = identityService;
        IpBanRepository = ipBanRepository;
    }

    public Task<bool> IsBanned()
    {
        var ip = IdentityService.Ip;

        return Task.FromResult(
            IpBanRepository
                .Get()
                .Any(x => x.Ip == ip)
        );
    }
}