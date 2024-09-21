using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Ccdd.Home.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class HomeDbContextFactory : IDesignTimeDbContextFactory<HomeDbContext>
{
    public HomeDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        HomeEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<HomeDbContext>()
            .UseSqlite(configuration.GetConnectionString("Default"));
        
        return new HomeDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Ccdd.Home.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
