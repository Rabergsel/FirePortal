using FirePortal.App.Database.Entities;
using FirePortal.App.Events;

namespace FirePortal.App.Services.Sessions;

public class SessionServerService
{
    private readonly List<SessionClientService> Sessions = new();
    private readonly EventSystem Event;

    public SessionServerService(EventSystem eventSystem)
    {
        Event = eventSystem;
    }

    public async Task Register(SessionClientService sessionClientService)
    {
        lock (Sessions)
        {
            if(!Sessions.Contains(sessionClientService))
                Sessions.Add(sessionClientService);
        }

        await Event.Emit("sessions.add", sessionClientService);
    }
    public async Task UnRegister(SessionClientService sessionClientService)
    {
        lock (Sessions)
        {
            if(Sessions.Contains(sessionClientService))
                Sessions.Remove(sessionClientService);
        }
        
        await Event.Emit("sessions.remove", sessionClientService);
    }

    public Task<SessionClientService[]> GetSessions()
    {
        lock (Sessions)
        {
            return Task.FromResult(Sessions.ToArray());
        }
    }
    
    public async Task ReloadUserSessions(User user)
    {
        var sessions = await GetSessions();
        
        foreach (var session in sessions)
        {
            if (session.User != null && session.User.Id == user.Id)
            {
                try
                {
                    session.NavigationManager.NavigateTo(session.NavigationManager.Uri, true);
                }
                catch (Exception)
                {
                    // ignore
                }
            }
        }
    }
}