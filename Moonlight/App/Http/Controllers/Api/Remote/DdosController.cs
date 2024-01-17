﻿using Microsoft.AspNetCore.Mvc;
using FirePortal.App.Database.Entities;
using FirePortal.App.Events;
using FirePortal.App.Http.Requests.Daemon;
using FirePortal.App.Repositories;
using FirePortal.App.Services.Background;

namespace FirePortal.App.Http.Controllers.Api.Remote;

[ApiController]
[Route("api/remote/ddos")]
public class DdosController : Controller
{
    private readonly Repository<Node> NodeRepository;
    private readonly DdosProtectionService DdosProtectionService;

    public DdosController(Repository<Node> nodeRepository, DdosProtectionService ddosProtectionService)
    {
        NodeRepository = nodeRepository;
        DdosProtectionService = ddosProtectionService;
    }

    [HttpPost("start")]
    public async Task<ActionResult> Start([FromBody] DdosStart ddosStart)
    {
        var tokenData = Request.Headers.Authorization.ToString().Replace("Bearer ", "");
        var id = tokenData.Split(".")[0];
        var token = tokenData.Split(".")[1];

        var node = NodeRepository.Get().FirstOrDefault(x => x.TokenId == id);

        if (node == null)
            return NotFound();
        
        if (token != node.Token)
            return Unauthorized();
        
        await DdosProtectionService.ProcessDdosSignal(ddosStart.Ip, ddosStart.Packets);
        
        return Ok();
    }

    [HttpPost("stop")]
    public async Task<ActionResult> Stop([FromBody] DdosStop ddosStop)
    {
        var tokenData = Request.Headers.Authorization.ToString().Replace("Bearer ", "");
        var id = tokenData.Split(".")[0];
        var token = tokenData.Split(".")[1];

        var node = NodeRepository.Get().FirstOrDefault(x => x.TokenId == id);

        if (node == null)
            return NotFound();
        
        if (token != node.Token)
            return Unauthorized();
        
        return Ok();
    }
}