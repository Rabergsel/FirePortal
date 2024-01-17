using GravatarSharp;
using Microsoft.AspNetCore.Mvc;
using FirePortal.App.Models.Notifications;
using FirePortal.App.Repositories;
using FirePortal.App.Services;
using FirePortal.App.Services.Sessions;

namespace FirePortal.App.Http.Controllers.Api.FirePortal.Notifications;

[ApiController]
[Route("api/FirePortal/notifications/register")]
public class RegisterController : Controller
{
    private readonly IdentityService IdentityService;
    private readonly NotificationRepository NotificationRepository;
    private readonly OneTimeJwtService OneTimeJwtService;

    public RegisterController(IdentityService identityService, NotificationRepository notificationRepository, OneTimeJwtService oneTimeJwtService)
    {
        IdentityService = identityService;
        NotificationRepository = notificationRepository;
        OneTimeJwtService = oneTimeJwtService;
    }

    [HttpGet]
    public async Task<ActionResult<TokenRegister>> Register()
    {
        var user = IdentityService.User;

        if (user == null)
            return NotFound();
        
        try
        {
            var id = NotificationRepository.RegisterNewDevice(user);

            return new TokenRegister()
            {
                Token = OneTimeJwtService.Generate((dict) =>
                {
                    dict["clientId"] = id.ToString();
                }, TimeSpan.FromDays(31))
            };
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }
}