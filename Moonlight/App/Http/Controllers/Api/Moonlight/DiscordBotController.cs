using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirePortal.App.ApiClients.Wings;
using FirePortal.App.ApiClients.Wings.Resources;
using FirePortal.App.Database.Entities;
using FirePortal.App.Http.Requests.DiscordBot.Requests;
using FirePortal.App.Repositories;
using FirePortal.App.Services;

namespace FirePortal.App.Http.Controllers.Api.FirePortal;

[ApiController]
[Route("api/FirePortal/discordbot")]
public class DiscordBotController : Controller
{
    private readonly Repository<User> UserRepository;
    private readonly Repository<Server> ServerRepository;
    private readonly ServerService ServerService;
    private readonly string Token = "";
    private readonly bool Enable;

    public DiscordBotController(
        Repository<User> userRepository,
        Repository<Server> serverRepository,
        ServerService serverService,
        ConfigService configService)
    {
        UserRepository = userRepository;
        ServerRepository = serverRepository;
        ServerService = serverService;

        var config = configService
            .Get()
            .FirePortal.DiscordBotApi;

        Enable = config.Enable;

        if (Enable)
        {
            Token = config.Token;
        }
    }
    
    [HttpGet("{id}/link")]
    public async Task<ActionResult> GetLink(ulong id)
    {
        if (!await IsAuth(Request))
            return StatusCode(403);
        
        if (await GetUserFromDiscordId(id) == null)
        {
            return BadRequest();
        }

        return Ok();
    }

    [HttpGet("{id}/servers")]
    public async Task<ActionResult<Server[]>> GetServers(ulong id)
    {
        if (!await IsAuth(Request))
            return StatusCode(403);
        
        var user = await GetUserFromDiscordId(id);

        if (user == null)
            return BadRequest();

        return ServerRepository
            .Get()
            .Include(x => x.Owner)
            .Include(x => x.Image)
            .Where(x => x.Owner.Id == user.Id)
            .ToArray();
    }

    [HttpPost("{id}/servers/{uuid}")]
    public async Task<ActionResult> SetPowerState(ulong id, Guid uuid, [FromBody] SetPowerSignal signal)
    {
        if (!await IsAuth(Request))
            return StatusCode(403);
        
        var user = await GetUserFromDiscordId(id);

        if (user == null)
            return BadRequest();

        var server = ServerRepository
            .Get()
            .Include(x => x.Owner)
            .FirstOrDefault(x => x.Owner.Id == user.Id && x.Uuid == uuid);

        if (server == null)
            return NotFound();

        if (Enum.TryParse(signal.Signal, true, out PowerSignal powerSignal))
        {
            await ServerService.SetPowerState(server, powerSignal);
            return Ok();
        }
        else
            return BadRequest();
    }

    [HttpGet("{id}/servers/{uuid}/details")]
    public async Task<ActionResult<ServerDetails>> GetServerDetails(ulong id, Guid uuid)
    {
        if (!await IsAuth(Request))
            return StatusCode(403);
        
        var user = await GetUserFromDiscordId(id);

        if (user == null)
            return BadRequest();

        var server = ServerRepository
            .Get()
            .Include(x => x.Owner)
            .FirstOrDefault(x => x.Owner.Id == user.Id && x.Uuid == uuid);

        if (server == null)
            return NotFound();

        return await ServerService.GetDetails(server);
    }
    
    [HttpGet("{id}/servers/{uuid}")]
    public async Task<ActionResult<ServerDetails>> GetServer(ulong id, Guid uuid)
    {
        if (!await IsAuth(Request))
            return StatusCode(403);
        
        var user = await GetUserFromDiscordId(id);

        if (user == null)
            return BadRequest();

        var server = ServerRepository
            .Get()
            .Include(x => x.Owner)
            .Include(x => x.Image)
            .Include(x => x.Node)
            .FirstOrDefault(x => x.Owner.Id == user.Id && x.Uuid == uuid);

        if (server == null)
            return NotFound();

        server.Node.Token = "";
        server.Node.TokenId = "";

        return Ok(server);
    }

    private Task<User?> GetUserFromDiscordId(ulong discordId)
    {
        var user = UserRepository
            .Get()
            .FirstOrDefault(x => x.DiscordId == discordId);

        return Task.FromResult(user);
    }

    private Task<bool> IsAuth(HttpRequest request)
    {
        if (!Enable)
            return Task.FromResult(false);
        
        if (string.IsNullOrEmpty(request.Headers.Authorization))
            return Task.FromResult(false);
        
        if(request.Headers.Authorization == Token)
            return Task.FromResult(true);
        
        return Task.FromResult(false);
    }
}