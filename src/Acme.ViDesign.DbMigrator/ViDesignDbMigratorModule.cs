using Acme.ViDesign.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.ViDesign.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ViDesignEntityFrameworkCoreDbMigrationsModule),
        typeof(ViDesignApplicationContractsModule)
        )]
    public class ViDesignDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
