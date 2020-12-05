using Acme.ViDesign.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.ViDesign
{
    [DependsOn(
        typeof(ViDesignEntityFrameworkCoreTestModule)
        )]
    public class ViDesignDomainTestModule : AbpModule
    {

    }
}