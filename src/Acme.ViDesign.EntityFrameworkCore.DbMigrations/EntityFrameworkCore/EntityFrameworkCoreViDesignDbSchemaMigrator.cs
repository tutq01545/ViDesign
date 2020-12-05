using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.ViDesign.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.ViDesign.EntityFrameworkCore
{
    public class EntityFrameworkCoreViDesignDbSchemaMigrator
        : IViDesignDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreViDesignDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ViDesignMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ViDesignMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}