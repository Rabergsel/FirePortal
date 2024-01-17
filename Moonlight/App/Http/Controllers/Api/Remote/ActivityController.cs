using Microsoft.AspNetCore.Mvc;

namespace FirePortal.App.Http.Controllers.Api.Remote;

[Route("api/remote/activity")]
[ApiController]
public class ActivityController : Controller
{
    [HttpPost]
    public ActionResult SaveActivity()
    {
        return Ok();
    }
}