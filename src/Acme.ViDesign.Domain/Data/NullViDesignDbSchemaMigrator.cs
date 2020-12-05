using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.ViDesign.Data
{
    /* This is used if database provider does't define
     * IViDesignDbSchemaMigrator implementation.
     */
    public class NullViDesignDbSchemaMigrator : IViDesignDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}