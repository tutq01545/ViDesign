using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Acme.ViDesign.EntityFrameworkCore
{
    [DependsOn(
        typeof(ViDesignEntityFrameworkCoreModule)
        )]
    public class ViDesignEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ViDesignMigrationsDbContext>();
        }
    }
}
