using Microsoft.AspNetCore.Mvc;
using FirePortal.App.Models.Notifications;
using FirePortal.App.Repositories;
using FirePortal.App.Services;
using FirePortal.App.Services.Sessions;

namespace FirePortal.App.Http.Controllers.Api.FirePortal.Notifications;

[ApiController]
[Route("api/FirePortal/notifications/pull")]
public class PullController : Controller
{
    private readonly IdentityService IdentityService;
    private readonly NotificationRepository NotificationRepository;
    private readonly OneTimeJwtService OneTimeJwtService;

    public PullController(IdentityService identityService, NotificationRepository notificationRepository, OneTimeJwtService oneTimeJwtService)
    {
        IdentityService = identityService;
        NotificationRepository = notificationRepository;
        OneTimeJwtService = oneTimeJwtService;
    }

    [HttpPost]
    public async Task<ActionResult<string>> Pull()
    {
        Stream req = Request.Body;
        string jwt = await new StreamReader(req).ReadToEndAsync();

        var dict = await OneTimeJwtService.Validate(jwt);

        if (dict == null)
            return NotFound();

        var _clientId = dict["clientId"];
        var clientId = int.Parse(_clientId);

        var client = NotificationRepository.GetClients().First(x => x.Id == clientId);
        
        try
        {
            var strings = "";

            var actions = NotificationRepository.GetActions().Where(x => x.NotificationClient == client).ToList();

            foreach (var a in actions)
            {
                strings += a.Action + ",";
                
                NotificationRepository.RemoveAction(a);
            }

            strings = strings.Trim(',');

            return $"[{strings}]";
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }
}