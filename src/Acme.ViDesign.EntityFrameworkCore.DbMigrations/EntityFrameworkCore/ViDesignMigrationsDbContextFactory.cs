using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.ViDesign.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class ViDesignMigrationsDbContextFactory : IDesignTimeDbContextFactory<ViDesignMigrationsDbContext>
    {
        public ViDesignMigrationsDbContext CreateDbContext(string[] args)
        {
            ViDesignEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ViDesignMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new ViDesignMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.ViDesign.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
