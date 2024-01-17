using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using FirePortal.App.Database;
using FirePortal.App.Services;
using FirePortal.App.Services.Files;
using MySql.Data.MySqlClient;

namespace FirePortal.App.Helpers;

public class DatabaseCheckupService
{
    private readonly ConfigService ConfigService;

    public DatabaseCheckupService(ConfigService configService)
    {
        ConfigService = configService;
    }

    public async Task Perform()
    {
        int connenctionTries = 1;
        var context = new DataContext(ConfigService);

        RetryToConnect:
        Logger.Info($"Checking database, Trial {connenctionTries}");
        
        if (!await context.Database.CanConnectAsync())
        {
            Logger.Fatal($"---------CONNECTION TRIAL {connenctionTries} failed-----------------");
            Logger.Fatal("Unable to connect to mysql database");
            Logger.Fatal("Please make sure the configuration is correct");
            Logger.Fatal("");
            Logger.Fatal("FirePortal will wait 1 minute before trying again!");
            Logger.Fatal("-----------------------------------------------");
            
            Thread.Sleep(TimeSpan.FromMinutes(1));
            
        }

        Logger.Info("Checking for pending migrations");

        var migrations = (await context.Database
            .GetPendingMigrationsAsync())
            .ToArray();

        if (migrations.Any())
        {
            Logger.Info($"{migrations.Length} migrations pending. Updating now");

            try
            {
                var backupHelper = new BackupHelper();
                await backupHelper.CreateBackup(
                    PathBuilder.File("storage", "backups", $"{new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds()}.zip"));
            }
            catch (Exception e)
            {
                Logger.Fatal("Unable to create backup");
                Logger.Fatal(e);
                Logger.Fatal("FirePortal will continue to start and apply the migrations without a backup");
            }
            
            Logger.Info("Applying migrations");
            
            await context.Database.MigrateAsync();
            
            Logger.Info("Successfully applied migrations");
        }
        else
        {
            Logger.Info("Database is up-to-date. No migrations have been performed");
        }
    }
}