﻿using FirePortal.App.Database.Entities;

namespace FirePortal.App.Plugin.UI.Servers;

public class ServerPageContext
{
    public List<ServerTab> Tabs { get; set; } = new();
    public List<ServerSetting> Settings { get; set; } = new();
    public Server Server { get; set; }
    public User User { get; set; }
    public string[] ImageTags { get; set; }
}