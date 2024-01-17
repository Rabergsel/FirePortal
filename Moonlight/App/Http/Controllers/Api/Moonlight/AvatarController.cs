using GravatarSharp;
using Microsoft.AspNetCore.Mvc;
using FirePortal.App.Repositories;

namespace FirePortal.App.Http.Controllers.Api.FirePortal;

[ApiController]
[Route("api/FirePortal/avatar")]
public class AvatarController : Controller
{
    private readonly UserRepository UserRepository;

    public AvatarController(UserRepository userRepository)
    {
        UserRepository = userRepository;
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult> GetAvatar([FromRoute] int id)
    {
        var user = UserRepository.Get().FirstOrDefault(x => x.Id == id);

        if (user == null)
            return NotFound();
        
        try
        {
            var url = GravatarController.GetImageUrl(user.Email.ToLower(), 100);

            using var client = new HttpClient();
            var res = await client.GetByteArrayAsync(url);

            return File(res, "image/png");
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }
}