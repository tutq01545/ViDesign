using Volo.Abp.Modularity;

namespace Acme.ViDesign
{
    [DependsOn(
        typeof(ViDesignApplicationModule),
        typeof(ViDesignDomainTestModule)
        )]
    public class ViDesignApplicationTestModule : AbpModule
    {

    }
}