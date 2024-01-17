using Discord.WebSocket;
using FirePortal.App.Services.DiscordBot;

namespace FirePortal.App.Helpers;

public class DiscordMaintenanceToggle
{
    private Task MaintenanceModeToggle(SocketSlashCommand command)
    {
        DiscordBotService.MaintenanceMode = !DiscordBotService.MaintenanceMode;
        return Task.CompletedTask;
    }
}
